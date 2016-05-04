using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatAppSignalr.Hubs
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
        public void Subscribe(string UserId)
        {
            Groups.Add(Context.ConnectionId, UserId);
        }

        public void Unsubscribe(string UserId)
        {
            Groups.Remove(Context.ConnectionId, UserId);
        }
    }
}