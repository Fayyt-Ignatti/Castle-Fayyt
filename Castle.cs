using System;

namespace Castle_Fayyt
{
  class Castle
  {
    public static void SplashScreen()
    {
      Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("\n\n" +
        "\t      ...                         .x+=:.        s          ..                  \n" +
        "\t   xH88\"`~ .x8X                  z`    ^%      :8    x .d88\"                   \n" +
        "\t :8888   .f\"8888Hf                  .   <k    .88     5888R                    \n" +
        "\t:8888>  X8L  ^\"\"`        u        .@8Ned8\"   :888ooo  '888R        .u          \n" +
        "\tX8888  X888h          us888u.   .@^%8888\" - *8888888   888R     ud8888.        \n" +
        "\t88888  !88888.     .@88 \"8888\" x88:  `)8b.   8888      888R   :888'8888.       \n" +
        "\t88888   %88888     9888  9888  8888N=*8888   8888      888R   d888 '88%\"\n" +
        "\t88888 '> `8888>    9888  9888   %8\"    R88   8888      888R   8888.+\"          \n" +
        "\t`8888L %  ?888   ! 9888  9888    @8Wou 9%   .8888Lu=   888R   8888L            \n" +
        "\t `8888  `-*\"\"   /  9888  9888  .888888P`    ^%888*    .888B . '8888c. .+       \n" +
        "\t  \"888.      :\"   \"888*\"\"888\" `   ^\"F        'Y\"     ^*888%   \"88888%         \n" +
        "\t    `\"\"***~\"`      ^Y\"   ^Y'                           \"%       \"YP'          "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\n" +
        "\t                .....                                                     s    \n" +
        "\t             .H8888888x.  '`+                ..           ..             :8    \n" +
        "\t            :888888888888x.  !              @L           @L             .88    \n" +
        "\t            8~    `\" * 88888888\"       u     9888i   .dL  9888i   .dL    :888ooo \n" +
        "\t            !      .  `f\"\"\"\"      us888u.  `Y888k:*888. `Y888k:*888. -*8888888 \n" +
        "\t             ~:...-` :8L <)88: .@88 \"8888\"   888E  888I   888E  888I   8888    \n" +
        "\t                .   :888:>X88! 9888  9888    888E  888I   888E  888I   8888    \n" +
        "\t             :~\"88x 48888X ^`  9888  9888    888E  888I   888E  888I   8888    \n" +
        "\t            <  :888k'88888X    9888  9888    888E  888I   888E  888I  .8888Lu= \n" +
        "\t              d8888f '88888X   9888  9888   x888N><888'  x888N><888'  ^%888*   \n" +
        "\t             :8888!    ?8888>  \"888 *\"\"888\"   \"88\"  888    \"88\"  888     'Y\"    \n" +
        "\t             X888!      8888~   ^Y\" ^ Y'          88F          88F            \n" +
        "\t             '888       X88f                     98\"          98\"             \n" +
        "\t              '%8:     .8*\"                    ./ \"          ./\"               \n" +
        "\t                 ^----~\"`                      ~`           ~`                 \n\n"); Console.ResetColor();

      Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\n\nPress enter to continue."); Console.ResetColor();
      Console.ReadLine();
    }

    public static void Entrance()
    {
      RoomDesigns.FayytCastle2();

      Console.WriteLine("\n\nYou stand at last at the gate of Castle Fayyt.");

      string choice = Actions.ChooseFirst(); Console.ResetColor();

      while (choice != "straight" && choice != "s")
      {
        RoomDesigns.FayytCastle2();

        if (choice == "observe" || choice == "o")
        {
          Console.Write("\n" +
            "  You see a castle.  The walls are ancient and as you make" +
            "\na slow circuit around it, you can see evidence of other" +
            "\nscars.  Not only has the weather beaten down on the walls" +
            "\nof the castle, but it has been pitted as if doused in" +
            "\nacid.  There are deep red stains on the ground in" +
            "\ngeometric shapes that look just enough like pitchforks," +
            "\nsickles, and other weapons of terrified and angry" +
            "\nvillagers." +
            "\n\n  You shudder as you complete your circuit and return" +
            "\nto the gate.");

          choice = Actions.ChooseNow(); Console.ResetColor();
        }

        else if (choice == "pick up" || choice == "pick" || choice == "p")
        {
          Console.Write("\n  There's nothing out here to pick up..." +
            "\n\texcept maybe a disease.");

          choice = Actions.ChooseNow(); Console.ResetColor();
        }

        else if (choice == "talk" || choice == "t")
        {
          Console.Write("\n" +
            "  With no one else to brag to, you tell yourself how" +
            "\nincredibly talented, svelte, intelligent, attractive" +
            "\nand tenacious you are." +
            "\n  You believe it, too.");

          choice = Actions.ChooseNow(); Console.ResetColor();
        }

        else if (choice == "magic" || choice == "m")
        {
          Console.Write("\n" +
            "  The magical energies near this castle are amazing..." +
            "\nand so, so dark.  Just reaching into the pool of energy" +
            "\nto create a spark of light in your hand is like swimming" +
            "\nin the blackest ocean.  You shudder at the attempt." +
            "\nBut, oh!  The strength of that pool makes your feeble" +
            "\nlight glow many times brighter than normal!" +
            "\n  Perhaps you could get used to this feeling!");

          choice = Actions.ChooseNow(); Console.ResetColor();
        }

        else if (choice == "attack" || choice == "a")
        {
          Console.ForegroundColor = ConsoleColor.Blue; Console.Write("\n\"What are we?\"");
          Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\n\"We're muggers!\"");
          Console.ForegroundColor = ConsoleColor.Blue; Console.Write("\n\"And what do we do?\"");
          Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\n\"We mug 'em!\"\n"); Console.ResetColor();
          Console.Write("\nYou mugged the portcullis for "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("100,000 gold"); Console.ResetColor(); Console.Write(".\n");

          choice = Actions.ChooseNow(); Console.ResetColor();
        }

        else if (choice == "defend" || choice == "d")
        {
          Console.Write("\n" +
            "  Block, parry, twist away, deflect, fall-back.\n\n" +
            "  It's quiet here.  You take a minute to ready yourself\n" +
            "for the fight to come.");

          choice = Actions.ChooseNow(); Console.ResetColor();
        }

        else if (choice == "heal" || choice == "h")
        {
          Console.Write("\nYou heal "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("10"); Console.ResetColor(); Console.Write(" hit points.");

          Fight.HeroHP += 10;

          if (Fight.HeroHP > Fight.HeroHPMax)
          {
            Fight.HeroHP = Fight.HeroHPMax;
          }
          Console.Write("\n\nCurrent hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(Fight.HeroHP); Console.ResetColor();

          choice = Actions.ChooseNow(); Console.ResetColor();
        }

        else if (choice == "left" || choice == "l" || choice == "right" || choice == "r")
        {
          Console.Write("\n" +
            "You are standing outside the gate of the castle.  To the\n" +
            "left and right of you is what used to be a moat.  You've\n" +
            "fashioned a kind of bridge over the long-overgrown moat,\n" +
            "and unless you want to find out if those long pointy\n" +
            "things growing up from the floor of the moat are still\n" +
            "deadly, I suggest you move straight ahead through the\n" +
            "portcullis.");

          choice = Actions.ChooseNow(); Console.ResetColor();
        }

        else if (choice == "back" || choice == "b")
        {
          Console.Write("\n" +
            "  Are you seriously going to give up now and go home?\n" +
            "CASTLE FAYYT, the pinnacle of your research and\n" +
            "preparation is before you now.  It's taken years of\n" +
            "scholarly pursuits, decades of physical preparation\n" +
            "and training, and months of travel through the most\n" +
            "difficult and inhospitable terrain to get here.  You\n" +
            "steel your nerves.  It was a momentary doubt.\n\n" +
            "  There's no turning back now.\n");

          choice = Actions.ChooseNow(); Console.ResetColor();
        }

        else if (choice == "Guide" || choice == "g")
        {
          choice = Actions.Guide(); Console.ResetColor();
          //choice = Actions.chooseNow(); Console.ResetColor();
        }

        else
        {
          choice = Actions.What(); Console.ResetColor();
        }
      }
      if (choice == "straight" || choice == "s")
      {
        Room2N();
      }
    }
    public static void Room2N()
    {
      RoomDesigns.TwoSide();

      Console.WriteLine("\n\nYou are in the first room.");
      int observed = 0;
      if (observed >= 2)
      {
        Program.FayytXP += 5;
      }

      string choice = Actions.ChooseFirst(); Console.ResetColor();

      while (choice != "left" && choice != "l" && choice != "right" && choice != "r" && choice != "back" && choice != "b")
      {
        RoomDesigns.TwoSide();

        if (choice == "observe" || choice == "o")
        {
          choice = Actions.Observe(); Console.ResetColor();
        }
        else if (choice == "pick up" || choice == "pick" || choice == "p")
        {
          choice = Actions.PickUp(); Console.ResetColor();
        }
        else if (choice == "talk" || choice == "t")
        {
          choice = Actions.Talk(); Console.ResetColor();
        }
        else if (choice == "magic" || choice == "m")
        {
          observed++;
          choice = Actions.Magic(); Console.ResetColor();
        }
        else if (choice == "attack" || choice == "a")
        {
          observed++;
          choice = Actions.Attack(); Console.ResetColor();
        }
        else if (choice == "defend" || choice == "d")
        {
          observed++;
          choice = Actions.Defend(); Console.ResetColor();
        }
        else if (choice == "heal" || choice == "h")
        {
          observed++;
          choice = Actions.Healing(); Console.ResetColor();
        }
        else if (choice == "straight" || choice == "s")
        {
          choice = Actions.Straight(); Console.ResetColor();
        }
        else if (choice == "guide" || choice == "g")
        {
          choice = Actions.Guide(); Console.ResetColor();
        }
        else
        {
          choice = Actions.What(); Console.ResetColor();
        }
      }
      if (choice == "left" || choice == "l")
      {
        Console.Write("You entered room 3 West.");
      }
      else if (choice == "right" || choice == "r")
      {
        Console.Write("You entered room 15 East.");
      }
      else
      {
        Entrance();
      }
    }

    public static void Room2W()
    {
      RoomDesigns.TwoLeft();

      Console.WriteLine("\n\nYou are in the first room.");
      int observed = 0;
      if (observed >= 2)
      {
        Program.FayytXP += 5;
      }

      string choice = Actions.ChooseFirst(); Console.ResetColor();

      while (choice != "left" && choice != "l" && choice != "straight" && choice != "s" && choice != "back" && choice != "b")
      {
        if (choice == "observe" || choice == "o")
        {
          choice = Actions.Observe(); Console.ResetColor();
        }
        else if (choice == "pick up" || choice == "pick" || choice == "p")
        {
          choice = Actions.PickUp(); Console.ResetColor();
        }
        else if (choice == "talk" || choice == "t")
        {
          choice = Actions.Talk(); Console.ResetColor();
        }
        else if (choice == "magic" || choice == "m")
        {
          observed++;
          choice = Actions.Magic(); Console.ResetColor();
        }
        else if (choice == "attack" || choice == "a")
        {
          observed++;
          choice = Actions.Attack(); Console.ResetColor();
        }
        else if (choice == "defend" || choice == "d")
        {
          observed++;
          choice = Actions.Defend(); Console.ResetColor();
        }
        else if (choice == "heal" || choice == "h")
        {
          observed++;
          choice = Actions.Healing(); Console.ResetColor();
        }
        else if (choice == "right" || choice == "r")
        {
          choice = Actions.Right(); Console.ResetColor();
        }
        else if (choice == "guide" || choice == "g")
        {
          choice = Actions.Guide(); Console.ResetColor();
        }
        else
        {
          choice = Actions.What(); Console.ResetColor();
        }
      }
      if (choice == "left" || choice == "l")
      {
        Entrance();
      }
      else if (choice == "straight" || choice == "s")
      {
        Console.Write("You entered room 3 West.");
      }
      else
      {
        Entrance();
      }
    }

    public static void Room2E()
    {
      RoomDesigns.TwoRight();

      Console.WriteLine("\n\nYou are in the first room.");
      int observed = 0;
      if (observed >= 2)
      {
        Program.FayytXP += 5;
      }

      string choice = Actions.ChooseFirst(); Console.ResetColor();

      while (choice != "straight" && choice != "s" && choice != "right" && choice != "r" && choice != "back" && choice != "b")
      {
        if (choice == "observe" || choice == "o")
        {
          choice = Actions.Observe(); Console.ResetColor();
        }
        else if (choice == "pick up" || choice == "pick" || choice == "p")
        {
          choice = Actions.PickUp(); Console.ResetColor();
        }
        else if (choice == "talk" || choice == "t")
        {
          choice = Actions.Talk(); Console.ResetColor();
        }
        else if (choice == "magic" || choice == "m")
        {
          observed++;
          choice = Actions.Magic(); Console.ResetColor();
        }
        else if (choice == "attack" || choice == "a")
        {
          observed++;
          choice = Actions.Attack(); Console.ResetColor();
        }
        else if (choice == "defend" || choice == "d")
        {
          observed++;
          choice = Actions.Defend(); Console.ResetColor();
        }
        else if (choice == "heal" || choice == "h")
        {
          observed++;
          choice = Actions.Healing(); Console.ResetColor();
        }
        else if (choice == "left" || choice == "l")
        {
          choice = Actions.Left(); Console.ResetColor();
        }
        else if (choice == "guide" || choice == "g")
        {
          choice = Actions.Guide(); Console.ResetColor();
        }
        else
        {
          choice = Actions.What(); Console.ResetColor();
        }
      }
      if (choice == "straight" || choice == "s")
      {
        Console.Write("You entered room 15 East.");
      }
      else if (choice == "right" || choice == "r")
      {
        Entrance();
      }
      else
      {
        Console.Write("You entered room 3 West.");
      }
    }

  }
}
