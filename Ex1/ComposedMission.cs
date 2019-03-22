using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Ex1
{
    public class ComposedMission : IMission
    {
        private List<Operation> operations;

        public event EventHandler<double> OnCalculate;


        public ComposedMission(string name)
        {
            operations = new List<Operation>();
            Name = name;
        }


        public String Name { get; }
        public String Type { get { return "Composed"; } }


        public ComposedMission Add(Operation op)
        {
            if (op != null)
            {
                operations.Add(op);
                return this;
            } else
            {
                throw new ArgumentException("ERROR! null pointer canno't be an operation!\n");
            }
        }


        public double Calculate(double value)
        {
            if(operations == null)
            {
                throw new Exception("ERROR! There's is no registered missions.");
            } else
            {
                /* getting the value after activating
                 * all of the methods at the list.*/

                foreach(Operation op in operations)
                {
                    value = op(value);
                }
                // if not NULL - invoking the registered methods.
                OnCalculate?.Invoke(this, value);
            }
            return value;
        }
    }
}