using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interface
{

    interface IShape
    {
        string Name { get; set; }

        /// <summary>
        /// area calculation formula
        /// </summary>
        /// <returns></returns>
        double Square();

        void Display();
    }
}
