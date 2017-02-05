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
        GameForm game;

        public MenuForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            pnlDifficulty.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlDifficulty.Visible = true;
            btnHardcore.Select();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tack för att du har spelat");
            Application.Exit();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            HideMenu();
            StartGame(EnumDifficulty.Easy);
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            HideMenu();
            StartGame(EnumDifficulty.Medium);
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            HideMenu();
            StartGame(EnumDifficulty.Hard);
        }

        private void btnHardcore_Click(object sender, EventArgs e)
        {
            HideMenu();
            StartGame(EnumDifficulty.Hardcore);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlDifficulty.Visible = false;
        }

        private void StartGame(EnumDifficulty d)
        {
            game = new GameForm(d);

            if (game.ShowDialog() == DialogResult.OK)
                this.Visible = true;
            else
                Application.Exit();
        }

        private void HideMenu()
        {
            this.pnlDifficulty.Visible = false;
            this.Visible = false;
        }
    }
}
