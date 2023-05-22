using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR_ASSIGNMENT
{
    public class vikClass
    {
        public string Bezeichnung { get; set; }

        // Parameter for a constructor
        public vikClass(string name)
        {
            Bezeichnung = name;
        }
        // Connecting/chaining constructors w/ eachother
        public vikClass() : this("Voreinstellung")
        {
        }
    }
}