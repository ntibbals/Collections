using System;
using Lab07_Collections.Classes;

namespace Lab07_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CreateDeck();
            Console.ReadLine();
            
        }

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
            Console.WriteLine("___________________________");

            Console.WriteLine($"Current count:{myDeck.Count()}");

            Console.WriteLine("___________________________");

            Console.WriteLine($"Removing face values: {card12.Suit} = {card13.Value} : {card12.Value} : {card11.Value} : {card1.Value} ");

            myDeck.Remove(card12);
            myDeck.Remove(card13);
            myDeck.Remove(card11);
            myDeck.Remove(card1);
            //newDeck = myDeck.Remove(card12);
            //newDeck = myDeck.Remove(card11);
            //newDeck = myDeck.Remove(card1);
            Console.WriteLine($"Current count:{myDeck.Count()}");
            foreach (Cards card in myDeck)
            {
                if (card != null)
                {
                    Console.WriteLine($"{card.Value} of {card.Suit}");
                }
            }
            Console.WriteLine("___________________________");




        }


    }
}
