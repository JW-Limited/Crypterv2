using Paket;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.BugBarrier
{
    public class ErrorMessageParser
    {
        private readonly Exception _innerException;
        private readonly string _exceptionType;
        private readonly string _library;
        private readonly string _method;
        private readonly List<string> _stackTraceFrames;
        private readonly IDictionary<string, string> _suggestedSolutions;

        public string ExceptionType => _exceptionType;
        public string Library => _library;
        public string Method => _method;
        public List<string> StackTraceFrames => _stackTraceFrames;
        public IDictionary<string, string> SuggestedSolutions => _suggestedSolutions;
        public Exception InnerException => _innerException;

        public ErrorMessageParser(string errorMessage, Exception ec)
        {
            ArgumentNullException.ThrowIfNull(errorMessage, nameof(errorMessage));

            Regex exceptionRegex = new Regex(@"(?<=\b)\w+\.\w+\.\w+(?=:)");
            Regex libraryRegex = new Regex(@"(?<=at\s)\w+\.\w+\.\w+");
            Regex methodRegex = new Regex(@"(?<=\s+at\s)[\w<>.]+\([^)]+\)");
            Match exceptionMatch = exceptionRegex.Match(errorMessage);
            Match libraryMatch = libraryRegex.Match(errorMessage);
            Match methodMatch = methodRegex.Match(errorMessage);

            if (exceptionMatch.Success)
            {
                _exceptionType = exceptionMatch.Value;
            }
            else
            {
                _exceptionType = "N/A";
            }

            if (libraryMatch.Success)
            {
                _library = libraryMatch.Value;
            }
            else
            {
                _library = "N/A";
            }

            if (methodMatch.Success)
            {
                _method = methodMatch.Value;
            }
            else
            {
                _method = "N/A";
            }

            _innerException = ec;
            _stackTraceFrames = GetStackTraceFrames();
            _suggestedSolutions = GetSuggestedSolutions();
        }

        public string GetSuggestedSolution()
        {
            if (_suggestedSolutions.ContainsKey(_exceptionType))
            {
                return _suggestedSolutions[_exceptionType];
            }
            else
            {
                return "No suggested solution found for this exception type.";
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Exception Type: {_exceptionType}");
            sb.AppendLine($"Library: {_library}");
            sb.AppendLine($"Method: {_method}");

            foreach (string stackTraceFrame in _stackTraceFrames)
            {
                sb.AppendLine(stackTraceFrame);
            }

            sb.AppendLine($"Suggested Solution: {GetSuggestedSolution()}");

            return sb.ToString();
        }

        private List<string> GetStackTraceFrames()
        {
            string stackTrace = InnerException.StackTrace;
            string[] stackTraceLines = stackTrace.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return stackTraceLines.ToList();
        }

        private IDictionary<string, string> GetSuggestedSolutions()
        {
            IDictionary<string, string> suggestedSolutions = new Dictionary<string, string>
            {
                { "System.IO.FileNotFoundException", "The file could not be found. Make sure that the file exists and that you have permission to access it." },
                { "System.NullReferenceException", "A null reference was encountered. Make sure that all of your variables are initialized before you use them." },
                { "System.IndexOutOfRangeException", "An index out of range exception was encountered. Make sure that you are accessing arrays and collections within their bounds." },
                { "System.ArgumentNullException", "An argument was null when it should not have been. Make sure that all of your arguments are initialized before you pass them to methods." },
                { "System.FormatException", "An invalid format was encountered. Make sure that you are formatting your data correctly." },
                { "System.DivideByZeroException", "An attempt was made to divide by zero. This is not a valid operation." },
                { "System.OverflowException", "An arithmetic operation resulted in a value that is too large or too small to be represented by the data type. Make sure that you are using the correct data type for your calculations." },
                { "System.OutOfMemoryException", "The program has run out of memory. This can happen if you are trying to allocate too much memory or if you have a memory leak." },
                { "System.Threading.ThreadAbortException", "A thread was aborted. This can happen if you are calling the `Abort()` method on a thread." },
                { "System.Threading.Tasks.TaskCanceledException", "A task was canceled. This can happen if you are calling the `Cancel()` method on a task." },
                { "System.Net.WebException", "An error occurred while communicating with a network resource. This can happen for a variety of reasons, such as a connection failure, a timeout, or a server error." },
                { "System.Security.SecurityException", "A security exception occurred. This can happen if you are trying to access a resource that you do not have permission to access." },
                { "System.UriFormatException", "An error occurred while parsing a URI. Make sure that the URI is formatted correctly." },
                { "System.IO.IOException", "An I/O error occurred. This can happen for a variety of reasons, such as a disk failure, a network error, or a file permission error." },
                { "System.Reflection.ReflectionTypeLoadException", "An error occurred while loading a type. This can happen if the type does not exist or if the assembly that contains the type is not loaded." },
                { "System.Configuration.ConfigurationErrorsException", "An error occurred while configuring the application. This can happen if the configuration file is missing or corrupted." },
                { "System.Xml.XmlException", "An error occurred while parsing XML. Make sure that the XML is formatted correctly." },
                { "System.IO.Compression.GZipException", "An error occurred while compressing or decompressing data. Make sure that the data is in a valid format." },
                { "System.IO.Packaging.ZipException", "An error occurred while zipping or unzipping data. Make sure that the data is in a valid format." },
                { "WinRT.ExceptionHelpers.ThrowExceptionForHR", "An error occurred while sharing a file with the windows FileSharer. Please update youre Collections to keep using this function." },
            };

            return suggestedSolutions;
        }


    }
}
