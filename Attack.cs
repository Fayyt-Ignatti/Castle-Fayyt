using System;

namespace Castle_Fayyt
{
  class Weapon
  {
    public static RandomAttackPool<int> WeaponPool = new RandomAttackPool<int>();

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
            RandomAttackPool<int> Weapon1 = new RandomAttackPool<int>();
            Weapon1.AddEntry(0, 10);
            Weapon1.AddEntry(1, 12);
            Weapon1.AddEntry(2, 6);
            Weapon1.AddEntry(3, 8);
            Weapon1.AddEntry(4, 10);
            Weapon1.AddEntry(5, 12);
            Weapon1.AddEntry(6, 12);
            Weapon1.AddEntry(7, 10);
            Weapon1.AddEntry(8, 8);
            Weapon1.AddEntry(9, 6);
            Weapon1.AddEntry(15, 6);

            WeaponPool = Weapon1;
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
            RandomAttackPool<int> Weapon2 = new RandomAttackPool<int>();
            Weapon2.AddEntry(0, 9);
            Weapon2.AddEntry(1, 11);
            Weapon2.AddEntry(2, 6);
            Weapon2.AddEntry(3, 8);
            Weapon2.AddEntry(4, 10);
            Weapon2.AddEntry(5, 12);
            Weapon2.AddEntry(6, 13);
            Weapon2.AddEntry(7, 10);
            Weapon2.AddEntry(8, 8);
            Weapon2.AddEntry(9, 6);
            Weapon2.AddEntry(16, 7);

            WeaponPool = Weapon2;
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
            RandomAttackPool<int> Weapon3 = new RandomAttackPool<int>();
            Weapon3.AddEntry(0, 8);
            Weapon3.AddEntry(1, 10);
            Weapon3.AddEntry(3, 6);
            Weapon3.AddEntry(4, 6);
            Weapon3.AddEntry(5, 8);
            Weapon3.AddEntry(6, 8);
            Weapon3.AddEntry(7, 10);
            Weapon3.AddEntry(8, 12);
            Weapon3.AddEntry(9, 10);
            Weapon3.AddEntry(10, 8);
            Weapon3.AddEntry(11, 6);
            Weapon3.AddEntry(18, 8);

            WeaponPool = Weapon3;
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
            RandomAttackPool<int> Weapon4 = new RandomAttackPool<int>();
            Weapon4.AddEntry(0, 7);
            Weapon4.AddEntry(1, 10);
            Weapon4.AddEntry(4, 5);
            Weapon4.AddEntry(5, 5);
            Weapon4.AddEntry(6, 6);
            Weapon4.AddEntry(7, 8);
            Weapon4.AddEntry(8, 9);
            Weapon4.AddEntry(9, 10);
            Weapon4.AddEntry(10, 12);
            Weapon4.AddEntry(11, 10);
            Weapon4.AddEntry(12, 8);
            Weapon4.AddEntry(20, 10);

            WeaponPool = Weapon4;
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
            RandomAttackPool<int> Weapon5 = new RandomAttackPool<int>();
            Weapon5.AddEntry(0, 6);
            Weapon5.AddEntry(1, 7);
            Weapon5.AddEntry(5, 5);
            Weapon5.AddEntry(6, 6);
            Weapon5.AddEntry(7, 7);
            Weapon5.AddEntry(8, 9);
            Weapon5.AddEntry(9, 9);
            Weapon5.AddEntry(10, 10);
            Weapon5.AddEntry(11, 12);
            Weapon5.AddEntry(12, 10);
            Weapon5.AddEntry(13, 9);
            Weapon5.AddEntry(22, 10);

            WeaponPool = Weapon5;
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
            RandomAttackPool<int> Weapon6 = new RandomAttackPool<int>();
            Weapon6.AddEntry(0, 5);
            Weapon6.AddEntry(1, 6);
            Weapon6.AddEntry(6, 4);
            Weapon6.AddEntry(7, 5);
            Weapon6.AddEntry(8, 6);
            Weapon6.AddEntry(9, 8);
            Weapon6.AddEntry(10, 10);
            Weapon6.AddEntry(11, 12);
            Weapon6.AddEntry(12, 14);
            Weapon6.AddEntry(13, 10);
            Weapon6.AddEntry(14, 9);
            Weapon6.AddEntry(24, 11);

            WeaponPool = Weapon6;
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
            RandomAttackPool<int> Weapon7 = new RandomAttackPool<int>();
            Weapon7.AddEntry(0, 4);
            Weapon7.AddEntry(1, 6);
            Weapon7.AddEntry(7, 4);
            Weapon7.AddEntry(8, 5);
            Weapon7.AddEntry(9, 6);
            Weapon7.AddEntry(10, 7);
            Weapon7.AddEntry(11, 10);
            Weapon7.AddEntry(12, 10);
            Weapon7.AddEntry(13, 12);
            Weapon7.AddEntry(14, 14);
            Weapon7.AddEntry(15, 10);
            Weapon7.AddEntry(26, 12);

            WeaponPool = Weapon7;
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
            RandomAttackPool<int> Weapon8 = new RandomAttackPool<int>();
            Weapon8.AddEntry(0, 3);
            Weapon8.AddEntry(1, 3);
            Weapon8.AddEntry(8, 4);
            Weapon8.AddEntry(9, 4);
            Weapon8.AddEntry(10, 5);
            Weapon8.AddEntry(11, 6);
            Weapon8.AddEntry(12, 8);
            Weapon8.AddEntry(13, 12);
            Weapon8.AddEntry(14, 14);
            Weapon8.AddEntry(15, 16);
            Weapon8.AddEntry(16, 12);
            Weapon8.AddEntry(29, 13);

            WeaponPool = Weapon8;
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
            RandomAttackPool<int> Weapon9 = new RandomAttackPool<int>();
            Weapon9.AddEntry(0, 2);
            Weapon9.AddEntry(1, 2);
            Weapon9.AddEntry(9, 4);
            Weapon9.AddEntry(10, 5);
            Weapon9.AddEntry(11, 8);
            Weapon9.AddEntry(12, 9);
            Weapon9.AddEntry(13, 11);
            Weapon9.AddEntry(14, 13);
            Weapon9.AddEntry(15, 14);
            Weapon9.AddEntry(16, 10);
            Weapon9.AddEntry(17, 8);
            Weapon9.AddEntry(32, 14);

            WeaponPool = Weapon9;
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
            RandomAttackPool<int> Weapon10 = new RandomAttackPool<int>();
            Weapon10.AddEntry(0, 2);
            Weapon10.AddEntry(1, 2);
            Weapon10.AddEntry(10, 4);
            Weapon10.AddEntry(11, 4);
            Weapon10.AddEntry(12, 5);
            Weapon10.AddEntry(13, 6);
            Weapon10.AddEntry(14, 8);
            Weapon10.AddEntry(15, 10);
            Weapon10.AddEntry(16, 13);
            Weapon10.AddEntry(17, 15);
            Weapon10.AddEntry(18, 8);
            Weapon10.AddEntry(19, 8);
            Weapon10.AddEntry(35, 15);

            WeaponPool = Weapon10;
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

