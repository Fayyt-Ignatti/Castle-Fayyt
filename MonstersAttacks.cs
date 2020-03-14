﻿using Castle_Fayyt.RNG;
using System;

namespace Castle_Fayyt
{
  internal class M6Attacks
  {
    private static readonly RandomBag<int> m6Claws = new RandomBag<int>();
    private static readonly RandomBag<int> m6Bite = new RandomBag<int>();

    public static int M6Damage()
    {
      bool M6Instantiated = false;
      if (M6Instantiated == false)
      {
        m6Claws.AddEntry(0, 10);
        m6Claws.AddEntry(1, 10);
        m6Claws.AddEntry(8, 19);
        m6Claws.AddEntry(12, 30);
        m6Claws.AddEntry(16, 19);
        m6Claws.AddEntry(20, 10);
        m6Claws.AddEntry(50, 2);
        m6Bite.AddEntry(0, 8);
        m6Bite.AddEntry(1, 7);
        m6Bite.AddEntry(5, 10);
        m6Bite.AddEntry(7, 30);
        m6Bite.AddEntry(9, 22);
        m6Bite.AddEntry(11, 18);
        m6Bite.AddEntry(20, 5);
        M6Instantiated = true;
      }

      Random M6Choice = new Random();
      int choose = M6Choice.Next(1, 4);

      if (choose == 1 || choose == 2)
      {
        int RandomPulledInternal = m6Bite.GetRandom();
        if (RandomPulledInternal == 0)
        {
          Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("\n\tThe monster missed."); Console.ResetColor();
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("\nThe monster BIT you for "); Console.ForegroundColor = ConsoleColor.Red; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write(" damage."); Console.ResetColor();
        }
        Fight.HeroHP -= RandomPulledInternal;
        Console.Write("\nYou have {0} hit points remaining.", Fight.HeroHP);
        return 1;
      }
      if (choose == 3)
      {
        int RandomPulledInternal = m6Claws.GetRandom();
        if (RandomPulledInternal == 0)
        {
          Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("\n\tThe monster missed."); Console.ResetColor();
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("\nThe monster hit you with his CLAWS for "); Console.ForegroundColor = ConsoleColor.Red; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write(" damage."); Console.ResetColor();
        }
        Fight.HeroHP -= RandomPulledInternal;
        Console.Write("\nYou have {0} hit points remaining.", Fight.HeroHP);
        return 3;
      }
      return 0;
    }
  }
}