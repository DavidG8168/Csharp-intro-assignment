using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excercise_1 {
    // The ComposedMission class, stores a complex function from the container.
    public class ComposedMission : IMission {
        // The members of the class.
        // By using a linked list, we can store the delegates.
        private LinkedList<CalcDelegate> calcs = new LinkedList<CalcDelegate>();
        // The class constructor.
        // Contains the type and name.
        public ComposedMission(string name) {
            this.Type = "Composed";
            this.Name = name;
        }
        // Property getters.
        // Get the mission name.
        public string Name { get; }
        // Get the mission type.
        public string Type { get; }
        // Insert the function into the list and return a refrence to it.
        public ComposedMission Add(CalcDelegate calc) {
            calcs.AddLast(calc);
            return this;
        }
        // An Event of when a mission is activated
        public event EventHandler<double> OnCalculate;
        // Calculate the value of the composed mission function by using the elements in the list.
        public double Calculate(double val) {
            foreach (CalcDelegate c in calcs) {
                val = c(val);
            }
            // Notify everyone.
            OnCalculate?.Invoke(this, val);
            return val;
        }
    }
}