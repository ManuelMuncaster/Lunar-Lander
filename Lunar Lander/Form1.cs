using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Lunar_Lander
{
    public partial class Form1 : Form
    {
        public static SoundPlayer boomPlayer = new SoundPlayer(Properties.Resources.atari_boom);
        public static SoundPlayer menu1Player = new SoundPlayer(Properties.Resources.menu1);
        public static SoundPlayer menu2Player = new SoundPlayer(Properties.Resources.menu2);
        public static SoundPlayer losePlayer = new SoundPlayer(Properties.Resources.loseV2);
        public static SoundPlayer boostPlayer = new SoundPlayer(Properties.Resources.boosterV2);
        public static SoundPlayer winPlayer = new SoundPlayer(Properties.Resources.winV2);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mainscreen ms = new Mainscreen();
            this.Controls.Add(ms);

            this.Controls.Remove(this);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }
    }
}
