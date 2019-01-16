using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Container<T> 
    {

        T[] cardDeck = new T[10];
        int currentIndex = 0;

        public void Add(T card)
        {
            if (currentIndex > cardDeck.Length -1)
            {
                Array.Resize(ref cardDeck, cardDeck.Length * 2);
            }

            cardDeck[currentIndex] = card;
            currentIndex++;
        }
    }
}
