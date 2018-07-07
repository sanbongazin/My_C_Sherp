using System;

namespace tanzaku
{
    class Process{
        string tanzaku;        
        public Process(string tanzaku){
            this.tanzaku = tanzaku;
        }

        public void Show(string input){
            foreach(char c in input){
                Console.WriteLine(c);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var p = new Process(input);
            p.Show(input);
        }
    }
}
