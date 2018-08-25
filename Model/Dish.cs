using System;

namespace Model
{
    /// <summary>
    /// Dish object to represent every available dishes
    /// </summary>
    public class Dish
    {
        public int Key { get; set; }
        public string Name { get; set; }

        // Determine if current dish is available for multiple requests
        public bool IsMultiple { get; set; }
    }
}
