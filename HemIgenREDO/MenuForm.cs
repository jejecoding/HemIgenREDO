using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HemIgenREDO
{
    public partial class MenuForm : Form
    {
        EnumDifficulty difficulty = new EnumDifficulty();
        GameForm game = new GameForm();

        public MenuForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            pnlDifficulty.Visible = false;
            game.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlDifficulty.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tack för att du har spelat");
            Application.Exit();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            game.Visible = true;
            difficulty = EnumDifficulty.Easy;
            this.Visible = false;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            game.Visible = true;
            difficulty = EnumDifficulty.Medium;
            this.Visible = false;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            game.Visible = true;
            difficulty = EnumDifficulty.Hard;
            this.Visible = false;
        }

        private void btnHardcore_Click(object sender, EventArgs e)
        {
            game.Visible = true;
            difficulty = EnumDifficulty.Hardcore;
            this.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlDifficulty.Visible = false;
        }
    }
}
