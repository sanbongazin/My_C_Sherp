using System;

namespace Readonly
{

    class Program
    {
        public static readonly int [] Values = {1,2,3};
        static void Main(string[] args)
        {
            //Values = new[] {10,20,30};
            //再代入は不可。フィールド初期化子、コンストラクターでのみ初期化可能なため
            Values[0] = 15;

            foreach(var s in Values){
            Console.WriteLine(s);
            }
        }
    }
}
