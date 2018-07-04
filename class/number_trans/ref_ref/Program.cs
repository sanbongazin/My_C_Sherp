using System;

namespace ref_ref
{
    class Program
    {
        public int[] Update(ref int[] data)
        {
            data[0] = 5;
            return data;
        }
        static void Main(string[] args)
        {
            var data = new[]{ 2, 4, 6};
            var p = new Program();
            Console.WriteLine(p.Update(ref data)[0]);//値が更新され、5になる
            Console.WriteLine(data[0]);//こちらには参照先が変更された値が参照されるので

        }
    }
}
