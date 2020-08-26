using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spiral
{
    public partial class Form1 : Form
    {
        private readonly double ROOT2 = Math.Sqrt(2);
        Pen p = new Pen(new SolidBrush(Color.Black), 20F);

        Graphics g;
        Bitmap bmp;

        int horzResolution = 1000;
        int vertResolution = 1000;

        float thickness = 0.1F;
        float minThickness = 1F;
        float maxThickness = 100F;

        Color color = Color.Black;

        public Form1()
        {
            InitializeComponent();
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            this.horzResolution = (int)nud_HorzSize.Value;
            this.vertResolution = (int)nud_VertSize.Value;
            this.thickness = (float)nud_LineThickness.Value;
            this.minThickness = (float)nud_MinThickness.Value;
            this.maxThickness = (float)nud_MaxThickness.Value;
        }

        private void drawSpiral()
        {
            double r = 1;

            int maxDim;
            if (bmp.Height < bmp.Width)
            {
                maxDim = bmp.Width;
            }
            else
            {
                maxDim = bmp.Height;
            }

            while (r < maxDim)
            {
                r = rotate(r, bmp.Width/2, bmp.Height/2, this.g);
            }
        }
        private void setPenWidth(double r)
        {
            float d = ((float)r) * thickness;

            if (d < minThickness)
            {
                Debug.WriteLine("Miniumum thickness");
                p.Width = minThickness;
            }
            else if (d > maxThickness)
            {
                Debug.WriteLine("Maximum thickness");
                p.Width = maxThickness;
            }
            else
            {
                Debug.WriteLine("Dynamic thickness");
                p.Width = d;
            }
        }
        private double rotate(double rIn, int xOffset, int yOffset, Graphics g)
        {
            p.Color = color;

            double r = rIn;

            int x = 0;
            int y = 0;

            int oldX = 0;
            int oldY = (int)r;

            double rIncreace = 0.06;
            for (; x < (int)r; ++x)
            {
                y = (int)Math.Sqrt(r * r - x * x);

                setPenWidth(r);
                g.DrawLine(p, oldX + xOffset, oldY + yOffset,
                    x + xOffset, y + yOffset);

                oldX = x;
                oldY = y;

                r += rIncreace;
            }
            for (; x > 0; --x)
            {
                y = -(int)Math.Sqrt(r * r - x * x);

                setPenWidth(r);
                g.DrawLine(p, oldX + xOffset, oldY + yOffset,
                    x + xOffset, y + yOffset);

                oldX = x;
                oldY = y;

                r += rIncreace;
            }
            for (; x > -(int)r; --x)
            {
                y = -(int)Math.Sqrt(r * r - x * x);

                setPenWidth(r);
                g.DrawLine(p, oldX + xOffset, oldY + yOffset,
                    x + xOffset, y + yOffset);

                oldX = x;
                oldY = y;

                r += rIncreace;
            }
            for (; x < 0; ++x)
            {
                y = (int)Math.Sqrt(r * r - x * x);

                setPenWidth(r);
                g.DrawLine(p, oldX + xOffset, oldY + yOffset,
                    x + xOffset, y + yOffset);

                oldX = x;
                oldY = y;

                r += rIncreace;
            }

            return r;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            loadingDialog ld = new loadingDialog();

            this.Enabled = false;
            ld.Show();

            bmp = new Bitmap(horzResolution, vertResolution);
            g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            drawSpiral();

            bmp.MakeTransparent(Color.White);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "(*.png)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }

            sfd.Dispose();


            ld.Close();

            ld.Dispose();
            this.Enabled = true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            
            if (cd.ShowDialog() == DialogResult.OK)
            {
                color = cd.Color;
                pictureBox1.BackColor = color;
            }
            cd.Dispose();
        }

        private void Nud_HorzSize_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            this.horzResolution = (int)nud.Value;
        }

        private void Nud_VertSize_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            this.vertResolution = (int)nud.Value;
        }

        private void Nud_MinThickness_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            this.minThickness = (float)nud.Value;
        }

        private void Nud_MaxThickness_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            this.maxThickness = (float)nud.Value;
        }

        private void Nud_LineThickness_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            this.thickness = (float)nud.Value;
        }
    }
}
