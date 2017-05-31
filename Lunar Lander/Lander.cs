using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunar_Lander
{
    class Lander
    {
        public int x, y, xSpeed, ySpeed, angle, angleSpeed, image, width, height;

        public Lander (int _x, int _y, int _xSpeed, int _ySpeed, int _angle, int _angleSpeed, int _image, int _width, int _height)
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
                if (angle == 0)
                {
                    y = y - 5;
                }

                if (angle <= 10 && angle != 0)
                {
                    y = y - 5;
                    x = x + 1;
                }  
            }
        }
    }
}