using Microsoft.AspNetCore.SignalR;

namespace FileSharing404
{
    public class WebRtcHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
