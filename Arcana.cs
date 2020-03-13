using System;

namespace Castle_Fayyt
{
  internal class Arcana
  {
    public static RandomAttackPool<int> MagicPool = new RandomAttackPool<int>();
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
            RandomAttackPool<int> Magic1 = new RandomAttackPool<int>();
            Magic1.AddEntry(0, 10);
            Magic1.AddEntry(1, 10);
            Magic1.AddEntry(2, 18);
            Magic1.AddEntry(3, 32);
            Magic1.AddEntry(4, 24);
            Magic1.AddEntry(7, 6);

            MagicPool = Magic1;
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
            RandomAttackPool<int> Magic2 = new RandomAttackPool<int>();
            Magic2.AddEntry(0, 10);
            Magic2.AddEntry(1, 10);
            Magic2.AddEntry(4, 20);
            Magic2.AddEntry(5, 31);
            Magic2.AddEntry(6, 23);
            Magic2.AddEntry(11, 6);

            MagicPool = Magic2;
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
            RandomAttackPool<int> Magic3 = new RandomAttackPool<int>();
            Magic3.AddEntry(0, 10);
            Magic3.AddEntry(1, 10);
            Magic3.AddEntry(6, 22);
            Magic3.AddEntry(7, 30);
            Magic3.AddEntry(8, 21);
            Magic3.AddEntry(15, 7);

            MagicPool = Magic3;
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
            RandomAttackPool<int> Magic4 = new RandomAttackPool<int>();
            Magic4.AddEntry(0, 10);
            Magic4.AddEntry(1, 10);
            Magic4.AddEntry(8, 21);
            Magic4.AddEntry(9, 30);
            Magic4.AddEntry(10, 22);
            Magic4.AddEntry(19, 7);

            MagicPool = Magic4;
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
            RandomAttackPool<int> Magic5 = new RandomAttackPool<int>();
            Magic5.AddEntry(0, 10);
            Magic5.AddEntry(1, 10);
            Magic5.AddEntry(10, 20);
            Magic5.AddEntry(11, 31);
            Magic5.AddEntry(12, 21);
            Magic5.AddEntry(22, 8);

            MagicPool = Magic5;
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
            RandomAttackPool<int> Magic6 = new RandomAttackPool<int>();
            Magic6.AddEntry(0, 10);
            Magic6.AddEntry(1, 10);
            Magic6.AddEntry(12, 21);
            Magic6.AddEntry(13, 32);
            Magic6.AddEntry(14, 18);
            Magic6.AddEntry(24, 9);

            MagicPool = Magic6;
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
            RandomAttackPool<int> Magic7 = new RandomAttackPool<int>();
            Magic7.AddEntry(0, 10);
            Magic7.AddEntry(1, 10);
            Magic7.AddEntry(15, 16);
            Magic7.AddEntry(16, 20);
            Magic7.AddEntry(17, 22);
            Magic7.AddEntry(18, 12);
            Magic7.AddEntry(28, 10);

            MagicPool = Magic7;
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
            RandomAttackPool<int> Magic8 = new RandomAttackPool<int>();
            Magic8.AddEntry(0, 10);
            Magic8.AddEntry(1, 10);
            Magic8.AddEntry(17, 16);
            Magic8.AddEntry(18, 18);
            Magic8.AddEntry(19, 22);
            Magic8.AddEntry(20, 13);
            Magic8.AddEntry(30, 11);

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
            RandomAttackPool<int> Magic9 = new RandomAttackPool<int>();
            Magic9.AddEntry(0, 10);
            Magic9.AddEntry(1, 9);
            Magic9.AddEntry(19, 6);
            Magic9.AddEntry(20, 8);
            Magic9.AddEntry(21, 14);
            Magic9.AddEntry(22, 22);
            Magic9.AddEntry(23, 10);
            Magic9.AddEntry(24, 9);
            Magic9.AddEntry(34, 12);

            MagicPool = Magic9;
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
            RandomAttackPool<int> Magic10 = new RandomAttackPool<int>();
            Magic10.AddEntry(0, 10);
            Magic10.AddEntry(1, 8);
            Magic10.AddEntry(21, 6);
            Magic10.AddEntry(22, 6);
            Magic10.AddEntry(23, 8);
            Magic10.AddEntry(24, 12);
            Magic10.AddEntry(25, 18);
            Magic10.AddEntry(26, 10);
            Magic10.AddEntry(27, 8);
            Magic10.AddEntry(38, 14);

            MagicPool = Magic10;
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