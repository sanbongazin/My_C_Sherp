using System;
// using super_class.Prop;

namespace super_class
{
    public class Person
    {
        public string FirstName{get;set;}
        public string LastName{get;set;}

        public string Show(){
            return $"名前は{this.LastName}{this.FirstName}です。";
    }
    
    class BuisinessPerson:Person
    {
        public string Work(){
            return $"{this.LastName}{this.FirstName}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var bp = new BuisinessPerson{
                FirstName = "太朗",
                LastName = "山田"
            };

            Console.WriteLine(bp.Work());
            Console.WriteLine(bp.Show());
        }
    }
    }
}
