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
        // A dictionary to map between the string and the delegate.
        private Dictionary<string, CalcDelegate> dictionary = new Dictionary<string, CalcDelegate>();
        // The indexer.
        public CalcDelegate this[string i] {
            // Get the item from the dictionary.
            get {
                // We will return the default value if not found in the dictionary.
                if (!(dictionary.ContainsKey(i))) {
                    return val => val;
                }
                return dictionary[i];
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