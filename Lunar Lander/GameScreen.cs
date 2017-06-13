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
using Lines;

namespace Lunar_Lander
{
    public partial class GameScreen : UserControl
    {
        //Bool values for key presses
        Boolean leftArrowDown, rightArrowDown, downArrowDown, upArrowDown, escapeDown;

        //creating graphic objects
        SolidBrush drawBrush = new SolidBrush(Color.White);
        Font drawFont = new Font("Courier", 16, FontStyle.Bold);
        Pen drawPen = new Pen(Color.White);

        List<int> moonLines = new List<int>();
        List<int> landerLines = new List<int>();

        Lander lander;
        Boolean didIntersect;

        public GameScreen()
        {
            InitializeComponent();
            Onstart();

            gameTimer.Enabled = true;
            gameTimer.Start();
        }

        public void Onstart()
        {
            int xLander = 500;
            int yLander = 500;
            int xSpeedLander = 1;
            int ySpeedLander = 1;
            int speedMultiLander = 1;
            int angleSpeedLander = 3;
            int angleLander = 90;
            int imageLander = 0;
            //Temp values for drawing test rectangle 
            int widthLander = 90;
            int heightLander = 90;
            int x2 = 0;
            int y2 = 0;

            //lander.x = Convert.ToInt64(x2);
            //lander.y = Convert.ToInt64(y2);

            LineSegment landerL1 = new LineSegment(xLander + 5, yLander - 5, xLander + 5, yLander + 5);
            //LineSegment landerL2 = new LineSegment(xLander + 5, y2 - 5, x2, y2 -5);
            //LineSegment landerL3 = new LineSegment();


            lander = new Lander(xLander, yLander, xSpeedLander, ySpeedLander, angleLander, angleSpeedLander, imageLander, widthLander, heightLander);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Escape:
                    escapeDown = true;
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Space:
                    escapeDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (leftArrowDown == true)
            {
                lander.Turn("left");
            }

            if (rightArrowDown == true)
            {
                lander.Turn("right");
            }

            if (upArrowDown == true)
            {
                lander.Boost("engage");

                if (lander.ySpeed > 2.7)
                {
                    lander.ySpeed -= 0.5f;
                }
               
            }

            #region Gravity
            lander.ySpeed += 0.05f;
            lander.xSpeed += 0.01f;
            lander.y = lander.y + lander.ySpeed;
            lander.x = lander.x + lander.xSpeed;
            #endregion


            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            float x2 = Convert.ToSingle(lander.x);
            float y2 = Convert.ToSingle(lander.y);

            //find the centre of the hero to set the origin point where rotation will happen
            e.Graphics.TranslateTransform(lander.width / 2 + x2, lander.width / 2 + y2);

            //rotate by the given angle for the hero
            e.Graphics.RotateTransform(lander.angle);

            // draw the object in the middle of the rotated origin point
            e.Graphics.DrawLine(drawPen, x2 + 5, y2 - 5, x2 + 5, y2 + 5);

            e.Graphics.DrawImage(Properties.Resources.lander90, 0 - lander.width / 2, 0 - lander.width / 2, lander.width, lander.height);
            //reset to original origin point
            e.Graphics.ResetTransform();

            //Temp Angle reading
            e.Graphics.DrawString(lander.angle + "", drawFont, drawBrush, 100, 100);
            e.Graphics.DrawString(lander.x + "X", drawFont, drawBrush, 200, 100);
            e.Graphics.DrawString(lander.xSpeed + "xSpeed", drawFont, drawBrush, 500, 100);
            e.Graphics.DrawString(lander.y + "Y", drawFont, drawBrush, 200, 200);
            e.Graphics.DrawString(lander.ySpeed + "ySpeed", drawFont, drawBrush, 500, 200);

            //Drawing World

            e.Graphics.DrawLine(drawPen, 500, 500, 600, 600);
        }


    }
}
