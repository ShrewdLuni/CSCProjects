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

            try
            {
                double a = Convert.ToDouble(inputA.Text);
                double b = Convert.ToDouble(inputB.Text);
                long n = Convert.ToInt64(inputN.Text);

                output.Text = MonteCarloMethod(a, b, n).ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private double MonteCarloMethod(double a, double b, long limit)
        {
            ConcurrentBag<int[]> Default = new ConcurrentBag<int[]>();
            List<int[]> Values = new List<int[]>();
            List<int[]> Dots = new List<int[]>();

            int count = 0;
            double w = b - a;
            double h = Math.Sinh(b) - Math.Sinh(a);
            for (int i = 0; i < limit + 1; i++)
            {
                double x = ConcurrentRandom.Instance.NextDouble();
                double y = ConcurrentRandom.Instance.NextDouble();

                y = b - (y * w);
                x = x * ConcurrentRandom.Instance.Next(Convert.ToInt32(a), Convert.ToInt32(b));
                double value = Math.Sinh(x);
                bool check = x <= value;
                if (check)
                    count++;

                //Dots.Add(new int[] { Convert.ToInt32(x * Convert.ToDouble(image.Height)), Convert.ToInt32(y * Convert.ToDouble(image.Width)), check ? 1 : 0 });
                Values.Add(new int[] { Convert.ToInt32(x * Convert.ToDouble(image.Height)), Convert.ToInt32(value * Convert.ToDouble(image.Width))});
            }
            label1.Text = $"{Math.Sinh(-2)}\n{Math.Sinh(-1)}\n{Math.Sinh(0)}\n{Math.Sinh(1)}\n{Math.Sinh(2)}";
            VisualizeMonteCarlo(Values, Dots, Default);
            return Math.Round(w * h * (count / Convert.ToDouble(limit)),4);
        }

        private void VisualizeMonteCarlo(List<int[]> Values, List<int[]> Dots, ConcurrentBag<int[]> Default)
        {
            image.Image = null;
            image.Image = new Bitmap(image.Width, image.Height);

            var values = Brushes.White;
            var inside = Brushes.Green;
            var outside = Brushes.Indigo;

            foreach (var item in Default)
            {
                if (item == null)
                    continue;
                using (var g = Graphics.FromImage(image.Image))
                {
                    g.FillRectangle(Brushes.Red, item[0], item[1], 3, 3);//drawing point 
                    image.Refresh();
                }
            }

            foreach (var item in Values)
            {
                if (item == null)
                    continue;
                using (var g = Graphics.FromImage(image.Image))
                {
                    g.FillRectangle(values, item[0], item[1], 1, 1);//drawing point 
                    image.Refresh();
                }
            }
            foreach (var item in Dots)
            {
                if (item == null)
                    continue;
                using (var g = Graphics.FromImage(image.Image))
                {
                    g.FillRectangle(item[2] == 1 ? inside : outside, item[0], item[1], 1, 1);//drawing point 
                    image.Refresh();
                }
            }







            //var currentFunction = false;

            //int limit = 5000;
            //int count = 0;

            //foreach (var list in collections)
            //{
            //    count = 0;
            //    foreach (var item in list)
            //    {
            //        count++;
            //        if (count > limit)
            //            break;
            //        if (item == null)
            //            continue;
            //        visited.Add(item[0] + " " + item[1]);
            //        using (var g = Graphics.FromImage(pictureBox1.Image))
            //        {
            //            g.FillRectangle(currentFunction ? sin : cos, item[0], item[1], 3, 3); //drawing point 
            //            pictureBox1.Refresh();
            //        }
            //    }
            //    currentFunction = true;
            //}
            //foreach (var item in Dots)
            //{
            //    if (item == null || visited.Contains(item[0] + " " + item[1]))
            //        continue;
            //    using (var g = Graphics.FromImage(pictureBox1.Image))
            //    {
            //        g.FillRectangle(item[2] == 1 ? inside : outside, item[0], item[1], 1, 1);//drawing point 
            //        pictureBox1.Refresh();
            //    }
            //}
            //foreach (var list in collections)
            //{
            //    count = 0;
            //    foreach (var item in list)
            //    {
            //        count++;
            //        if (count > limit)
            //            break;
            //        if (item == null)
            //            continue;
            //        visited.Add(item[0] + " " + item[1]);
            //        using (var g = Graphics.FromImage(pictureBox1.Image))
            //        {
            //            g.FillRectangle(currentFunction ? sin : cos, item[0], item[1], 3, 3); //drawing point 
            //            pictureBox1.Refresh();
            //        }
            //    }
            //    currentFunction = true;
            //}
            //SinValues.Clear();
            //CosValues.Clear();
            //Dots.Clear();
        }

    }
    public static class ConcurrentRandom
    {
        [ThreadStatic]
        private static Random? _local;

        public static Random Instance => _local ??= new Random();
    }
}
