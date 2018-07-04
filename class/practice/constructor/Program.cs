using System;

namespace constructor
{
    class Messeage{
        int number;

        static Messeage(){
            Console.WriteLine("静的コンストラクター");
        }
        public Messeage(int number){
            this.number=number;
            Console.WriteLine($"通常のコンストラクター{number}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var m1 = new Messeage(1);
            var m2 = new Messeage(2);
        }
    }
}
