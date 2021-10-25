using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taki
{
    public class  Player
    {
        public LinkedList<Card> cards = new LinkedList<Card>();
        public string Name;
        public Player(string name)
        {
            this.Name = name;
        }

        public void GiveCard(Card card)
        {
            cards.AddLast(card);
        }

        public void ReleaseCard(Card card)
        {
            cards.Remove(card);
        }
    }
}
