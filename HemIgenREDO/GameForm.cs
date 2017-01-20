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
        DateTime start;

        Player player = new Player();

        public GameForm()
        {
            InitializeComponent();
        }

        private void NewGame()
        {
            player.Health = 100;
            player.Thirst = 100;
            player.Steps = 0;
        }
    }
}
