using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using Lines;

namespace Lunar_Lander
{
    class Lander
    {
        public int angle, angleSpeed, image, width, height;
        public double x, y, xSpeed, ySpeed;

        public Lander (double _x, double _y, double _xSpeed, double _ySpeed, int _angle, int _angleSpeed, int _image, int _width, int _height)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
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

        public void Collide (Boolean didIntersect)
        {

        }

        public void Boost (string engage)
        {

            if (angle == 90 && ySpeed >= -5.7)
            {
                ySpeed -= 0.25f;
            }

           if (angle == 0 && xSpeed <= 4.9)
            {
                xSpeed -= 0.02f;
            }

           if (angle == 180 && xSpeed >= -5)
            {
                xSpeed += 0.04f;
            }

            if (angle >= 0 && angle <= 10)
            {
                xSpeed -= 0.04f;
            }

            if (angle >= 10 && angle <= 20)
            {
                xSpeed -= 0.04f;
            }

            if (angle >= 20 && angle <= 30)
            {
                xSpeed -= 0.04f;
                ySpeed -= 0.05;
            }

            if (angle >= 30 && angle <= 40)
            {
                xSpeed -= 0.04f;
                ySpeed -= 0.10;
            }

            if (angle >= 40 && angle <= 50)
            {
                xSpeed -= 0.02f;
                ySpeed -= 0.15;
            }

            if (angle >= 50 && angle <= 60)
            {
                xSpeed -= 0.02f;
                ySpeed -= 0.15;
            }

            if (angle >= 60 && angle <= 70)
            {
                xSpeed -= 0.02f;
                ySpeed -= 0.20;
            }

            if (angle >= 70 && angle <= 80)
            {
                xSpeed -= 0.01f;
                ySpeed -= 0.20;
            }

            if (angle >= 80 && angle <= 89)
            {
                xSpeed -= 0.01f;
                ySpeed -= 0.25;
            }

            if (angle >= 91 && angle <= 100)
            {
                xSpeed += 0.01f;
                ySpeed -= 0.25;
            }

            if (angle >= 100 && angle <= 110)
            {
                xSpeed += 0.01f;
                ySpeed -= 0.20;
            }

            if (angle >= 110 && angle <= 120)
            {
                xSpeed += 0.01f;
                ySpeed -= 0.20;
            }

            if (angle >= 120 && angle <= 130)
            {
                xSpeed += 0.02f;
                ySpeed -= 0.15;
            }

            if (angle >= 130 && angle <= 140)
            {
                xSpeed += 0.02f;
                ySpeed -= 0.15;
            }

            if (angle >= 140 && angle <= 150)
            {
                xSpeed += 0.04f;
                ySpeed -= 0.10;
            }

            if (angle >= 150 && angle <= 160)
            {
                xSpeed += 0.04f;
                ySpeed -= 0.05;
            }

            if (angle >= 160 && angle <= 170)
            {
                xSpeed += 0.04f;
            }

            if (angle >= 170 && angle <= 179)
            {
                xSpeed += 0.04f;
            }
        }
    }
    }
