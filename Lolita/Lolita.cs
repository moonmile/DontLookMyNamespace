using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LolitaRoom
{
    public class Lolita : Room.IPerson
    {
        public void Post(Room.IPerson dest, object obj)
        {
            this.box = obj;
        }
        public string GetBagContent()
        {
            var bag = box as AliceRoom.Prada;
            if (bag == null)
                return "none";
            else
                return bag.Content;
        }
    }
}
