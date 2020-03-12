using System;

namespace Castle_Fayyt
{
  class Actions
  {
    public static string ChooseFirst()
    {
      Console.Write("\n\nWhat would you like to do "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(Program.PlayerName); Console.ResetColor(); Console.Write("?");
      Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\nO"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("BSERVE | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("P"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("ICK UP | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("T"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("ALK | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("M"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("AGIC | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("A"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("TTACK | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("D"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("EFEND | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("H"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("EAL |");
      Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\tL"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("EFT | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("R"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("IGHT | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("S"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("TRAIGHT | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("B"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("ACK | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("G"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("UIDE\n\n"); Console.ForegroundColor = ConsoleColor.Red;

      string choice = Console.ReadLine();
      choice = choice.ToLower();
      return choice;
    }

    public static string ChooseNow()
    {
      Console.Write("\n\nWhat would you like to do now "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(Program.PlayerName); Console.ResetColor(); Console.Write("?");
      Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\nO"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("BSERVE | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("P"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("ICK UP | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("T"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("ALK | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("M"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("AGIC | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("A"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("TTACK | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("D"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("EFEND | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("H"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("EAL |");
      Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\n\tL"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("EFT | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("R"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("IGHT | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("S"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("TRAIGHT | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("B"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("ACK | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("G"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("UIDE\n\n"); Console.ForegroundColor = ConsoleColor.Red;

      string choice = Console.ReadLine();
      choice = choice.ToLower();
      return choice;
    }
    public static string Observe()
    {
      Random observing = new Random();
      int choose = observing.Next(1, 4);

      if (choose == 1)
      {
        Console.Write("\n" +
          "  The dust in this room is mixed with a find sediment of\n" +
          "dirt blown in through the high windows.  Small plants\n" +
          "have tried with all their might to take root, but since\n" +
          "none have been able to penetrate the flagstone floor,\n" +
          "they are forced to subsist on the paltry half-inch of\n" +
          "ground covering.\n");

        string choice = ChooseNow();
        return choice;
      }

      else if (choose == 2)
      {
        Console.Write("\n" +
          "  This room is utterly empty.  You do not see any talking\n" +
          "clocks or animated candlesticks, chipped cups, or romantic\n" +
          "feather-dusters.  What you do see is dust, walls, your\n" +
          "own footsteps, and the unworldly paw-marks of the beasts\n" +
          "that now dwell in Castle Fayyt.\n");

        string choice = ChooseNow();
        return choice;
      }

      else
      {
        Console.Write("\n" +
          "  You focus your attention on the tracks on the floor.\n" +
          "Through the half-inch of dust you see your fresh\n" +
          "footprints, but also the subtler, older tracks of what\n" +
          "you can only guess are demons, hobgoblins, and possibly\n" +
          "minotaurs.\n\n" +
          "  You shudder, and once again set your senses on high\n" +
          "alert.\n");

        string choice = ChooseNow();
        return choice;
      }
    }

    public static string PickUp()
    {
      Random pick = new Random();
      int choose = pick.Next(1, 4);

      if (choose == 1)
      {
        Console.Write("\n" +
          "  There is nothing here to pick up...\n" +
          "\texcept maybe a disease.\n");

        string choice = ChooseNow();
        return choice;
      }

      else if (choose == 2)
      {
        Console.Write("\n" +
          "  You pick up a small bit of something that looks like\n" +
          "either a tiny raisin, or a chocolate chip.  Doesn't smell\n" +
          "like any kind of chocolate you've encountered.\n\n" +
          "  Oh, well.  Might as well put it in your pocket.  Even\n" +
          "a minor treasure like this from Castle Fayyt could bring\n" +
          "you fame, fortune, and more importantly: Proof!!\n");

        string choice = ChooseNow();
        return choice;
      }

      else
      {
        Console.Write("\n" +
          "  Dust everywhere.  Decayed bits in lumps that must have\n" +
          "been wooden furniture.  Here and there lumps of rusted and\n" +
          "corroded metal.  You sift through them like a connoisseur\n" +
          "of fine fragments, selecting the best representation of\n" +
          "utter garbage.\n");

        string choice = ChooseNow();
        return choice;
      }
    }

    public static string Talk()
    {
      Random talk = new Random();
      int choose = talk.Next(1, 4);

      if (choose == 1)
      {
        Console.Write("\n" +
          "  With no one else to brag to you tell yourself how\n" +
          "incredibly talented, svelte, intellingent, attractive,\n" +
          "and tenacious you are.\n\n" +
          "  You believe it, too.\n\n" +
          "The hidden eyes watching you aren't impressed at all.\n");

        string choice = ChooseNow();
        return choice;
      }

      else if (choose == 2)
      {
        Console.Write("\n" +
          "  They say the walls have ears.  And in fact, these ones\n" +
          "do.  While you mumble to yourself about the path you've\n" +
          "taken, and question if you're going the right way, the\n" +
          "walls are taking silent notes, too.\n");

        string choice = ChooseNow();
        return choice;
      }

      else
      {
        Console.Write("\n" +
          "  It's so quiet here.  Eerily quiet.  Unnaturally quiet.\n\n" +
          "  To break the silence, you start singing the bawdiest,\n" +
          "most ribald songs you know!\n\n" +
          "  The silent eyes laugh and dance in merry amusement.\n");

        string choice = ChooseNow();
        return choice;
      }
    }

    public static string Magic()
    {
      Random magic = new Random();
      int choose = magic.Next(1, 4);

      if (choose == 1)
      {
        Console.Write("\n" +
          "  The pull of the darkness here in the castle is immense.\n" +
          "Even as you walk the halls, you can’t help but fiddle with\n" +
          "the power that seems to flow like a raging flood all\n" +
          "around you.  What mighty havoc you could wreak with this\n" +
          "much power.  Nations would bow, continents could be\n" +
          "toppled, and the whole world reshaped as you desired…\n\n" +
          "  With great effort, you tear your mind from these\n" +
          "thoughts, extinguish the flame shield you set around\n" +
          "yourself, and focus on the goal before you.\n\n" +
          "  The silent eyes pass knowing glances at each other.\n");

        string choice = ChooseNow();
        return choice;
      }

      else if (choose == 2)
      {
        Console.Write("\n" +
          "  You create a wisp of blue electricity, and watch it\n" +
          "dance between your fingers, then across your knuckles, and\n" +
          "finally arc from one hand to the other.  This simple trick\n" +
          "was the first you were able to master.  How ironic that\n" +
          "you draw power for your light magic now from such a black\n" +
          "force.\n\n" +
          "  Hidden eyes are mildly impressed at your form and control.\n");

        string choice = ChooseNow();
        return choice;
      }

      else
      {
        Console.Write("\n" +
          "  To pass the time, you manifest an ice sword in each\n" +
          "hand, and practice some dual-wield techniques coupled with\n" +
          "psionic magical attacks.\n\n" +
          "  Your skill with both blade and arcana give the hidden\n" +
          "eyes great insight into your abilities.\n");

        string choice = ChooseNow();
        return choice;
      }
    }

    public static string Attack()
    {
      Random attack = new Random();
      int choose = attack.Next(1, 7);

      if (choose == 1)
      {
        Console.Write("\n" +
          "  That pile of dust in the corner which must once have\n" +
          "been a beautiful armoire is looking at you funny. This\n" +
          "offence cannot be tolerated! You attack!\n\n" +
          "  Hidden eyes watch you and prepare their counter-measures.\n");

        string choice = ChooseNow();
        return choice;
      }

      else if (choose == 2)
      {
        Console.ForegroundColor = ConsoleColor.Blue; Console.Write("\n\t\"What are we?\"\n");
        Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\t\"We're muggers!\"\n");
        Console.ForegroundColor = ConsoleColor.Blue; Console.Write("\t\"And what do we do?\"\n");
        Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\t\"We mug 'em!\"\n\n"); Console.ResetColor();
        Console.Write("  You mugged the carpet for "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("100,000 gold"); Console.ResetColor(); Console.Write(".\n\n" +
          "  The hidden eyes watch you in stunned disbelief.\n" +
          "    \"Is this what we face?\"");

        string choice = ChooseNow();
        return choice;
      }

      else if (choose == 3)
      {
        Console.Write("\n" +
          "  The bloodlust suddenly overpowers you. You lash out at\n" +
          "everything in the empty room, raising clouds of dust\n" +
          "After a few moments, you come to your senses with a sigh\n" +
          "of satisfaction.\n\n" +
          "  Your display has been observed and appraised.\n");

        string choice = ChooseNow();
        return choice;
      }

      else if (choose == 4)
      {
        Console.Write("\n" +
          "  You dance with the shadows, your agile form leaping this\n" +
          " way and that as your lunge, parry, and disengage.\n\n" +
          "  Hidden eyes take notice of your form and learn something\n" +
          "about your style and skills.\n");

        string choice = ChooseNow();
        return choice;
      }

      else if (choose == 5)
      {
        Console.Write("\n" +
          "  The dance of the blade is like a ballet. To keep in top\n" +
          "form requires constant practice and endless determination.\n\n" +
          "  You take a quiet minute to master anew the deadly,\n" +
          "killing steps of the dance.\n\n" +
          "  Your skills are great, and you have given an unexpected\n" +
          "advantage to the enemy.\n");

        string choice = ChooseNow();
        return choice;
      }

      else
      {
        Console.Write("\n" +
          "  The bloodlust suddenly overpowers you. You lash out at\n" +
          "everything in the empty room, raising clouds of dust\n" +
          "After a few moments, you come to your senses with a sigh\n" +
          "of satisfaction.\n\n" +
          "  You are watched by the hidden eyes.\n");

        string choice = ChooseNow();
        return choice;
      }
    }

    public static string Defend()
    {
      Random magic = new Random();
      int choose = magic.Next(1, 4);

      if (choose == 1)
      {
        Console.Write("\n" +
          "  You take a moment to practice your defensive posturing.\n\n" +
          "  Hidden eyes watch you and prepare their counter-measures.\n");

        string choice = ChooseNow();
        return choice;
      }

      else if (choose == 2)
      {
        Console.Write("\n" +
          "  The dance of death is not only to take the attack to\n" +
          "the enemy, but also to dodge, disengage, and defend.\n" +
          "You must remain in top form, and so you practice your\n" +
          "subtle craft in preparation for the coming dance.\n\n" +
          "  Silent notes are taken by the hidden eyes.\n");

        string choice = ChooseNow();
        return choice;
      }

      else
      {
        Console.Write("\n" +
          "  Block, parry, twist away, deflect, fall back.\n\n" +
          "  It's quiet here.  You take a minute to ready yourself\n" +
          "for the fight to come.\n\n" +
          "  You are watched by the hidden eyes.\n");

        string choice = ChooseNow();
        return choice;
      }
    }

    public static string Healing()
    {
      Random heal = new Random();
      int choose = heal.Next(1, 4);

      if (choose == 1)
      {
        Console.Write("\n" +
          "  Through the black murk of the magical energy permeating\n" +
          "every inch of the castle, you pull the delicate tendrils\n" +
          "of power required to heal your wounds.\n");

        Console.Write("\nYou heal "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(Heal.AtLvlHealing()); Console.ResetColor(); Console.Write(" hit points.");

        Fight.HeroHP += Heal.AtLvlHealing();

        if (Fight.HeroHP > Fight.HeroHPMax)
        {
          Fight.HeroHP = Fight.HeroHPMax;
        }
        Console.Write("\n\nCurrent hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(Fight.HeroHP); Console.ResetColor();

        string choice = ChooseNow();
        return choice;
      }

      else if (choose == 2)
      {
        Console.Write("\n" +
          "  You dip once again into the blackest of magical energy.\n" +
          "Your soul registers a weak plea for the pure light you can\n" +
          "barely remember training with.  You heedlessly plunge\n" +
          "forward molding the blackness to heal your wounds.\n");

        Console.Write("\nYou heal "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(Heal.AtLvlHealing()); Console.ResetColor(); Console.Write(" hit points.");

        Fight.HeroHP += Heal.AtLvlHealing();

        if (Fight.HeroHP > Fight.HeroHPMax)
        {
          Fight.HeroHP = Fight.HeroHPMax;
        }
        Console.Write("\n\nCurrent hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(Fight.HeroHP); Console.ResetColor();

        string choice = ChooseNow();
        return choice;
      }

      else
      {
        Console.Write("\n" +
          "  The druidic sages who guided you in learning the healing\n" +
          "arts were patient, but strict.  Under their tutelage, you\n" +
          "gratefully learned the delicate magic of self-restoration.\n" +
          "You apply it to yourself now.\n");

        Console.Write("\nYou heal "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(Heal.AtLvlHealing()); Console.ResetColor(); Console.Write(" hit points.");

        Fight.HeroHP += Heal.AtLvlHealing();

        if (Fight.HeroHP > Fight.HeroHPMax)
        {
          Fight.HeroHP = Fight.HeroHPMax;
        }
        Console.Write("\n\nCurrent hit points are "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(Fight.HeroHP); Console.ResetColor();

        string choice = ChooseNow();
        return choice;
      }
    }

    public static string Left()
    {
      Random magic = new Random();
      int choose = magic.Next(1, 4);

      if (choose == 1)
      {
        Console.Write("\n" +
          "  There is no doorway to the left.\n");

        string choice = ChooseNow();
        return choice;
      }

      else if (choose == 2)
      {
        Console.Write("\n" +
          "  You bang your head on the wall.  Ouch!  That hurts.\n");

        string choice = ChooseNow();
        return choice;
      }

      else
      {
        Console.Write("\n" +
          "  You take quick and decisive action by swiveling to the\n" +
          "left. What you didn't account for was there being no door\n" +
          "in that direction.\n");

        string choice = ChooseNow();
        return choice;
      }
    }

    public static string Right()
    {
      Random magic = new Random();
      int choose = magic.Next(1, 4);

      if (choose == 1)
      {
        Console.Write("\n" +
          "  There is no doorway to the right.\n");

        string choice = ChooseNow();
        return choice;
      }

      else if (choose == 2)
      {
        Console.Write("\n" +
          "  The realization of the futility of your existential\n" +
          "existence dulls your senses for a fraction of a second,\n" +
          "and you forget that there is no door to the right.\n");

        string choice = ChooseNow();
        return choice;
      }

      else
      {
        Console.Write("\n" +
          "  Although your internal map tells you that the shortest\n" +
          "path to your goal is through the door to the right, you\n" +
          "are dismayed to realize that there is, in fact, no door\n" +
          "to the right.\n");

        string choice = ChooseNow();
        return choice;
      }
    }

    public static string Straight()
    {
      Random magic = new Random();
      int choose = magic.Next(1, 4);

      if (choose == 1)
      {
        Console.Write("\n" +
          "  You are certain that the wall before you is a trick,\n" +
          "that there must be a hidden doorway.\n\n" +
          "  You search for a few minutes before finally giving up\n" +
          "and admitting there is no door in front of you.\n");

        string choice = ChooseNow();
        return choice;
      }

      else if (choose == 2)
      {
        Console.Write("\n" +
          "  Well, would you look at that...\n" +
          "    there is a door in front of you, after all....\n" +
          "\t...\n" +
          "\t\t...\n");
        Console.ForegroundColor = ConsoleColor.Blue; Console.Write("\t\t\tPSYCH!\n"); Console.ResetColor();

        string choice = ChooseNow();
        return choice;
      }

      else
      {
        Console.Write("\n" +
          "  You examine the creepy lettering scrawled on the wall:\n\n"); Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\t\"!REDRUM, REDRUM\"\n\n"); Console.ResetColor();
        Console.Write("  Odd how it seems so fresh and is oozing down.\n");

        string choice = ChooseNow();
        return choice;
      }
    }

    public static string Guide()
    {
      Console.ForegroundColor = ConsoleColor.White; Console.Write("\n" +
        "  CASTLE FAYYT is a text-adventure where you are the brave\n" +
        "  adventurer searching for a lost treasure.\n\n" +
        "  To play the game, read the text and type suitable\n" +
        "  responses.\n\n" +
        "  Generally, these responses will result in actions or\n" +
        "  information:\n\n");
      Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\t* observe (or o)"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" ==  Look around the room and\n" +
          "\t   observe your surroundings.\n");
      Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\t* pick up (or p)"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" == If you see something of\n" +
        "\t   interest, by all means, pick it up.  It might\n" +
        "\t   be worth it.\n");
      Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("\t* talk (or t)"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" == Use your words.\n");
      Console.ForegroundColor = ConsoleColor.Red; Console.Write("\t* magic (or m)"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" == Magic exists in this world.\n" +
        "\t    You will start with a basic fire spell and as\n" +
        "\t   you gain levels, will unlock more potent fire,\n" +
        "\t   ice, and lightning spells.\n" +
      "\t      Occasionally in an encounter, your magic\n" +
      "\t   spells will not do damage to the enemy, but\n" +
      "\t   will instead give you a burst of healing.\n" +
      "\t     In any case, the magical energies here are\n" +
      "\t   extremely black.  Any use of magic outside of\n" +
      "\t   an actual encounter will be studied and give\n" +
      "\t   your enemies the advantage.\n");
      Console.ForegroundColor = ConsoleColor.Red; Console.Write("\t* attack (or a)"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" == There are enemies.  You will\n" +
          "\t   fight them.  Be warned, however, that\n" +
          "\t   fighting needlessly will give the silent\n" +
          "\t   watchers strategic information about your\n" +
          "\t   style and your abilities.\n");
      Console.ForegroundColor = ConsoleColor.Red; Console.Write("\t* defend (or d)"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" == Or perhaps you will want to\n" +
        "\t   avoid damage.  Again, there are silent watchers\n" +
        "\t   who will learn from you if you show off your\n" +
        "\t   defensive manoeuvers.\n");
      Console.ForegroundColor = ConsoleColor.Green; Console.Write("\t* heal (or h)"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" == Use your magical ability to heal\n" +
        "\t   your wounds.  Works both inside of and outside\n" +
        "\t  of an encounter.\n");
      Console.ForegroundColor = ConsoleColor.Blue; Console.Write("\t* left (or l)"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" == Move through a door to the left\n" +
          "\t   of you.\n");
      Console.ForegroundColor = ConsoleColor.Blue; Console.Write("\t* right or r)"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" == Move through a door to the right\n" +
        "\t   of you.\n");
      Console.ForegroundColor = ConsoleColor.Blue; Console.Write("\t* straight (or s)"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" == Move through a door straight\n" +
        "\t   ahead of you.\n");
      Console.ForegroundColor = ConsoleColor.Blue; Console.Write("\t* back (or b)"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" == Turn 180 degrees, and go back to\n" +
        "\t   the previous room.\n" +
        "\t    Because you have turned 180 degrees, you will\n" +
        "\t   see it from a different angle, but it will be\n" +
        "\t   the same room you just left.\n");
      Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("\t* inventory (or i)"); Console.ForegroundColor = ConsoleColor.White; Console.Write(" == Prints out a list of items\n" +
        "\t   in your possession with a description of that\n" +
        "\t   item's properties or bonuses.\n");
      Console.Write("\t* guide (or g) == Brings you back to this\n" +
        "\t   informative guide.  In case you were wondering."); Console.ResetColor();

      string choice = ChooseNow();
      return choice;
    }

    public static string What()
    {
      Console.Write("\nWhat's that?  Did you say something "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(Program.PlayerName); Console.ResetColor(); Console.Write("?");

      string choice = ChooseNow();
      return choice;
    }
  }
}
