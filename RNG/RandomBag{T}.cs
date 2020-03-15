using System;
using System.Collections.Generic;
using System.Linq;

namespace Castle_Fayyt.RNG
{
  /// <summary>
  /// Random generator of type T.
  /// </summary>
  /// <typeparam name="T">Type to randomly select.</typeparam>
  public class RandomBag<T>
  {
    /// <summary>
    /// Accumulated weight.
    /// </summary>
    private float AccumulatedWeight => this.lastEntry is null ? 0 : this.lastEntry.AccumulatedWeight;

    /// <summary>
    /// Collection of entries.
    /// </summary>
    private readonly List<RandomBagEntry<T>> entries = new List<RandomBagEntry<T>>();

    /// <summary>
    /// Random number generator.
    /// </summary>
    private readonly Random rand = new Random();

    /// <summary>
    /// Last entry.
    /// </summary>
    private RandomBagEntry<T> lastEntry = null;

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
      RandomBagEntry<T> newEntry;
      float accumulatedWeight = this.AccumulatedWeight + weight;

      if (this.lastEntry is null)
      {
        newEntry = new RandomBagEntry<T>(item, accumulatedWeight);
      }
      else
      {
        newEntry = this.lastEntry.GenerateNext(item, accumulatedWeight);
      }

      this.entries.Add(newEntry);
      this.lastEntry = newEntry;
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
      float r = (float)random.NextDouble() * this.AccumulatedWeight;

      return this.ChooseWithValue(r);
    }

    /// <summary>
    /// Chooses entry in this bag using random value.
    /// </summary>
    /// <param name="value">Value.</param>
    /// <returns>Selected item.</returns>
    public T ChooseWithValue(float value)
    {
      if (this.entries.Count == 0 || value < 0 || value > this.AccumulatedWeight)
      {
        return default;
      }

      return this.ChooseWithValue(value, this.entries.Count / 2, 0, this.entries.Count - 1);
    }

    /// <summary>
    /// Chooses entry in this bag using random value.
    /// </summary>
    /// <param name="value">Value.</param>
    /// <param name="index">Index.</param>
    /// <param name="lowIndex">Low index.</param>
    /// <param name="highIndex">High index.</param>
    /// <returns>Selected item.</returns>
    private T ChooseWithValue(float value, int index, int lowIndex, int highIndex)
    {
      var atIndex = this.entries[index];
      int direction = atIndex.Compare(value);

      if (direction == 0)
      {
        return atIndex.Item;
      }

      if (direction < 0)
      {
        highIndex = index;
      }

      if (direction > 0)
      {
        lowIndex = index;
      }

      index = ((highIndex - lowIndex) / 2) + lowIndex;

      if (lowIndex == index && highIndex - index == 1)
      {
        index = highIndex;
      }

      return this.ChooseWithValue(value, index, lowIndex, highIndex);
    }
  }
}