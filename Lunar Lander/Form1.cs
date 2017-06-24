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
using System.IO;

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

        public static System.Windows.Media.MediaPlayer boomSound;
        public static System.Windows.Media.MediaPlayer select1;
        public static System.Windows.Media.MediaPlayer menu2;
        public static System.Windows.Media.MediaPlayer lose;

        public Form1()
        {
            InitializeComponent();

            boomSound = new System.Windows.Media.MediaPlayer();
            boomSound.Open(new Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "boom.wav")));
            boomSound.Volume = 1;

            select1 = new System.Windows.Media.MediaPlayer();
            select1.Open(new Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "menu1.wav")));
            select1.Volume = 1;

            menu2 = new System.Windows.Media.MediaPlayer();
            menu2.Open(new Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "menu2.wav")));
            menu2.Volume = 1;

            lose = new System.Windows.Media.MediaPlayer();
            lose.Open(new Uri(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "lose.wav")));
            lose.Volume = 1;
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
