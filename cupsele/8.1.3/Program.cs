using System;

namespace _8._1._3
{
    class Triangle{
        private double _width;
        private double _height;

        public double Width{
            set{
                if(value<=0){
                    throw new ArgumentException("自然数にしろや");
                }
                this._width = value;
            }
            get{return this._width;}
        }

        public double Height{
            set{
                if(value<=0){
                    throw new ArgumentException("自然数にしろや");
                }
                this._height = value;
            }
            get{return this._height;}
        }

        public double GetArea(){
            return Width * Height / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var t = new Triangle();
            t.Width = 10;
            t.Height = 5;

            Console.WriteLine($"面積:{t.GetArea()}");
            t.Width = -5;
        }
    }
}
