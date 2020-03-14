using System;
using System.Collections.Generic;

namespace Castle_Fayyt.RNG
{
  /// <summary>
  /// Random generator of type T.
  /// </summary>
  /// <typeparam name="T">Type to randomly select.</typeparam>
  internal class RandomBag<T>
  {
    /// <summary>
    /// Collection of entries.
    /// </summary>
    private readonly List<RandomBagEntry<T>> entries = new List<RandomBagEntry<T>>();

    /// <summary>
    /// Random number generator.
    /// </summary>
    private readonly Random rand = new Random();

    /// <summary>
    /// Accumulated weight.
    /// </summary>
    private float accumulatedWeight;

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomBag{T}"/> class.
    /// </summary>
    /// <param name="entries">Collection of starting entries.</param>
    public RandomBag(params (T item, float weight)[] entries)
    {
      foreach (var (item, weight) in entries)
      {
        this.AddEntry(item, weight);
      }
    }

    /// <summary>
    /// Adds entry to this random bag.
    /// </summary>
    /// <param name="item">Item to add to random bag.</param>
    /// <param name="weight">Weight of item - how likely it is to be selected.</param>
    public void AddEntry(T item, float weight)
    {
      this.accumulatedWeight += weight;
      this.entries.Add(new RandomBagEntry<T>(item, this.accumulatedWeight));
    }

    /// <summary>
    /// Selects a random item from this random bag.
    /// </summary>
    /// <returns>Selected item.</returns>
    public T GetRandom()
    {
      return this.GetRandom(this.rand);
    }

    /// <summary>
    /// Selects a random item from this random bag.
    /// </summary>
    /// <param name="random">Random number generator to use.</param>
    /// <returns>Selected item.</returns>
    public T GetRandom(Random random)
    {
      float r = (float)random.NextDouble() * this.accumulatedWeight;

      foreach (var entry in this.entries)
      {
        if (entry.AccumulatedWeight >= r)
        {
          return entry.Item;
        }
      }

      return default;
    }
  }
}