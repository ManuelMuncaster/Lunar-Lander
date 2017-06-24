using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lunar_Lander
{
    public partial class pauseScreen : Form
    {
        int index = 0;
        int lastIndex = 0;

        public pauseScreen()
        {
            InitializeComponent();
        }

        static pauseScreen pause;
        static public DialogResult result;

        public static DialogResult Show(string Text, string btnYes, string btnNo)
        {
            pause = new pauseScreen();
            pause.titleLabel6.Text = Text;
            pause.yesLabel.Text = btnYes;
            pause.noLabel.Text = btnNo;
            pause.ShowDialog();
            return result;
        }

        private void pauseScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            lastIndex = index;
            Form form = this.FindForm();

            switch (e.KeyCode)
            {
                case Keys.Left:
                    {
                        Form1.menu1Player.Play();
                        if (index != 0)
                        {
                            index--;
                        }

                        if (index == 0)
                        {
                            index = 2;
                        }
                        break;
                    }

                case Keys.Right:
                    {
                        Form1.menu1Player.Play();
                        if (index != 2)
                        {
                            index++;
                        }

                        else
                        {
                            index = 1;
                        }
                        break;
                    }


                //clicking on the screen with space key
                case Keys.Space:
                    switch (index)
                    {
                        //yes button

                        case 1:
                            Form1.menu2Player.Play();
                            result = DialogResult.No;
                            this.Close();
                            break;

                        //no button
                        case 2:
                            Form1.menu2Player.Play();
                            result = DialogResult.Yes;
                            this.Close();
                            break;
                    }
                    break;
            }

            //set button to white if not clicked on
            switch (lastIndex)
            {
                case 1:
                    noLabel.ForeColor = Color.White;
                    break;
                case 2:
                    yesLabel.ForeColor = Color.White;
                    break;
            }

            //set selected button to red
            switch (index)
            {
                case 1:
                    noLabel.ForeColor = Color.Red;
                    break;
                case 2:
                    yesLabel.ForeColor = Color.Red;
                    break;
            }
        }
    }
}
