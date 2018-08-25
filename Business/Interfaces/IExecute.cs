using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    /// <summary>
    /// This interface represents all 
    /// execution operations of the business layer
    /// </summary>
    interface IExecute
    {
        string Process(string[] input);
    }
}
