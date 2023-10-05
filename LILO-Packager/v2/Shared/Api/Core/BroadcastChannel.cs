using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using Grpc.Core;
using LILO_Packager.v2.shared;
using Microsoft.Extensions.DependencyInjection;

namespace LILO_Packager.v2.Shared.Api.Core
{
    public class BroadcastChannel
    {
        private readonly object lockObject = new object();
        private readonly List<IObserver<BroadcastMessage>> observers = new List<IObserver<BroadcastMessage>>();
        public int ObserverCount => observers.Count;
        private static Lazy<BroadcastChannel> _lazyInstance = new Lazy<BroadcastChannel>(() => new BroadcastChannel());
        public static BroadcastChannel Instance => _lazyInstance.Value;

        public event EventHandler<BroadcastEventArgs> BroadcastEvent;

        public void Subscribe(IObserver<BroadcastMessage> observer)
        {
            lock (lockObject)
            {
                observers.Add(observer);
            }
        }

        public void Unsubscribe(IObserver<BroadcastMessage> observer)
        {
            lock (lockObject)
            {
                observers.Remove(observer);
            }
        }

        public void Broadcast(BroadcastMessage message)
        {
            lock (lockObject)
            {
                foreach (var observer in observers)
                {
                    try
                    {
                        observer.OnNext(message);
                    }
                    catch (Exception ex)
                    {
                        ConsoleManager.Instance().WriteLineWithColor($"Error broadcasting to observer: {ex.Message}",ConsoleColor.DarkRed);
                    }
                }
            }

            OnBroadcastEvent(message);
        }

        protected virtual void OnBroadcastEvent(BroadcastMessage message)
        {
            BroadcastEvent?.Invoke(this, new BroadcastEventArgs(message));
        }
    }

    public class BroadcastEventArgs : EventArgs
    {
        public BroadcastMessage Message { get; }

        public BroadcastEventArgs(BroadcastMessage message)
        {
            Message = message;
        }
    }


    public enum BroadcastMessageType
    {
        Info,
        Warning,
        Error,
        Action
    }

    public enum BroadcastEndPoint
    {
        ForAll,
        MainHost,
        Encryption,
        Decryption,

    }

    public class BroadcastMessage
    {
        public BroadcastMessageType Type { get; private set; }
        public BroadcastEndPoint EndPoint { get; private set; }
        public string? Payload { get; private set; }
        public BroadCastMessageParameters? BroadcastMessageArgs {  get; private set; }

        public BroadcastMessage(BroadcastMessageType type,
                                BroadcastEndPoint endPoint,
                                string payload)
        {
            Type = type;
            EndPoint = endPoint;
            Payload = payload;
        }

        public BroadcastMessage(BroadcastMessageType type,
                                BroadcastEndPoint endPoint,
                                BroadCastMessageParameters castMessageParameters)
        {
            Type = type;
            EndPoint = endPoint;
            BroadcastMessageArgs = castMessageParameters;
        }
    }

    public class BroadCastMessageParameters
    {

    }
}
