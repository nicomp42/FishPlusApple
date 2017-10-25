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
    class Program {
        static void Main(string[] args) {
            Fish bass = new Fish("Billy Bass");
            Apple redDelicious = new Apple("Johnny Appleseed");
            FishApple fishApple;    // Wo do not need to instantiate this, that will be done for us in the + oprator...

            // Invoke the overloaded operator. See the Apple class. 
            fishApple = redDelicious + bass;    // This is actually a method call. 

            Console.WriteLine("Apple + Fish = " + fishApple.name);

        }
    }
}
