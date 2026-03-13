using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Blackjack.Lib.UnitTests
{
    [TestClass]
    public class HandTestsUS
    {
        /// <summary>
        /// Testet, dass eine Hand mit den Karten 2, 3 und 7 den Wert 12 zurückgibt.
        /// </summary>
        [TestMethod]
        public void TestHandValue_CardsAddUpToTwelve()
        {
            // Arrange
            Hand hand = new Hand();
            hand.AddCard(new Card(CardSuit.Diamond, CardValue.Two));
            hand.AddCard(new Card(CardSuit.Spade, CardValue.Three));
            hand.AddCard(new Card(CardSuit.Club, CardValue.Seven));

            // Act
            int actual = hand.CalculateValue();

            // Assert
            Assert.AreEqual(12, actual);
        }

        /// <summary>
        /// Testet, dass eine Hand mit 2 und Jack den Wert 12 zurückgibt.
        /// </summary>
        [TestMethod]
        public void TestHandValue_TwoAndFaceCard_ReturnsTwelve()
        {
            // Arrange
            Hand hand = new Hand();
            hand.AddCard(new Card(CardSuit.Heart, CardValue.Two));
            hand.AddCard(new Card(CardSuit.Diamond, CardValue.Jack));

            // Act
            int actual = hand.CalculateValue();

            // Assert
            Assert.AreEqual(12, actual);
        }

        /// <summary>
        /// Testet, dass eine Hand mit 2, 10 und Ace (Ace zählt als 1) den Wert 13 zurückgibt.
        /// </summary>
        [TestMethod]
        public void TestHandValue_WithAceCountingAsOne_ReturnsThirteen()
        {
            // Arrange
            Hand hand = new Hand();
            hand.AddCard(new Card(CardSuit.Diamond, CardValue.Two));
            hand.AddCard(new Card(CardSuit.Spade, CardValue.Ten));
            hand.AddCard(new Card(CardSuit.Club, CardValue.Ace));

            // Act
            int actual = hand.CalculateValue();

            // Assert
            Assert.AreEqual(13, actual);
        }

        /// <summary>
        /// Testet, dass eine Hand mit Ace, 10 und 2 (Ace zählt als 1) den Wert 13 zurückgibt.
        /// </summary>
        [TestMethod]
        public void TestHandValue_AceFirstWithTenAndTwo_ReturnsThirteen()
        {
            // Arrange
            Hand hand = new Hand();
            hand.AddCard(new Card(CardSuit.Heart, CardValue.Ace));
            hand.AddCard(new Card(CardSuit.Club, CardValue.Ten));
            hand.AddCard(new Card(CardSuit.Spade, CardValue.Two));

            // Act
            int actual = hand.CalculateValue();

            // Assert
            Assert.AreEqual(13, actual);
        }

        /// <summary>
        /// Testet, dass eine Hand mit Ace, 9 und Ace den Wert 21 zurückgibt (Blackjack).
        /// </summary>
        [TestMethod]
        public void TestHandValue_AceNineAndAce_ReturnsTwentyOne()
        {
            // Arrange
            Hand hand = new Hand();
            hand.AddCard(new Card(CardSuit.Spade, CardValue.Ace));
            hand.AddCard(new Card(CardSuit.Diamond, CardValue.Nine));
            hand.AddCard(new Card(CardSuit.Club, CardValue.Ace));

            // Act
            int actual = hand.CalculateValue();

            // Assert
            Assert.AreEqual(21, actual);
        }

        /// <summary>
        /// Testet, dass eine Hand mit Ace, 8, Jack und Ace den Wert 20 zurückgibt.
        /// </summary>
        [TestMethod]
        public void TestHandValue_MultipleAces_ReturnsTwenty()
        {
            // Arrange
            Hand hand = new Hand();
            hand.AddCard(new Card(CardSuit.Club, CardValue.Ace));
            hand.AddCard(new Card(CardSuit.Diamond, CardValue.Eight));
            hand.AddCard(new Card(CardSuit.Heart, CardValue.Jack));
            hand.AddCard(new Card(CardSuit.Spade, CardValue.Ace));

            // Act
            int actual = hand.CalculateValue();

            // Assert
            Assert.AreEqual(20, actual);
        }

        /// <summary>
        /// Testet, dass eine Hand mit fünf Aces den Wert 15 zurückgibt (alle außer einem zählen als 1).
        /// </summary>
        [TestMethod]
        public void TestHandValue_FiveAces_ReturnsFifteen()
        {
            // Arrange
            Hand hand = new Hand();
            hand.AddCard(new Card(CardSuit.Heart, CardValue.Ace));
            hand.AddCard(new Card(CardSuit.Diamond, CardValue.Ace));
            hand.AddCard(new Card(CardSuit.Spade, CardValue.Ace));
            hand.AddCard(new Card(CardSuit.Club, CardValue.Ace));
            hand.AddCard(new Card(CardSuit.Diamond, CardValue.Ace));

            // Act
            int actual = hand.CalculateValue();

            // Assert
            Assert.AreEqual(15, actual);
        }

        /// <summary>
        /// Testet, dass eine Hand mit Ace und King den Wert 21 zurückgibt (natürlicher Blackjack).
        /// </summary>
        [TestMethod]
        public void TestHandValue_AceAndKing_ReturnsTwentyOne()
        {
            // Arrange
            Hand hand = new Hand();
            hand.AddCard(new Card(CardSuit.Heart, CardValue.Ace));
            hand.AddCard(new Card(CardSuit.Spade, CardValue.King));

            // Act
            int actual = hand.CalculateValue();

            // Assert
            Assert.AreEqual(21, actual);
        }

        /// <summary>
        /// Testet, dass eine Hand mit 10, 9 und 5 den Wert 24 zurückgibt (Bust).
        /// </summary>
        [TestMethod]
        public void TestHandValue_BustHand_ReturnsTwentyFour()
        {
            // Arrange
            Hand hand = new Hand();
            hand.AddCard(new Card(CardSuit.Diamond, CardValue.Ten));
            hand.AddCard(new Card(CardSuit.Heart, CardValue.Nine));
            hand.AddCard(new Card(CardSuit.Club, CardValue.Five));

            // Act
            int actual = hand.CalculateValue();

            // Assert
            Assert.AreEqual(24, actual);
        }

        /// <summary>
        /// Testet, dass eine Hand mit fünf Karten (5, 4, 6, 3, 3) den Wert 21 zurückgibt.
        /// </summary>
        [TestMethod]
        public void TestHandValue_FiveCardHand_ReturnsTwentyOne()
        {
            // Arrange
            Hand hand = new Hand();
            hand.AddCard(new Card(CardSuit.Diamond, CardValue.Five));
            hand.AddCard(new Card(CardSuit.Spade, CardValue.Four));
            hand.AddCard(new Card(CardSuit.Club, CardValue.Six));
            hand.AddCard(new Card(CardSuit.Spade, CardValue.Three));
            hand.AddCard(new Card(CardSuit.Heart, CardValue.Three));

            // Act
            int actual = hand.CalculateValue();

            // Assert
            Assert.AreEqual(21, actual);
        }
    }
}