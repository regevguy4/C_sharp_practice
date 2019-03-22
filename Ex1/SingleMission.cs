using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class SingleMission : IMission
    {
        private Operation operation;

        public event EventHandler<double> OnCalculate;

        public String Name { get; }
        public String Type { get { return "Single"; } }

        public SingleMission(Operation op, string name)
        {   
            operation = op;
            Name = name;
        }
        
        public double Calculate(double value)
        {
            // getting the value of the mission on the input.
            double calcValue = operation(value);

            // if not NULL - invoking the registered methods.
            OnCalculate?.Invoke(this, calcValue);

            return calcValue;
        }
    }
}
