using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunar_Lander
{
    class Lander
    {
        public int angle, angleSpeed, image, width, height;
        public double x, y, xSpeed, ySpeed, speedMulti;

        public Lander (double _x, double _y, double _xSpeed, double _ySpeed, double _speedMulti, int _angle, int _angleSpeed, int _image, int _width, int _height)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            speedMulti = _speedMulti;
            angle = _angle;
            angleSpeed = _angleSpeed;
            image = _image;
            width = _width;
            height = _height;
        }

        public void Turn (string direction)
        {
            if (direction == "left")
            {

                if (angle >= 3)
                {
                    angle -= angleSpeed;
                }
            }

           else if (direction == "right")
            {
                if (angle <= 177)
                {
                    angle += angleSpeed;
                }
            }
        }

        public void Boost (string engage)
        {

            if (angle == 90 && ySpeed >= -5.7)
            {
                ySpeed -= 0.1f;
            }

           if (angle == 0 && xSpeed <= 4.9)
            {
                xSpeed += 0.02f;
            }

           if (angle == 180 && xSpeed >= -5)
            {
                xSpeed -= 0.02f;
            }

            if (angle > 0 && angle <= 10)
            {
                xSpeed += 0.02f;
            }

            if (angle >= 10 && angle <= 20)
            {
                xSpeed += 0.02f;
            }

            //if (angle >= 20 && angle <= 30)
            //{
            //    ySpeed = 1.5;
            //    y = y - ySpeed;
            //    x = x - xSpeed;
            //}

            //if (angle >= 30 && angle <= 40)
            //{
            //    ySpeed = 2;
            //    y = y - ySpeed;
            //    x = x - xSpeed;
            //}

            //if (angle >= 40 && angle <= 50)
            //{
            //    ySpeed = 2.5;
            //    y = y - ySpeed;
            //    x = x - xSpeed;
            //}

            //if (angle >= 50 && angle <= 60)
            //{
            //    ySpeed = 3;
            //    y = y - ySpeed;
            //    x = x - xSpeed;
            //}

            //if (angle >= 60 && angle <= 70)
            //{
            //    ySpeed = 3.5;
            //    y = y - ySpeed;
            //    x = x - xSpeed;
            //}

            //if (angle >= 70 && angle <= 80)
            //{
            //    ySpeed = 4;
            //    y = y - ySpeed;
            //    x = x - xSpeed;
            //}

            //if (angle >= 80 && angle <= 89)
            //{
            //    ySpeed = 4.5;
            //    y = y - ySpeed;
            //    x = x - xSpeed;
            //}

            //if (angle >= 91 && angle <= 100)
            //{
            //    ySpeed = 4.5;
            //    y = y - ySpeed;
            //    x = x + xSpeed;
            //}

            //if (angle >= 100 && angle <= 110)
            //{
            //    ySpeed = 4;
            //    y = y - ySpeed;
            //    x = x + xSpeed;
            //}

            //if (angle >= 110 && angle <= 120)
            //{
            //    ySpeed = 3.5;
            //    y = y - ySpeed;
            //    x = x + xSpeed;
            //}

            //if (angle >= 120 && angle <= 130)
            //{
            //    ySpeed = 3;
            //    y = y - ySpeed;
            //    x = x + xSpeed;
            //}

            //if (angle >= 130 && angle <= 140)
            //{
            //    ySpeed = 2.5;
            //    y = y - ySpeed;
            //    x = x + xSpeed;
            //}

            //if (angle >= 140 && angle <= 150)
            //{
            //    ySpeed = 2;
            //    y = y - ySpeed;
            //    x = x + xSpeed;
            //}

            //if (angle >= 150 && angle <= 160)
            //{
            //    ySpeed = 1.5;
            //    y = y - ySpeed;
            //    x = x + xSpeed;
            //}

            //if (angle >= 160 && angle <= 170)
            //{
            //    ySpeed = 1;
            //    y = y - ySpeed;
            //    x = x + xSpeed;
            //}

            //if (angle >= 170 && angle <= 179)
            //{
            //    ySpeed = 0.5;
            //    y = y - ySpeed;
            //    x = x + xSpeed;
            //}
        }
    }
    }
