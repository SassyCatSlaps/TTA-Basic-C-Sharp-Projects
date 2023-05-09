using System;
using System.Collections.Generic;
//using System.Text;

//namespace ARRAYS_AND_LISTS
// **ONCE YOU SET THE SIZE OF THE ARRAY ITS VERY DIFFICULT TO CHANGE IT  --  use to store large quantities of something
//{
    class Program
    {
        static void Main()
        {
        // lists  --  much more adaptable, and have more methods connected to them and  are used than arrays  --  will use the namespace System.Collections.Generic  --  doesn't need the length declared
        // example syntax:
        List<int> intList = new List<int>();
        // add an integer to the 'List' example syntax:
        intList.Add(4);
        intList.Add(10);
        intList.Add(17);
        intList.Remove(17);

        Console.WriteLine(intList[0]);
        Console.ReadLine();

        List<string> stringList = new List<string>();
        stringList.Add("Hallo");
        stringList.Add("Banger");
        stringList.Add("Crew");
        stringList.Remove("Banger");

        Console.WriteLine(stringList[0][1]);
        Console.ReadLine();

        //way to store images in a library with C#:
        // 5000 = image info goes here
        byte[] byteArray = new byte[5000];

        //// arrays = objects  --  way to hold a group of variables  --  still have to declare data type and create a new object of it as part of array syntax  --  ' [] ' = the word "array"
        //// in order to initiliza an array, must create a new instance of the array  --  array length must be defined, meaning you have to put something inside the square array brackets
        //// keyword 'new' is used to create an instance of a class or struct  --  used to allocate memory and initialize an object or a value type
        //// example syntax: int[] variable = new int[];
        //// Example: MyClass obj = new MyClass();

        //int[] NumArray = new int[5];
        //// add items to array by calling the index spot for that element 
        //NumArray[0] = 5;
        //NumArray[1] = 2;
        //NumArray[2] = 10;
        //NumArray[3] = 200;
        //NumArray[4] = 5000;

        //// below is the same code above, written in a single line that is simpler and way easier to read:
        //int[] NumArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 }; 

        //// another, even faster and easier way to create arrays -- where you dont even have to say youre creating an array and can just use curly brackets {}
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //// now lets change a number within that array  --  syntax: variable[insert-index-#-to-be-changed-here] = insert-new-value-here;
        //numArray2[5] = 650;




        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
        }
    }
//}