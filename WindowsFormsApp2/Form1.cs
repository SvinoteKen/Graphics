using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(Pens.Red, 10, 5, 110, 15);
            g.DrawEllipse(Pens.Blue, 10, 20, 110, 45);
            g.DrawRectangle(Pens.Green, 10, 70, 110, 45);
            g.FillEllipse(Brushes.Blue, 130, 20, 110, 45);
            g.FillRectangle(Brushes.Green, 130, 70, 110, 45);
            base.OnPaint(e);
        }
    }
}
