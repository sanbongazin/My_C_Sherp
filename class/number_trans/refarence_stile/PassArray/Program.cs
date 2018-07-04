﻿using System;

namespace PassArray
{
    
    class Program
    {
        public int[] Update(int[] data)
        {
            data = new []{10, 20, 30};
            return data;
        } 
     static void Main(string[] args)
        {
            var data = new[] {2, 4, 6};
            var p = new Program();

            Console.WriteLine(p.Update(data)[0]);//インスタンス化したクラスを読みにいってるので、10が出てくるはず
            Console.WriteLine(data[0]);//丸ごと配列が入れ替わり、メモリ番地が切り替わっているため、Main内の配列番号０が参照される。
            
        }
    }
}
