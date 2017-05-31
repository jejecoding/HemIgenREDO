using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HemIgenREDO
{
    public class Map
    {
        int playerPosX, playerPosY;
        int controlPosX, controlPosY;
        bool yIsOk, xIsOk;
        Player player;

        Control lastControl;
        public List<PictureBox> dangers = new List<PictureBox>();

        public Map()
        {
            //player = currentPlayer;
        }
        public int PlayerPosX
        {
            get { return playerPosX; }
            set { playerPosX = value; }
        }

        public int PlayerPosY
        {
            get { return playerPosY; }
            set { playerPosY = value; }
        }

        public Control LastControl
        {
            get { return lastControl; }
            set { lastControl = value; }
        }

        public void PlaceControls(TableLayoutPanel parentTLP, int level)
        {
            for (int r = 0; r < parentTLP.RowCount; r++)
            {
                for (int c = 0; c < parentTLP.ColumnCount; c++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Click += Pb_Click;
                    pb.Dock = DockStyle.Fill;
                    pb.Margin = Padding.Empty;
                    pb.BackColor = Color.DarkGray;
                    parentTLP.Controls.Add(pb, c, r);
                }
            }
            
            Random rand = new Random();
            for (int i = 0; i< (level + 3); i++)
            {
               dangers.Add((PictureBox)parentTLP.Controls[rand.Next(parentTLP.Controls.Count)]);
            }
        }

        private void Pb_Click(object sender, System.EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            TableLayoutPanel parentTLP = (TableLayoutPanel)pb.Parent;
            MovePlayer(parentTLP, pb);
        }

        /// <summary>
        /// if player can move, will move; else shows error message
        /// </summary>
        /// <param name="parentTLP"></param>
        /// <param name="selectedControl"></param>
        public void MovePlayer(TableLayoutPanel parentTLP, Control selectedControl)
        {
            if (lastControl != selectedControl)
            {
                controlPosX = parentTLP.GetCellPosition(selectedControl).Column;
                controlPosY = parentTLP.GetCellPosition(selectedControl).Row;

                EqualAxis();

                if (xIsOk && yIsOk)
                {
                    foreach (PictureBox pb in dangers)
                    {
                        //if (parentTLP.Controls.IndexOf(lastControl) == parentTLP.Controls.IndexOf(pb))
                        //{
                        //    lastControl.BackColor = Color.Red;
                        //}
                        //else
                        //{
                        //    lastControl.BackColor = SystemColors.Control;
                        //}

                        if (parentTLP.Controls.IndexOf(selectedControl) == parentTLP.Controls.IndexOf(pb))
                        {
                            //damage player
                            MessageBox.Show("You got damaged");
                            
                        }
                    }
                    lastControl.BackColor = SystemColors.Control;
                    playerPosX = controlPosX;
                    playerPosY = controlPosY;
                    selectedControl.BackColor = SystemColors.Highlight;
                    lastControl = selectedControl;

                    
                }
                else
                {
                    MessageBox.Show("Can't go there!");
                }
            }
        }

        /// <summary>
        /// checks if player can move in x-direction
        /// </summary>
        private void MoveIsOkX()
        {
            if ((playerPosX + 1) == controlPosX || playerPosX - 1 == controlPosX)
                xIsOk = true;
            else
                xIsOk = false;
        }

        /// <summary>
        /// checks if player can move in y-direction
        /// </summary>
        private void MoveIsOkY()
        {
            if (playerPosY + 1 == controlPosY || playerPosY - 1 == controlPosY)
                yIsOk = true;
            else
                yIsOk = false;
        }

        /// <summary>
        /// Checks which arguments to compare
        /// </summary>
        private void EqualAxis()
        {
            if (playerPosY == controlPosY)
            {
                yIsOk = true;
                MoveIsOkX();
            }
            else if (playerPosX == controlPosX)
            {
                xIsOk = true;
                MoveIsOkY();
            }
            else
            {
                xIsOk = false;
                yIsOk = false;
            }
        }

        public void SpecifyMap(TableLayoutPanel container, PictureBox initialControl)
        {

            lastControl = container.Controls[0];
            PlayerPosX = container.GetCellPosition(lastControl).Column;
            PlayerPosY = container.GetCellPosition(lastControl).Row;
        }

        public void Danger()
        {
            //if (player.Water != 0)
            //    lblWater.Text = String.Format("Water: {0}", player.ThirstTaken());
            //else
            //    lblHealth.Text = String.Format("Health: {0}", player.DamageTaken());

            //lblSteps.Text = String.Format("Steps: {0}", player.StepTaken());

            //player.gameMap.MovePlayer(tlpMap, btnStepTest);

            //if (player.Health == 0)
            //{
            //    tmrPlaytime.Stop();
            //    this.Text = "GAME OVER";
            //    lblDesc.Text = "GAME OVER";
            //    btnStepTest.Enabled = false;
            //    btnHealthTest.Enabled = false;
            //    btnWaterTest.Enabled = false;
            //}
        }

        public void Healer()
        {
            //if (player.Health < 100)
            //    lblHealth.Text = String.Format("Health: {0}", player.Heal());

            //player.gameMap.MovePlayer(tlpMap,btnHealthTest);
        }
    }
}
