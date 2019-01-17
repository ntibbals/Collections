using System;
using Lab07_Collections.Classes;

namespace Lab07_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Casino!");
            CreateDeck();
            Deal();
            Console.ReadLine();
            
        }

        /// <summary>
        /// Instantiates Initial example deck
        /// </summary>
        public static void CreateDeck()
        {
            Deck<Cards> myDeck = new Deck<Cards>();
            Cards card1 = new Cards(Cards.Suits.Hearts, "A");
            Cards card2 = new Cards(Cards.Suits.Hearts, "2");
            Cards card3 = new Cards(Cards.Suits.Hearts, "3");
            Cards card4 = new Cards(Cards.Suits.Hearts, "4");
            Cards card5 = new Cards(Cards.Suits.Hearts, "5");
            Cards card6 = new Cards(Cards.Suits.Hearts, "6");
            Cards card7 = new Cards(Cards.Suits.Hearts, "7");
            Cards card8 = new Cards(Cards.Suits.Hearts, "8");
            Cards card9 = new Cards(Cards.Suits.Hearts, "9");
            Cards card10 = new Cards(Cards.Suits.Hearts, "10");
            Cards card11 = new Cards(Cards.Suits.Hearts, "J");
            Cards card12 = new Cards(Cards.Suits.Hearts, "Q");
            Cards card13 = new Cards(Cards.Suits.Hearts, "K");

            myDeck.Add(card1);
            myDeck.Add(card2);
            myDeck.Add(card3);
            myDeck.Add(card4);
            myDeck.Add(card5);
            myDeck.Add(card6);
            myDeck.Add(card7);
            myDeck.Add(card8);
            myDeck.Add(card9);
            myDeck.Add(card10);
            myDeck.Add(card11);
            myDeck.Add(card12);
            myDeck.Add(card13);

            foreach (Cards card in myDeck)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }
            Console.WriteLine($"Current count:{myDeck.Count()}");

            Console.WriteLine("_______________________________________________________________________________");

            Console.WriteLine($"Removing face values: {card12.Suit} = {card13.Value} : {card12.Value} : {card11.Value} : {card1.Value} ");

            myDeck.Remove(card12);
            myDeck.Remove(card13);
            myDeck.Remove(card11);
            myDeck.Remove(card1);
            Console.WriteLine($"Current count:{myDeck.Count()}");
            foreach (Cards card in myDeck)
            {
                if (card != null)
                {
                    Console.WriteLine($"{card.Value} of {card.Suit}");
                }
            }
            Console.WriteLine("_______________________________________________________________________________");
        }

        /// <summary>
        /// Deals cards
        /// </summary>
        public static void Deal()
        {

            Deck<Cards> dealer = new Deck<Cards>();
            Deck<Cards> p1 = new Deck<Cards>();
            Deck<Cards> p2 = new Deck<Cards>();

            Cards card1 = new Cards(Cards.Suits.Spades, "A");
            Cards card2 = new Cards(Cards.Suits.Clubs, "2");
            Cards card3 = new Cards(Cards.Suits.Clubs, "3");
            Cards card4 = new Cards(Cards.Suits.Hearts, "4");
            Cards card5 = new Cards(Cards.Suits.Diamonds, "5");
            Cards card6 = new Cards(Cards.Suits.Diamonds, "6");
            Cards card7 = new Cards(Cards.Suits.Diamonds, "7");
            Cards card8 = new Cards(Cards.Suits.Diamonds, "8");
            Cards card9 = new Cards(Cards.Suits.Diamonds, "9");
            Cards card10 = new Cards(Cards.Suits.Spades, "10");
            Cards card11 = new Cards(Cards.Suits.Spades, "J");
            Cards card12 = new Cards(Cards.Suits.Spades, "Q");
            Cards card13 = new Cards(Cards.Suits.Spades, "K");

            dealer.Add(card1);
            dealer.Add(card2);
            dealer.Add(card3);
            dealer.Add(card4);
            dealer.Add(card5);
            dealer.Add(card6);
            dealer.Add(card7);
            dealer.Add(card8);
            dealer.Add(card9);
            dealer.Add(card10);
            dealer.Add(card11);
            dealer.Add(card12);
            dealer.Add(card13);

            Console.WriteLine($"Player 1 Deck: {p1.Count()}");
            Console.WriteLine($"Player 1 Deck: {p2.Count()}");
            Console.Write("Dealer");
            foreach (Cards card in dealer)
            {
                Console.Write($" ~ {card.Value} of {card.Suit} ~ ");
            }
            Console.WriteLine();
            Console.WriteLine("_______________________________________________________________________________");
            Console.WriteLine("Distributing deck....");

            dealer.Remove(card1);
            dealer.Remove(card10);
            dealer.Remove(card11);
            dealer.Remove(card12);
            dealer.Remove(card13);

            p1.Add(card1);
            p1.Add(card10);
            p1.Add(card11);
            p1.Add(card12);
            p1.Add(card13);

            dealer.Remove(card5);
            dealer.Remove(card6);
            dealer.Remove(card7);
            dealer.Remove(card8);
            dealer.Remove(card9);

            p2.Add(card5);
            p2.Add(card6);
            p2.Add(card7);
            p2.Add(card8);
            p2.Add(card9);
            Console.Write($"Player One");
            foreach (Cards card in p1)
            {
                if (card != null)
                {
                    Console.Write($" ~ {card.Value} of {card.Suit}");
                }
            }
            Console.WriteLine();
            Console.Write($"Player Two");
            foreach (Cards card in p2)
            {
                if (card != null)
                {
                    Console.Write($" ~ {card.Value} of {card.Suit}");
                }
            }
            Console.WriteLine();
            Console.Write($"Dealer");
            foreach (Cards card in dealer)
            {
                if (card != null)
                {
                    Console.Write($" ~ {card.Value} of {card.Suit}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("_______________________________________________________________________________");

        }

    }
}
