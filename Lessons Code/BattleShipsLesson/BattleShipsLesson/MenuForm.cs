namespace BattleShipsLesson
{
    public partial class MenuForm : Form
    {
        internal static ConnectionData connectionData = new ConnectionData();
        public MenuForm()
        {
            InitializeComponent();
        }
        private void PlayerConnected()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    connectionData.OnConnect -= PlayerConnected;
                    connectionData.OnMessageReceived -= HostError;
                    GameForm gameForm = GameForm.GetInstance();
                    gameForm.Owner = this;
                    gameForm.Show();
                    this.Hide();
                }));
            }
            else
            {
                connectionData.OnConnect -= PlayerConnected;
                connectionData.OnMessageReceived -= HostError;
                GameForm gameForm = GameForm.GetInstance();
                gameForm.Owner = this;
                gameForm.Show();
                this.Hide();
            }
        }
        private void HostError(string message)
        {
            HostDataLabel.Visible = false;
            CancelHostButton.Visible = false;
            JoinButton.Enabled = true;
            connectionData.OnConnect -= PlayerConnected;
            connectionData.OnMessageReceived -= HostError;
            connectionData.Disconnect();
        }
        private void ClientError(string message)
        {
            connectionData.OnConnect -= PlayerConnected;
            connectionData.OnMessageReceived -= ClientError;
            connectionData.Disconnect();
            HostButton.Enabled = true;
            JoinBox.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            connectionData.OnConnect += PlayerConnected;
            connectionData.OnMessageReceived += HostError;
            connectionData.Start(true);
            HostDataLabel.Text = connectionData.GetHostData();
            HostDataLabel.Visible = true;
            CancelHostButton.Visible = true;
            JoinButton.Enabled = false;
        }

        private void CancelHostButton_Click(object sender, EventArgs e)
        {
            HostDataLabel.Visible = false;
            CancelHostButton.Visible = false;
            JoinButton.Enabled = true;
            connectionData.OnConnect -= PlayerConnected;
            connectionData.OnMessageReceived -= HostError;
            connectionData.Disconnect();
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            HostButton.Enabled = false;
            JoinBox.Visible = true;
        }

        private void JoinCancelButton_Click(object sender, EventArgs e)
        {
            connectionData.OnConnect -= PlayerConnected;
            connectionData.OnMessageReceived -= ClientError;
            connectionData.Disconnect();
            HostButton.Enabled = true;
            JoinBox.Visible = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            connectionData.OnConnect += PlayerConnected;
            connectionData.OnMessageReceived += ClientError;
            connectionData.Start(false, IPInput.Text);
        }
    }
}
