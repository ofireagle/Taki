using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taki
{
    public class Brain : Player
    {
     
        Random rand = new Random();

        public Brain(string name) : base (name)
        {
            base.Name = name;
        }

        public LinkedList<Card> Play(Card top, bool PlusTwoActivated)
        {
            if (PlusTwoActivated)
            {
                foreach (Card c in cards)
                    if (c.Value == Value.PlusTwo)
                        return new LinkedList<Card>(new Card[] { c });
                return null;
            
            }
            LinkedList<Card> same = new LinkedList<Card>(); // all cards in the same color (top's color)

            foreach(Card card in cards)
                if (top.Color == card.Color)
                    same.AddFirst(card);

            if (same.First != null)
            {
                Takicolor(same); // if there's taki colored put it first
                if (same.First.Value.Value == Value.Taki)
                {
                    same = BestOrder(same);
                    return same;
                }
            }
            SuperTaki();
            if (this.cards.First.Value.Value == Value.SuperTaki)
            {
                LinkedList<Card> color = mostcolor();
                color.AddFirst(this.cards.First.Value);
                LinkedListNode<Card> y = color.First.Next;
                while (y != null)
                {
                    this.cards.Remove(y.Value);
                    y = y.Next;
                }
                return color;
            }
            LinkedList<Card> result = new LinkedList<Card>();
            if(same.First!=null) // if there's card in top's color
            {
                result.AddFirst(BestCard(same));
                return result;
            }

            foreach (Card card in cards)
                if (card.Value == top.Value)
                {
                    result.AddFirst(card);
                    return result;
                }

            changeColor();
            if (cards.First.Value.Value == Value.ChangeColor)
            {
                LinkedList<Card> change = mostcolor();
                if (change!= null && change.First != null)
                {

                    Card answer = change.First.Value;
                    if (change.First.Next != null)
                        answer.Color = change.First.Next.Value.Color;
                    return new LinkedList<Card>(new Card[] { answer });
                }
            }
            return null;

        }

        // if there is Taki card
        private static void Takicolor (LinkedList<Card> same)
        {
            LinkedListNode<Card> x = same.First;
            
            while (x != null)
            {
                if (x.Value.Value == Value.Taki)
                {
                    LinkedListNode<Card> taki = x;
                    same.Remove(taki);
                    same.AddFirst(taki);
                    return;
                }
                x = x.Next;
            }
        }
        private void SuperTaki()
        {
            foreach(Card card in cards)
                if (card.Value == Value.SuperTaki)
                {
                    this.cards.Remove(card);
                    this.cards.AddFirst(card);
                    return;
                }
        }
        // the best Card available
        private Card BestCard(LinkedList<Card> color)
        {
            if (color.Count == 0)
                return null;

            foreach (Card card in color)
                if (card.Value == Value.PlusTwo)
                    return card;

            foreach (Card card in color)
                if (card.Value == Value.Stop)
                    return card;

            foreach (Card card in color)
                if (card.Value == Value.ChangeDirection)
                    return card;

            foreach (Card card in color)
                if (card.Value == Value.plus)
                    return card;

            return color.First.Value;


        }
        //return the best order
        private LinkedList<Card> BestOrder(LinkedList<Card> color)
        {
            
            LinkedList<Card> order = new LinkedList<Card>();
            order.AddFirst(color.First.Value);
            color.RemoveFirst();
            LinkedListNode<Card> x = new LinkedListNode<Card>(BestCard(color));
            if (x.Value != null)
                color.Remove(x.Value);
            while (color.Count != 0)
            {
                order.AddLast(color.First.Value);
                color.RemoveFirst();
            }
            if (x.Value != null)
                order.AddLast(x.Value);

            return order;
        }

        private LinkedList<Card> mostcolor()
        {
            LinkedList<Card> yellow = new LinkedList<Card>();
            LinkedList<Card> green = new LinkedList<Card>();
            LinkedList<Card> blue = new LinkedList<Card>();
            LinkedList<Card> red = new LinkedList<Card>();
            LinkedListNode<Card> x = this.cards.First.Next;
            while (x != null)
            {
                if (x.Value.Color == Color.Yellow)
                    yellow.AddLast(x.Value);
                if (x.Value.Color == Color.Blue)
                    blue.AddLast(x.Value);
                if (x.Value.Color == Color.Red)
                    red.AddLast(x.Value);
                if (x.Value.Color == Color.Green)
                    green.AddLast(x.Value);
                x = x.Next;
            }
            if (yellow.Count > green.Count && yellow.Count > red.Count && yellow.Count > blue.Count)
                return yellow;
            if (red.Count > green.Count && red.Count > yellow.Count && red.Count > blue.Count)
                return red;
            if (blue.Count > yellow.Count && blue.Count > red.Count && blue.Count > green.Count)
                return blue;
            if (green.Count > blue.Count && green.Count > yellow.Count && green.Count > red.Count)
                return green;
            if (red.Count != 0)
                return red;
            if (yellow.Count != 0)
                return yellow;
            if (blue.Count != 0)
                return blue;
            if (green.Count != 0)
                return green;

            return null;
        }
        private void changeColor()
        {
            LinkedListNode<Card> x = this.cards.First;
            while (x != null)
            {
                if (x.Value.Value == Value.ChangeColor)
                {
                    this.cards.Remove(x);
                    this.cards.AddFirst(x);
                    return;
                }
                x = x.Next;
            }
        }






        static Random r = new Random();
        public static String GenerateName()
        {
            string[] array =
            {
                "Neriya",
                "Amit",
                "Adam",
                "Omer",
                "Neomie",
                "Aviv",
                "Avia",
                "Rachel",
                "Aviad",
                "Noam",
                "Moshe",
                "Adi",
                "Roni",
                "Yoav",
                "Yonatan",
                "Eyal"
            };
            int i = r.Next(array.Length);
            return array[i];
        }
    }
}
