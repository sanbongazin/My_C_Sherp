﻿using System;

namespace class_practice
{
    class Figure{
        public static void GetTriangleArea(int width, int height){
            Console.WriteLine($"三角形の面積は{width * height/2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string [] input = Console.ReadLine().Split(' ');
            Figure.GetTriangleArea(10,20/*int.Parse(input[0]),int.Parse(input[1])*/);
        }
    }
}
