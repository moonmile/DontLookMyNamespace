using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var alice = new AliceRoom.Alice();
            var lolita = new LolitaRoom.Lolita();
            var lewis = new LewisRoom.Lewis();

            // Pradaを作成
            alice.Init();

            // AliceRoom.Prada は見れない
            Console.WriteLine("alice room : {0}", 
                alice.GetBagContent());
            Console.WriteLine("lolita room: {0}", 
                lolita.GetBagContent());
            // Lolitaに渡す
            alice.Post(lolita);
            Console.WriteLine("alice room : {0}",
                alice.GetBagContent());
            Console.WriteLine("lolita room: {0}",
                lolita.GetBagContent());

            // Lwewis から AliceRoom.Prada は見れない
        }
    }
}
