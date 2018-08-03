using System;
using System.Collections;
using System.Collections.Generic;

namespace iterator2
{
    class PrimeList : IEnumerable<int>
    {
        int max = 2;

        public PrimeList(int max){
            this.max = max;
        } 

        public IEnumerator<int> GetEnumerator(){
            bool IsPrime(int Value){
                var prime = true;
                
                for(var i = 2; i<= Math.Floor(Math.Sqrt(Value)); i++){
                    if(Value % i == 0){
                        prime = false;
                        break;
                    }
                }
                return prime;
            }

            const int Min = 2;
            if(max < Min){
                Console.WriteLine("引数maxは2以上の値を指定してください。");
                yield break;
            }

            for(var num = Min; num<=max; num++){
                if(IsPrime(num)){
                    yield return num;
                }
            }
        } 
        
        IEnumerator IEnumerable.GetEnumerator(){
            return this.GetEnumerator();
        }            
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = new PrimeList(100);
            foreach(var Value in list){
                Console.WriteLine(Value);
            }
        }
    }
}
