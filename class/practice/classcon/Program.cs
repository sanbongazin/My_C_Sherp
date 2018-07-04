using System;

namespace classcon
{
    class Myapp{
        public static  readonly string Title = "C＃";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Myapp.Title);
            //Myapp.Title="本気で覚えるC#";
        }
    }
}
