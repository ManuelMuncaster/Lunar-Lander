using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Lunar_Lander
{
    public partial class ManualScreen : UserControl
    {
        public ManualScreen()
        {
            InitializeComponent();
        }

        private void ManualScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Form form = this.FindForm();

                Form1.menu2Player.Play();

                GameScreen gs = new GameScreen();
                gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);

                form.Controls.Add(gs);
                form.Controls.Remove(this);
            }

            if (e.KeyCode == Keys.Escape)
            {
                Form form = this.FindForm();

                Form1.menu2Player.Play();

                Mainscreen ms = new Mainscreen();
                ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

                form.Controls.Add(ms);
                form.Controls.Remove(this);
            }
        }
    }
}
