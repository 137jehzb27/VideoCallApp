using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class VideoHub : Hub
{
    public async Task SendSignal(string user, string signal)
    {
        await Clients.All.SendAsync("ReceiveSignal", user, signal);
    }
}