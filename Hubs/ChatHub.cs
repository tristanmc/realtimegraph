using Microsoft.AspNetCore.SignalR;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task Poke(string user, string message)
        {
            
            var data = new FlareItem
            {
                Name = "flare",
                Children = new []
                {
                    new FlareItem 
                    { 
                        Name="baby",
                        Children = new []
                        {
                            new FlareItem {Name= "Indigo", Size= 3938},
                            new FlareItem {Name= "Aqua", Size=3812 },
                            new FlareItem {Name= "Green", Size=6714 },
                            new FlareItem {Name= "Turquoise", Size= 743}
                        }.ToList()
                    }
                }.ToList()
            };

            await Clients.Others.SendAsync("Refresh", user, data);
        }
    }
}