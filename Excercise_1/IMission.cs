using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excercise_1 {
    // The mission interface, implemented by SingleMission and ComposedMission.
    public interface IMission {
        // An Event of when a mission is activated
        event EventHandler<double> OnCalculate;
        // Get the name of the mission.
        String Name { get; }
        // Get the type of the mission.
        String Type { get; }
        // Calculate the value of the mission.
        double Calculate(double value);
    }
}