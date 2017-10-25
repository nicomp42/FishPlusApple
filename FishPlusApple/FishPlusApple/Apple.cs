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
    class Apple {

        public Apple(String appleName) {
            this.appleName = appleName;
        }
        public String appleName { get; set; }
        /// <summary>
        /// Overload the + operator to handle a Fish object and an Apple object. 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public static FishApple operator +(Apple a, Fish f) {
            FishApple fishApple = new FishApple("");
            // How do you add a Fish object and an Apple object? Any way you want to!
            fishApple.name = a.appleName + ", " + f.fishName;
            return fishApple;
        }

    }
}
