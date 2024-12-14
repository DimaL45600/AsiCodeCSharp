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
        private bool prepairStage = true;
        private byte[,] PlayerFieldData = new byte[10, 10];
        private List<Ship> PlayerShips = new List<Ship>();
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
                    for(int i = 0; i < newShip.Length; i++)
                    {
                        if (newShip.IsHorizontal)
                        {
                            PlayerFieldData[row, column + i] = (byte)selectedShip;
                            newShip.Positions.Add(new Point(column+i, row));
                        }
                        else
                        {
                            PlayerFieldData[row + i, column] = (byte)selectedShip;
                            newShip.Positions.Add(new Point(column, row + i));
                        }
                    }
                    PlayerShips.Add(newShip);
                    string[] radioText = selectedRadio.Text.Split('(',')');
                    int leftShips = Convert.ToInt32(radioText[1]) - 1;
                    selectedRadio.Text = $"{radioText[0]}({leftShips})";
                    if(leftShips == 0)
                    {
                        selectedRadio.Enabled = false;
                    }
                    if(PlayerShips.Count == 10) ReadyButton.Enabled = true;
                }
                PlayerField.Invalidate();
            }
        }

        private bool CheckPalce(int row, int column, Ship shipData)
        {
            Point testCell = new Point(column, row);
            if (shipData.IsHorizontal) testCell.X += shipData.Length - 1;
            else testCell.Y += shipData.Length - 1;
            if(testCell.X > 9 || testCell.Y > 9) return false;
            testCell.X = column; testCell.Y = row;
            for (int i = 0; i < shipData.Length; i++)
            {
                if (shipData.IsHorizontal) testCell.X = column + i;
                else testCell.Y = row + i;
                if (PlayerFieldData[testCell.Y, testCell.X] != 0) return false;
                if(testCell.X - 1 >= 0)
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
        }
    }
}
