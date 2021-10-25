using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taki
{
    public class Taki
    {
        public Player[] Players = new Player[2];
        public int Currentturn = 0;
        public Deck AvailableCards = new Deck(true);
        public Deck PlayedCards = new Deck(false);
        public Card Top;
       
        public Taki(Player[] players)
        {
            Players = players;
            AvailableCards.Shuffle();
            Top = AvailableCards.DrawCard();
            Stack<Card> temp = new Stack<Card>();
            while(Top.Value== Value.ChangeColor || Top.Value == Value.ChangeDirection || Top.Value == Value.plus || Top.Value == Value.PlusTwo || Top.Value == Value.SuperTaki || Top.Value == Value.Taki || Top.Value == Value.Stop)
            {
                Card newtop = AvailableCards.DrawCard();
                Top = newtop;
                temp.Push(newtop);
            }
            while(temp.Count!=0)
            {
                AvailableCards.InertCard(temp.Pop());
            }
            PlayedCards.InertCard(Top);
            foreach (Player p in Players)
                for (int i = 0; i < 8; i++)
                    p.GiveCard(AvailableCards.DrawCard());

        }

        /// <summary>
        /// Returns whether the current player wins
        /// </summary>
        public bool DidPlayerWin()
        {
            return (Players[Currentturn].cards.Count == 0);
        }

        /// <summary>
        /// Returns true if the action was done
        /// </summary>
        public bool FillAvailavleCardsWithShuffledPlayedCardsIfNeeded()
        {
            if (AvailableCards.HowManyLeft() < 10)
            {
                Top = PlayedCards.DrawCard();
                while (PlayedCards.HowManyLeft() > 0)
                {
                    AvailableCards.InertCard(PlayedCards.DrawCard());
                }
                AvailableCards.Shuffle();
                PlayedCards.InertCard(Top);
                return true;
            }
            return false;
        }

        public int Direction = 1; // or -1

        public void PassTurn()
        {
            Currentturn = (3 + Currentturn + Direction) % Players.Length;
        }

        public void GivePlayerCard(Player p)
        {
            if (PlusTwoActivated)
            {
                for (int i = 0; i < PlusTwosCounter; i++)
                {
                    p.GiveCard(AvailableCards.DrawCard());
                    p.GiveCard(AvailableCards.DrawCard());
                    FillAvailavleCardsWithShuffledPlayedCardsIfNeeded();
                }
                PlusTwoActivated = false;
            }
            else
            {
                p.GiveCard(AvailableCards.DrawCard());
            }
            PassTurn();
        }

        public bool PlusTwoActivated = false;

        private bool IsLegal(Card played)
        {
            if (PlusTwoActivated)
                return played.Value == Value.PlusTwo;
            if (Top.Color == played.Color || Top.Value == played.Value || played.Value == Value.ChangeColor || played.Value == Value.SuperTaki)
                return true;
            
            return false;
            
        }

        public bool IsLegal(LinkedList<Card> sequnce)
        {
            Card first = sequnce.First.Value;

            if (sequnce.Count == 1)
                return IsLegal(first);

            if (PlusTwoActivated)
                return false;

            //if ((first.Value == Value.Taki || first.Value == Value.SuperTaki) && first.Color == Top.Color)
            //{
            //    sequnce.Remove(first);
            //}

            foreach (Card card in sequnce)
                if (card.Color != first.Color)
                    return false;

            return true;
        }

        private int PlusTwosCounter;

        /// <summary>
        /// puts all given cards (assuming that's legal) and applying weird stuff according to the last card
        /// </summary>
        public void MakeTurn(Card[] cards)
        {
            foreach (Card card in cards)
            {
                PlayedCards.InertCard(card);
                Players[Currentturn].cards.Remove(card);
            }

            if (DidPlayerWin())
                return;

            Card maybeWeirdCard = PlayedCards.WhatsOnTop();

            if (maybeWeirdCard.Value == Value.ChangeDirection)
            {
                Direction = -Direction;
            }
            else if (maybeWeirdCard.Value == Value.PlusTwo)
            {
                if (PlusTwoActivated)
                    PlusTwosCounter++;
                else
                    PlusTwosCounter = 1;
                PlusTwoActivated = true;
            }
            else if (maybeWeirdCard.Value == Value.Stop)
            {
                PassTurn();
            }
            else if (maybeWeirdCard.Value == Value.plus)
            {
                return;
            }
            
            PassTurn();

            Top = PlayedCards.WhatsOnTop();
        }
    }
}
