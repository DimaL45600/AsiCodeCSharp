using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShipsLesson
{
    public partial class GameForm : Form
    {
        private bool gameStatus = false;
        private bool prepairStage = true;
        private bool enemyReady = false;
        private bool turnStatus = false;
        private byte[,] PlayerFieldData = new byte[10, 10];
        private List<Ship> PlayerShips = new List<Ship>();
        private byte[,] EnemyFieldData = new byte[10, 10];
        private List<Ship> EnemyShips = new List<Ship>();
        private int selectedShip = 1;
        private RadioButton selectedRadio;

        private static GameForm? instance;
        public static GameForm GetInstance()
        {
            if (instance == null || instance.IsDisposed) return instance = new GameForm();
            return instance;
        }
        public GameForm()
        {
            InitializeComponent();
            selectedRadio = ShipR1;
            if (MenuForm.connectionData.IsHost) IsHostLabel.Text = "Host";
            else IsHostLabel.Text = "Client";
            MenuForm.connectionData.OnMessageReceived += MessegeRecived;
            MenuForm.connectionData.OnClientDisconnected += PlayerDisconected;
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner?.Show();
        }

        private void PalyerField_MouseClick(object sender, MouseEventArgs e)
        {
            if (prepairStage)
            {
                var cell = GetCellFromMouse(PlayerField, e.Location);
                AddShipToCell(cell.X, cell.Y);
            }
        }

        private Point GetCellFromMouse(TableLayoutPanel panel, Point mousePosition)
        {
            int cellWidth = panel.Width / panel.ColumnCount;
            int cellHeight = panel.Height / panel.RowCount;

            int col = mousePosition.X / cellWidth;
            int row = mousePosition.Y / cellHeight;

            return new Point(col, row);
        }

        private void AddShipToCell(int column, int row)
        {
            if (PlayerFieldData[row, column] == 0 && selectedRadio.Enabled == true)
            {
                Ship newShip = new Ship(selectedShip, !IsVertical.Checked);
                if (!CheckPalce(row, column, newShip)) MessageBox.Show("Cannot place ship in this place!");
                else
                {
                    for (int i = 0; i < newShip.Length; i++)
                    {
                        if (newShip.IsHorizontal)
                        {
                            PlayerFieldData[row, column + i] = (byte)selectedShip;
                            newShip.Positions.Add(new Point(column + i, row));
                        }
                        else
                        {
                            PlayerFieldData[row + i, column] = (byte)selectedShip;
                            newShip.Positions.Add(new Point(column, row + i));
                        }
                    }
                    PlayerShips.Add(newShip);
                    string[] radioText = selectedRadio.Text.Split('(', ')');
                    int leftShips = Convert.ToInt32(radioText[1]) - 1;
                    selectedRadio.Text = $"{radioText[0]}({leftShips})";
                    if (leftShips == 0)
                    {
                        selectedRadio.Enabled = false;
                    }
                    if (PlayerShips.Count == 10) ReadyButton.Enabled = true;
                }
                PlayerField.Invalidate();
            }
        }

        private bool CheckPalce(int row, int column, Ship shipData)
        {
            Point testCell = new Point(column, row);
            if (shipData.IsHorizontal) testCell.X += shipData.Length - 1;
            else testCell.Y += shipData.Length - 1;
            if (testCell.X > 9 || testCell.Y > 9) return false;
            testCell.X = column; testCell.Y = row;
            for (int i = 0; i < shipData.Length; i++)
            {
                if (shipData.IsHorizontal) testCell.X = column + i;
                else testCell.Y = row + i;
                if (PlayerFieldData[testCell.Y, testCell.X] != 0) return false;
                if (testCell.X - 1 >= 0)
                {
                    if (PlayerFieldData[testCell.Y, testCell.X - 1] != 0) return false;
                    if (testCell.Y - 1 >= 0) if (PlayerFieldData[testCell.Y - 1, testCell.X - 1] != 0) return false;
                    if (testCell.Y + 1 < 9) if (PlayerFieldData[testCell.Y + 1, testCell.X - 1] != 0) return false;
                }
                if (testCell.X + 1 <= 9)
                {
                    if (PlayerFieldData[testCell.Y, testCell.X + 1] != 0) return false;
                    if (testCell.Y - 1 >= 0) if (PlayerFieldData[testCell.Y - 1, testCell.X + 1] != 0) return false;
                    if (testCell.Y + 1 < 9) if (PlayerFieldData[testCell.Y + 1, testCell.X + 1] != 0) return false;

                }
                if (testCell.Y - 1 >= 0)
                {
                    if (PlayerFieldData[testCell.Y - 1, testCell.X] != 0) return false;
                    if (testCell.X - 1 >= 0) if (PlayerFieldData[testCell.Y - 1, testCell.X - 1] != 0) return false;
                    if (testCell.X + 1 < 9) if (PlayerFieldData[testCell.Y - 1, testCell.X + 1] != 0) return false;

                }
                if (testCell.Y + 1 <= 9)
                {
                    if (PlayerFieldData[testCell.Y + 1, testCell.X] != 0) return false;
                    if (testCell.X - 1 >= 0) if (PlayerFieldData[testCell.Y + 1, testCell.X - 1] != 0) return false;
                    if (testCell.X + 1 < 9) if (PlayerFieldData[testCell.Y + 1, testCell.X + 1] != 0) return false;
                }
            }
            return true;
        }

        private void PlayerField_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            int cellData = PlayerFieldData[e.Row, e.Column];
            if (cellData == 1)
            {
                e.Graphics.FillRectangle(Brushes.Green, e.CellBounds);
            }
            if (cellData == 2)
            {
                e.Graphics.FillRectangle(Brushes.Yellow, e.CellBounds);
            }
            if (cellData == 3)
            {
                e.Graphics.FillRectangle(Brushes.Orange, e.CellBounds);
            }
            if (cellData == 4)
            {
                e.Graphics.FillRectangle(Brushes.Red, e.CellBounds);
            }
            if (cellData == 5)
            {
                e.Graphics.FillRectangle(Brushes.Gray, e.CellBounds);
            }
        }

        private void ShipR1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShipR1.Checked)
            {
                selectedShip = 1;
                selectedRadio = ShipR1;
            }
        }

        private void ShipR2_CheckedChanged(object sender, EventArgs e)
        {
            if (ShipR2.Checked)
            {
                selectedShip = 2;
                selectedRadio = ShipR2;
            }
        }

        private void ShipR3_CheckedChanged(object sender, EventArgs e)
        {
            if (ShipR3.Checked)
            {
                selectedShip = 3;
                selectedRadio = ShipR3;
            }
        }

        private void ShipR4_CheckedChanged(object sender, EventArgs e)
        {
            if (ShipR4.Checked)
            {
                selectedShip = 4;
                selectedRadio = ShipR4;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            PlayerFieldData = new byte[10, 10];
            ShipR4.Text = "battleship       (1)";
            ShipR1.Enabled = true;
            ShipR3.Text = "cruisers           (2)";
            ShipR2.Enabled = true;
            ShipR2.Text = "destroyers      (3)";
            ShipR3.Enabled = true;
            ShipR1.Text = "torpedo boat (4)";
            ShipR4.Enabled = true;
            ReadyButton.Enabled = false;
            PlayerShips.Clear();
            PlayerField.Invalidate();
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            PrepairBox.Visible = false;
            ReadyButton.Text = "Waiting for other player!";
            ReadyButton.Enabled = false;
            prepairStage = false;
            MenuForm.connectionData.SendMessage("Ready");
        }
        private void MessegeRecived(string message)
        {
            Invoke((Action)(() =>
            {
                if (message == "Ready")
                {
                    enemyReady = true;
                    label3.Visible = true;
                    if (!prepairStage && enemyReady)
                    {
                        Random random = new Random();
                        if (random.Next(0, 1) == 0)
                        {
                            turnStatus = false;
                            MenuForm.connectionData.SendMessage("turn:1");
                        }
                        else
                        {
                            turnStatus = true;
                            MenuForm.connectionData.SendMessage("turn:0");
                        }
                        StartGame();
                    }
                    return;
                }
                if (message.Contains("turn"))
                {
                    turnStatus = message.Split(':')[1] == "1";
                    StartGame();
                    return;
                }
                if (gameStatus)
                {
                    if (message.Contains("shoot"))
                    {
                        Point hit = new Point(Convert.ToInt32(message.Split(':', ',')[2]), Convert.ToInt32(message.Split(':', ',')[1]));
                        if (PlayerFieldData[hit.Y, hit.X] != 0)
                        {
                            PlayerShips.First(s => s.Positions.Contains(hit)).Health -= 1;
                            int[] shipData = new int[4];
                            for (int i = 0; i < PlayerShips.Count; i++)
                            {
                                if (PlayerShips[i].Health > 0) shipData[PlayerShips[i].Length - 1] += 1;
                            }
                            player4label.Text = $"Player(4) : {shipData[3]}";
                            player3label.Text = $"Player(3) : {shipData[2]}";
                            player2label.Text = $"Player(2) : {shipData[1]}";
                            player1label.Text = $"Player(1) : {shipData[0]}";
                            MenuForm.connectionData.SendMessage($"hit:{hit.Y},{hit.X}:{shipData[0]},{shipData[1]},{shipData[2]},{shipData[3]}");
                            if (shipData[0] == 0 && shipData[1] == 0 && shipData[2] == 0 && shipData[3] == 0)
                            {
                                gameStatus = false;
                                MessageBox.Show("You loose");
                                MenuForm.connectionData.Disconnect();
                            }
                            PlayerField.Invalidate();
                        }
                        else
                        {
                            turnStatus = true;
                            TurnLabel.Text = "Your turn";
                            MenuForm.connectionData.SendMessage($"miss:{hit.Y},{hit.X}");
                        }
                        PlayerFieldData[hit.Y, hit.X] = 5;
                        PlayerField.Invalidate();
                    }
                    if (message.Contains("hit"))
                    {
                        Point hit = new Point(Convert.ToInt32(message.Split(':', ',')[2]), Convert.ToInt32(message.Split(':', ',')[1]));
                        int[] enemyShips = new int[4];
                        enemyShips[0] = Convert.ToInt32(message.Split(':', ',')[3]);
                        enemyShips[1] = Convert.ToInt32(message.Split(':', ',')[4]);
                        enemyShips[2] = Convert.ToInt32(message.Split(':', ',')[5]);
                        enemyShips[3] = Convert.ToInt32(message.Split(':', ',')[6]);
                        enemy4Label.Text = $"Enemy(4) : {enemyShips[3]}";
                        enemy3Label.Text = $"Enemy(3) : {enemyShips[2]}";
                        enemy2Label.Text = $"Enemy(2) : {enemyShips[1]}";
                        enemy1Label.Text = $"Enemy(1) : {enemyShips[0]}";
                        EnemyFieldData[hit.Y, hit.X] = 1;
                        turnStatus = true;
                        if (enemyShips[0] == 0 && enemyShips[1] == 0 && enemyShips[2] == 0 && enemyShips[3] == 0)
                        {
                            gameStatus = false;
                            MessageBox.Show("You win");
                            MenuForm.connectionData.Disconnect();
                        }
                        EnemyField.Invalidate();
                    }
                    if (message.Contains("miss"))
                    {
                        Point hit = new Point(Convert.ToInt32(message.Split(':', ',')[2]), Convert.ToInt32(message.Split(':', ',')[1]));
                        EnemyFieldData[hit.Y, hit.X] = 2;
                        TurnLabel.Text = "Enemy turn";
                        EnemyField.Invalidate();
                    }
                }
            }));
        }
        private void PlayerDisconected()
        {
            MessageBox.Show("Enemy disconected");
            this.Close();
        }
        private void StartGame()
        {
            gameStatus = true;
            ReadyButton.Visible = false;
            label3.Visible = false;
            TurnLabel.Visible = true;
            TurnLabel.Text = turnStatus ? "Your turn" : "Enemy turn";
        }

        private void EnemyField_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            int cellData = EnemyFieldData[e.Row, e.Column];
            if (cellData == 1)
            {
                e.Graphics.FillRectangle(Brushes.Red, e.CellBounds);
            }
            if (cellData == 2)
            {
                e.Graphics.FillRectangle(Brushes.Gray, e.CellBounds);
            }
        }

        private void EnemyField_MouseClick(object sender, MouseEventArgs e)
        {
            if (gameStatus && turnStatus)
            {
                var cell = GetCellFromMouse(EnemyField, e.Location);
                MenuForm.connectionData.SendMessage($"shoot:{cell.Y},{cell.X}");
                turnStatus = false;
            }
        }
    }
}
