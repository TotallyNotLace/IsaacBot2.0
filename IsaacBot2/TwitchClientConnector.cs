using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client;
using TwitchLib.Client.Models;

namespace IsaacBot2
{
    internal class TwitchClientConnector
    {
        public event Action twitchStopCalled;

        public TwitchClient client;
        public ConnectionCredentials credentials;

        public string botUsername = "IsaacChatBot";

        private string clientID = "gp762nuuoqcoxypju8c569th9wz7q5";
        private string clientSecret = "ag1chohipov7u5kn1ydaqtud8cn5ih";
        private string accessToken = "i01ggjp4ydw6t21nwiqzeazxuf8o9s";

        private string accessCLIToken = "i4o7tqz58qtnmf8unzt44x8b4yj9z1";

        //these are the tokens set from that one night i got it working
        private string accessCLIToken2 = "g8vi6g7lo3anx7fe75qlv36bphv8wg";
        private string clientIDold = "p8pjdheibnhcsf0wfkwlslag8rux19";

        private IsaacProcessor isaacProcessor;


        //take channel name //take bot username //take access token
        public void Initialize()
        {
            client = new TwitchClient();
            credentials = new ConnectionCredentials(botUsername, accessCLIToken);

            isaacProcessor = new IsaacProcessor();
            isaacProcessor.stopCalled += OnIsaacProcessorCrash;

            client.OnConnected += OnConnected;
            client.OnJoinedChannel += OnJoinedChannel;
            client.OnMessageReceived += OnMessageReceived;
            client.Initialize(credentials);
            client.Connect();
        }

        public void SetupEvents()
        {

        }

        private void OnMessageReceived(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
        {
            Console.WriteLine($"{e.ChatMessage.Username}:{e.ChatMessage.Message}");
            isaacProcessor.CheckCommand(e.ChatMessage.Message);
        }

        private void OnJoinedChannel(object sender, TwitchLib.Client.Events.OnJoinedChannelArgs e)
        {
            Console.WriteLine($"In a channel! {e.Channel}");
            client.SendMessage(e.Channel, "hello!");
        }

        private void OnConnected(object sender, EventArgs e)
        {
            Console.WriteLine("Connected!");
            client.JoinChannel("TotallyNotLace");
        }

        private void OnIsaacProcessorCrash()
        {
            isaacProcessor.stopCalled -= OnIsaacProcessorCrash;
            isaacProcessor = null;

            twitchStopCalled.Invoke();
        }
    }
}
