namespace Prog_Fundamentals_Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {

        // Label : Start of our Menu
        Start:
            // Display program information
            Console.WriteLine("// Name: Your Name");
            Console.WriteLine("// Date: The Current Date");
            Console.WriteLine("// Assignment: Programming 120 - Midterm\n");


            Console.WriteLine("Midterm App Main Menu:");
            Console.WriteLine("1. Calculator");
            Console.WriteLine("2. Financial Calculator");
            Console.WriteLine("3. Geometry Calculator");
            Console.WriteLine("4. Cartesian Plane");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();


            //---- Calculator----------------
            if (choice == "1")
            {
            // Calculator

            // Label : Start of calculator
            CalculatorStart:
                // Display the name of the Calculator app and prompt the user to enter a number or type 'exit' to return to the main menu.
                Console.WriteLine("\nCalculator App:");
                Console.WriteLine("Enter a number (or type 'exit' to return to the main menu):");
                string input = Console.ReadLine();

                // Check if the user wants to exit the calculator app.
                if (input.ToLower() == "exit") goto Start;

                double initialNumber; // Variable to store the first user input as a number.

                // Attempt to parse the user input into a double. If the input is not a valid number, catch the FormatException and prompt again.
                try
                {
                    initialNumber = double.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                    goto CalculatorStart; // Go back to the start of the calculator app to allow the user to enter a number again.
                }

                // Prompt the user for a second number.
                Console.WriteLine("Enter a second number: ");
                string userSecondNumber = Console.ReadLine();

                double secondNumber; // Variable to store the second user input as a number.

                // Attempt to parse the second user input into a double. If the input is not a valid number, catch the FormatException and prompt again.
                try
                {
                    secondNumber = double.Parse(userSecondNumber);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                    goto CalculatorStart; // Go back to the start of the calculator app to allow the user to enter the second number again.
                }

                // Display options for mathematical operations: Add, Subtract, Multiply, Divide, or Exit the calculator app.
                Console.WriteLine("Options: 1. Add, 2. Subtract, 3. Multiply, 4. Divide, 5. Exit");
                Console.Write("Select an operation: ");
                string operation = Console.ReadLine();

                // At this point, further implementation would be needed to handle the operation selection and perform the desired calculation.

                if (operation == "1")
                {
                    // Addition Operation
                    double sum = initialNumber + secondNumber;
                    Console.WriteLine($"The sum of {initialNumber} + {secondNumber} = {sum}");

                }
                else if (operation == "2")
                {
                    // Subtract operation
                }
                else if (operation == "3")
                {
                    // Multiply operation
                }
                else if (operation == "4")
                {
                    // Divide operation
                }
                else if (operation == "5")
                {
                    goto Start;
                }
                else
                {
                    Console.WriteLine("Invalid operation, please try again.");
                    goto CalculatorStart;
                }
                goto Start;
            }


            //---- Financial Calculator ----------------
            else if (choice == "2")
            {
                // Placeholder for user input and selection logic for Financial Calculator options:
                // 1. Net Income
                // 2. Rule of 72
                // 3. Net Worth
                // Use if-else statements to navigate between options and try-catch blocks to handle input errors.

                goto Start;
            }

            //---- Geomertry Calculator ----------------
            else if (choice == "3")
            {
                // Placeholder for user input and selection logic for Geometry Calculator options:
                // 1. Square - calculate area and perimeter
                // 2. Rectangle - calculate area and perimeter
                // 3. Circle - calculate area and circumference
                // 4. Right Cone - calculate volume
                // Use if-else statements for shape selection and perform calculations based on inputs.

                goto Start;
            }

            //---- Cartesian Plane ----------------
            else if (choice == "4")
            {
                // Placeholder for input, calculation, and display logic:
                // 1. Ask for x and y values.
                // 2. Determine the quadrant or special case (origin, x-axis, y-axis).
                // Use if-else structures to assess and display the point's location based on x and y values.

                goto Start;
            }
            else if (choice == "5")
            {
                // Exit the program
                return;
            }
            else
            {
                Console.WriteLine("Invalid option, please try again.");
                goto Start;
            }
        }
    }
}
