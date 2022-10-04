using Microsoft.AspNetCore.SignalR;
namespace RewardApi.Hubs
{
    public class RewardHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            //await _usersService.AddUserAsync(Context.ConnectionId, Context.User.UserName());
            await base.OnConnectedAsync();
        }

        public async Task Echo(string message) {
            await Clients.Caller.SendAsync("On Message Received", message);
        }
    }
}