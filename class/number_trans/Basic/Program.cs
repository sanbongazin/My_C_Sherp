using System;

namespace Basic
{
    class Program
    {
        public int CountUp (int data){
            data++;
            return data;
        }
        static void Main(string[] args)
        {
            var data = 1;
            var p = new Program();
            Console.WriteLine(p.CountUp(data));
            Console.WriteLine(data);
        }
    }
}
