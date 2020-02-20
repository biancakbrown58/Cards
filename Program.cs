using System;
using System.Collections.Generic;

namespace Cards
{
  class Program
  {
    static void Main(string[] args)
    {

      var suit = new List<string> { "spades", "diamonds", "clubs", "hearts" };
      var face = new List<string> { "ace", "2", "3", "4", "5", "6", "7", "8", "9", "jack", "queen", "king" };
      var deck = new List<Card>();


      for (var i = 0; i < suit.Count; i++)
      {
        for (var n = 0; n < face.Count; n++)
        {
          var card = new Card();
          card.Face = face[n];
          card.Suit = suit[i];
          deck.Add(card);
        }

        // Console.WriteLine(deck);
      }

      for (int i = deck.Count - 1; i >= 1; i--)
      {
        var n = new Random().Next(i);
        var temp = deck[n];
        deck[n] = deck[i];
        deck[i] = temp;
      }
      var playerHand = new List<Card>();
      Console.WriteLine($"Your first card is {deck[0].Face} of {deck[0].Suit}");

      playerHand.Add(deck[0]);
      deck.RemoveAt(0);

      var isRunning = true;
      while (isRunning)
      {
        Console.WriteLine("hit enter to view next card or quit to end");
        var input = Console.ReadLine().ToLower();
        if (input == "")
        {
          Console.WriteLine($"Your next card is {deck[0].Face} of {deck[0].Suit}");
          playerHand.Add(deck[0]);
          deck.RemoveAt(0);
        }
        else if (input == "quit")
        {
          isRunning = false;
        }

      }
    }
  }
}


