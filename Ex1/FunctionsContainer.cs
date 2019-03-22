using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public delegate double Operation(double param);

    public class FunctionsContainer
    {
        private Dictionary<string, Operation> container;

        public FunctionsContainer()
        {
            container = new Dictionary<string, Operation>();
        }

        public Operation this [string name]
        {
            get
            {
                /* checks if the function key is in the container. if isn't -
                 adding it, and define it as the ID function. */

                if (!container.ContainsKey(name))
                {
                    container.Add(name, val => val);
                }
                return container[name];
            }

            set { container[name] = value; }
        }

        // returning the names of all  the missions in the container.
        public List<string> getAllMissions()
        {
            var funcNames = new List<string>();

            foreach(var mission in container)
            {
                funcNames.Add(mission.Key);
            }
            return funcNames;
        }
    }
}
