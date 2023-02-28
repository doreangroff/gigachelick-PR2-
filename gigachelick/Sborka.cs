using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gigachelick
{
    internal class Head
    {
        private int _x;
        
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        private int _y;
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        private int _r;
        public int R
        {
            get { return _r; }
            set { _r = value; }
        }
        public Head(int x, int y, int r)
        {
            _x = x; _y = y; r = R;
        }

    }
    internal class Body
    {
        private int _x;
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        private int _y;
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        private int _height;
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        private int _lenght;
        public int Lenght
        {
            get { return _lenght; }
            set { _lenght = value; }
        }
        public Body(int x, int y, int height, int lenght)
        {
            _x=x; _y=y; _height = height; _lenght = lenght;
        }
    }
    internal class Hands
    {
        private int _l;
        public int L
        {
            get { return _l; }
            set { _l = value; }
        }
        private int _angle;
        public int Angle
        {
            get { return _angle; }
            set { _angle = value; }
        }
        public Hands(int l, int angle)
        {
            this._l = l ; _angle = angle;
        }
    }
    internal class Legs
    {
        private int _l;
        public int L
        {
            get { return _l; }
            set { _l = value; }
        }
        private int _angle;
        public int Angle
        {
            get { return _angle; }
            set { _angle = value; }
        }
        public Legs(int l, int angle)
        {
            this._l=l ; _angle = angle;
        }
    }
}
