using System;
using System.Collections.Generic;

namespace iterator
{
    class PrimeNumber {
        public IEnumerable<int> GetPrimes(int max){
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
    }
    class Program
    {
        static void Main(string[] args)
        {
         var p = new PrimeNumber();
         
         foreach(var Value in p.GetPrimes(100)){
             Console.WriteLine(Value);
         }   
        }
    }
}
