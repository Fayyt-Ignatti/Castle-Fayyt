using System;

namespace Castle_Fayyt
{
  class Program
  {

    public static int FayytXP = 0;
    public static int FayytHP = 500;
    public static string PlayerName = "";


    static void Main(string[] args)
    {
      Castle.SplashScreen();

      RoomDesigns.FayytCastle();

      Console.Write("\n\n\n" +
        "  Welcome to Castle Fayyt." +
        "\nA text adventure with experience." +
        "\n\n  An adventurer - you - has stumbled" +
        "\nupon an ancient text in a dusty tome." +
        "\n\n  On it's yellowed and disintegrating" +
        "\npages reads the history of "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("Fayyt Ignatti"); Console.ResetColor();
      Console.Write("\n -- the fabled last Lady of Castle Fayyt --" +
        "\nlong lost to time and passed into the" +
        "\nrealms of legend and hearsay.");

      Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\n\nPress enter to continue."); Console.ResetColor();
      Console.ReadLine();

      Console.Write("\n" +
        "  On a corner of a page, barely" +
        "\ndiscernible, was a hand-written note:");
      Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("\n\n\tThe "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("Chalice of Riches "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("is safe. " +
        "\n\tHowever hard they search, nobody" +
        "\n\twill find it in my eternal chambers" +
        "\n\tfor I will guard it myself." +
        "\n\tInterlopers-- Be Warned!"); Console.ResetColor();
      Console.Write("\n\n" +
        "  This small note led to years of" +
        "\nresearch as you learned all you could about" +
        "\nCastle Fayyt, the "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("Chalice of Riches"); Console.ResetColor(); Console.Write("," +
          "\nand Lady Fayyt herself.");

      Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\n\nPress enter to continue."); Console.ResetColor();
      Console.ReadLine();

      Console.WriteLine("\n\n" +
        "  Some legends said her castle was burned" +
        "\nto the ground while she screamed to death" +
        "\nwithin its walls; while other legends said" +
        "\ndespite every effort, nothing could destroy" +
        "\nher castle, and she could never be killed.");
      Console.Write("\n\n" +
        "  Despite all the difficulties and setbacks," +
        "\nhere you stand at the entrance of Castle Fayyt." +
        "\nLost to time, purged from memory, but now," +
        "\nwithin your grasp.");

      Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\n\nPress enter to continue."); Console.ResetColor();
      Console.ReadLine();

      Console.Write("\n\n" +
      "  Will you be able to defeat what awaits you?" +
      "\nTo wrest the "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("Chalice of Riches"); Console.ResetColor(); Console.Write(" from the cold grasp" +
        "\nof the creature that once was "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("Fayyt Ignatti"); Console.ResetColor(); Console.Write("? \n\n");

      while (true)
      {
        Console.WriteLine("Please enter a character name:"); Console.ForegroundColor = ConsoleColor.Cyan;
        PlayerName = Console.ReadLine(); Console.ResetColor();

        if (string.IsNullOrEmpty(PlayerName))
        {
          Console.WriteLine("Every hero or heroinne needs a name.");
        }
        else break;
      }

      Console.Write("\n\nWelcome to the game,"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(PlayerName); Console.ResetColor(); Console.Write("." +
        "\n\tTry not to die.\n\n");

      Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\n\nPress enter to begin your adventure."); Console.ResetColor();
      Console.ReadLine();

      Castle.Entrance();
    }
  }
}