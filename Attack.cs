using Castle_Fayyt.RNG;
using System;

namespace Castle_Fayyt
{
  internal class Weapon
  {
    public static RandomBag<int> WeaponPool = new RandomBag<int>();

    public static bool Lvl1Instantiated = false;
    public static bool Lvl2Instantiated = false;
    public static bool Lvl3Instantiated = false;
    public static bool Lvl4Instantiated = false;
    public static bool Lvl5Instantiated = false;
    public static bool Lvl6Instantiated = false;
    public static bool Lvl7Instantiated = false;
    public static bool Lvl8Instantiated = false;
    public static bool Lvl9Instantiated = false;
    public static bool Lvl10Instantiated = false;

    public static int Attack()
    {
      switch (Fight.HeroLvl)
      {
        case 1:
          if (Lvl1Instantiated == false)
          {
            var weapon1 = new RandomBag<int>((0, 10), (1, 12), (2, 6), (3, 8), (4, 10), (5, 12), (6, 12), (7, 10),(8, 8), (9, 6), (15, 6));

            WeaponPool = weapon1;
            Lvl1Instantiated = true;
          }

          int RandomPulledInternal = WeaponPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tYou Missed!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          else if (RandomPulledInternal == 15)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Hit!  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\n\nYour attack did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 2:
          if (Lvl2Instantiated == false)
          {
            var weapon2 = new RandomBag<int>((0, 9), (1, 11), (2, 6), (3, 8), (4, 10), (5, 12), (6, 13), (7, 10), (8, 8), (9, 6), (16, 7));

            WeaponPool = weapon2;
            Lvl2Instantiated = true;
          }

          RandomPulledInternal = WeaponPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tYou Missed!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          else if (RandomPulledInternal == 16)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Hit!  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\n\nYour attack did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 3:
          if (Lvl3Instantiated == false)
          {
            var weapon3 = new RandomBag<int>((0, 8), (1, 10), (3, 6), (4, 6), (5, 8), (6, 8), (7, 10), (8, 12), (9, 10), (10, 8), (11, 6), (18, 8));

            WeaponPool = weapon3;
            Lvl3Instantiated = true;
          }

          RandomPulledInternal = WeaponPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tYou Missed!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          else if (RandomPulledInternal == 18)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Hit!  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\n\nYour attack did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 4:
          if (Lvl4Instantiated == false)
          {
            var weapon4 = new RandomBag<int>((0, 7), (1, 10), (4, 5), (5, 5), (6, 6), (7, 8), (8, 9), (9, 10), (10, 12), (11, 10), (12, 8), (20, 10));

            WeaponPool = weapon4;
            Lvl4Instantiated = true;
          }

          RandomPulledInternal = WeaponPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tYou Missed!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          else if (RandomPulledInternal == 20)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Hit!  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\n\nYour attack did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 5:
          if (Lvl5Instantiated == false)
          {
            var weapon5 = new RandomBag<int>((0, 6), (1, 7), (5, 5), (6, 6), (7, 7), (8, 9), (9, 9), (10, 10), (11, 12), (12, 10), (13, 9), (22, 10));

            WeaponPool = weapon5;
            Lvl5Instantiated = true;
          }

          RandomPulledInternal = WeaponPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tYou Missed!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          else if (RandomPulledInternal == 22)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Hit!  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\n\nYour attack did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 6:
          if (Lvl6Instantiated == false)
          {
            var weapon6 = new RandomBag<int>((0, 5), (1, 6), (6, 4), (7, 5), (8, 6), (9, 8), (10, 10), (11, 12), (12, 14), (13, 10), (14, 9), (24, 11));

            WeaponPool = weapon6;
            Lvl6Instantiated = true;
          }

          RandomPulledInternal = WeaponPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tYou Missed!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          else if (RandomPulledInternal == 24)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Hit!  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\n\nYour attack did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 7:
          if (Lvl7Instantiated == false)
          {
            var weapon7 = new RandomBag<int>((0, 4), (1, 6), (7, 4), (8, 5), (9, 6), (10, 7), (11, 10), (12, 10), (13, 12), (14, 14), (15, 10), (26, 12));

            WeaponPool = weapon7;
            Lvl7Instantiated = true;
          }

          RandomPulledInternal = WeaponPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tYou Missed!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          else if (RandomPulledInternal == 26)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Hit!  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\n\nYour attack did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 8:
          if (Lvl8Instantiated == false)
          {
            var weapon8 = new RandomBag<int>((0, 3), (1, 3), (8, 4), (9, 4), (10, 5), (11, 6), (12, 8), (13, 12), (14, 14), (15, 16), (16, 12), (29, 13));

            WeaponPool = weapon8;
            Lvl8Instantiated = true;
          }

          RandomPulledInternal = WeaponPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tYou Missed!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          else if (RandomPulledInternal == 29)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Hit!  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\n\nYour attack did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 9:
          if (Lvl9Instantiated == false)
          {
            var weapon9 = new RandomBag<int>((0, 2), (1, 2), (9, 4), (10, 5), (11, 8), (12, 9), (13, 11), (14, 13), (15, 14), (16, 10), (17, 8), (32, 14));

            WeaponPool = weapon9;
            Lvl9Instantiated = true;
          }

          RandomPulledInternal = WeaponPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tYou Missed!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          else if (RandomPulledInternal == 32)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Hit!  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\n\nYour attack did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 10:
          if (Lvl10Instantiated == false)
          {
            var weapon10 = new RandomBag<int>((0, 2), (1, 2), (10, 4), (11, 4), (12, 5), (13, 6), (14, 8), (15, 10), (16, 13), (17, 15), (18, 8), (19, 8), (35, 15));

            WeaponPool = weapon10;
            Lvl10Instantiated = true;
          }

          RandomPulledInternal = WeaponPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\n\tYou Missed!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          else if (RandomPulledInternal == 35)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Hit!  "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\n\nYour attack did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;
      }
      return 0;
    }
  }
}