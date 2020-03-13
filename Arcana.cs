using Castle_Fayyt.RNG;
using System;

namespace Castle_Fayyt
{
  internal class Arcana
  {
    public static RandomBag<int> MagicPool = new RandomBag<int>();
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

    public static int Magic()
    {
      switch (Fight.HeroLvl)
      {
        case 1:
          if (Lvl1Instantiated == false)
          {
            var magic1 = new RandomBag<int>((0, 10), (1, 10), (2, 18), (3, 32), (4, 24), (7, 6));

            MagicPool = magic1;
            Lvl1Instantiated = true;
          }

          int RandomPulledInternal = MagicPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueFull(1)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueFull(1);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 1)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueHalf(1)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueHalf(1);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 7)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Arcana!  "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\n\nYour magic flame did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 2:
          if (Lvl2Instantiated == false)
          {
            var magic2 = new RandomBag<int>((0, 10), (1, 10), (4, 20), (5, 31), (6, 23), (11, 6));

            MagicPool = magic2;
            Lvl2Instantiated = true;
          }

          RandomPulledInternal = MagicPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueFull(2)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueFull(2);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 1)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueHalf(2)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueHalf(2);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 11)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Arcana!  "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\n\nYour frozen darts did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 3:
          if (Lvl3Instantiated == false)
          {
            var magic3 = new RandomBag<int>((0, 10), (1, 10), (6, 22), (7, 30), (8, 21), (15, 7));

            MagicPool = magic3;
            Lvl3Instantiated = true;
          }

          RandomPulledInternal = MagicPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueFull(3)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueFull(3);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 1)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueHalf(3)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueHalf(3);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 15)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Arcana!  "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\n\nYour plasma whip did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 4:
          if (Lvl4Instantiated == false)
          {
            var magic4 = new RandomBag<int>((0, 10), (1, 10), (8, 21), (9, 30), (10, 22), (19, 7));

            MagicPool = magic4;
            Lvl4Instantiated = true;
          }

          RandomPulledInternal = MagicPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueFull(4)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueFull(4);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 1)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueHalf(4)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueHalf(4);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 19)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Arcana!  "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\n\nYour fireball did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 5:
          if (Lvl5Instantiated == false)
          {
            var magic5 = new RandomBag<int>((0, 10), (1, 10), (10, 20), (11, 31), (12, 21), (22, 8));

            MagicPool = magic5;
            Lvl5Instantiated = true;
          }

          RandomPulledInternal = MagicPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueFull(5)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueFull(5);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 1)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueHalf(5)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueHalf(5);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 22)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Arcana!  "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\n\nYour winter's blade did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 6:
          if (Lvl6Instantiated == false)
          {
            var magic6 = new RandomBag<int>((0, 10), (1, 10), (12, 21), (13, 32), (14, 18), (24, 9));

            MagicPool = magic6;
            Lvl6Instantiated = true;
          }

          RandomPulledInternal = MagicPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueFull(6)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueFull(6);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 1)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueHalf(6)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueHalf(6);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 24)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Arcana!  "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\n\nYour light jolt did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 7:
          if (Lvl7Instantiated == false)
          {
            var magic7 = new RandomBag<int>((0, 10), (1, 10), (15, 16), (16, 20), (17, 22), (18, 12), (28, 10));

            MagicPool = magic7;
            Lvl7Instantiated = true;
          }

          RandomPulledInternal = MagicPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueFull(7)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueFull(7);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 1)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueHalf(7)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueHalf(7);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 28)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Arcana!  "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\n\nYour icicle storm did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 8:
          if (Lvl8Instantiated == false)
          {
            var Magic8 = new RandomBag<int>((0, 10), (1, 10), (17, 16), (18, 18), (19, 22), (20, 13), (30, 11));

            MagicPool = Magic8;
            Lvl8Instantiated = true;
          }

          RandomPulledInternal = MagicPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueFull(8)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueFull(8);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 1)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueHalf(8)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueHalf(8);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 30)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Arcana!  "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\n\nYour cone of flames did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 9:
          if (Lvl9Instantiated == false)
          {
            var magic9 = new RandomBag<int>((0, 10), (1, 9), (19, 6), (20, 8), (21, 14), (22, 22), (23, 10), (24, 9), (34, 12));

            MagicPool = magic9;
            Lvl9Instantiated = true;
          }

          RandomPulledInternal = MagicPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueFull(9)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueFull(9);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 1)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueHalf(9)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueHalf(9);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 34)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Arcana!  "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\n\nYour ball lightning did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        case 10:
          if (Lvl10Instantiated == false)
          {
            var magic10 = new RandomBag<int>((0, 10), (1, 8), (21, 6), (22, 6), (23, 8), (24, 12), (25, 18), (26, 10), (27, 8), (38, 14));

            MagicPool = magic10;
            Lvl10Instantiated = true;
          }

          RandomPulledInternal = MagicPool.GetRandom();

          if (RandomPulledInternal == 0)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueFull(10)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueFull(10);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 1)
          {
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\n\tYou Healed "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(HealLookup.GetHealValueHalf(10)); Console.ForegroundColor = ConsoleColor.Green; Console.Write(" hit points."); Console.ResetColor();

            Fight.HeroHP += HealLookup.GetHealValueHalf(10);

            if (Fight.HeroHP > Fight.HeroHPMax)
            {
              Fight.HeroHP = Fight.HeroHPMax;
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n\tYour current hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{0}", Fight.HeroHP); Console.ResetColor();

            return 0;
          }
          else if (RandomPulledInternal == 38)
          {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\n\tCritical Arcana!  "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(" damage!"); Console.ResetColor();
            return RandomPulledInternal;
          }
          Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\n\nYour coruscating blaze did "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(RandomPulledInternal); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(" damage."); Console.ResetColor();
          return RandomPulledInternal;

        default:
          return 0;
      }
    }
  }
}