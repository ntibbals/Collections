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
    }
}
