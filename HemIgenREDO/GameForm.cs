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
    public partial class GameForm : Form
    {
        bool closeForm;
        DateTime start = DateTime.Now;
        EnumDifficulty difficulty;
        Player player = new Player();

        public GameForm(EnumDifficulty difficultyFromMenuForm)
        {
            InitializeComponent();
            difficulty = difficultyFromMenuForm;
            NewGame();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            tmrPlaytime.Start();
            lblHealth.Text = String.Format("Health: {0}", player.Health);
            lblWater.Text = String.Format("Water: {0}", player.Water);
            lblSteps.Text = String.Format("Steps: {0}", player.Steps);
            lblTime.Text = "Time played: 00:00";
            HideUnused();
        }

        private void NewGame()
        {
            btnStepTest.Select();
            player.Health = 100;
            player.Water = 100;
            player.Steps = 0;
            switch (difficulty)
            {
                case EnumDifficulty.Easy:
                    {
                        this.Text += " [Easy]";
                        player.Damage = 1;
                        player.Thirst = 1;
                        player.Healing = 1;
                        player.Hydration = 1;
                        break;
                    }
                case EnumDifficulty.Medium:
                    {
                        this.Text += " [Medium]";
                        player.Damage = 2;
                        player.Thirst = 2;
                        player.Healing = 2;
                        player.Hydration = 2;
                        break;
                    }
                case EnumDifficulty.Hard:
                    {
                        this.Text += " [Hard]";
                        player.Damage = 5;
                        player.Thirst = 5;
                        player.Healing = 5;
                        player.Hydration = 5;
                        break;
                    }
                case EnumDifficulty.Hardcore:
                    {
                        this.Text += " [Hardcore!]";
                        player.Damage = 10;
                        player.Thirst = 10;
                        player.Healing = 10;
                        player.Hydration = 10;
                        break;
                    }
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeForm)
                e.Cancel = true;
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Äru säker?", "hallå", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                closeForm = true;
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Äru säker?", "hallå", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                closeForm = true;
            }
        }

        private void btnStepTest_Click(object sender, EventArgs e)
        {
            if (player.Water != 0)
                lblWater.Text = String.Format("Water: {0}", player.ThirstTaken());
            else
                lblHealth.Text = String.Format("Health: {0}", player.DamageTaken());

            lblSteps.Text = String.Format("Steps: {0}", player.StepTaken());

            if (player.Health == 0)
            {
                tmrPlaytime.Stop();
                this.Text = "GAME OVER";
                lblDesc.Text = "GAME OVER";
                btnStepTest.Enabled = false;
                btnHealthTest.Enabled = false;
                btnWaterTest.Enabled = false;
            }
        }

        private void tmrPlaytime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = Playtime();
        }

        private string Playtime()
        {
            TimeSpan playTimeSpan = DateTime.Now - start;
            return String.Format("Time played: {0:mm\\:ss}",playTimeSpan);
        }

        private void btnHealthTest_Click(object sender, EventArgs e)
        {
            if (player.Health < 100)
                lblHealth.Text = String.Format("Health: {0}", player.Heal());
        }

        private void btnWaterTest_Click(object sender, EventArgs e)
        {
            if (player.Water < 100)
                lblWater.Text = String.Format("Water: {0}", player.Hydrate());
        }

        private void HideUnused()
        {
            lblInventory.Hide();
            tlpInventory.Hide();
            btnHand.Hide();
            btnMagnifier.Hide();
        }
    }
}
