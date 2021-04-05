using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Чертеж_фигур
{
    public partial class Watch3d : Form
    {
        double angleX;
        double angleY;

        TrackBar tbSize;

        List<Dot3d> dot3s = new List<Dot3d>();
        Point point0 = new Point (0,0);

        Pen pen = new Pen(Color.DarkRed);

        int tmp_X;
        int tmp_Y;

        public Watch3d()
        {
            InitializeComponent();

            point0.X = pictureBox1.Width / 2;
            point0.Y = pictureBox1.Height / 2;

            angleX = 1.0;
            angleY = 1.0;

          //  label1.Text = String.Format("Текущее значение: {0}", angleX.ToString());
           trackBarX.Value = 100;
            trackBarY.Value = 100;

            tbSize = new TrackBar { Parent = this, Maximum = 200, Left = 0, Value = 10 }; // подгонка трэкбара по прараметрам типизации размера

            tbSize.ValueChanged += tbValueChanged;
            tbValueChanged(null, EventArgs.Empty);
            
        }
        void tbValueChanged(object sender, EventArgs e)
        {
            float scale = 10;
            scale = tbSize.Value;

        }

        private Point Parse3d(Dot3d dot)
        {
            double res_X = -dot._z * Math.Sin(angleX) + dot._x * Math.Cos(angleX) + point0.X;
            double res_Y = -(dot._z * Math.Cos(angleY)) + dot._x * Math.Sin(angleY) + dot._y * Math.Cos(angleY) + point0.Y;
            return new Point((int)(res_X), (int)(res_Y));
        }

        void Draw(List<Dot3d> dot)
        {
            if (dot3s.Count <= 0)
                return;

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bmp);

            for(int i=0; i<dot.Count - 1; i++)
            {
                graphics.DrawLine(pen, Parse3d(dot[i]), Parse3d(dot[i + 1]));
            }
            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
            GC.Collect();
        }

        #region Фигуры
        private void Prism() // фигура тетраэдора
        {
            if (dot3s != null)
                dot3s.Clear();

            dot3s.Add(new Dot3d(0,0,0));
            dot3s.Add(new Dot3d(300, 0, 0));
            dot3s.Add(new Dot3d(0, 300, 0));
            dot3s.Add(new Dot3d(0, 0, 300));
            dot3s.Add(new Dot3d(300, 0, 0));
            dot3s.Add(new Dot3d(0, 0, 0));
            dot3s.Add(new Dot3d(0, 0, 300));
            dot3s.Add(new Dot3d(0, 300, 0));
            dot3s.Add(new Dot3d(0, 0, 0));
        }

        private void Circle() // фигура сферы
        {
            if (dot3s != null)
                dot3s.Clear();
            for(double i=0.0; i<= 6.41; i += 0.1)
            {
                for (double j = 0.00; j <= 13.2; j += 0.2)
                    dot3s.Add(new Dot3d((int)(200 * Math.Sin(i) * Math.Sin(j)), (int)(200 * Math.Sin(i) * Math.Cos(j)), (int)(200 * Math.Cos(i))));
            }

        }

        private void Shell() // фигура ракушки
        {
            if (dot3s != null)
                dot3s.Clear();

             for (double i = 0.0; i <= 1.0; i += 0.1)
             {
                for (double j = 0.00; j <= 13.2; j += 0.2)
                    dot3s.Add(new Dot3d((int)(200 * Math.Sin(i) * Math.Sin(j)), (int)(200 * Math.Sin(i) * Math.Cos(j)), (int)(200 * Math.Cos(i))));
             }
        }

        private void Cube()
        {
            // очистим если есть
            if (dot3s != null)
                dot3s.Clear();

            // заполним
            dot3s.Add(new Dot3d(0, 0, 0));
            dot3s.Add(new Dot3d(200, 0, 0));
            dot3s.Add(new Dot3d(200, 0, 200));
            dot3s.Add(new Dot3d(0, 0, 200));
            dot3s.Add(new Dot3d(0, 200, 200));
            dot3s.Add(new Dot3d(0, 200, 0));
            dot3s.Add(new Dot3d(0, 0, 200));
            dot3s.Add(new Dot3d(0, 0, 0));
            dot3s.Add(new Dot3d(0, 200, 0));
            dot3s.Add(new Dot3d(200, 200, 0));
            dot3s.Add(new Dot3d(200, 200, 200));
            dot3s.Add(new Dot3d(200, 0, 200));
            dot3s.Add(new Dot3d(200, 0, 0));
            dot3s.Add(new Dot3d(200, 200, 0));
            dot3s.Add(new Dot3d(0, 200, 0));
            dot3s.Add(new Dot3d(0, 200, 200));
            dot3s.Add(new Dot3d(200, 200, 200));
            dot3s.Add(new Dot3d(200, 200, 200));
        }

        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // выбор фигуры для загрузки
        {
            switch (cmbFigurs.SelectedIndex)
            {
                case 0: Prism();
                    Draw(dot3s);
                    break;
                case 1: Circle();
                    Draw(dot3s);
                    break;
                case 2: Cube();
                    Draw(dot3s);
                    break;
                case 3: Shell();
                    Draw(dot3s);
                    break;
            }
        }

        #region Работа с Trackbar (Оси)
        private void trackBarX_Scroll(object sender, EventArgs e)
        {
            lbX.Text = angleX.ToString();
            angleX = (double)(trackBarX.Value) / 100;
            Draw(dot3s);
        }


        private void trackBarY_Scroll(object sender, EventArgs e)
        {
            lbY.Text = angleY.ToString();
            angleY = (double)(trackBarY.Value) / 100;
            Draw(dot3s);
        }
        #endregion

        public void DrawModel()
        {
         //   Matrix[] transforms = new Matrix[];
        }
    }
}
