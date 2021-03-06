﻿using System;

namespace returnref
{
    class PassrefReturn{
        public ref int Returnref(int [] data){
            return ref data[0];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var data = new [] { 1, 2, 3};
            var p = new PassrefReturn();
            ref int num = ref p.Returnref(data);//refをポインタモードとしてみれば、答えの解釈としてわかりやすかった。
            // アドレスのコピーとして考えることができる。

            num = 10;
            Console.WriteLine(num);//Main関数のnumを参照しているため
            Console.WriteLine(data[0]);//アドレスが更新されたため。

        }
    }
}
