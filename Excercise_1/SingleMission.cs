using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excercise_1 {
    // The SingleMission class, stores a simple function from the container.
    public class SingleMission : IMission {
        // The members of the class.
        // We can store the function we need to calculate using a delegate.
        private CalcDelegate CalcDel;
        // The class constructor.
        // Contains the type, name and delegate.
        public SingleMission(CalcDelegate calcDel, string name) {
            this.Type = "Single";
            this.Name = name;
            this.CalcDel = calcDel;
        }
        // Property getters.
        // Get the mission name.
        public string Name { get; }
        // Get the mission type.
        public string Type { get; }
        // An Event of when a mission is activated.
        public event EventHandler<double> OnCalculate;
        // Calculates the value of the function.
        public double Calculate(double val) {
            // Calculate the value.
            val = CalcDel(val);
            // Notify everyone.
            OnCalculate?.Invoke(this, val);
            return val;
        }
    }
}