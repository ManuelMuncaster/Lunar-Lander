//By: Manuel Muncaster
//Purpose: Final Project
//Date: May 24, 2017
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
using System.Threading;

namespace Lunar_Lander
{
    public partial class GameScreen : UserControl
    {
        //Bool values for key presses
        Boolean BDown, MDown, NDown, escapeDown, spaceDown, upKeyDown, downKeydown, leftKeyDown, rightKeyDown;

        //creating graphic objects
        SolidBrush drawBrush = new SolidBrush(Color.White);
        Font drawFont = new Font("8bit Wonder", 10, FontStyle.Bold);
        Pen drawPen = new Pen(Color.White);
        Pen redPen = new Pen(Color.Red);

        //creating lists
        public List<LineSegment> moonLines = new List<LineSegment>();
        public List<LineSegment> landerLines = new List<LineSegment>();
        public List<LineSegment> landingAreas = new List<LineSegment>();
        public List<Image> landerAnimation = new List<Image>();

        public string explode, win;
        public double roundedX, roundedYspeed, roundedY;
        static public int fuelLost, crashed, score, scoreAdd, animate;

        Random fuelGen = new Random();
        Random scoreGen = new Random();

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
            //Setting up ints and Collision Lines
            int xLander = 400;
            int yLander = 100;
            int xSpeedLander = 1;
            int ySpeedLander = 1;
            int angleSpeedLander = 1;
            int angleLander = 90;
            int imageLander = 0;
            int widthLander = 45;
            int heightLander = 45;
            int fuel = 1000;

            lander = new Lander(xLander, yLander, xSpeedLander, ySpeedLander, angleLander, angleSpeedLander, imageLander, widthLander, heightLander, fuel);

            score = 0;

            landerAnimation.Add(Properties.Resources.landerboost1Final);
            landerAnimation.Add(Properties.Resources.landerboost2Final);
            landerAnimation.Add(Properties.Resources.landerboost3Final);
            landerAnimation.Add(Properties.Resources.landerboost4Final);
            landerAnimation.Add(Properties.Resources.landerboost5Final);


            #region Collision Lines
            LineSegment landerL1 = new LineSegment((int)lander.x, (int)lander.y, (int)lander.x, (int)lander.y + lander.height);
            LineSegment landerL2 = new LineSegment((int)lander.x + lander.width, (int)lander.y, (int)lander.x + lander.width, (int)lander.y + lander.height);
            LineSegment landerL3 = new LineSegment((int)lander.x, (int)lander.y + lander.height, (int)lander.x + lander.width, (int)lander.y + lander.height);

            landerLines.Add(landerL1);
            landerLines.Add(landerL2);
            landerLines.Add(landerL3);

            LineSegment moonL1 = new LineSegment(0, 0, 39, 231);
            LineSegment moonL2 = new LineSegment(39, 231, 140, 308);
            LineSegment moonL3 = new LineSegment(203, 308, 256, 491);
            LineSegment moonL4 = new LineSegment(256, 491, 306, 432);
            LineSegment moonL5 = new LineSegment(306, 432, 333, 500);
            LineSegment moonL6 = new LineSegment(333, 500, 371, 528);
            LineSegment moonL7 = new LineSegment(371, 528, 388, 627);
            LineSegment moonL8 = new LineSegment(473, 627, 506, 552);
            LineSegment moonL9 = new LineSegment(506, 552, 535, 607);
            LineSegment moonL10 = new LineSegment(535, 607, 578, 500);
            LineSegment moonL11 = new LineSegment(578, 500, 636, 615);
            LineSegment moonL12 = new LineSegment(732, 615, 790, 524);
            LineSegment moonL13 = new LineSegment(840, 524, 869, 426);
            LineSegment moonL14 = new LineSegment(869, 426, 980, 307);
            LineSegment moonL15 = new LineSegment(980, 307, 1080, 189);
            LineSegment moonL16 = new LineSegment(1080, 189, 1166, 324);
            LineSegment moonL17 = new LineSegment(1166, 324, 1271, 217);
            LineSegment moonL18 = new LineSegment(1271, 217, 1370, 0);

            LineSegment landingArea1= new LineSegment(140, 308, 203, 308); 
            LineSegment landingArea2= new LineSegment(388, 627, 473, 627); 
            LineSegment landingArea3 = new LineSegment(636, 615, 732, 615); 
            LineSegment landingArea4 = new LineSegment(790, 524, 827, 524);
            LineSegment landingArea5 = new LineSegment(1080, 189, 1059, 189);

            landingAreas.Add(landingArea1);
            landingAreas.Add(landingArea2);
            landingAreas.Add(landingArea3);
            landingAreas.Add(landingArea4);
            landingAreas.Add(landingArea5);

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
            #endregion
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upKeyDown = true;
                    break;
                case Keys.Down:
                    downKeydown = true;
                    break;
                case Keys.Left:
                    leftKeyDown = true;
                    break;
                case Keys.Right:
                    rightKeyDown = true;
                    break;
                case Keys.B:
                    BDown = true;
                    break;
                case Keys.M:
                    MDown = true;
                    break;
                case Keys.N:
                    NDown = true;
                    break;
                case Keys.Escape:
                    Form1.menu2Player.Play();
                    escapeDown = true;
                    pause();
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upKeyDown = false;
                    break;
                case Keys.Down:
                    downKeydown = false;
                    break;
                case Keys.Left:
                    leftKeyDown = false;
                    break;
                case Keys.Right:
                    rightKeyDown = false;
                    break;
                case Keys.B:
                    BDown = false;
                    break;
                case Keys.M:
                    MDown = false;
                    break;
                case Keys.N:
                    NDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                case Keys.Escape:
                    escapeDown = false;
                    break;
                default:
                    break;
            }
        }

        public void pause()
        {   //Code for pause screen
            gameTimer.Enabled = false;

            DialogResult result = pauseScreen.Show("Quit The Game?", "Yes", "No");

            switch (result)
            {
                case DialogResult.No:
                    gameTimer.Enabled = true;
                    escapeDown = false;
                    BDown = false;
                    MDown = false;
                    break;

                case DialogResult.Yes:
                    Mainscreen ms = new Mainscreen();
                    Form form = this.FindForm();
                    form.Controls.Add(ms);
                    form.Controls.Remove(this);

                    ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
                    break;
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (BDown == true)
            {
                lander.Turn("left");
            }

            if (MDown == true)
            {
                lander.Turn("right");
            }

            if (NDown == true)
            {
                Form1.boostPlayer.Play();
                animate = 1;

                if (lander.fuel  > 0)
                {
                    lander.Boost("engage");
                    lander.fuel--;
                }

                else
                {
                    Form1.boostPlayer.Stop();
                    animate = 0;
                }


                if (lander.ySpeed > 2.7)
                {
                    lander.ySpeed -= 0.5f;
                }
            }

            else
            {
                Form1.boostPlayer.Stop();
                animate = 0;

            }

            //Determines if you have crashed without any fuel left
            if (crashed == 1)
            {
                gameTimer.Stop();
                Form form = this.FindForm();

                if (form !=null)
                {
                    GameoverScreen gos = new GameoverScreen();
                    gos.Location = new Point((form.Width - gos.Width) / 2, (form.Height - gos.Height) / 2);
                    form.Controls.Add(gos);
                    form.Controls.Remove(this);
                    crashed = 0;
                    #region Updating Hitbox Position
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
#endregion
                }
            }

            #region Gravity
            lander.ySpeed += 0.05f;
            lander.xSpeed += 0.001f;
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

            //Checking hitbox of lander against the moon for intersections
            foreach (LineSegment l in landerLines)
            {
                foreach (LineSegment m in moonLines)
                {
                    didIntersect = Intersection.LineSegementsIntersect(l, m, true);

                    if (didIntersect == true)
                    {
                        fuelLost = fuelGen.Next(300, 400);
                        lander.fuel = lander.fuel - fuelLost;
                        gameTimer.Stop();
                        explode = "true";
                        gameTimer.Start();
                        this.Refresh();
                        Form1.boomPlayer.Play();
                        lander.x = 400;
                        lander.y = 100;
                        lander.angle = 90;
                        lander.ySpeed = 0.5;
                        lander.xSpeed = 1;
                        #region Updating Postions
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
                        #endregion

                        Thread.Sleep(2500);
                        fuelLost = 0;

                        if (lander.fuel <= 1)
                        {
                            crashed = 1;
                        }

                        explode = "false";
                    }
                    else
                    {
                        //Do nothing
                    }
                }
            }

            //Comparing hitbox against landing areas and determining if the lander has crashed or landed depending on the parameters set
            foreach (LineSegment l in landerLines)
            {
                foreach (LineSegment m in landingAreas)
                {
                    didIntersect = Intersection.LineSegementsIntersect(l, m, true);

                    if (didIntersect == true)
                    {
                        if (lander.ySpeed > 1.5)
                        {
                            fuelLost = fuelGen.Next(300, 400);
                            lander.fuel = lander.fuel - fuelLost;
                            gameTimer.Stop();
                            explode = "true";
                            gameTimer.Start();
                            this.Refresh();
                            Form1.boomPlayer.Play();
                            lander.x = 400;
                            lander.y = 100;
                            lander.angle = 90;
                            lander.ySpeed = 0.5;
                            lander.xSpeed = 1;

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

                            Thread.Sleep(2500);
                            fuelLost = 0;

                            if (lander.fuel <= 1)
                            {
                                crashed = 1;
                            }

                            explode = "false";
                        }

                        else if (lander.y < 1.5)
                        {
                            gameTimer.Stop();
                            win = "true";
                            gameTimer.Start();
                            this.Refresh();
                            Form1.winPlayer.Play();
                            lander.x = 400;
                            lander.y = 100;
                            lander.angle = 90;
                            lander.ySpeed = 0.5;
                            lander.xSpeed = 1;

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
                                
                            Thread.Sleep(2500);
                            win = "false";
                        }

                        else if (lander.angle > 92 && lander.angle < 88)
                        {
                            fuelLost = fuelGen.Next(300, 400);
                            lander.fuel = lander.fuel - fuelLost;
                            gameTimer.Stop();
                            explode = "true";
                            gameTimer.Start();
                            this.Refresh();
                            Form1.boomPlayer.Play();
                            lander.x = 400;
                            lander.y = 100;
                            lander.angle = 90;
                            lander.ySpeed = 0.5;
                            lander.xSpeed = 1;

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

                            Thread.Sleep(2500);
                            fuelLost = 0;

                            if (lander.fuel <= 1)
                            {
                                crashed = 1;
                            }

                            explode = "false";
                        }

                        else if (lander.angle <= 92 && lander.angle >= 88)
                        {
                            //Determines score by seeing where the lander's y is after the landing is complete. 

                            roundedY = Math.Round(lander.y, 0);

                            if (roundedY == 263 || roundedY == 264)
                            {
                                scoreAdd = scoreAdd + 100;
                                score = score + scoreAdd;
                                //scoreAdd = 0;

                            }

                            else if (roundedY == 583 || roundedY == 582)
                            {
                                scoreAdd = scoreAdd + 50;
                                score = score + scoreAdd;
                                //scoreAdd = 0;
                            }

                            else if (roundedY == 571 || roundedY == 570)
                            {
                                scoreAdd = scoreAdd + 50;
                                score = score + scoreAdd;
                                //scoreAdd = 0;
                            }

                            else if (roundedY == 479 || roundedY == 480)
                            {
                                scoreAdd = scoreAdd + 400;
                                score = score + scoreAdd;
                                //scoreAdd = 0;
                            }

                            else if (roundedY == 144 || roundedY == 145)
                            {
                                scoreAdd = scoreAdd + 150;
                                score = score + scoreAdd;
                                //scoreAdd = 0;
                            }

                            gameTimer.Stop();
                            win = "true";
                            Form1.winPlayer.Play();
                            gameTimer.Start();
                            this.Refresh();
                            lander.x = 400;
                            lander.y = 100;
                            lander.angle = 90;
                            lander.ySpeed = 0.5;
                            lander.xSpeed = 1;

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

                            Thread.Sleep(2500);
                            win = "false";
                            scoreAdd = 0;
                        }
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

            //Draw Moon's Surface LA = Landing Area
            e.Graphics.DrawLine(drawPen, 0, 0, 39, 231);
            e.Graphics.DrawLine(drawPen, 39, 231, 140, 308);
            e.Graphics.DrawLine(drawPen, 140, 308, 203, 308); //LA
            e.Graphics.DrawLine(drawPen, 203, 309, 256, 491);
            e.Graphics.DrawLine(drawPen, 256, 491, 306, 432);
            e.Graphics.DrawLine(drawPen, 306, 432, 333, 500);
            e.Graphics.DrawLine(drawPen, 333, 500, 371, 528);
            e.Graphics.DrawLine(drawPen, 371, 528, 388, 627);
            e.Graphics.DrawLine(drawPen, 388, 627, 473, 627); //LA
            e.Graphics.DrawLine(drawPen, 473, 627, 506, 552);
            e.Graphics.DrawLine(drawPen, 506, 552, 535, 607);
            e.Graphics.DrawLine(drawPen, 535, 607, 578, 500);
            e.Graphics.DrawLine(drawPen, 578, 500, 636, 615);
            e.Graphics.DrawLine(drawPen, 636, 615, 732, 615); //LA
            e.Graphics.DrawLine(drawPen, 732, 615, 790, 524);
            e.Graphics.DrawLine(drawPen, 790, 524, 840, 524); //LA
            e.Graphics.DrawLine(drawPen, 840, 524, 869, 426);
            e.Graphics.DrawLine(drawPen, 869, 426, 980, 307);
            e.Graphics.DrawLine(drawPen, 980, 307, 1025, 189);
            e.Graphics.DrawLine(drawPen, 1025, 189, 1080, 189); //LA
            e.Graphics.DrawLine(drawPen, 1080, 189, 1166, 324);
            e.Graphics.DrawLine(drawPen, 1166, 324, 1271, 217);
            e.Graphics.DrawLine(drawPen, 1271, 217, 1370, 0);

            ////Hit box Lines TESTING PURPOSES ONLY
            //e.Graphics.DrawLine(drawPen, landerLines[0].x1, landerLines[0].y1, landerLines[0].x2, landerLines[0].y2);
            //e.Graphics.DrawLine(drawPen, landerLines[1].x1, landerLines[1].y1, landerLines[1].x2, landerLines[1].y2);
            //e.Graphics.DrawLine(drawPen, landerLines[2].x1, landerLines[2].y1, landerLines[2].x2, landerLines[2].y2);


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
                if (animate == 1)
                {
                    foreach(Image i in landerAnimation)
                    {
                        e.Graphics.DrawImage(i, 0 - lander.width / 2, 0 - lander.width / 2, lander.width, lander.height);
                    }
                    
                }

                else
                {
                    e.Graphics.DrawImage(Properties.Resources.landerFinal2, 0 - lander.width / 2, 0 - lander.width / 2, lander.width, lander.height);
                }
            }

            //reset to original origin point
            e.Graphics.ResetTransform();

            roundedX = Math.Round(lander.xSpeed, 2);
            roundedYspeed = Math.Round(lander.ySpeed, 2);

            //Nessarcy because the tranformations by for the lander mess up the x and y coordinates for the message
            if (explode == "true")
            {
                e.Graphics.DrawString("You crashed and lost " + fuelLost + " fuel units." , drawFont, drawBrush, 500, 300);
            }

            if (win == "true")
            {
                e.Graphics.DrawString("You landed and received " + scoreAdd + " points.", drawFont, drawBrush, 500, 300); 
            }

            //UI Printing onto the screen
            e.Graphics.DrawString("Angle: " + lander.angle, drawFont, drawBrush, 1100, 10);
            e.Graphics.DrawString("Horizonal Speed: " + roundedX, drawFont, drawBrush, 1100, 40);
            e.Graphics.DrawString("Verical Speed: " + roundedYspeed, drawFont, drawBrush, 1100, 70);
            e.Graphics.DrawString("Fuel: " + lander.fuel, drawFont, drawBrush, 1100, 100);
            e.Graphics.DrawString("Score: " + score, drawFont, drawBrush, 50, 10);
        }
    }
}
