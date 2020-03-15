using System;
using System.Collections.Generic;
using System.Text;

namespace Castle_Fayyt.RNG
{
  /// <summary>
  /// Random bag entry.
  /// </summary>
  /// <typeparam name="T">Entry type.</typeparam>
  internal class RandomBagEntry<T>
  {
    /// <summary>
    /// Gets or sets accuulated weight.
    /// </summary>
    public float AccumulatedWeight { get; set; }

    /// <summary>
    /// Gets or sets item.
    /// </summary>
    public T Item { get; set; }

    /// <summary>
    /// Previous accumulated weight.
    /// </summary>
    private float accumulatedWeightPrevious;

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomBagEntry{T}"/> class.
    /// </summary>
    /// <param name="previous">Previous entry.</param>
    /// <param name="item">Item.</param>
    /// <param name="accumulatedWeight">Accumulated weight.</param>
    public RandomBagEntry(RandomBagEntry<T> previous, T item, float accumulatedWeight)
      : this(previous.AccumulatedWeight, item, accumulatedWeight)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomBagEntry{T}"/> class.
    /// </summary>
    /// <param name="item">Item.</param>
    /// <param name="accumulatedWeight">Accumulated weight.</param>
    public RandomBagEntry(T item, float accumulatedWeight)
      : this(0f, item, accumulatedWeight)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomBagEntry{T}"/> class.
    /// </summary>
    /// <param name="previousAccumulatedWeight">Previous accumulated weight.</param>
    /// <param name="item">Item.</param>
    /// <param name="accumulatedWeight">Accumulated weight.</param>
    private RandomBagEntry(float previousAccumulatedWeight, T item, float accumulatedWeight)
    {
      this.accumulatedWeightPrevious = previousAccumulatedWeight;
      this.Item = item;
      this.AccumulatedWeight = accumulatedWeight;
    }

    /// <summary>
    /// Compares value to this bag entry.
    /// </summary>
    /// <param name="value">Value to compare with.</param>
    /// <returns>Compare result.</returns>
    public int Compare(float value)
    {
      if (value <= this.accumulatedWeightPrevious)
      {
        return -1;
      }

      if (value > this.AccumulatedWeight)
      {
        return 1;
      }

      return 0;
    }

    /// <summary>
    /// Generates next bag entry from this bag entry.
    /// </summary>
    /// <param name="item">Item for this entry.</param>
    /// <param name="weight">Weight for this entry.</param>
    /// <returns>Next entry.</returns>
    public RandomBagEntry<T> GenerateNext(T item, float weight)
    {
      return new RandomBagEntry<T>(this, item, weight);
    }
  }
}