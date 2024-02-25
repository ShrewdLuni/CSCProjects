using System.Drawing;
using System.Drawing.Drawing2D;

namespace HomeWork1
{

    public partial class Form1 : Form
    {
        private object _locker = new object();

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double customLibraryAnswer = Math.Round(TrapezoidalRule(a, b, Sin), 8);
                double defaultLibraryAnswer = Math.Round(TrapezoidalRule(a, b, Math.Sin), 8);
                resultTrapezoidalRule1.Text = customLibraryAnswer.ToString();
                resultTrapezoidalRule2.Text = defaultLibraryAnswer.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox3.Text);
                double b = Convert.ToDouble(textBox4.Text);
                long n = Convert.ToInt64(textBox5.Text);
                MonteCarloMethod(a, b, n, Sin, Cos);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }

        }

        private double TrapezoidalRule(double a, double b, Func<double, double> Function)
        {
            double h = 1;
            double area = 0;
            double x = a;
            double y = a + h;
            double step = 0;
            long limit = Convert.ToInt64(b) - Convert.ToInt64(y) + 1;
            Parallel.For(0, limit, (i) =>
            {
                step = i * h;
                area += FindAreaOfTrapezoid(x + step, y + step, h, Function);
            });
            return area;
        }

        private double FindAreaOfTrapezoid(double x,double y,double h, Func<double, double> Function)
        {
            return (Function(x) + Function(y)) * h / 2;
        }

        private double MonteCarloMethod(double a, double b, long limit, Func<double, double> FunctionTop, Func<double, double> FunctionBottom)
        {
            List<int[]> SinValues = new List<int[]>();
            List<int[]> CosValues = new List<int[]>();
            List<int[]> Dots = new List<int[]>();
            double count = 0;
            double temp = 2;
            HashSet<string> visited = new HashSet<string>();
            Parallel.For(0, limit + 1, (i) =>
            {
                double x = ConcurrentRandom.Instance.NextDouble() * (b - a);//b - a  (a+)
                double y = getRandomDirection() * ConcurrentRandom.Instance.NextDouble();//-1 1
                double sinValue = FunctionTop(x);
                double cosValue = FunctionBottom(x);
                if (y <= sinValue && y >= cosValue)
                {
                    count++;
                    Dots.Add(new int[] { Convert.ToInt32(x * 300 / (b - a)), Convert.ToInt32((y + 1) * 100 + 4), 1 });//info for drawing dots
                }
                else
                    Dots.Add(new int[] { Convert.ToInt32(x * 300 / (b - a)), Convert.ToInt32((y + 1) * 100 + 4), 0 });//info for drawing dots


                SinValues.Add(new int[] { Convert.ToInt32(x * 300 / (b - a)), Convert.ToInt32(sinValue * 100) + 104 });//info for drawing sin
                CosValues.Add(new int[] { Convert.ToInt32(x * 300 / (b - a)), Convert.ToInt32(cosValue * 100) + 104 });//info for drawing cos
            });
            resultMonteCarlo1.Text = Math.Round(((b - a) * temp * (count / limit))).ToString();
            VisualizeMonteCarlo(visited, SinValues, CosValues, Dots);
            return (b - a) * temp * (count / limit);
        }

        private double getRandomDirection()
        {
            double answer = ConcurrentRandom.Instance.Next(-1, 2);
            while (answer == 0)
                answer = ConcurrentRandom.Instance.Next(-1, 2);
            return answer;
        }

        private double Sin(double x)
        {
            x %= 2 * Math.PI;
            double answer = x;
            bool negative = true;
            for (int curTerm = 1; curTerm <= 10; curTerm++)
            {
                double temp = Math.Pow(x, (curTerm * 2) + 1) / Factorial((curTerm * 2) + 1);
                if (negative)
                    answer -= temp;
                else
                    answer += temp;
                negative = !negative;
            }
            return answer;
        }

        private double Cos(double x)
        {
            x %= 2 * Math.PI;
            double answer = 1.0;
            bool negative = true;
            for (int power = 1; power <= 10; power++)
            {
                double temp = Math.Pow(x, (power * 2)) / Factorial((power * 2));
                if (negative)
                    answer -= temp;
                else
                    answer += temp;
                negative = !negative;
            }
            return answer;
        }

        private long Factorial(long n)
        {
            if (n <= 1)
                return 1;
            return n * Factorial(n - 1);
        }

        public static class ConcurrentRandom
        {
            [ThreadStatic]
            private static Random? _local;

            public static Random Instance => _local ??= new Random();
        }

        private void VisualizeMonteCarlo(HashSet<string> visited, List<int[]> SinValues, List<int[]> CosValues, List<int[]> Dots)
        {
            pictureBox1.Image = null;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            var collections = new List<int[]>[] { SinValues, CosValues };
            var brush = Brushes.Red;
            foreach (var list in collections)
            {
                foreach (var item in list)
                {
                    if (item == null)
                        continue;
                    visited.Add(item[0] + " " + item[1]);
                    using (var g = Graphics.FromImage(pictureBox1.Image))
                    {
                        g.FillRectangle(brush, item[0], item[1], 3, 3); //drawing point 
                        pictureBox1.Refresh();
                    }
                }
                brush = Brushes.DeepSkyBlue;
            }
            foreach (var item in Dots)
            {
                if (item == null || visited.Contains(item[0] + " " + item[1]))
                    continue;
                using (var g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.FillRectangle(item[2] == 1 ? Brushes.Green : Brushes.Indigo, item[0], item[1], 1, 1); //drawing point 
                    pictureBox1.Refresh();
                }
            }
            SinValues.Clear();
            CosValues.Clear();
            Dots.Clear();
        }
    }
}

