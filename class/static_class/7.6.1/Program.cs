﻿using System;

namespace _7._6._1
{
    class Person{
        public string FirstName{get;set;}
        public string LastName{get;set;}

        public void Show(string greeting = "こんにちは",string title = "さん"){

            Console.WriteLine($"{greeting},{this.LastName}{this.FirstName}{title}!");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person(){
            FirstName="山田",
            LastName="太郎"
            };

            p.Show();

            p.Show(title:Console.ReadLine());
        }
    }
}
