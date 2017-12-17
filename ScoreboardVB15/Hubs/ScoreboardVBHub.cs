using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace ScoreboardVB15.Hubs
{
    public class ScoreboardVBHub : Hub
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        //private static string message = "Initial message";
        public void SendMessage(string message, string team, string roomName)
        {
            //_scoreVB += 1;
            //Clients.All.introduce(_scoreVB);
            //Clients.All.showMessage(message);
            Clients.Group(roomName).showMessage(message, team);
        }

        public async Task JoinRoom(string roomName)
        {
            await Groups.Add(Context.ConnectionId, roomName);
            Clients.Group(roomName).addChatMessage(Context.User.Identity.Name + " joined: " + roomName + ".");
        }

        public async Task LeaveRoom(string roomName)
        {
            await Groups.Remove(Context.ConnectionId, roomName);
            Clients.Group(roomName).addChatMessage(Context.User.Identity.Name + " left: " + roomName + ".");
        }
    }
}