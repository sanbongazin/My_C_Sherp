using System;
using System.IO;
using System.Windows.;

namespace fileblocker
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(@"C:\test.txt");
        //ファイルのサイズを取得
            long filesize = fi.Length;
            if(fi.Length>1000000){
                MessageBox.Show("正しい値を入力してください。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            
            }
        }
    }
}
