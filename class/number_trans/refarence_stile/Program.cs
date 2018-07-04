﻿using System;

namespace refarence_stile
{
    class Program
    {
        public int [] Update(int [] data){
            data[0] = 5;
            return data; //配列のなかの値を返す
        } 
        static void Main(string[] args)
        {
            var data = new [] {2,4,6};

            var p = new Program();
            Console.WriteLine(p.Update(data)[0]);//予想：この場合はクラスのインスタンスから、５を返すようなプログラムとなっているため。
            Console.WriteLine(data[0]);//予想：本来は、２が返される筈だが、先ほどの実行で、値がセットされ、0番地に、５が代入されているため、５を返す。
        }
    }
}
