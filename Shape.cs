using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Metal_Up_A_Level_Project
{
    public abstract class Shape
    {
        protected Pen Pen
        {
            get;
            private set;
        }

        protected int X1
        {
            get;
            private set;
        }

        protected int X2
        {
            get;
            private set;
        }

        protected int Y1
        {
            get;
            private set;
        }

        protected int Y2
        {
            get;
            private set;
        }
        public abstract void Draw(Graphics g);

        public void GrowTo1(int x2, int y2)
        {
            X2 = x2; Y2 = y2;
        }
    }
}
