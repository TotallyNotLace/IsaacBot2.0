using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client;
using TwitchLib.Client.Models;

namespace IsaacBot2
{
    internal class TwitchClientConnector
    {
        public event Action twitchStopCalled;

        public event Action<string> CallConsole;


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


        public void BotActivator(Action<string> consoleEvent)
        {
            if (client == null)
            {
                client = new TwitchClient();
            }

            Console.WriteLine(client);
            if(credentials != null)
            {
                credentials = null;
            }

            credentials = new ConnectionCredentials(botUsername, accessCLIToken);

            CallConsole = consoleEvent;

            if(isaacProcessor == null)
            {
                isaacProcessor = new IsaacProcessor();
            }

            isaacProcessor.ActivateProcessor(ConsoleDelegate);

            isaacProcessor.stopCalled += OnIsaacProcessorCrash;

            client.OnConnected += OnConnected;
            client.OnJoinedChannel += OnJoinedChannel;
            client.OnMessageReceived += OnMessageReceived;
            client.Initialize(credentials);
            client.Connect();
        }

        private void OnMessageReceived(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
        {
            Console.WriteLine($"{e.ChatMessage.Username}:{e.ChatMessage.Message}");
            CallConsole.Invoke($"{e.ChatMessage.Username}:{e.ChatMessage.Message}");
            isaacProcessor.CheckCommand(e.ChatMessage.Message);
        }

        private void OnJoinedChannel(object sender, TwitchLib.Client.Events.OnJoinedChannelArgs e)
        {
            CallConsole.Invoke($"In the channel: {e.Channel}");
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
            client.Disconnect();
            twitchStopCalled.Invoke();
        }

        private void ConsoleDelegate(string message)
        {
            CallConsole.Invoke(message);
        }

        public void StopBot()
        {
            isaacProcessor.stopCalled -= OnIsaacProcessorCrash;
            client.OnConnected -= OnConnected;
            client.OnJoinedChannel -= OnJoinedChannel;
            client.OnMessageReceived -= OnMessageReceived;

            CallConsole("Stopping Bot");

            client.LeaveChannel("TotallyNotLace");
            client.Disconnect();
        }
    }
}
