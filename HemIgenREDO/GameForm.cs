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

        int initialIndex;
        PictureBox initialPB;

        public GameForm(EnumDifficulty difficultyFromMenuForm)
        {
            InitializeComponent();
            difficulty = difficultyFromMenuForm;
            
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            NewGame();

            tmrPlaytime.Start();
            lblHealth.Text = String.Format("Health: {0}", player.Health);
            lblLevel.Text = String.Format("Level: {0}", player.Level);
            lblSteps.Text = String.Format("Steps: {0}", player.Steps);
            lblTime.Text = "Time played: 00:00";
            HideUnused();

            PlacePlayer();
            player.gameMap.SpecifyMap(tlpMap, initialPB);
            player.gameMap.LastControl = initialPB;           
        }

        private void NewGame()
        {
            switch (difficulty)
            {
                case EnumDifficulty.Easy:
                    {
                        this.Text += " [Easy]";
                        player.Damage = 1;
                        player.Healing = 1;
                        break;
                    }
                case EnumDifficulty.Medium:
                    {
                        this.Text += " [Medium]";
                        player.Damage = 2;
                        player.Healing = 2;
                        break;
                    }
                case EnumDifficulty.Hard:
                    {
                        this.Text += " [Hard]";
                        player.Damage = 5;
                        player.Healing = 5;
                        break;
                    }
                case EnumDifficulty.Hardcore:
                    {
                        this.Text += " [Hardcore!]";
                        player.Damage = 10;
                        player.Healing = 10;
                        break;
                    }
            }
            player.Difficulty = difficulty;
            player.Health = 100;
            player.Level = 0;
            player.Steps = 0;
            player.gameMap.PlaceControls(tlpMap, player.LevelUp());            
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeForm)
                e.Cancel = true;
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Är du säker på att du vill avsluta? Den nuvarande omgången går ej att återvända till.", "Avsluta Spelet", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                closeForm = true;
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Är du säker på att du vill återgå till huvudmenyn? Den nuvarande omgången går ej att återvända till.", "Återgå till Huvudmeny", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                closeForm = true;
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
        private void HideUnused()
        {
            lblInventory.Hide();
            tlpInventory.Hide();
            btnHand.Hide();
            btnMagnifier.Hide();
        }

        private void PlacePlayer()
        {
            bool placeOk;
            do
            {
                placeOk = true;
                initialIndex = RandomIndex(tlpMap);
                initialPB = (PictureBox)tlpMap.Controls[0];
                foreach (PictureBox pb in player.gameMap.dangers)
                {
                    if (tlpMap.Controls.IndexOf(initialPB) == tlpMap.Controls.IndexOf(pb))
                    {
                        placeOk = false;
                    }
                }
            } while (!placeOk);
            tlpMap.Controls[0].BackColor = SystemColors.Highlight;
        }

        private int RandomIndex(TableLayoutPanel parent)
        {
            Random r = new Random();
            return r.Next(0, parent.Controls.Count);
        }
    }
}
