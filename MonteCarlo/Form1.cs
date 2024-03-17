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

        private void button1_Click(object sender, EventArgs e)
        {

                double a = Convert.ToDouble(inputA.Text);
                double b = Convert.ToDouble(inputB.Text);
                long n = Convert.ToInt64(inputN.Text);

                output.Text = MonteCarloMethod(a, b, n).ToString();
        }

        private double MonteCarloMethod(double a, double b, long limit)
        {
            ConcurrentBag<int[]> Default = new ConcurrentBag<int[]>();
            List<int[]> Values = new List<int[]>();
            List<int[]> Dots = new List<int[]>();

            double count = 0;

            double w = b - a;
            double h = Math.Sinh(b) - Math.Sinh(a);


            image.Image = null;
            image.Image = new Bitmap(image.Width, image.Height);


            for (double i = 0; i < limit; i++)
            {
                var one = ConcurrentRandom.Instance.NextDouble();
                var two = ConcurrentRandom.Instance.NextDouble();

                var x = b - (one * w);//a - b -> 0 - 1
                var y = Math.Sinh(b) - (two * h);//Sinh(a) - Sinh(b)
                var value = Math.Sinh(x);
                if (y <= value)
                {
                    count++;
                    using (var g = Graphics.FromImage(image.Image))
                    {
                        g.FillRectangle(Brushes.Indigo, Convert.ToInt32(((w - (one * w))/w) * image.Width), image.Height - Convert.ToInt32(((h - (two * h)) / h) * image.Height), 3, 3);
                        image.Refresh();
                    }
                }
                else
                {
                    using (var g = Graphics.FromImage(image.Image))
                    {
                        g.FillRectangle(Brushes.Green, Convert.ToInt32(((w - (one * w)) / w) * image.Width), image.Height - Convert.ToInt32(((h - (two * h)) / h) * image.Height), 3, 3);
                        image.Refresh();
                    }
                }
                using (var g = Graphics.FromImage(image.Image))
                {
                    g.FillRectangle(Brushes.Red, Convert.ToInt32(((w - (one * w)) / w) * image.Width), Convert.ToInt32(((h - ((value / Math.Sinh(b)) * h)) / h) * image.Height) / 2, 3, 3);
                    image.Refresh();
                }

            }
            return ((w * h) * (count / Convert.ToDouble(limit)));
        }

    }
    public static class ConcurrentRandom
    {
        [ThreadStatic]
        private static Random? _local;

        public static Random Instance => _local ??= new Random();
    }
}


//for (double i = -5; i < 5; i += 0.01)
//{
//    var x = Convert.ToInt32((image.Width / 2) + i * (image.Width) / 5);
//    var y = Convert.ToInt32((image.Height / 2) - Math.Sinh(i) * (image.Height) / 5);
//    using (var g = Graphics.FromImage(image.Image))
//    {
//        g.FillRectangle(Brushes.White, x, image.Height / 2, 2, 2);
//        g.FillRectangle(Brushes.White, image.Width / 2, y, 2, 2);
//        g.FillRectangle(Brushes.Red, x, y, 3, 3);//drawing point 
//        image.Refresh();
//    }
//}

//else
//{
//    using (var g = Graphics.FromImage(image.Image))
//    {
//        g.FillRectangle(Brushes.Green, Convert.ToInt32((image.Width / 2) + x * (image.Width) / (b - a) / 5), Convert.ToInt32((image.Height / 2) - y * (image.Height) / (b - a) / 5), 2, 2);
//        image.Refresh();
//    }
//}