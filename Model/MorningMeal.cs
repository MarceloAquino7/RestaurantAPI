using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// This class represents the current meal available for morning time
    /// </summary>
    public class MorningMeal : BaseMeal
    {
        // Constructor
        public MorningMeal(string name = "morning", List<Dish> dishes = null)
        {
            // Initialization of Dishes list due to no DB
            if (dishes == null)
            {
                dishes = new List<Dish>() {
                    new Dish()
                    {
                        Name = "eggs",
                        Key = 1,
                        IsMultiple = false
                    },
                    new Dish()
                    {
                        Name = "toast",
                        Key = 2,
                        IsMultiple = false
                    },
                    new Dish()
                    {
                        Name = "coffee",
                        Key = 3,
                        IsMultiple = true
                    }
                };
            }

            Name = name;
            Dishes = dishes;
        }
    }
}
