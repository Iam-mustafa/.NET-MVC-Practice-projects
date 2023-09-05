using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketClientStarter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket client = null;
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipaddr = null;
            try
            {
                Console.WriteLine("***Socket client****");
                Console.WriteLine("Type a valid server IP address and Enter");

                string strIPAddress = Console.ReadLine();
                Console.WriteLine("Enter valid port no 0-65535");
                string strPortInput = Console.ReadLine();
                int nPortInput = 0;
                if(!IPAddress.TryParse(strIPAddress, out ipaddr))
                {
                    Console.WriteLine("Invalid server IP supplied");
                    return;
                }
                if (!int.TryParse(strPortInput, out nPortInput))
                {
                    Console.WriteLine("Invalid port no supplied");
                    return;
                }
                System.Console.WriteLine(string.Format("IPAddress: {0}, Port: {1}",ipaddr.ToString(),nPortInput));
                client.Connect(ipaddr, nPortInput);
                Console.WriteLine("connected to server, type something to send data,type exit to close.");
                string inputCommand = string.Empty;
                while(true)
                {
                    inputCommand = Console.ReadLine();
                    if(inputCommand.Equals("<EXIT>"))
                    {
                        break;
                    }
                    byte[] buffSend = Encoding.ASCII.GetBytes(inputCommand);
                    client.Send(buffSend);
                    byte[] buffReceived = new byte[128];
                    int nRecv = client.Receive(buffReceived);

                    Console.WriteLine("Data Received: {0}", Encoding.ASCII.GetString(buffReceived,0,nRecv));

                }
            }
            catch (Exception excp)
            {
                Console.WriteLine(excp.ToString());
            }
            finally
            {
                if (client != null)
               {
                    if (client.Connected)
                    { 
                        client.Shutdown(SocketShutdown.Both);
                
                    }
                    client.Close();
                    client.Dispose();
                }
                
            }
            Console.WriteLine("press a key to exit...");
            Console.ReadKey();
             
        }
    }
}
