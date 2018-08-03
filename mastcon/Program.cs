
using System;
using System.Linq;
using System.Threading.Tasks;
using Mastodot;
using Mastodot.Entities;
using Mastodot.Enums;
using Mastodot.Utils;
using System.Reactive.Linq;
using System.Timers;

namespace Mastcon
{
    class Program
	{
		//private async Task OAuth (){
		//	//var InstanceUrl = new Uri("https://qiitadon.com/");
		//	var authClient = new AuthenticationClient("pawoo.net");
		//	//var Oauth = authClient.OAuthUrl();
  //          //try
  //          //{
  //          //    System.Diagnostics.Process.Start("/Application/Google Chrome.app", Oauth);
  //          //}
  //          //finally { }
  //          var appRegistration = await authClient.CreateApp("MastCon", Scope.Read | Scope.Write | Scope.Follow);

		//	var auth = await authClient.ConnectWithPassword("sanbongazin@gmail.com", "masa1412");
  //          var client = new MastodonClient(appRegistration, auth);

  //          var streaming = client.GetPublicStreaming();
  //          streaming.OnUpdate += (sender, e) =>
  //          {
  //              Console.WriteLine(e.Status.Account.DisplayName);
  //              Console.WriteLine(e.Status.Account);
  //              Console.WriteLine();

  //          };
		//	streaming.Start();
			
		//}

		private void OAuth(){
			Console.WriteLine(DateTime.Now.Second);
			var registeredApp = ApplicaionManager.RegistApp("qiitadon.com","MastCondot", Scope.Read | Scope.Write | Scope.Follow).Result;
			var url = ApplicaionManager.GetOAuthUrl(registeredApp);
			Console.WriteLine(url);
			var code = Console.ReadLine();
			var tokens = ApplicaionManager.GetAccessTokenByCode(registeredApp, code).Result;

			//Console.WriteLine(tokens.);
			Console.WriteLine(tokens.AccessToken);
			//var client = new MastodonClient(url, code);

			Console.WriteLine("OAuthSuccess!");

			var p = new Program();
			for (; ; )
			{
				Console.WriteLine("May I help you?(readmode: r, tootmode: t, exit: other):");
				var answer = Console.ReadLine();
				if (answer == "r")
				{
					p.Read(url, tokens.AccessToken);
				}
				else if (answer == "t")
				{
					Console.WriteLine("Please Write to send Toot:");
					var content = Console.ReadLine();
					p.Toot(url,tokens.AccessToken,content);
				}
				else
				{
					break;
				}
			}
          
		}

		private void Read(string url, string AccessToken){
			var client = new MastodonClient(url, AccessToken);
			var time = DateTime.Now.ToString();
			Console.WriteLine(time);
			//for (time == 60)
			//{
				var statusDs = client.GetObservablePublicTimeline()
						   .OfType<Status>()
						   .Subscribe(x => Console.WriteLine($"{x.Account.FullUserName} Tooted: {x.Content}"));
				Console.WriteLine("Press Key then Finish");
				Console.ReadKey();
				statusDs.Dispose();
				Console.WriteLine("Finish");
			//}
		}

		private void Toot(string url, string AccessToken, string content){
			var client = new MastodonClient(url, AccessToken);

			client.PostNewStatus(status: content);
		}
		static void Main(string[] args)
		{
			//var p = new Program();
			new Program().OAuth();
        }
    }
}
