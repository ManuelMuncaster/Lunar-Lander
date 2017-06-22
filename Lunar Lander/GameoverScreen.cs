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

        public GameoverScreen()
        {
            InitializeComponent();

        }

        private void GameoverScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Form form = this.FindForm();

            switch (e.KeyCode)
            {
                case Keys.Space:
                    switch (index)
                    {
                        case 0:

                            Mainscreen ms = new Mainscreen();
                            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

                            form.Controls.Add(ms);
                            form.Controls.Remove(this);

                            break;
                    }
                    break;
            }

        }

    }

}
