using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    /// <summary>
    /// Class to represent all operations inside night meals
    /// </summary>
    public class NightBLL : BaseBLL
    {
        private NightMeal NightMeal;

        // Constructor
        public NightBLL() : base(new NightMeal())
        {
            NightMeal = new NightMeal();
        }
    }
}
