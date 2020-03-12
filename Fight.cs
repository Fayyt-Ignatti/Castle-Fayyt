using System;
using System.Collections.Generic;

namespace Castle_Fayyt
{
  class Fight
  {
    public static int M6HP = 100;
    public static int M9HP = 150;
    public static int M12HP = 150;
    public static int M14HP = 100;
    public static int M56HP = 200;
    public static int M47HP = 200;
    public static int M39HP = 400;
    public static int M30HP = 300;
    public static int M20HP = 300;

    public static int HeroHP = 125;
    public static int HeroHPMax = 125;
    public static int HeroXP = 0;
    public static int HeroLvl = 1;

    public static Dictionary<int, int> HeroLvlDict = new Dictionary<int, int>() { { 1, 0 }, { 2, 200 }, { 3, 400 }, { 4, 600 }, { 5, 800 }, { 6, 1100 }, { 7, 1500 }, { 8, 1900 }, { 9, 2400 }, { 10, 2900 } };
    public static Dictionary<int, int> HeroHPMaxDict = new Dictionary<int, int>() { { 1, 125 }, { 2, 150 }, { 3, 175 }, { 4, 200 }, { 5, 250 }, { 6, 300 }, { 7, 350 }, { 8, 400 }, { 9, 450 }, { 10, 500 } };


    public static void BattleRound()
    {
      int Damage = 0;

      Random random = new Random();
      int choose = random.Next(1, 3);

      if (choose == 1)
      {
        Damage = Arcana.Magic();
      }

      else if (choose == 2)
      {
        Damage = Weapon.Attack();
      }

      M6HP -= Damage;
      if (M6HP <= 0)
      {
        Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\nMonster is dead.  Congratualtions.  Yada-yada."); Console.ResetColor();
        HeroXP += 100;
        if (HeroLvlDict.TryGetValue(HeroLvl + 1, out int XPNeeded))
        {
          if (XPNeeded <= HeroXP)
          {
            HeroLvl++;
            HeroHPMaxDict.TryGetValue(HeroLvl, out int NewMax);
            HeroHPMax = NewMax;
            HeroHP = NewMax;
            Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\n\n\tYou leveled up!  Current level is "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("{0}", HeroLvl); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\tYour new Max HP is "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("{0}", HeroHPMax); Console.ResetColor();
          }
        }
        M6HP = 100;
      }
      Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("\nThis is the new M6 HP: "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write(M6HP); Console.ResetColor();
      M6Attacks.M6Damage();
    }
  }
}

