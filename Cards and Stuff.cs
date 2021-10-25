using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taki
{
    public class Card
    {
        public readonly Value Value;
        public Color Color;

        public Card(Value value, Color color)
        {
            this.Value = value;
            this.Color = color;
        }
    }

    public class Deck
    {
        private Stack<Card> cards = new Stack<Card>();

        public Deck(bool WITH_CARDS)
        {
            if (WITH_CARDS)
            {
                for (int i = 0; i < 4; i++)
                {
                    InertCard(new Card(Value.plus, Color.Red));
                    InertCard(new Card(Value.plus, Color.Blue));
                    InertCard(new Card(Value.plus, Color.Yellow));
                    InertCard(new Card(Value.plus, Color.Green));
                    InertCard(new Card(Value.One, Color.Red));
                    InertCard(new Card(Value.Three, Color.Red));
                    InertCard(new Card(Value.Four, Color.Red));
                    InertCard(new Card(Value.Five, Color.Red));
                    InertCard(new Card(Value.Six, Color.Red));
                    InertCard(new Card(Value.Seven, Color.Red));
                    InertCard(new Card(Value.Eight, Color.Red));
                    InertCard(new Card(Value.Nine, Color.Red));
                    InertCard(new Card(Value.Stop, Color.Red));
                    InertCard(new Card(Value.PlusTwo, Color.Red));
                    InertCard(new Card(Value.Taki, Color.Red));
                    InertCard(new Card(Value.ChangeDirection, Color.Red));
                    InertCard(new Card(Value.One, Color.Yellow));
                    InertCard(new Card(Value.Three, Color.Yellow));
                    InertCard(new Card(Value.Four, Color.Yellow));
                    InertCard(new Card(Value.Five, Color.Yellow));
                    InertCard(new Card(Value.Six, Color.Yellow));
                    InertCard(new Card(Value.Seven, Color.Yellow));
                    InertCard(new Card(Value.Eight, Color.Yellow));
                    InertCard(new Card(Value.Nine, Color.Yellow));
                    InertCard(new Card(Value.Stop, Color.Yellow));
                    InertCard(new Card(Value.PlusTwo, Color.Yellow));
                    InertCard(new Card(Value.Taki, Color.Yellow));
                    InertCard(new Card(Value.ChangeDirection, Color.Yellow));
                    InertCard(new Card(Value.One, Color.Blue));
                    InertCard(new Card(Value.Three, Color.Blue));
                    InertCard(new Card(Value.Four, Color.Blue));
                    InertCard(new Card(Value.Five, Color.Blue));
                    InertCard(new Card(Value.Six, Color.Blue));
                    InertCard(new Card(Value.Seven, Color.Blue));
                    InertCard(new Card(Value.Eight, Color.Blue));
                    InertCard(new Card(Value.Nine, Color.Blue));
                    InertCard(new Card(Value.Stop, Color.Blue));
                    InertCard(new Card(Value.PlusTwo, Color.Blue));
                    InertCard(new Card(Value.Taki, Color.Blue));
                    InertCard(new Card(Value.ChangeDirection, Color.Blue));
                    InertCard(new Card(Value.One, Color.Green));
                    InertCard(new Card(Value.Three, Color.Green));
                    InertCard(new Card(Value.Four, Color.Green));
                    InertCard(new Card(Value.Five, Color.Green));
                    InertCard(new Card(Value.Six, Color.Green));
                    InertCard(new Card(Value.Seven, Color.Green));
                    InertCard(new Card(Value.Eight, Color.Green));
                    InertCard(new Card(Value.Nine, Color.Green));
                    InertCard(new Card(Value.Stop, Color.Green));
                    InertCard(new Card(Value.PlusTwo, Color.Green));
                    InertCard(new Card(Value.Taki, Color.Green));
                    InertCard(new Card(Value.ChangeDirection, Color.Green));
                    InertCard(new Card(Value.SuperTaki, Color.None));
                    InertCard(new Card(Value.SuperTaki, Color.None));
                    InertCard(new Card(Value.ChangeColor, Color.None));
                    InertCard(new Card(Value.ChangeColor, Color.None));
                }
                Shuffle();
            }
        }

        public int HowManyLeft()
        {
            return cards.Count;
        }

        public Card DrawCard()
        {
            return cards.Pop();
        }

        public void InertCard(Card card)
        {
            cards.Push(card);
        }

        public Card WhatsOnTop()
        {
            return cards.Peek();
        }

        Random rand = new Random();
        public void Shuffle()
        {
            Card[] cardsArray = cards.ToArray();
            for (int i = 0, m = 0; i < cardsArray.Length; i++, m++)
            {

                int x = rand.Next(cardsArray.Length);
                Card temp = cardsArray[x];
                cardsArray[x] = cardsArray[m];
                cardsArray[m] = temp;
            }

            cards = new Stack<Card>(cardsArray);
        }

    }


    public enum Color
    {
        Green,
        Yellow,
        Red,
        Blue,
        None
    }

    public enum Value
    {
        Stop,
        PlusTwo,
        plus,
        ChangeDirection,
        Taki,
        SuperTaki,
        ChangeColor,
        One,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine
    }
}
