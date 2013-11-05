namespace Hani.Utilities
{
    internal abstract partial class NetworkClient
    {
        internal delegate void StateHandler();
        internal event StateHandler OnConnecting, OnConnected, OnDisconnected, OnFailedToConnect;

        protected void Connecting()
        {
            if (!DisplayEvents) return;
            if (OnConnecting != null) new StateHandler(OnConnecting)();
        }

        protected void Connected()
        {
            if (!DisplayEvents) return;
            if (OnConnected != null) new StateHandler(OnConnected)();
        }

        protected void Disconnected()
        {
            if (!DisplayEvents) return;
            if (OnDisconnected != null) new StateHandler(OnDisconnected)();
        }

        protected void FailedToConnect()
        {
            if (!DisplayEvents) return;
            if (OnFailedToConnect != null) new StateHandler(OnFailedToConnect)();
        }
    }
}