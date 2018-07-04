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
                Console.WriteLine(args[0]);//コンソールで見栄えをよくするために使いました。
                string input_before = args[0];//Console.ReadLine()の代わりに使用。
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
                Console.WriteLine(args[1]);//コンソールで見栄えをよくするために使いました。
                int n = int.Parse(args[1]);//Console.ReadLine());
                double h = (b - a) / n;

                x = a;

                double[] result = new double[n];

                    Function(x, a, b, n, h);

                if (mustnt[0] != cant.IsMatch(input[0]) || mustnt[1] != cant.IsMatch(input[1]))
                {
                    Console.Write("積分計算を続けますか？続けるにはyを入力");
                    Console.WriteLine(args[2]);//コンソールで見栄えをよくするために使いました。
                    string select = args[2];//Console.ReadLine();
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

            double function_a = 0; //こちらは、答えを0と定義しました。定義しないと、答えは加算されません。どういう定義かわからなかったので、、こちらは適宜調整が必要かもしれません
            double function_b = Math.Sin(b) / b;

            for (int i = 0; i < n; i++)
            {
                s_1 += Math.Sin(x) / x;
                    if(Double.IsNaN(s_1)){//こっちは、その定義のなさをカバーするために、一回目のみ、０に直しました。
                        s_1 = 0;
                    }
                x += h;
            }
            Console.WriteLine("答えは"+ h / 2 * (function_a + 2 * s_1 + function_b));
            return 0;
        }
    }
}

