using System;

namespace medarist
{
    class Connect {
        public static void Show(int i,ref string [] data){
            
        string [] medal = new string [] {"Gold","Silver","Bronze"};

        Console.WriteLine(medal[i]+" "+data[i]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string [] data = new string[3];
            for(int c = 0;c<3;c++){
            data[c] = Console.ReadLine();
            }

            // var p = new Connect();

            for(int i = 0;i<3;i++){
            Connect.Show(i,ref data);
            }
        }
    }
}
