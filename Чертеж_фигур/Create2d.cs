using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Чертеж_фигур
{
    public partial class Create2d : Form
    {
        Pen pen = new Pen(Color.CadetBlue, 3);
        Point point0 = new Point(0, 0);

        public Create2d()
        {
            InitializeComponent();

            point0.X = pictureBox1.Width / 2;
            point0.Y = pictureBox1.Height / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtLine1.Text.Equals("")|| txtLine2.Text.Equals("")|| txtLine3.Text.Equals("")|| txtLine4.Text.Equals(""))
                {
                    MessageBox.Show("Заполните все поля");
                }

            int lin1 = Convert.ToInt32(txtLine1.Text);
            int lin2 = Convert.ToInt32(txtLine2.Text);
            int lin3 = Convert.ToInt32(txtLine3.Text);
            int lin4 = Convert.ToInt32(txtLine4.Text);
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.DrawLine(pen, lin1, lin2, lin3, lin4);
            graphics.Dispose();

            }
            catch 
            {
            }
            finally
            {
                ClearTxt();
            }
        }


       private void SizeFigure()
        {
            int a;
        }

        private void btnCleare_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void SelectColor()
        {
            switch (cmbSelectColor.SelectedIndex)
            {
                case 0:
                  Pen pen = new Pen(Color.Black);
                    break;
                case 1:
                    new Pen(Color.Yellow);
                    break;
            }
            
        }

        private void ClearTxt()
        {
            txtLine1.Clear();
            txtLine2.Clear();
            txtLine3.Clear();
            txtLine4.Clear();

        }

        private void btn3d_Click(object sender, EventArgs e)
        {
            Watch3d watch3 = new Watch3d();
            watch3.Show();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                point0.X = e.X;
                point0.Y = e.Y;
            }
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            Triangles triangles = new Triangles();
            triangles.Triangle();
        }

       

        public void JsonFiled()
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Graphics> grs = new List<Graphics>();
          //  grs.Add();
        }

        public class Triangles :Dot2d
        {
            Random r = new Random();
           public void Triangle()
            {
                _x = r.Next(0);
                _y = r.Next(0);
            for(int i = 0; i<100; i++)
                {
                    new Pen(Color.Black, 3);
                }
            }
        }

        private void btnRectangle_Click(object sender, EventArgs e, PaintEventArgs s)

            {
                Pen myPen = new Pen(Color.Black, 2);
                Rectangle[] myRectsArray =
                {
              new Rectangle(10, 10, 200, 200)
            };
                Graphics g = s.Graphics;
                g.Clear(Color.White);
                g.DrawRectangles(myPen, myRectsArray);
            }

     /*   public class Rectangles : Dot2d 
        {
            Rectang rec = new Rectang();
            public void Rectangled(int A, )
            {
                Pen myPen = new Pen(Color.Black, 2);
                Rectangle[] myRectsArray =
                {
              new Rectangle(10, 10, 200, 200)
            };
                Graphics g = s.Graphics;
                g.Clear(Color.White);
                g.DrawRectangles(myPen, myRectsArray);*/
            }
        }

