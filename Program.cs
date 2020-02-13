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
      var deck = new List<string>();


      for (var i = 0; i < suit.Count; i++)
      {
        for (var n = 0; n < face.Count; n++)
        {
          var card = face[n] + " " + suit[i];
          deck.Add(card);
        };
        Console.WriteLine(deck);
      }



    }

    private static object newList<T>()
    {
      throw new NotImplementedException();
    }
  }
}
//for shuffle
//  Random random1 = new Random();
//       string[] suit = { "spades", "diamonds", "clubs", "hearts" };
//       string[] face = { "ace", "2", "3" };

//       int randomSuit = random1.Next(suit.Length);
//       int randomFace = random1.Next(face.Length);
