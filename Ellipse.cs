﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Metal_Up_A_Level_Project
{
    public class Ellipse : Shape
    {
        public Ellipse(Pen p, int x1, int y1) : base(p, x1, y1)
        {
        }

        public Ellipse(Pen p, int x1, int y1, int x2, int y2) : base(p, x1, y1, x2, y2)
        {
        }

        public override void Draw(Graphics g)
        {
            int x = Math.Min(X1, X2);
            int y = Math.Min(Y1, Y2);
            int w = Math.Max(X1, X2) - x; int h = Math.Max(Y1, Y2) - y;
            if (w > 0 && h > 0)
            {
                g.DrawArc(Pen, x, y, w, h, 0F, 360F);
            }
        }
    }
}