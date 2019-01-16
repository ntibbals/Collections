using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Deck<T, P1, P2> : IEnumerable<T>
    {

        T[] cardDeck = new T[10];

        P1[] PlayerOne = new P1[5];
        P2[] PlayerTwo = new P2[5];
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
            if (currentIndex < cardDeck.Length)
            {
                Array.Resize(ref cardDeck, cardDeck.Length - 1);
            }
            cardDeck[currentIndex] != card;
            currentIndex++;

        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return cardDeck[i];

            }
        }
        public IEnumerator<P1> GetEnumeratorP1()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return PlayerOne[i];

            }
        }
        public IEnumerator<P2> GetEnumeratorP2()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return PlayerTwo[i];

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
