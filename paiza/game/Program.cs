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
