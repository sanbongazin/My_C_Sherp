using System;

namespace data_refarence
{
    class Program
    {
        public int CountUp(ref int data){
            data++;
            return data;
        }
        static void Main(string[] args)
        {
            int data; 
            //var data= 1;
            //これを初期値なしに変更
            var p = new Program();
            Console.WriteLine(p.CountUp(ref data));//このrefは、参照先を示しており、インスタンス化されたクラスの実行により、Mainクラスのdataが、参照され、インクリメントされ、２を返すはず
            Console.WriteLine(data);//上の説明文から、Main内のdataがインクリメントされたままで値が出力されるため、2となっている。
        }
    }
}
