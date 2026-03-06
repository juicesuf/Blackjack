using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Blackjack.Lib.UnitTests
{
    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void TestCalculateValue()
        {
                Hand hand = new Hand();
                hand.AddCard(Factory.CreateCard(CardSuit.Club, CardValue.Five));
                hand.AddCard(Factory.CreateCard(CardSuit.Heart, CardValue.Nine));
            
                int value = hand.CalculateValue();

                Assert.AreEqual(14, value);

        }

        [TestMethod]
        public void TestHandStatus()
        {
            Hand hand = new Hand();
            hand.AddCard(Factory.CreateCard(CardSuit.Club, CardValue.Five));
            hand.AddCard(Factory.CreateCard(CardSuit.Heart, CardValue.Nine));

            int value = hand.CalculateValue();

            Assert.AreEqual(HandStatus.Safe, hand.Status);
        }

        [TestMethod]
        public void TestCalculateValue_WithAce()
        {
            Hand hand = new Hand();
            hand.AddCard(Factory.CreateCard(CardSuit.Diamond, CardValue.Ace));
            hand.AddCard(Factory.CreateCard(CardSuit.Spade, CardValue.Nine));

            int value = hand.CalculateValue();

            Assert.AreEqual(20, value);
        }
    }
    
}
