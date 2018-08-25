using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Interfaces
{
    /// <summary>
    /// This interface represents all 
    /// reading operations of the business layer
    /// </summary>
    interface IRead
    {
        Dish Get(int key);
    }
}
