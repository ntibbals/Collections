using System;
using Xunit;
using Lab07_Collections;
using Lab07_Collections.Classes;

namespace Deck_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddCard()
        {
            ///Determine if cards are being added to deck
            Deck<Cards> testDeck = new Deck<Cards>();
            Cards card1 = new Cards(Cards.Suits.Hearts, "A");
            Cards card2 = new Cards(Cards.Suits.Hearts, "2");
            Cards card3 = new Cards(Cards.Suits.Hearts, "3");
            testDeck.Add(card1);
            testDeck.Add(card2);
            testDeck.Add(card3);
            int expectedValue = 3;
            Assert.Equal(expectedValue, testDeck.Count());
        }

        [Fact]
        public void TestAddCardPropertySuit()
        {
            ///Determine if cards property for suit is assigned
            Deck<Cards> testDeck = new Deck<Cards>();
            Cards testCard1 = new Cards(Cards.Suits.Spades, "A");
            testDeck.Add(testCard1);
            Assert.Equal(Cards.Suits.Spades, testCard1.Suit);
        }
        [Fact]
        public void TestAddCardPropertyValue()
        {
            ///Determine if cards property for value is assigned
            Deck<Cards> testDeck = new Deck<Cards>();
            Cards testCard1 = new Cards(Cards.Suits.Spades, "Q");
            testDeck.Add(testCard1);
            string expected = "Q";
            Assert.Equal(expected, testCard1.Value);
        }

        [Fact]
        public void TestRemoveCard()
        {
            ///Determine if card can be removed from deck
            Deck<Cards> testDeck = new Deck<Cards>();
            Cards card1 = new Cards(Cards.Suits.Hearts, "A");
            Cards card2 = new Cards(Cards.Suits.Hearts, "2");
            Cards card3 = new Cards(Cards.Suits.Hearts, "3");
            testDeck.Add(card1);
            testDeck.Add(card2);
            testDeck.Add(card3);
            testDeck.Remove(card3);
            testDeck.Remove(card2);
            int expectedValue = 1;
            Assert.Equal(expectedValue, testDeck.Count());
        }

        [Fact]
        public void TestCannotRemoveCardThatNotInDeck()
        {
            ///Determine if card can be removed from deck
            Deck<Cards> testDeck = new Deck<Cards>();
            Cards card1 = new Cards(Cards.Suits.Hearts, "A");
            Cards card2 = new Cards(Cards.Suits.Hearts, "2");
            Cards card3 = new Cards(Cards.Suits.Hearts, "3");
            Cards card7 = new Cards(Cards.Suits.Spades, "J");

            testDeck.Add(card1);
            testDeck.Add(card2);
            testDeck.Add(card3);
            testDeck.Remove(card7);
            int expected = 3;
            Assert.Equal(expected, testDeck.Count());
        }
    }
}
