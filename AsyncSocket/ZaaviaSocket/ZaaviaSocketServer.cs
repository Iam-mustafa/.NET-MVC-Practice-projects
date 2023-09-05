using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ZaaviaSocket
{
    public class ZaaviaSocketServer
    {
        IPAddress mIP;
        int mPort;
        TcpListener mTCPListener;

        List<TcpClient> mClients;

        public EventHandler<ClientConnectedEventArgs> RaiseClientConnectedEvent;

        public EventHandler<TextReceivedEventArgs> RaiseTextReceivedEvent;

        public EventHandler<ConnectionDisconnectedEventArgs> RaiseClientDisconnectedEvent;

        public bool KeepRunning { get; set; }

        public ZaaviaSocketServer()
        {
            mClients = new List<TcpClient>();
        }
        protected virtual void OnRaiseClientConnectedEvent(ClientConnectedEventArgs e)
        {
            EventHandler<ClientConnectedEventArgs> handler = RaiseClientConnectedEvent;         
            if(handler != null)
            {
                handler(this, e);
            }
        }
        protected virtual void OnRaiseTextReceivedEvent(TextReceivedEventArgs trea)
        {
            EventHandler<TextReceivedEventArgs> handler = RaiseTextReceivedEvent;
            if (handler != null)
            {
                handler(this, trea);
            }
        }
        protected virtual void OnRaiseClientDisconnectedEvent(ConnectionDisconnectedEventArgs cdea)
        {
            EventHandler<ConnectionDisconnectedEventArgs> handler = RaiseClientDisconnectedEvent;

            if (handler != null)
            {
                handler(this, cdea);
            }
        }

        public async void StartListeningForIncomingConnection(IPAddress ipaddr = null, int port = 23000)
        {
            if (ipaddr == null)
            {
                ipaddr = IPAddress.Any;
            }
            if (port <= 0)
            {
                port = 23000;
            }
            mIP = ipaddr;
            mPort = port;
            System.Diagnostics.Debug.WriteLine(String.Format("IP Address:{0} - Port : {1}", mIP.ToString(), mPort));

            mTCPListener = new TcpListener(mIP, mPort);

            try
            {
                mTCPListener.Start();

                KeepRunning = true;

                while (KeepRunning)
                {
                    var ReturnedByAccept = await mTCPListener.AcceptTcpClientAsync();                    
                    mClients.Add(ReturnedByAccept);

                    Debug.WriteLine(string.Format("Client connected Successfully, count: {0} - {1}", 
                        mClients.Count, ReturnedByAccept.Client.RemoteEndPoint)
                        );

                    TakeCareOfTCPClient(ReturnedByAccept);

                    ClientConnectedEventArgs eaClientConnected;
                    eaClientConnected = new ClientConnectedEventArgs(
                        ReturnedByAccept.Client.RemoteEndPoint.ToString()
                        );
                    OnRaiseClientConnectedEvent(eaClientConnected);
                }
            }
            catch (Exception excp)
            {
                System.Diagnostics.Debug.WriteLine(excp.ToString());
            }
        }

        public void StopServer()
        {
            try
            {
                if(mTCPListener != null)
                {
                    mTCPListener.Stop();
                }
                foreach(TcpClient c in mClients)
                {
                    c.Close();
                }
                mClients.Clear();
            }
            catch (Exception excp)
            {

                Debug.WriteLine(excp.ToString());
            }
        }

        private async void TakeCareOfTCPClient(TcpClient paramClient)
        {
            NetworkStream stream = null;
            StreamReader reader = null;
            string clientEndPoint = paramClient.Client.RemoteEndPoint.ToString();
            try
            {
                stream = paramClient.GetStream();
                reader = new StreamReader(stream);

                char[] buff = new char[64];
                while (KeepRunning)
                {
                    Debug.WriteLine("*** Ready to read");

                    int nRet = await reader.ReadAsync(buff, 0, buff.Length);

                    System.Diagnostics.Debug.WriteLine("Returned" + nRet);

                    if (nRet == 0)
                    {
                        OnRaiseClientDisconnectedEvent(
                            new ConnectionDisconnectedEventArgs(clientEndPoint));
                        RemoveClient(paramClient);
                        System.Diagnostics.Debug.WriteLine("Socket disconnected");
                        break;
                    }
                    string receivedText = new string(buff);

                    System.Diagnostics.Debug.WriteLine("***Received:" + receivedText);

                    OnRaiseTextReceivedEvent(new TextReceivedEventArgs(
                        paramClient.Client.RemoteEndPoint.ToString(),
                        receivedText
                        ));
                    Array.Clear(buff, 0, buff.Length);
                }
            }
            catch (Exception excp)
            {
                OnRaiseClientDisconnectedEvent(
                new ConnectionDisconnectedEventArgs(clientEndPoint));
                RemoveClient(paramClient);
                System.Diagnostics.Debug.WriteLine(excp.ToString());
            }
        }

        private void RemoveClient(TcpClient paramClient)
        {
            if(mClients.Contains(paramClient))
            {
                mClients.Remove(paramClient);
                paramClient.Close();
                Debug.WriteLine(String.Format("Client removed, count: {0}", mClients.Count));
            }
        }
        public void SendToAll(string leMessage)
        {
            if (string.IsNullOrEmpty(leMessage))
            {
                return;
            }
            try
            {
                byte[] buffMessage = Encoding.ASCII.GetBytes(leMessage);
                foreach (TcpClient c in mClients)
                {
                    c.GetStream().Write(buffMessage, 0, buffMessage.Length);
                }
            }
            catch (Exception excp)
            {
                Debug.WriteLine(excp.ToString());
            }
        }
    }
}
