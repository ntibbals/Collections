using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Deck<T> : IEnumerable<T>, IEnumerable
    {

        T[] cardDeck = new T[10];
        T[] PlayerOne = new T[5];
        T[] PlayerTwo = new T[5];

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

        public void Remove(T card)
        {
            int counter = 0;
            for (int i = 0; i < cardDeck.Length; i++)
            {
                counter++;
                if (cardDeck[i].Equals(card))
                {

                }
            }

        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return cardDeck[i];

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
