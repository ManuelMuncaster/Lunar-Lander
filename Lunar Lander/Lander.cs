using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunar_Lander
{
    class Lander
    {
        public int x, y, xSpeed, ySpeed, angle, image, width, height;

        public Lander (int _x, int _y, int _xSpeed, int _ySpeed, int _angle, int _image, int _width, int _height)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            angle = _angle;
            image = _image;
            width = _width;
            height = _height;
        }

        public void Turn (string direction)
        {
            if (direction == "left")
            {
                angle -= xSpeed;
                angle -= ySpeed;
            }

            if (direction == "right")
            {
                angle += xSpeed;
                angle += ySpeed;
            }
        }
    }
}
