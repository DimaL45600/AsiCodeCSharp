namespace BattleShipsLesson
{
    public partial class MenuForm : Form
    {
        internal static ConnectionData connectionData = new ConnectionData();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectionData.OnClientConnected += PalyerConnected;
            connectionData.OnClientDisconnected += HostError;
            connectionData.Start(true);
            HostLabel.Text = connectionData.GetHostData();
            CancelHostButton.Visible = true;
            HostLabel.Visible = true;
            JoinButton.Enabled = false;
        }
        private void HostError()
        {
            CancelHostButton.Visible = false;
            HostLabel.Visible = false;
            JoinButton.Enabled = true;
            connectionData.OnClientConnected -= PalyerConnected;
            connectionData.OnClientDisconnected -= HostError;
            connectionData.Disconnect();
        }
        private void PalyerConnected()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    connectionData.OnMessageReceived -= ClientError;
                    connectionData.OnClientDisconnected -= HostError;
                    connectionData.OnClientConnected -= PalyerConnected;

                    GameForm gameForm = GameForm.GetInstance();
                    gameForm.Owner = this;
                    gameForm.Show();
                    this.Hide();
                }));
            }
            else
            {
                // ≈сли мы уже в UI потоке, то выполн€ем напр€мую
                connectionData.OnMessageReceived -= ClientError;
                connectionData.OnClientDisconnected -= HostError;
                connectionData.OnClientConnected -= PalyerConnected;

                GameForm gameForm = GameForm.GetInstance();
                gameForm.Owner = this;
                gameForm.Show();
                this.Hide();
            }
        }
        private void CancelHostButton_Click(object sender, EventArgs e)
        {
            CancelHostButton.Visible = false;
            HostLabel.Visible = false;
            JoinButton.Enabled = true;
            connectionData.OnClientConnected -= PalyerConnected;
            connectionData.OnClientDisconnected -= HostError;
            connectionData.Disconnect();
        }
        private void JoinButton_Click(object sender, EventArgs e)
        {
            JoinBox.Visible = true;
            HostButton.Enabled = false;
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            string ip = IPInput.Text;
            connectionData.OnMessageReceived += ClientError;
            connectionData.OnClientConnected += PalyerConnected;
            connectionData.Start(false, ip);
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            connectionData.OnMessageReceived -= ClientError;
            connectionData.OnClientConnected -= PalyerConnected;
            connectionData.Disconnect();
            JoinBox.Visible = false;
            HostButton.Enabled = true;
        }
        private void ClientError(string message)
        {
            connectionData.OnMessageReceived -= ClientError;
            connectionData.OnClientConnected -= PalyerConnected;
            connectionData.Disconnect();
            JoinBox.Visible = false;
            HostButton.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            connectionData.Disconnect();
            Application.Exit();
        }

        
    }
}
