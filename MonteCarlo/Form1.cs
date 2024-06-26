using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace MonteCarlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Graphics graphics { get; set; }
        public ConcurrentBag<int[]> Dots = new ConcurrentBag<int[]>();
        private void button1_Click(object sender, EventArgs e)
        {
            image.Image = null;
            image.Image = new Bitmap(image.Width, image.Height);
            graphics = Graphics.FromImage(image.Image);
            Dots.Clear();

            double a = Convert.ToDouble(inputA.Text);
            double b = Convert.ToDouble(inputB.Text);
            long n = Convert.ToInt64(inputN.Text);
            output.Text = MonteCarloMethod(a, b, n).ToString();
            Draw();
            image.Refresh();
        }

        private double MonteCarloMethod(double a, double b, long limit)
        {
            double count = 0;
            double w = b - a;
            double h = Math.Sinh(b) - Math.Sinh(a);
            Parallel.For(0, limit, (i) =>
            {
                double one = ConcurrentRandom.Instance.NextDouble() * w;
                double two = ConcurrentRandom.Instance.NextDouble() * h;

                double x = b - one;
                double y = Math.Sinh(b) - two;
                double value = Math.Sinh(x);
                //y < value => count++
                Dots.Add(new int[] { Convert.ToInt32(((w - one) / w) * image.Width), image.Height - Convert.ToInt32(((h - two) / h) * image.Height), y <= value ? 1 : 0});
            });
            count = Dots.Where(item => item[2] == 1).Count();
            return Math.Round((w * h) * (count / limit), 3);
        }

        private void Draw()
        {
            foreach(var item in Dots.Where(x => x != null))
                graphics.FillRectangle(item[2] == 1 ? Brushes.Indigo : Brushes.LightGreen, item[0], item[1], 1, 1);
        }

        private void output_Click(object sender, EventArgs e)
        {

        }
    }
    public static class ConcurrentRandom
    {
        [ThreadStatic]
        private static Random? _local;

        public static Random Instance => _local ??= new Random();
    }
}



//using (var g = Graphics.FromImage(image.Image))
//{
//    g.FillRectangle(Brushes.Red, Convert.ToInt32(((w - (one * w)) / w) * image.Width), Convert.ToInt32((((h - ((value / Math.Sinh(b)) * h)) / h) * image.Height)), 3, 3);
//    image.Refresh();
//}