using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    /// <summary>
    /// Class to represent all operations inside morning meals
    /// </summary>
    public class MorningBLL : BaseBLL
    {
        private MorningMeal MorningMeal;

        // Constructor
        public MorningBLL() : base(new MorningMeal())
        {
            MorningMeal = new MorningMeal();
        }
    }
}
