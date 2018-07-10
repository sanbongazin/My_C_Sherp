using System;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var strings = args.Append(new[] { "ポ", "プ", "テ", "ピピック" }[new Random(args.GetHashCode() + new Random().Next()).Next(4)]);
        if (strings.Skip(strings.Count() - 4).SequenceEqual(new[] { "ポ", "プ", "テ", "ピピック" }) || Main(strings.ToArray()).IsCanceled)
            strings.Append("\r\n　　　　　　　　　　　　　　　　　　　　　　　　　-------　､　ｒへ------､ \r\n　　　　　　　　　　　　　　　　　　 ＿__､+''\"~八 ~''＜ つ　　　＼ \r\n _､+''\"~　 ./ ,:　　　　＾ 　 丶　　　　　ヽく＿＿　∧ \r\n　　　　　　 , -r-　　　　 / 　 　 　 / / -､　　　　'´￣!＼‘,　‘:,　 |　　　 ＼/ \r\n　　　　　／ .∧　　 ＼..ﾞ|/＿,,.｡*'/ /|,/＼＿_／^ヽ /,,_　`! 　 ',　| \r\n　　　 ／　　　∧　　　 ＼　〈〉.　,　.|　ｙ''\"ヽ______ 7´⌒ヽ _ | ト;′ \r\n 〈　　　　　 ∧ （竹） .∨...　｜｜ ,r ヽ 三三 /‘:, Y! .|,′ \r\n∨ 　 　 　 ∧　　　　∨...　|.| 八 °,!三三{.　° ﾉ 八/ ---､ \r\n. ∨ 　 　 　 ∧　　　　∨....∨（.＾ 　　 ､_,､_, `　　　,.ｨ ^ !./＿　　', \r\n　　　　 ∨　　 ／三ﾐメ、　　∨　冫≧=‐------‐ｧ=≦/ .|/　　 } 　 ! \r\n.　　　 　 ∨三三三三圦__.＼＼/　＼|ｲ `''＜:＼/:::::／　　|　　（＿__） \r\n　　　 〈〉　　 ノ　ゞ三ｼ.　＼　＼;　　 { /　　　 ｀¨ﾍ⌒こフ　.∨ 〔､､､_） \r\n　　　　　　　）　　　 　 　 　 ＼八　　`^i､_ __　　　 ＼＼　　 .∨ ｀¨´ \r\n　　　　 ＜ﾍ＿/三＼＿／｜＼､.＼　/::/　 ）　　　　 `'´　＿ ,∨､ \r\n |＼三三三三:／　　|.＼/^ ゞク≦---‐=≦::::::「:::::::::|::::/ \r\n /:::::::/:::::::/:::::::::;′:::::::::|::::::::::|:人\r\nhappy end!!").ToList().ForEach(p => Console.Write(p));
    }
}