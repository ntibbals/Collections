using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab07_Collections.Classes
{
    public class Deck<T> : IEnumerable<T>, IEnumerable
    {

        /// <summary>
        /// Collection container for each deck of cards
        /// </summary>
        T[] cardDeck = new T[10];
        /// <summary>
        /// Holds count for current index
        /// </summary>
        int currentIndex = 0;
        /// <summary>
        /// Holds count for current total cards in deck
        /// </summary>
        int count = 0;
        /// <summary>
        /// Returns count when called
        /// </summary>
        /// <returns>current count</returns>
        public int Count()
        {
            return count;
        }
        /// <summary>
        /// Adds a card to the deck
        /// </summary>
        /// <param name="card">card to add</param>
        public void Add(T card)
        {
            if (currentIndex > cardDeck.Length -1)
            {
                Array.Resize(ref cardDeck, cardDeck.Length + 5); /// resizes list as needed
            }

            cardDeck[currentIndex] = card; /// places card in container accordingly
            currentIndex++; ///counts current index
            count++; //adds to running counter for total amoutn of cards in deck
        }

        /// <summary>
        /// Removes a given card from deck
        /// </summary>
        /// <param name="card">card to remove</param>
        /// <returns>updated deck of cards</returns>
        public T[] Remove(T card)
        {

            if (cardDeck.Contains(card)) /// ensures card is in deck before running
            {
                count--; ///removes count from current total
                for (int i = 0; i < cardDeck.Length; i++)
                {
                    if (cardDeck[i].Equals(card))///finds position of given card
                    {
                        int index = Array.IndexOf(cardDeck, card); ///identifies index position
                        T[] tempDeck = cardDeck.Where((element, j) => j != index).ToArray(); /// instantiates a new array based on removing of card based on index position
                        Array.Copy(tempDeck, cardDeck, tempDeck.Length); /// copies the placeholder into the deck
                        return cardDeck; 
                    }
                }
            }

                return cardDeck; /// if card doesn't exist, just return the deck
       
        }

        /// <summary>
        /// enumerator interface to do black magic on enumerator with yield return
        /// </summary>
        /// <returns>each cardDeck position in the background through "yield"</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return cardDeck[i];

            }
        }

        /// <summary>
        /// Finds the enumerator
        /// </summary>
        /// <returns>Enumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
