using System;

namespace teratail
{
    class Program
    {
        static void Main(string[] args)
        {
            //int [] input = int.Parse("10 100".Split(' '));//文字列を分裂して、配列を順次代入

            //Console.WriteLine(int.Parse(input[0])+int.Parse(input[1]));//配列のそれぞれの値をint.Parseでint型に変換してから,値を表示する。
            int sum = 0;
            foreach(var s in Console.ReadLine().Split(' ')){
                sum += int.Parse(s);
            }
            Console.WriteLine(sum);
        }
    }
}
