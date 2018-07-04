using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Write("積分区間を半角スペースで区切って入力:");
                string input_before = Console.ReadLine();
                var cant_before = new Regex(@"[0-9]\s{1}[0-9]");
                var mustnt_before = false;

                string[] input = input_before.Split(' ');

                int[] data = new int[input.Length];
                var cant = new Regex(@"[0-9]");
                bool[] mustnt = new bool[input.Length];

                if (mustnt[0] == cant.IsMatch(input[0]) || mustnt[1] == cant.IsMatch(input[1]) || mustnt_before == cant_before.IsMatch(input_before))
                {
                    Console.WriteLine("構文エラー。半角数字を半角スペースで区切って入力してください。");
                    continue;
                }
                double a = double.Parse(input[0]);
                double b = double.Parse(input[1]);
                double x = 0;
                Console.Write("分割数を入力:");
                int n = int.Parse(Console.ReadLine());
                double h = (b - a) / n;

                x = a;

                double[] result = new double[n];

                    Function(x, a, b, n, h);

                if (mustnt[0] != cant.IsMatch(input[0]) || mustnt[1] != cant.IsMatch(input[1]))
                {
                    Console.Write("積分計算を続けますか？続けるにはyを入力");
                    string select = Console.ReadLine();
                    if (select == "y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }
        static double Function( double x, double a, double b, double n, double h)
        {

            double s_1 = 0;
            double s = 0;

            double function_a = Math.Sin(x) / x;
            double function_b = Math.Sin(x) / x;

            for (int i = 0; i < n; i++)
            {


                s_1 = Math.Sin(x) / x;

                s += s_1;//Math.Sin(x) / x;

                x += h;
                //Console.WriteLine(s_1 + " " + s_2);
                /*if (i == 2) //d=2の時の表示
                {
                    Console.WriteLine(h / 2 * s_1 * s_2);
                }*/
            }
            Console.WriteLine(/*"d = {0:D2}: {1,13:F10}", d, */ h / 2 * (function_a + 2 * s + function_b));
            return 0;
        }
    }
}

