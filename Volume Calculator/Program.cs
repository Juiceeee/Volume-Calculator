#region Namespace

using System;

#endregion

namespace Volume_Calculator // Grouping classes in to folders the more you have later keeps architecture clean.
{
    /// <summary>The <see cref="Program"/> class.</summary>
    internal class Program
    {
        #region Constants

        /// <summary>The console title.</summary>
        private const string CONSOLE_TITLE = "Volume Calculator";

        /// <summary>The exit code message.</summary>
        private const string EXIT_CODE_MESSAGE = "Press any Key to Exit...";

        /// <summary>The height.</summary>
        private const string HEIGHT = "Height";

        /// <summary>The input was invalid and requires a number.</summary>
        private const string INVALID_NUMERIC_INPUT = "Please only input numerical values. [0-9]";

        /// <summary>The request input.</summary>
        private const string REQUEST_INPUT = "Please enter the";

        /// <summary>The volume.</summary>
        private const string VOLUME = "Volume";

        /// <summary>The width.</summary>
        private const string WIDTH = "Width";

        #endregion

        #region Methods

        /// <summary>Calculates the volume.</summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns>System.Int32.</returns>
        private static int CalculateVolume(int width, int height)
        {
            int volume = width * height;

            return volume;
        }

        /// <summary>The intro to this application.</summary>
        /// <param name="back">The back.</param>
        /// <param name="front">The front.</param>
        private static void Intro(ConsoleColor back, ConsoleColor front)
        {
            // Assign the console title
            Console.Title = CONSOLE_TITLE;

            // Customize the console with your colors
            Console.BackgroundColor = back;
            Console.ForegroundColor = front; // This allows customization of colors without giving perma-defautl!

            // Introduction
            Console.WriteLine("Purpose: This application will to calculate the " + VOLUME + " of your dimensions.");
            Console.WriteLine(string.Empty);

            // Insert other intro text after...
        }

        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args) // Ignore the 'string[] args' for now. That is only if you want your app to run with pre-configured settings and values.
        {
            // TODO: Validate input is a null / space or an empty field.
            // TODO: When user enters invalid input loop the same request until they do it right. The next code wont work if they don't enter the correct format.

            // Run all lines of code in Intro first 
            Intro(ConsoleColor.Black, ConsoleColor.Green);

            // Defines the variables we will be using later to store our values.
            int width = 0;
            int height = 0;
            int volume = 0;

            // Request the users input for width and height to calculate the volume of the dimensions.
            Console.WriteLine(REQUEST_INPUT + " fields below to find the " + VOLUME + ".");
            Console.WriteLine(string.Empty);

            // WIDTH ------------------

            // Request user input
            Console.Write(REQUEST_INPUT + " " + WIDTH + ": ");

            // Reads the input line as a string into w.
            string _width = Console.ReadLine();

            // If the _width can converted / parsed to a number then it puts the value in an out (output) result variable.
            if (int.TryParse(_width, out int result))
            {
                // Conversion from text to number passed.
                width = result;
                Console.WriteLine("Registered the " + WIDTH + ": " + width);
                Console.WriteLine(string.Empty);
            }
            else if (string.IsNullOrEmpty(_width)) // Checks the _width is not an empty space or a null
            {
                // Let the user know only numbers are allowed no empty spaces.
                Console.WriteLine(INVALID_NUMERIC_INPUT);
            }
            else // Conversion from text to number failed.
            {
                // Let the user know only numbers are allowed.
                Console.WriteLine(INVALID_NUMERIC_INPUT);
            }

            // TODO: Create a loop so the user has no choice to continue until we get a number

            // HEIGHT ------------------

            // Request the height value

            Console.Write("Input your height: ");

            // Read the input text or number into h variable
            string h = Console.ReadLine();

            // Converts the h into a height number if possible
            height = int.Parse(h);

            Console.WriteLine("You have entered the height: " + height);

            // DO THE MATH

            // Find the volume with basic math
            volume = width * height;

            // Output the values to console
            Console.WriteLine(string.Empty);

            Console.WriteLine("Results:");

            Console.WriteLine("Width: " + width);
            Console.WriteLine("Height: " + height);

            // Leave a spacing here to make this not as cluttered on the output window the user like a jumble of text.
            Console.WriteLine(string.Empty);

            Console.WriteLine("Volume: " + volume);

            // Wait for user input before exiting the code.

            Console.WriteLine(EXIT_CODE_MESSAGE);

            Console.Read();
        } // Your code ends here

        #endregion
    }
}