namespace Castle_Fayyt
{
  public class Heal
  {
    public const int Lvl1Full = 12;

    public const int Lvl2Full = 18;

    public const int Lvl3Full = 22;

    public const int Lvl4Full = 28;

    public const int Lvl5Full = 38;

    public const int Lvl6Full = 48;

    public const int Lvl7Full = 60;

    public const int Lvl8Full = 72;

    public const int Lvl9Full = 86;

    public const int Lvl10Full = 100;

    public const int Lvl1Half = 6;

    public const int Lvl2Half = 9;

    public const int Lvl3Half = 11;

    public const int Lvl4Half = 14;

    public const int Lvl5Half = 19;

    public const int Lvl6Half = 24;

    public const int Lvl7Half = 30;

    public const int Lvl8Half = 36;

    public const int Lvl9Half = 43;

    public const int Lvl10Half = 50;

    public static int AtLvlHealing()
    {
      int CurrentLevel = Fight.HeroLvl;

      switch (CurrentLevel)
      {
        case 1:
          return Lvl1Full;
        case 2:
          return Lvl2Full;
        case 3:
          return Lvl3Full;
        case 4:
          return Lvl4Full;
        case 5:
          return Lvl5Full;
        case 6:
          return Lvl6Full;
        case 7:
          return Lvl7Full;
        case 8:
          return Lvl8Full;
        case 9:
          return Lvl9Full;
        case 10:
          return Lvl10Full;
        default:
          return 12;
      }
    }
  }
}
