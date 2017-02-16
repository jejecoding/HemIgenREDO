using System.Drawing;
using System.Windows.Forms;

namespace HemIgenREDO
{
    public class Map
    {
        int playerPosX, playerPosY;
        int controlPosX, controlPosY;
        bool yIsOk, xIsOk;

        Control lastControl;

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
    }
}
