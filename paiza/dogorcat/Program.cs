using System;

namespace dogorcat
{
    class Count{
        public int dog{set;get;}
        public int cat {set;get;}

        public string Show(){
            if(this.dog<this.cat){
                return "cat";
            }else{
                return "dog";
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Count();
            for(int i = 0 ;i<3 ;i++){
                string count =Console.ReadLine();
                if (count=="dog"){
                    p.dog++;
                }else{
                    p.cat++;
                }

            }

            Console.WriteLine(p.Show());
        }
    }
}
