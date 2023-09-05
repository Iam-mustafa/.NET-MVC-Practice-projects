using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ZaaviaSocket
{
    public class ClientConnectedEventArgs : EventArgs
    {
        public string NewClient { get; set; }
        public ClientConnectedEventArgs(string _newClient)
            {
            NewClient = _newClient;
            }
    }
    public class TextReceivedEventArgs : EventArgs
    {
        public string ClientWhoSentText { get; set; }
        public string TextReceived { get; set; }
        public TextReceivedEventArgs(string _clientWhoSentText,string _textReceived)
        {
            ClientWhoSentText = _clientWhoSentText;
            TextReceived = _textReceived;
        }
    }

    public class ConnectionDisconnectedEventArgs : EventArgs
    {
        public string DisconnectedPeer { get; set; }

        public ConnectionDisconnectedEventArgs(string _disconnectedPeer)
        {
            DisconnectedPeer = _disconnectedPeer;
        }
    }
}