using System;
using System.IO;

namespace Pets {
    public class Dog : Pet {
        public Dog(string petName, string ownerName, double petWeight)
         : base("dog", petName, ownerName, petWeight) {
            name = petName;
            owner = ownerName;
            weight = petWeight; 
        }

        public string bark(int count) {
            string barks = "";
            for(int i = 0; i <= count - 1; i++) {
                barks += "bark!";
            }
            return barks;
        }
    }
}