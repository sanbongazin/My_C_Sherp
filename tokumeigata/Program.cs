using System;
using System.Collections.Generic;

namespace tokumeigata
{
    class Program
    {
        public IEnumerable<string> GetStrings(){
            yield return "あいうえお";
            yield return "かきくけこ";
            yield return "さしすせそ";
        }
        static void Main(string[] args)
        {
            var ite = new Program();
            foreach(var str in ite.GetStrings()){
                Console.WriteLine(str);
            }
        }
    }
}
