/*********************************************************
 * Demonstrate operator overloading
 * We 'add' a Fish and an Apple
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * *******************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishPlusApple {
    /// <summary>
    /// A fish class. It will be added to an Apple to produce a FishApple, whatever that is.
    /// </summary>
    class Fish {
        public Fish(String fishName) {
            this.fishName = fishName;
        }
        public String fishName { get; set; }
    }
}
