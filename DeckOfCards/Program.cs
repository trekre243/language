using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();

            Player trevor = new Player("Trevor");
            for(int i = 0; i < 7; i++)
            {
                trevor.Draw(deck);
            }

            foreach(Card card in trevor.Hand)
            {
                Console.WriteLine($"{card.StringVal} of {card.Suit}");
            }
            int handSize = trevor.Hand.Count;
            for(int i = 0; i < handSize; i++)
            {
                Card card = trevor.Discard(0);
                Console.WriteLine($"{card.StringVal} of {card.Suit}");
            }
            Console.WriteLine(trevor.Hand.Count);
        }
    }

    class Card
    {
        private string stringVal;
        private string suit;
        private int val;

        public string StringVal
        {
            get { return this.stringVal; }
        }

        public string Suit
        {
            get { return this.suit; }
        }

        public int Val
        {
            get { return this.val; }
        }

        public Card(string stringVal, string suit)
        {
            this.stringVal = stringVal;
            this.suit = suit;

            switch(stringVal)
            {
                case "Ace":
                    this.val = 13;
                    break;
                case "King":
                    this.val = 12;
                    break;
                case "Queen":
                    this.val = 11;
                    break;
                case "Jack":
                    this.val = 10;
                    break;
                default:
                    this.val = Int32.Parse(stringVal) - 1;
                    break;
            }
        }

        public Card(int val, string suit)
        {
            this.val = val;
            this.suit = suit;

            switch(val)
            {
                case 13:
                    this.stringVal = "Ace";
                    break;
                case 12:
                    this.stringVal = "King";
                    break;
                case 11:
                    this.stringVal = "Queen";
                    break;
                case 10:
                    this.stringVal = "Jack";
                    break;
                default:
                    this.stringVal = (val + 1).ToString();
                    break;
            }
        }
    }

    class Deck
    {
        private List<Card> cards;

        public List<Card> Cards
        {
            get { return this.cards; }
        }
        
        public Deck()
        {
            this.cards = new List<Card>();
            this.Reset();
        }

        public Card Deal()
        {
            Card removedCard = this.cards[this.cards.Count - 1];
            this.cards.RemoveAt(this.cards.Count - 1);
            return removedCard;
        }

        public void Reset()
        {
            foreach(string suit in new string[] {"Hearts", "Diamonds", "Clubs", "Spades"})
            {
                for(int val = 1; val <= 13; val++)
                {
                    this.cards.Add(new Card(val, suit));
                }
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for(int shufflePasses = 0; shufflePasses < 10; shufflePasses++)
            {
                for(int i = 0; i < this.cards.Count; i++)
                {
                    int swapIndex = rand.Next(this.cards.Count);
                    Card temp = this.cards[swapIndex];
                    this.cards[swapIndex] = this.cards[i];
                    this.cards[i] = temp;
                }
            }
        }
    }

    class Player
    {
        private string name;
        private List<Card> hand;

        public string Name
        {
            get { return this.name; }
        }

        public List<Card> Hand
        {
            get { return this.hand; }
        }

        public Player(string name)
        {
            this.name = name;
            this.hand = new List<Card>();
        }

        public Card Draw(Deck deck)
        {
            Card drawnCard = deck.Deal();
            this.hand.Add(drawnCard);
            return drawnCard;
        }

        public Card Discard(int index)
        {
            if(index < 0 || index > this.hand.Count)
            {
                return null;
            }
            Card discardedCard = this.hand[index];
            this.hand.RemoveAt(index);
            return discardedCard;
        }
    }
}
