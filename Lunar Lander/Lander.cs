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
                if (angle <= 180)
                {
                    angle += angleSpeed;
                }
            }
        }

        public void Boost (string engage)
        {

            if (engage == "on")
            {
                if (angle == 90)
                {
                    y = y - 5;
                }

                if (angle == 2)
                {
                    x = x - 5;
                } 
                
                if (angle > 2 && angle <= 10)
                {
                    y = y - 0.2;
                    x = x - 4.8;
                }
                
                if (angle >= 10 && angle <= 20)
                {
                    y = y - 0.4;
                    x = x - 4.6;
                }

                if (angle >= 20 && angle <= 30)
                {
                    y = y - 0.6;
                    x = x - 4.4;
                }

                if (angle >= 30 && angle <= 40)
                {
                    y = y - 0.8;
                    x = x - 4.2;
                }
            }
        }
    }
}