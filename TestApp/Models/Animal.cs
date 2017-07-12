using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Animal
    {
        public string Species { get; set; }
        public int Legs { get; set; }
        public IEnumerable<string> Diet { get; set; }
        public Animal() { Species = "Puppy"; Legs = 4; Diet =  new List<string>{ "Dog food", "Newspapers"}; }
    }
}
