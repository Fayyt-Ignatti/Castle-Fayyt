using System;
using System.Collections.Generic;
using System.Text;

namespace Castle_Fayyt.RNG
{
  /// <summary>
  /// Random bag entry.
  /// </summary>
  /// <typeparam name="T">Entry type.</typeparam>
  internal struct RandomBagEntry<T>
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
    /// Initializes a new instance of the <see cref="RandomBagEntry{T}"/> struct.
    /// </summary>
    /// <param name="item">Item.</param>
    /// <param name="accumulatedWeight">Accumulated weight.</param>
    public RandomBagEntry(T item, float accumulatedWeight)
    {
      this.Item = item;
      this.AccumulatedWeight = accumulatedWeight;
    }
  }
}