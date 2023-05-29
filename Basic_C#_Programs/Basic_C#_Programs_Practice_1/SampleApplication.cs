

/*** -----------------------------------------------------------------------------------------------------------------------------------------------------------  

                                                                            NEW C# Terms:

Console.WriteLine(“Hello, World!”); 
    - a C# instruction to console that prints “Hello, World!” on screen. Like JS, semicolon is used to end any specific C# instruction.


System 
    - is the main namespace of the BaseClassLibrary (massive library of code that provides the most basic functionality of the C# language).


Using 
    - a keyword that tells compiler that I’ll be utilizing the System library.


class SampleApplication 
    - tells compiler that anything between curly braces { } = part of class named SampleApplication. here, a class is an organized grouping of code.


Main() 
    - a function that tells the compiler to execute anything between curly braces. 
    - in a console application, a function w/ the name “Main()” is automatically executed as first step in running the prog.


static 
    - a keyword used as a type of modifier for the Main() function. It refers to itself rather than creating an instance of the class it’s modifying.
    - tells the compiler that this function can be called without relying on reference to an object.


void 
    - another modifier of the Main() function. It tells the compiler that this function isn’t going to return a value. 
    - instead, it’s just going to perform an action (like printing words to the console).

 ----------------------------------------------------------------------------------------------------------------------------------------------------------- ***/

 using System;

 class SampleApplication {
    static void Main() {
        Console.WriteLine("Hallo, Zusammen!");
    }
 }