using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class EventHub : Hub
{
    public async Task SendMessage()
    {
        await Clients.All.SendAsync("ReceiveMessage");
    }
}
