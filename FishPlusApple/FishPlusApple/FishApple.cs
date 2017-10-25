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
    /// What do you get when you add a Fish and an Apple? A FishApple!
    /// </summary>
    class FishApple {

        public FishApple(String name) {
            this.name = name;
        }
        public String name { get; set; }


    }
}
