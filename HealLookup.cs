using System.Collections.Generic;

namespace Castle_Fayyt
{
  /// <summary>
  /// Heal values lookup class.
  /// </summary>
  internal static class HealLookup
  {
    /// <summary>
    /// Heal values lookup table - level to heal value.
    /// </summary>
    private static readonly Dictionary<int, int> HealValuesTable = new Dictionary<int, int>()
    {
      {1, 12 },
      {2, 18 },
      {3, 22 },
      {4, 28 },
      {5, 38 },
      {6, 48 },
      {7, 60 },
      {8, 72 },
      {9, 86 },
      {10, 100 }
    };

    /// <summary>
    /// Gets full heal amount for level.
    /// </summary>
    /// <param name="level">Level.</param>
    /// <returns>Heal amount.</returns>
    public static int GetHealValueFull(int level)
    {
      const int ERROR_LOOKUP = 1;

      if (HealValuesTable.TryGetValue(level, out int lookup))
      {
        return lookup;
      }

      return HealValuesTable[ERROR_LOOKUP];
    }

    /// <summary>
    /// Gets half heal amount for level.
    /// </summary>
    /// <param name="level">Level.</param>
    /// <returns>Heal amount.</returns>
    public static int GetHealValueHalf(int level)
    {
      return GetHealValueFull(level) / 2;
    }
  }
}