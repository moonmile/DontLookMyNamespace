using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LewisRoom
{
    public class Lewis : Room.IPerson
    {
        public void LookUp()
        {
            var alice = new AliceRoom.Alice();
            // alice.Prada は見えない
        }
        public void Post(Room.IPerson dest, object obj)
        {
            this.box = obj;
            // object で受け取っても分からない
            // リフレクションだと見れる？
        }
    }
}
