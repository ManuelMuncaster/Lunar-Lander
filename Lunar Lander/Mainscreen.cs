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
            Onstart();
        }

        public void Onstart()
        {

        }

        private void Mainscreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        //    lastIndex = index;

        //    switch (e.KeyCode)
        //    {
        //        case Keys.Up:

        //            if (index != 0)
        //                index--;
        //            else
        //            {
        //                index = 3;
        //            }
        //            break;
        //        case Keys.Down:

        //            if (index != 3)
        //                index++;
        //            else
        //            {
        //                index = 0;
        //            }
        //            break;

        //        //clicking on the screen with space key
        //        case Keys.Space:
        //            switch (index)
        //            {
        //                //start button
        //                case 0:

        //                    InstructionScreen si = new InstructionScreen();
        //                    si.Location = new Point((form.Width - si.Width) / 2, (form.Height - si.Height) / 2);

        //                    form.Controls.Add(si);
        //                    form.Controls.Remove(this);

        //                    break;

        //                //highscore button
        //                case 1:

        //                    //play sound
        //                    Form1.select.Stop();
        //                    Form1.select.Play();

        //                    HighscoreScreen hs = new HighscoreScreen();
        //                    form.Controls.Add(hs);
        //                    form.Controls.Remove(this);

        //                    hs.Location = new Point((form.Width - hs.Width) / 2, (form.Height - hs.Height) / 2);

        //                    break;

        //                //option button
        //                case 2:

        //                    //play sound
        //                    Form1.select.Stop();
        //                    Form1.select.Play();

        //                    OptionScreen os = new OptionScreen();

        //                    form.Controls.Add(os);
        //                    form.Controls.Remove(this);

        //                    os.Location = new Point((form.Width - os.Width) / 2, (form.Height - os.Height) / 2);
        //                    break;

        //                //exit button
        //                case 3:

        //                    //play sound
        //                    Form1.gameOver.Stop();
        //                    Form1.gameOver.Play();
        //                    Thread.Sleep(1000);

        //                    Application.Exit();
        //                    break;
        //            }
        //            break;
        //    }

            ////set button to white if not clicked on
            //switch (lastIndex)
            //{
            //    case 0:
            //        startLabel.ForeColor = Color.White;
            //        break;
            //    case 1:
            //        highScoreLabel.ForeColor = Color.White;
            //        break;
            //    case 2:
            //        optionLabel.ForeColor = Color.White;
            //        break;
            //    case 3:
            //        exitLabel.ForeColor = Color.White;
            //        break;
            //}

    //        //set selected button to red
    //        switch (index)
    //        {
    //            case 0:
    //                startLabel.ForeColor = Color.Red;
    //                break;
    //            case 1:
    //                highScoreLabel.ForeColor = Color.Red;
    //                break;
    //            case 2:
    //                optionLabel.ForeColor = Color.Red;
    //                break;
    //            case 3:
    //                exitLabel.ForeColor = Color.Red;
    //                break;
    //        }
    //    }
    }
    }
}
