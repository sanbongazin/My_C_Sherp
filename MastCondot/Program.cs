using System;
using System.Threading.Tasks;
using Mastodot;
using Mastodot.Utils;
using Mastodot.Enums;
using Mastodot.Exceptions;
using Mastodot.Entities;

namespace MastCondot
{
    class Program
    {
        private async Task Run(){
            var registeredApp = ApplicaionManager.RegistApp("qiitadon.com", "Mastcondot", Scope.Read | Scope.Write | Scope.Follow);
            var url = ApplicaionManager.GetOAuthUrl(registeredApp);
        }
        static void Main(string[] args)
        {
            var p = new Program();
        }
    }
}
