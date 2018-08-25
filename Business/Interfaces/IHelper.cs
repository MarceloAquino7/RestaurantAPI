using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    /// <summary>
    /// This interface represents all 
    /// helping operations of the business layer
    /// </summary>
    interface IHelper
    {
        List<int> Sanitize(string[] inputs);

        Dictionary<int, int> Evaluate(List<int> inputs);
    }
}
