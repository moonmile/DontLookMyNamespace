using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// Lolita クラスにのみ公開する
[assembly: InternalsVisibleTo("LolitaRoom")]

namespace AliceRoom
{
    public class Alice : Room.IPerson
    {
        public void Init()
        {
            var bag = new Prada();
            bag.Owner = "Alice";
            bag.Content = "my secret";
            this.box = bag;
        }
        public string GetBagContent()
        {
            var bag = box as AliceRoom.Prada;
            if (bag == null)
                return "NONE";
            else
                return bag.Content;
        }
    }
    /// <summary>
    /// Plada クラスは LolitaRoom にのみ公開
    /// </summary>
    internal class Prada
    {
        // Owner を設定できるのは Alice だけ
        public string Owner { get; internal protected set; }
        // コンテンツは Lolita も取得できる
        public string Content { get; set; }
    }
}
