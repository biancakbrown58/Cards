namespace Cards
{
  public class Card
  {
    // Properties
    // rank
    public string Face { get; set; }
    // suit
    public string Suit { get; set; }
    // color
    public string ColorOfTheCard { get; set; }


    // Method
    public string DisplayCard()
    {
      return $"{Face} of {Suit}";
    }

    public int GetCardValue()
    {
      if (Face == "ace")
      {
        return 11;
      }
      else if (Face == "queen" || Face == "king" || Face == "jack")
      {
        return 10;
      }
      else
      {
        return int.Parse(Face);
      }
    }
  }
}