using System;

namespace BranchingAssignment

/*----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Create a console-based application for getting a shipping quote for a package

REQUIREMENTS:

1. The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
2. The user must then be prompted for the package weight.
3. If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express. Have a good day.” At this point the program would end.
4. The user must then be prompted for the package width.
5. Then the package height.
6. Then the package length.
7. If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
8. Next, multiply the three dimensions (height, width, & length) together, and multiply the product by the weight. Finally, divide the outcome by 100.
9. The result of that calculation is the quote.
10. Display the quote to the user as a dollar amount.

OUTPUT EXAMPLE:

    Welcome to Package Express. Please follow the instructions below.
    Please enter the package weight:
    40
    Please enter the package width:
    10
    Please enter the package height:
    12
    Please enter the package length:
    11
    Your estimated total for shipping this package is: $528.00
    Thank you!

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below:\n");

            // 2. user must then be prompted for the package weight.
            Console.WriteLine("Please enter the package weight:");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());

            // 3. If the pkgWeight is greater than 50, display error message, “Package too heavy to be shipped via Package Express. Have a good day.” At this point the program would end = 'return'.
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            // 4. user must then be prompted for the package width.
            Console.WriteLine("Please enter the package width:");
            int pkgWidth = Convert.ToInt32(Console.ReadLine());

            // 5. Then the package height
            Console.WriteLine("Please enter the package height:");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());

            // 6. Then the package length.
            Console.WriteLine("Please enter the package length:");
            int pkgLength = Convert.ToInt32(Console.ReadLine());

            // 7. If dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end = 'return'.
            // the 'dimentions' will be assigned the value of pkgWidth + pkgHeight + pkgLength
            int dimentions = pkgWidth + pkgHeight + pkgLength;

            // I wrote a simple if statement here to determine if the package will qualify for shipping services
            if (dimentions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            // 8. multiply the three dimensions (height, width, & length) together, and multiply the product by the weight. Lastly, divide the outcome by 100.
            // 9. result of this calculation is the 'quote'.
            int quoteResult = pkgWidth * pkgHeight * pkgLength * pkgWeight / 100;

            // 10. Display the quote to the user as a dollar amount.
            Console.WriteLine("Your estimated total for shipping this package is: $" + quoteResult + ".00" + "\nThank you!");
            Console.ReadLine();
        }
    }
}
