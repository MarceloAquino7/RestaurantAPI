using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// This class represents the current meal available for night time
    /// </summary>
    public class NightMeal : BaseMeal
    {
        // Constructor
        public NightMeal(string name="night", List<Dish> dishes = null)
        {
            // Initialization of Dishes list due to no DB
            if (dishes == null)
            {
                dishes = new List<Dish>() {
                    new Dish()
                    {
                        Name = "steak",
                        Key = 1,
                        IsMultiple = false
                    },
                    new Dish()
                    {
                        Name = "potato",
                        Key = 2,
                        IsMultiple = true
                    },
                    new Dish()
                    {
                        Name = "wine",
                        Key = 3,
                        IsMultiple = false
                    },
                    new Dish()
                    {
                        Name = "cake",
                        Key = 4,
                        IsMultiple = false
                    }
                };
            }

            Name = name;
            Dishes = dishes;
        }
    }
}
