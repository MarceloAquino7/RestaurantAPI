using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// Base class to represent every meal
    /// </summary>
    public class BaseMeal : IRead
    {
        public string Name { get; set; }

        // List of available dishes for the current meal
        public List<Dish> Dishes { get; set; }

        /// <summary>
        /// Get a dish by its key
        /// </summary>
        /// <param name="key">Key of the desired dish</param>
        /// <returns>Dish object</returns>
        public Dish Get(int key)
        {
            var dishe = Dishes.FirstOrDefault(x => x.Key == key);
            if (!(dishe == null))
                return dishe;
            return new Dish() { Name = "error" };
        }
    }
}
