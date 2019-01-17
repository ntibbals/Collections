using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab07_Collections.Classes
{
    public class Deck<T> : IEnumerable<T>, IEnumerable
    {

        T[] cardDeck = new T[10];
        T[] PlayerOne = new T[5];
        T[] PlayerTwo = new T[5];

        int currentIndex = 0;
        int count = 0;
        public int Count()
        {
            return count;
        }
        public void Add(T card)
        {
            if (currentIndex > cardDeck.Length -1)
            {
                Array.Resize(ref cardDeck, cardDeck.Length * 2);
            }

            cardDeck[currentIndex] = card;
            currentIndex++;
            count++;
        }

        public T[] Remove(T card)
        {
            count--;
            int counter = 0;
            for (int i = 1; i < cardDeck.Length; i++)
            {
                counter++;
                if (cardDeck[i].Equals(card))
                {
                    break;
                }
            }
            T[] tempDeck = cardDeck.Where((element, j) => j != counter).ToArray();
            Array.Copy(tempDeck, cardDeck, tempDeck.Length);
            return cardDeck;
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
