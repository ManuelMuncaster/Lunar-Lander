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
    public partial class Mainscreen : UserControl
    {
        int index = 0;
        int lastIndex = 0;

        public Mainscreen()
        {
            InitializeComponent();
        }

        private void Mainscreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            lastIndex = index;
            Form form = this.FindForm();

            switch (e.KeyCode)
            {
                case Keys.Up:

                    if (index != 0)
                        index--;
                    else
                    {
                        index = 2;
                    }
                    break;
                case Keys.Down:

                    if (index != 2)
                        index++;
                    else
                    {
                        index = 0;
                    }
                    break;

                //clicking on the screen with space key
                case Keys.Space:
                    switch (index)
                    {
                        //start button
                        case 0:

                            ManualScreen mas = new ManualScreen();
                            mas.Location = new Point((form.Width - mas.Width) / 2, (form.Height - mas.Height) / 2);

                            form.Controls.Add(mas);
                            form.Controls.Remove(this);

                            break;

                            //highscore button
                        case 1:

                            //    HighscoreScreen hs = new HighscoreScreen();
                            //    form.Controls.Add(hs);
                            //    form.Controls.Remove(this);

                            //    hs.Location = new Point((form.Width - hs.Width) / 2, (form.Height - hs.Height) / 2);

                            break;

                        //exit button
                        case 2:

                            Application.Exit();
                            break;
                    }
                    break;
            }
            //set button to white if not clicked on
            switch (lastIndex)
            {
                case 0:
                    startLabel.ForeColor = Color.White;
                    break;
                case 1:
                    highScoreLabel.ForeColor = Color.White;
                    break;
                case 2:
                    exitLabel.ForeColor = Color.White;
                    break;
            }

            //set selected button to red
            switch (index)
            {
                case 0:
                    startLabel.ForeColor = Color.Red;
                    break;
                case 1:
                    highScoreLabel.ForeColor = Color.Red;
                    break;
                case 2:
                    exitLabel.ForeColor = Color.Red;
                    break;
            }
        }
    }
    }
