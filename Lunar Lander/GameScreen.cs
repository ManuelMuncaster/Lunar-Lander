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

        public List<LineSegment> moonLines = new List<LineSegment>();
        public List<LineSegment> landerLines = new List<LineSegment>();

        public string explode;


        Lander lander;
        Boolean didIntersect = false;

        public GameScreen()
        {
            InitializeComponent();
            Onstart();

            gameTimer.Enabled = true;
            gameTimer.Start();
        }

        public void Onstart()
        {
            int xLander = 400;
            int yLander = 400;
            int xSpeedLander = 1;
            int ySpeedLander = 1;
            int speedMultiLander = 1;
            int angleSpeedLander = 3;
            int angleLander = 90;
            int imageLander = 0;
            //Temp values for drawing test rectangle 
            int widthLander = 45;
            int heightLander = 45;
            int x2 = 0;
            int y2 = 0;
            int fuel = 100;

            lander = new Lander(xLander, yLander, xSpeedLander, ySpeedLander, angleLander, angleSpeedLander, imageLander, widthLander, heightLander, fuel);

            LineSegment landerL1 = new LineSegment((int)lander.x, (int)lander.y, (int)lander.x, (int)lander.y + lander.height);
            LineSegment landerL2 = new LineSegment((int)lander.x + lander.width, (int)lander.y, (int)lander.x + lander.width, (int)lander.y + lander.height);
            LineSegment landerL3 = new LineSegment((int)lander.x, (int)lander.y + lander.height, (int)lander.x + lander.width, (int)lander.y + lander.height);

            landerLines.Add(landerL1);
            landerLines.Add(landerL2);
            landerLines.Add(landerL3);

            LineSegment moonL1 = new LineSegment(0, 0, 39, 231);
            LineSegment moonL2 = new LineSegment(39, 231, 140, 308);
            LineSegment moonL3 = new LineSegment(140, 308, 203, 309);
            LineSegment moonL4 = new LineSegment(203, 309, 256, 491);
            LineSegment moonL5 = new LineSegment(256, 491, 306, 432);
            LineSegment moonL6 = new LineSegment(306, 432, 333, 500);
            LineSegment moonL7 = new LineSegment(333, 500, 371, 528);
            LineSegment moonL8 = new LineSegment(371, 528, 388, 627);
            LineSegment moonL9 = new LineSegment(388, 627, 473, 627);
            LineSegment moonL10 = new LineSegment(473, 627, 506, 552);
            LineSegment moonL11 = new LineSegment(506, 552, 535, 607);
            LineSegment moonL12 = new LineSegment(535, 607, 578, 500);
            LineSegment moonL13 = new LineSegment(578, 500, 636, 615);
            LineSegment moonL14 = new LineSegment(636, 615, 732, 615);
            LineSegment moonL15 = new LineSegment(732, 615, 790, 524);
            LineSegment moonL16 = new LineSegment(790, 524, 827, 524);
            LineSegment moonL17 = new LineSegment(827, 524, 869, 426);
            LineSegment moonL18 = new LineSegment(869, 426, 980, 307);
            LineSegment moonL19 = new LineSegment(980, 307, 1025, 189);
            LineSegment moonL20 = new LineSegment(1025, 189, 1059, 189);
            LineSegment moonL21 = new LineSegment(1059, 189, 1166, 324);
            LineSegment moonL22 = new LineSegment(1166, 324, 1271, 217);
            LineSegment moonL23 = new LineSegment(1271, 217, 1387, 326);
            LineSegment moonL24 = new LineSegment(1387, 326, 1498, 0);

            moonLines.Add(moonL1);
            moonLines.Add(moonL2);
            moonLines.Add(moonL3);
            moonLines.Add(moonL4);
            moonLines.Add(moonL5);
            moonLines.Add(moonL6);
            moonLines.Add(moonL7);
            moonLines.Add(moonL8);
            moonLines.Add(moonL9);
            moonLines.Add(moonL10);
            moonLines.Add(moonL11);
            moonLines.Add(moonL12);
            moonLines.Add(moonL13);
            moonLines.Add(moonL14);
            moonLines.Add(moonL15);
            moonLines.Add(moonL16);
            moonLines.Add(moonL17);
            moonLines.Add(moonL18);
            moonLines.Add(moonL19);
            moonLines.Add(moonL20);
            moonLines.Add(moonL21);
            moonLines.Add(moonL22);
            moonLines.Add(moonL23);
            moonLines.Add(moonL24);
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
                

                if (lander.fuel  > 0)
                {
                    lander.Boost("engage");
                    lander.fuel--;
                }

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

            //update lander lines

            landerLines[0].x1 = (int)lander.x;
            landerLines[0].y1 = (int)lander.y;
            landerLines[0].x2 = (int)lander.x;
            landerLines[0].y2 = (int)lander.y + lander.height;
            landerLines[0].pStart = new System.Windows.Point(landerLines[0].x1, landerLines[0].y1);
            landerLines[0].pEnd = new System.Windows.Point(landerLines[0].x2, landerLines[0].y2);

            landerLines[1].x1 = (int)lander.x + lander.width;
            landerLines[1].y1 = (int)lander.y;
            landerLines[1].x2 = (int)lander.x + lander.width;
            landerLines[1].y2 = (int)lander.y + lander.height;
            landerLines[1].pStart = new System.Windows.Point(landerLines[1].x1, landerLines[1].y1);
            landerLines[1].pEnd = new System.Windows.Point(landerLines[1].x2, landerLines[1].y2);

            landerLines[2].x1 = (int)lander.x;
            landerLines[2].y1 = (int)lander.y + lander.height;
            landerLines[2].x2 = (int)lander.x + lander.width;
            landerLines[2].y2 = (int)lander.y + lander.height;
            landerLines[2].pStart = new System.Windows.Point(landerLines[2].x1, landerLines[2].y1);
            landerLines[2].pEnd = new System.Windows.Point(landerLines[2].x2, landerLines[2].y2);

            foreach (LineSegment l in landerLines)
            {
                foreach(LineSegment m in moonLines)
                {
                    didIntersect = Intersection.LineSegementsIntersect(l, m, true);

                    if (didIntersect == true)
                    {
                        explode = "true";
                        gameTimer.Enabled = false;
                    }

                    else
                    {
                        
                    }
                }
            }


            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

            float x2 = Convert.ToSingle(lander.x);
            float y2 = Convert.ToSingle(lander.y);

            //Draw Moon's Surface

            e.Graphics.DrawLine(drawPen, 0, 0, 39, 231);
            e.Graphics.DrawLine(drawPen, 39, 231, 140, 308);
            e.Graphics.DrawLine(drawPen, 140, 308, 203, 309);
            e.Graphics.DrawLine(drawPen, 203, 309, 256, 491);
            e.Graphics.DrawLine(drawPen, 256, 491, 306, 432);
            e.Graphics.DrawLine(drawPen, 306, 432, 333, 500);
            e.Graphics.DrawLine(drawPen, 333, 500, 371, 528);
            e.Graphics.DrawLine(drawPen, 371, 528, 388, 627);
            e.Graphics.DrawLine(drawPen, 388, 627, 473, 627);
            e.Graphics.DrawLine(drawPen, 473, 627, 506, 552);
            e.Graphics.DrawLine(drawPen, 506, 552, 535, 607);
            e.Graphics.DrawLine(drawPen, 535, 607, 578, 500);
            e.Graphics.DrawLine(drawPen, 578, 500, 636, 615);
            e.Graphics.DrawLine(drawPen, 636, 615, 732, 615);
            e.Graphics.DrawLine(drawPen, 732, 615, 790, 524);
            e.Graphics.DrawLine(drawPen, 790, 524, 827, 524);
            e.Graphics.DrawLine(drawPen, 827, 524, 869, 426);
            e.Graphics.DrawLine(drawPen, 869, 426, 980, 307);
            e.Graphics.DrawLine(drawPen, 980, 307, 1025, 189);
            e.Graphics.DrawLine(drawPen, 1025, 189, 1059, 189);
            e.Graphics.DrawLine(drawPen, 1059, 189, 1166, 324);
            e.Graphics.DrawLine(drawPen, 1166, 324, 1271, 217);
            e.Graphics.DrawLine(drawPen, 1271, 217, 1387, 326);
            e.Graphics.DrawLine(drawPen, 1387, 326, 1498, 0);

            //Hit box Lines
            e.Graphics.DrawLine(drawPen, landerLines[0].x1, landerLines[0].y1, landerLines[0].x2, landerLines[0].y2);
            e.Graphics.DrawLine(drawPen, landerLines[1].x1, landerLines[1].y1, landerLines[1].x2, landerLines[1].y2);
            e.Graphics.DrawLine(drawPen, landerLines[2].x1, landerLines[2].y1, landerLines[2].x2, landerLines[2].y2);

            //find the centre of the hero to set the origin point where rotation will happen
            e.Graphics.TranslateTransform(lander.width / 2 + x2, lander.width / 2 + y2);

            //rotate by the given angle for the hero
            e.Graphics.RotateTransform(lander.angle);
      
            if (explode == "true")
            {
                e.Graphics.DrawImage(Properties.Resources.boomFinal, 0 - lander.width / 2, 0 - lander.width / 2, lander.width, lander.height);
            }
            else
            {
                e.Graphics.DrawImage(Properties.Resources.landerFinal2, 0 - lander.width / 2, 0 - lander.width / 2, lander.width, lander.height);
            }

            //reset to original origin point
            e.Graphics.ResetTransform();

            //Temp Angle reading
            e.Graphics.DrawString(lander.angle + "", drawFont, drawBrush, 100, 100);
            e.Graphics.DrawString(lander.x + "X", drawFont, drawBrush, 200, 100);
            e.Graphics.DrawString(lander.xSpeed + "xSpeed", drawFont, drawBrush, 500, 100);
            e.Graphics.DrawString(lander.y + "Y", drawFont, drawBrush, 200, 200);
            e.Graphics.DrawString(lander.ySpeed + "ySpeed", drawFont, drawBrush, 500, 200);
            e.Graphics.DrawString("Fuel:" + lander.fuel, drawFont, drawBrush, 500, 500);
        }
    }
}
