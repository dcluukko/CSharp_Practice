using System;

class HotelCost
{
  static void Main()
  {
    Console.WriteLine("In what season are you booking a stay?");
    string season = Console.ReadLine();

    Console.WriteLine("On the weekend or weeknight?");
    string dayOfWeek = Console.ReadLine();

    bool summer = season == "summer";
    bool weekend = dayOfWeek == "weekend";

    if (summer && weekend)
    {
      Console.WriteLine("Your stay is probably going to be expensive. It's both peak travel season AND the weekend");
    }
    else if (summer || weekend)
    {
      Console.WriteLine("yo yo mad billz for rillz");
    }
    else if (!(summer || weekend))
    {
      Console.WriteLine("You will be swimming in green. THis ish is hella cheapsies");
    }
    else
    {
      Console.WriteLine("Your stay might be expensive, but it could be worse lolololol!");
    }
  }
}