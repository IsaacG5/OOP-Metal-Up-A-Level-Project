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
        public abstract void Draw(Graphics g);
        public abstract void GrowTo(int x2, int y2);
    }
}
