using System.Drawing;
using System.Drawing.Drawing2D;

namespace HomeWork1
{

    public static class ConcurrentRandom
    {
        [ThreadStatic]
        private static Random? _local;

        public static Random Instance => _local ??= new Random();
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            resultTrapezoidalRule1.Text = TrapezoidalRule(a, b, Sin).ToString();
            resultTrapezoidalRule2.Text = TrapezoidalRule(a, b, Math.Sin).ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);
            resultMonteCarlo1.Text = MonteCarloMethod(a, b, 100000, Sin, Cos).ToString();
            resultMonteCarlo2.Text = MonteCarloMethod(a, b, 100000, Math.Sin, Math.Cos).ToString();
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
            double count = 0;
            double temp = 2;

            Parallel.For(0, limit + 1, (i) =>
              {
                  double x = ConcurrentRandom.Instance.NextDouble() * (b - a);//b - a  (a+)
                  double y = getRandomDirection() * ConcurrentRandom.Instance.NextDouble();//-1 1
                  if (y <= FunctionTop(x) && y >= FunctionBottom(x))
                      count++;
              });
            return (b - a) * temp * (count / limit);
        }

        private double getRandomDirection()
        {
            double answer = ConcurrentRandom.Instance.Next(-1, 1);
            while (answer == 0)
                answer = ConcurrentRandom.Instance.Next(-1, 1);
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
            for (int power = 1; power <= 7; power++)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen ellipsePen = new Pen(Color.Red, 5); //pen for ellipse            
            Pen rectanglePen = new Pen(Color.Black, 3); //pen for rectangle
            e.Graphics.DrawRectangle(rectanglePen, new Rectangle(0, 0, 300, 300));
            e.Graphics.FillRectangle(Brushes.Black, 15, 15, 2, 2); //drawing point 
        }
    }
}

