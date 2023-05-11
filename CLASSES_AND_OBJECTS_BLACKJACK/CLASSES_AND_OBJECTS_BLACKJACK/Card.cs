using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        // "Class = cookie cutter and Object = the actual cookie"
        // 2. a. time to add some properties to this card aka its state  --  ask yourself "what kind of properties does a card have?"

        // EXAMPLE (not part of step 2 -- refereced in step 11 a): sometimes its useful to have default values assigned to an object immediately upon creation  -- Constructor method name is always the name of the class (in this case 'Card')
        // this is just for EXAMPLE and for it to work I will go to the Program.cs file and temp comment out the values assigned to the cardOne object
        // Constructor = values assigned to an object upon creation -- EXAMPLE of this syntax in line below:
        //public Card()
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}
        // will comment out after testing EXAMPLE to not confuse myself 

        // 2. b. has a property called 'suit' i.e. diamond, heart, spade, ace  --  define/set this value as a string data type

        // it won't do anything util we start using methods  --  only 2 things you can do w/ obj property is 'get' and 'set' | public means it is accessable to other parts of prg
        // C# shorthand for creating properties within objects syntax:
        // the line below translates to "Card class has a property of data type string called 'Suit' and you can get or set this property"
        public string Suit { get; set; }

        // 3. a card also has a 'face' i.e. aces, queens, kings, 10s, 2s, etc.  --  assign 'face' property to a string data type
        public string Face { get; set; }

        // 4. what do we do with these classes aka the model/design for an object?  --  objs modeled after these properties can now be given some kind of value -- go back to 'Program ' file step 5

        
    }
}
