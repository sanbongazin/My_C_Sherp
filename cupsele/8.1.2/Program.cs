using System;

namespace _8._1._2
{
    class Triangle{
        public double Width;
        public double Height;

        public double GetWidth(){
            return this.Width;
        }

        public void SetWidth(double width){
            if(width <= 0){
                throw new ArgumentException("正数で設定してください");
            }

            this.Width = width;
        }

        public double GetHeight(){
            return this.Height;
        }

        public void SetHeight(double Height){
            if(Height <= 0){
               throw new ArgumentException("正数で設定してください"); 
            }
            this.Height=Height;
        }

        public double GetArea(){
            return GetWidth() * GetHeight();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var t = new Triangle();

            t.SetWidth(10);
            t.SetHeight(5);
            Console.WriteLine($"面積:{t.GetArea()}");

            t.SetWidth(-5);
        }
    }
}
