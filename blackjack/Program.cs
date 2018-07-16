using System;

namespace blackjack
{
    class Player_Brain{
        public (int dealer, int player) Hard_hand(int dealer, int player){
            var card = new Card();
            if(dealer <= 11){
               Console.WriteLine("ヒットを宣言");
               dealer += card.Generate_card();
               player += card.Generate_card();
            }

            return (dealer,player);
        }

        public (int dealer, int player) Hard_hand_Exception(int dealer, int player){
           var card = new Card();
           dealer += card.Generate_card();
           player += card.Generate_card();

           return (dealer,player);
        }

    }

    class Card{
        System.Random rnd = new System.Random(10);
        
        public int Generate_card(){
            return rnd.Next(11);
        }
    class Program
    {   
        public void Burst_check(int dealer, int player, int i){
            if(dealer > 21 && player >21){
                Console.WriteLine("両プレーヤー共にバーストしました。引き分けです。");
                return;
            }else if(dealer > 21){
                Console.WriteLine("ディーラーがバーストしました。プレーヤーの勝利です。");
                return;
            }else if(player > 21){
                Console.WriteLine("プレーヤーがバーストしました。ディーラーの勝利です。");
                return;
            }else if (dealer == 21 && player == 21){
                Console.WriteLine("共にブラックジャックです。引き分けとなります。");
                return;
            }else if (dealer == 21){
                Console.WriteLine("ディーラーがブラックジャックになりました。ディーラーの勝利です");
                return;
            }else if(player == 21){
                Console.WriteLine("プレーヤーがブラックジャックになりました。プレーヤーの勝利です。");
                return;
            }

            if(i == 1){
                if(dealer > player){
                    Console.WriteLine("ディーラーの勝利です。");
                    return;
                }else{
                    Console.WriteLine("プレーヤーの勝利です。");
                    return;
                }     
            }   
            return;
        }

    }

        static void Main(string[] args)
        {
            var card = new Card();
            int dealer = card.Generate_card();
            int player = card.Generate_card();

            Console.WriteLine("ブラックジャックへようこそ。");
            Console.WriteLine("ディーラーのカードは:" + dealer);
            Console.WriteLine("プレイヤーのカードは:" + player);

            var brain = new Player_Brain();
            player += card.Generate_card();
            dealer += card.Generate_card();
            Console.WriteLine("2枚目。プレイヤーのカード合計は:" + player);
            Console.WriteLine("2枚目。ディーラーのカード合計は:" + dealer);

            var BC = new Program();
            int i = 1;

            if(player <= 11){
                var answer = brain.Hard_hand(dealer, player);
                BC.Burst_check(answer.dealer, answer.player,i);
                // BC.Gadgement(answer.dealer,answer.player);

                Console.WriteLine("3枚目プレイヤーのカード合計は:" + answer.player);
                Console.WriteLine("3枚目ディーラーのカード合計は:"+answer.dealer);
            }else if ((player >= 12 && dealer <= 3) || (player >=12 && dealer >= 7)){
                var answer = brain.Hard_hand_Exception(dealer, player);
                BC.Burst_check(answer.dealer, answer.player,i);
                // BC.Gadgement(answer.dealer, answer.dealer);

                Console.WriteLine("3枚目プレイヤーのカード合計は:" + answer.player);
                Console.WriteLine("3枚目ディーラーのカード合計は:" + answer.dealer);
            }

        }
    }
}
