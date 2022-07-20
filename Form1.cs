﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Metal_Up_A_Level_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        Pen currentPen = new Pen(Color.Black);
        bool dragging = false;
        Point startOfDrag = Point.Empty;
        Point lastMousePosition = Point.Empty;
        List<Line> lines = new List<Line>();

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            foreach (Line line in lines)
            { 
                line.Draw(gr);
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startOfDrag = lastMousePosition = e.Location;
            lines.Add(new Line(currentPen, e.X, e.Y));
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Line currentLine = lines.Last();
                currentLine.GrowTo(e.X, e.Y);
                lastMousePosition = e.Location;
                Refresh(); 
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
