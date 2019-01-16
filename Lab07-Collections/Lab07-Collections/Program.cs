using System;
using Lab07_Collections.Classes;

namespace Lab07_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Container<string> myDeck = new Container<string>();

            myDeck.Add("King");
            myDeck.Add("Queen");
            myDeck.Add("Jack");

            foreach(string card in myDeck)
            {
                Console.WriteLine(card);
            }
        }
    }
}
