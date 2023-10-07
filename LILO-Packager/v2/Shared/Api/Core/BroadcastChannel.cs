using LILO_Packager.v2.Shared;
using LILO_Packager.v2.Shared.Api.Types;

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
        public event EventHandler<BroadCastSubscriptionEventArgs> BroadCastSubscribeEvent;

        public void Subscribe(IObserver<BroadcastMessage> observer,string name = null)
        {
            lock (lockObject)
            {
                observers.Add(observer);
                BroadCastSubscribeEvent?.Invoke(this,new BroadCastSubscriptionEventArgs(true, name ?? "n/a"));
            }
        }

        public void Unsubscribe(IObserver<BroadcastMessage> observer, string name = null)
        {
            lock (lockObject)
            {
                observers.Remove(observer);
                BroadCastSubscribeEvent?.Invoke(this, new BroadCastSubscriptionEventArgs(false, name ?? "n/a"));
              
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

    public class BroadCastSubscriptionEventArgs : EventArgs
    {
        public bool Subscriped { get; private set; }
        public string Observer { get; private set; }

        public BroadCastSubscriptionEventArgs(bool subscriped, string observer)
        {
            Subscriped = subscriped;
            Observer = observer;
        }
    }
}
