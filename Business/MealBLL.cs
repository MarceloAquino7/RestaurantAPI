using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    /// <summary>
    /// Main class to work with meal logical business process
    /// </summary>
    public static class MealBLL
    {
        /// <summary>
        /// Method to identify the right business and request for its processing
        /// </summary>
        /// <param name="Items">Current params of the requested meal</param>
        /// <returns>string with the description of the request</returns>
        public static string ProcessRequest(string Items)
        {
            Items = Items.ToLower();
            string[] Input = Items.Split(",");

            string MealTime = Input[0];
            var MealBll = MealFactory(MealTime);

            if (MealBll == null)
                return "Invalid Meal Id";

            return MealBll.Process(Input);
        }

        /// <summary>
        /// Method to be used to determine 
        /// which business class should be used
        /// </summary>
        /// <param name="id">Meal time id</param>
        /// <returns>Respective business object</returns>
        public static BaseBLL MealFactory(string id)
        {
            if (id == "morning")
                return new MorningBLL();
            else if (id == "night")
                return new NightBLL();

            return null;
        }
    }
}
