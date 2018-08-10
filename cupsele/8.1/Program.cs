using System;

namespace _8._1
{
    class Person{
        public string FirstName;
        public string LastName;

        private string Show(){
            return $"名前は{this.FirstName}{this.LastName}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.FirstName = "太郎";
            p.LastName = "山田";

            p.Show();           
        }
    }
}
