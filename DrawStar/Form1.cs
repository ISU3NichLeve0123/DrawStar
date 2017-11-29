using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x = Convert.ToSingle(xCoordianatTextBox.Text), y = Convert.ToSingle(yCoordinatieTextBox.Text);
            float size =Convert.ToSingle(sizeTextBox.Text);         
            Pen pen = new Pen(Color.Black, 1);
            DrawStar(pen, x, y,size);
        }
        public void DrawStar(Pen pen, float x, float y, float size)
        {
            float sF = size/174;
            Graphics fg = this.CreateGraphics();
            fg.Clear(Color.White);
            
           // fg.DrawRectangle(pen, x, y, 174* sF, 163*sF);
            fg.DrawLine(pen,88*sF +x, 0* sF + y, 110 * sF + x, 63 * sF + y);// from point 0 to point 1
            fg.DrawLine(pen, 110 * sF + x, 63 * sF + y, 174 * sF + x, 64 * sF + y);//from point 1 to point 2
            fg.DrawLine(pen, 174 * sF + x, 64 * sF + y, 122 * sF + x, 103 * sF + y);//from point 2 to point 3
            fg.DrawLine(pen, 122 * sF + x, 103 * sF + y, 145 * sF + x , 163 * sF + y);//from point 3 to point 4
            fg.DrawLine(pen, 145 * sF + x, 163 * sF + y, 88 * sF + x, 128 * sF + y);//from point 4 to point 5
            fg.DrawLine(pen, 88 * sF + x, 128 * sF + y, 33 * sF + x, 163 * sF + y);//from point 5 to point 6
            fg.DrawLine(pen, 33 * sF + x, 163 * sF + y, 54 * sF + x, 104 * sF + y);//from point 6 to point 7
            fg.DrawLine(pen, 54 * sF + x, 104 * sF + y, 0 * sF + x, 66 * sF + y);//from point 7 to point 8
            fg.DrawLine(pen, 0 * sF + x, 66 * sF + y, 67 * sF + x, 63 * sF + y);//from point 8 to point 9
            fg.DrawLine(pen, 67 * sF + x, 63 * sF + y, 88 * sF + x, 0 * sF + y);//from point 9 to point 0
            
        }
    }
}
