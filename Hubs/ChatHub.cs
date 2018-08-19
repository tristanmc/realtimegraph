using Microsoft.AspNetCore.SignalR;
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
            var data = @"
            {
                ""name"": ""flare"",
                ""children"": [
                    {
                    ""name"": ""analytics"",
                    ""children"": [
                        {
                        ""name"": ""cluster"",
                        ""children"": [{
                            ""name"": ""AgglomerativeCluster"",
                            ""size"": 3938
                        }, {
                            ""name"": ""CommunityStructure"",
                            ""size"": 3812
                        }, {
                            ""name"": ""HierarchicalCluster"",
                            ""size"": 6714
                        }, {
                            ""name"": ""MergeEdge"",
                            ""size"": 743
                        }
                        ]
                    }
                    ]
                    }
                ]
                }
            ";
            await Clients.Others.SendAsync("Refresh", user, data);
        }
    }
}