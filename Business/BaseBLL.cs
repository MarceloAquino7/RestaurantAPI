using Business.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    /// <summary>
    /// Base class to represent all meal business operations
    /// </summary>
    public class BaseBLL : IHelper, IExecute
    {
        BaseMeal Base;


        // Constructor
        public BaseBLL(BaseMeal BaseMeal = null)
        {
            Base = BaseMeal == null ? new BaseMeal() : BaseMeal;
        }

        /// <summary>
        /// Method to process the current input
        /// </summary>
        /// <param name="input">Params of the requested meal</param>
        /// <returns>string with the description of the request</returns>
        public string Process(string[] input)
        {
            var result = "";

            var input_values = Sanitize(input);

            var values_ocurrency = Evaluate(input_values);

            foreach (KeyValuePair<int, int> entry in values_ocurrency)
            {
                var current_dish = Base.Get(Convert.ToInt32(entry.Key));
                result += current_dish.Name;

                if (entry.Value > 1 && current_dish.IsMultiple)
                    result += string.Format("(x{0})", entry.Value);

                if (!(entry.Key == input_values.Last()))
                    result += ", ";
            }

            return result;
        }

        /// <summary>
        /// Method to sanitize the current inputs 
        /// to prevent invalid data
        /// </summary>
        /// <param name="inputs">Params of the requested meal</param>
        /// <returns>List with the number/key of the dishes</returns>
        public List<int> Sanitize(string[] inputs)
        {
            var sanitized_values = new List<int>();
            var input_values = inputs.ToList();
            input_values.RemoveAt(0);
            
            int value = 0;

            foreach (string item in input_values)
            {
                Int32.TryParse(item, out value);
                if (value != 0)
                    sanitized_values.Add(Convert.ToInt32(item));
                value = 0;
            }

            sanitized_values = sanitized_values.OrderBy(x => x).ToList();
            return sanitized_values;
        }

        /// <summary>
        /// Method to search for multiple dishes 
        /// requested on the parameter
        /// </summary>
        /// <param name="inputs">List of desired dishes key</param>
        /// <returns>Dictionary with Dish Key as key and Dish Count as value</returns>
        public Dictionary<int, int> Evaluate(List<int> inputs)
        {
            var input_ocurrency = new Dictionary<int, int>();

            foreach (int item in inputs)
            {
                if (!input_ocurrency.ContainsKey(item))
                {
                    int count = inputs.Count(x => x == item);
                    input_ocurrency.Add(item, count);
                }
            }
            return input_ocurrency;
        }
    }
}
