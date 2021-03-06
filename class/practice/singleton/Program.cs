﻿using System;

namespace singleton
{
    class Mysingleton {
        private static Mysingleton instance = new Mysingleton();

        private Mysingleton(){ }

        //あらかじめ用意しておいたインスタンスを取得
        public static Mysingleton Instance{
            get{
                return instance;
            }
        }

        public string x = "hello";
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {   
            var f = Mysingleton.Instance;
            var g = Mysingleton.Instance;

            f.x = "こんにちは";//参照先が静的（同じ所を指している）なため
            Console.WriteLine(g.x); 
            
        }
    }
}
