using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excercise_1 {
    // Create a CalcDelegate.
    public delegate double CalcDelegate(double val);
    // FunctionContainer has the indexer, that maps between the function and its implementation.
    public class FunctionsContainer {
        // The members of the class.
        // A dictionary to map between the string and the delegate.
        private Dictionary<string, CalcDelegate> dictionary = new Dictionary<string, CalcDelegate>();
        // The indexer.
        public CalcDelegate this[string i] {
            // Get the item from the dictionary.
            get {
                // Return value if found in dictionary.
                if (dictionary.ContainsKey(i)) {
                    return dictionary[i];
                }
                // Otherwise return the default.
                else {
                    return val => val;
                }
            }
            // Set the value of the item in the dictionary.
            set {
                dictionary[i] = value;
            }
        }
        // Return a new list with all the current missions.
        public List<string> getAllMissions() {
            // Create a list and return it.
            return new List<string>(this.dictionary.Keys);
        }
    }
}