using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lunar_Lander
{
    public partial class GameoverScreen : UserControl
    {
        int index = 0;
        SolidBrush drawBrush = new SolidBrush(Color.White);
        Font drawFont = new Font("8bit Wonder", 25, FontStyle.Bold);

        public GameoverScreen()
        {
            InitializeComponent();
            Form1.losePlayer.Play();

        }

        private void GameoverScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Form form = this.FindForm();
                Form1.menu2Player.Play();

                Mainscreen ms = new Mainscreen();
                ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

                form.Controls.Add(ms);
                form.Controls.Remove(this);
            }

        }

        private void GameoverScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("You Scored: " + GameScreen.score + " points.", drawFont, drawBrush, 395, 300);
        }
    }

}
