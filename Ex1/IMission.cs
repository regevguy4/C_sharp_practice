using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public interface IMission
    {
        event EventHandler<double> OnCalculate;  // An Event of when a mission is activated

        String Name { get; }
        String Type { get; }

        /* returning the calculated value of
           the mission while activated on the input.*/

        double Calculate(double value);
    }
}
