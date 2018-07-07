using System;

namespace game
{
    class Program
    {   
        class Process{
            private int screen_x;
            private int screen_y;
            private int data_x;
            private int data_y;

            public Process(int screen_x, int screen_y, int data_x, int data_y){
                this.screen_x = screen_x;
                this.screen_y = screen_y;
                this.data_x = data_x;
                this.data_y = data_y;
            }

            public int Show(){
                return (data_x*screen_x)+(data_y*screen_y)-(data_x*data_y);
            }
        }
        static void Main(string[] args)
        {
            // あなたはあるゲームのプログラムを書いています。
            // このゲームでは主人公の移動に応じて、 画面を左下原点でスクロールさせます。
            // 一度に背景の全ての要素を描画すると処理が追いつかなくなってしまいました。

            // このため、スクロールする際に、前回の背景の描画結果をコピーし、前回の背景に無い画素のみを描画する事にしました。
            // 画面の解像度と y 軸方向、 x 軸方向のスクロール距離が与えられます。
            // この時、コピーして描画量を減らした結果、どれほどの画素を描画するかを出力して下さい。

            // 例えば、 入力例 1 では x 方向に 30 画素、 y 方向に 30 画素分スクロールします。
            // 以下の画像のように、スクロールする前の描画結果を右上にコピーすると、描画する画素数は 
            // (30 × 240) + (30 × 180) - (30 × 30) = 11700 画素となります。

            string [] screen_input =  args[0].Split(' ');//Console.ReadLine().Split(' ');
            int screen_x = int.Parse(screen_input[1]); 
            int screen_y = int.Parse(screen_input[0]);

            string [] data = args[1].Split(' ');//Console.ReadLine().Split(' ');
            int data_x = int.Parse(data[1]);
            int data_y = int.Parse(data[0]);

            var p = new Process(screen_x,screen_y,data_x,data_y);

            Console.WriteLine(p.Show());


        }
    }
}
