using ZaaviaSocket;
namespace AsyncSocket
{
    public partial class Form1 : Form
    {
        ZaaviaSocketServer mserver;
        public Form1()
        {
            InitializeComponent();
            mserver = new ZaaviaSocketServer();
            mserver.RaiseClientConnectedEvent += HandleClientConnected;
            mserver.RaiseTextReceivedEvent += HandleTextReceived;
            mserver.RaiseClientDisconnectedEvent += HandleClientDisconnected;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAcceptIncomingAsync_Click(object sender, EventArgs e)
        {
            mserver.StartListeningForIncomingConnection();
        }

        private void btnSenndAll_Click(object sender, EventArgs e)
        {
            mserver.SendToAll(txtMessage.Text.Trim());
        }

        


        private void btnStopServer_Click(object sender, EventArgs e)
        {
            mserver.StopServer();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            mserver.StopServer();
        }
        void HandleClientConnected(object sender, ClientConnectedEventArgs ccea)
        {
            txtConsole.AppendText(string.Format("{0} - New client connected:{1}{2}",
                DateTime.Now,ccea.NewClient,Environment.NewLine));
        }
        void HandleTextReceived(object sender, TextReceivedEventArgs trea)
        {
            txtConsole.AppendText(
                string.Format(
                    "{0} - Received from {3} : {1}{2}",
                    DateTime.Now,
                    trea.TextReceived,
                    Environment.NewLine,
                    trea.ClientWhoSentText));

        }
        void HandleClientDisconnected(object sender, ConnectionDisconnectedEventArgs cdea)
        {
            if (!txtConsole.IsDisposed)
            {
                txtConsole.AppendText(string.Format("{0} - Client Disconnected: {1}\r\n",
                    DateTime.Now, cdea.DisconnectedPeer));
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}