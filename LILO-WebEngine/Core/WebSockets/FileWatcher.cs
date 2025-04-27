using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using LILO_WebEngine.Core.Handler;
using LILO_WebEngine.Core.Local;
using LILO_WebEngine.Core.Local.Types;

namespace LILO_WebEngine.Core.WebSockets
{
    public class FileWatcher : IDisposable
    {
        private static readonly Lazy<FileWatcher> _instance = new(() => new FileWatcher());
        public static FileWatcher Instance => _instance.Value;
        
        private Dictionary<string, FileSystemWatcher> _watchers = new();
        private readonly HashSet<string> _ignoredExtensions = new(StringComparer.OrdinalIgnoreCase)
        {
            ".tmp", ".lock", ".swp", ".gitignore", ".git"
        };
        
        private int _debounceMilliseconds = 300;
        private Dictionary<string, Timer> _debounceTimers = new();
        
        private FileWatcher() { }
        
        public void WatchDirectory(string path)
        {
            if (_watchers.ContainsKey(path) || !Directory.Exists(path))
                return;
                
            try
            {
                var watcher = new FileSystemWatcher(path)
                {
                    IncludeSubdirectories = true,
                    NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName,
                    EnableRaisingEvents = true
                };
                
                watcher.Changed += OnFileChanged;
                watcher.Created += OnFileChanged;
                watcher.Renamed += OnFileRenamed;
                
                _watchers.Add(path, watcher);
                
                EngineEventHandler.Instance.AddEvent(new WEB_ENGINE_EVENT
                {
                    Name = "FileWatcher",
                    Description = $"Started watching directory: {path}",
                    NeedsToAccept = false,
                    HappeningTime = DateTime.Now
                });
            }
            catch (Exception ex)
            {
                EngineEventHandler.Instance.AddEvent(new WEB_ENGINE_EVENT
                {
                    Name = "FileWatcher Error",
                    Description = $"Failed to watch directory {path}: {ex.Message}",
                    NeedsToAccept = false,
                    HappeningTime = DateTime.Now
                });
            }
        }
        
        public void StopWatching(string path)
        {
            if (_watchers.TryGetValue(path, out var watcher))
            {
                watcher.EnableRaisingEvents = false;
                watcher.Dispose();
                _watchers.Remove(path);
            }
        }
        
        private void OnFileChanged(object sender, FileSystemEventArgs e)
        {
            if (ShouldIgnoreFile(e.FullPath))
                return;
                
            DebounceFileChange(e.FullPath);
        }
        
        private void OnFileRenamed(object sender, RenamedEventArgs e)
        {
            if (ShouldIgnoreFile(e.FullPath))
                return;
                
            DebounceFileChange(e.FullPath);
        }
        
        private void DebounceFileChange(string filePath)
        {
            lock (_debounceTimers)
            {
                if (_debounceTimers.TryGetValue(filePath, out var existingTimer))
                {
                    existingTimer.Change(_debounceMilliseconds, Timeout.Infinite);
                }
                else
                {
                    var timer = new Timer(state => 
                    {
                        NotifyFileChange((string)state);
                        
                        lock (_debounceTimers)
                        {
                            if (_debounceTimers.TryGetValue((string)state, out var timerToRemove))
                            {
                                timerToRemove.Dispose();
                                _debounceTimers.Remove((string)state);
                            }
                        }
                    }, filePath, _debounceMilliseconds, Timeout.Infinite);
                    
                    _debounceTimers[filePath] = timer;
                }
            }
        }
        
        private async void NotifyFileChange(string filePath)
        {
            try
            {
                var relativePath = GetRelativePath(filePath);
                
                EngineEventHandler.Instance.AddEvent(new WEB_ENGINE_EVENT
                {
                    Name = "FileChanged",
                    Description = $"File changed: {relativePath}",
                    NeedsToAccept = false,
                    HappeningTime = DateTime.Now
                });
                
                await WebSocketServer.Instance.BroadcastFileChangeAsync(relativePath);
            }
            catch (Exception ex)
            {
                EngineEventHandler.Instance.AddEvent(new WEB_ENGINE_EVENT
                {
                    Name = "FileWatcher Error",
                    Description = $"Error notifying file change: {ex.Message}",
                    NeedsToAccept = false,
                    HappeningTime = DateTime.Now
                });
            }
        }
        
        private bool ShouldIgnoreFile(string filePath)
        {
            var extension = Path.GetExtension(filePath);
            return _ignoredExtensions.Contains(extension);
        }
        
        private string GetRelativePath(string fullPath)
        {
            foreach (var basePath in _watchers.Keys)
            {
                if (fullPath.StartsWith(basePath, StringComparison.OrdinalIgnoreCase))
                {
                    var relativePath = fullPath.Substring(basePath.Length).TrimStart(Path.DirectorySeparatorChar);
                    return relativePath;
                }
            }
            
            return fullPath;
        }
        
        public void Dispose()
        {
            foreach (var watcher in _watchers.Values)
            {
                watcher.EnableRaisingEvents = false;
                watcher.Dispose();
            }
            
            _watchers.Clear();
            
            lock (_debounceTimers)
            {
                foreach (var timer in _debounceTimers.Values)
                {
                    timer.Dispose();
                }
                
                _debounceTimers.Clear();
            }
        }
    }
} 