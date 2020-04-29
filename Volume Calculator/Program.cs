using System;

namespace Volume_Calculator // Grouping classes in to folders the more you have later keeps architecture clean.
{
    class Program // Start of app for the compiler to begin reading 
    {

        // TODO: Create console volume calculator.


        // We can place variables outside here for all methods to access

        static void Main(string[] args) // Ignore the args for now come in later.
        { // Your code begins below here

            Console.Title = "Volume Calculator";
            // We can place variables here for only Main() to access..

            //Console.WriteLine("Give app a title: ");
            //string title = Console.ReadLine();

            //Console.Title = title;

            //^^^^ Works


            // Defines the variables we will be using later to store our values.
            int width = 0;
            int height = 0;
            int volume = 0;

            // TIP: int = number, string = text

            Console.Write("Input your width: ");


            // Reads the input line as a string into w.
            string w = Console.ReadLine();

            // Converts the w variable into a width.

            // It tryies to convert the 'w' variable IF its a number in string format. And put it into 'width' variable.
            width = int.Parse(w); // When you hold yourt mouse over Parse() it will give a description of that it does.

            Console.WriteLine("You have entered the width: " + width);
            

            // Request the height value

            Console.Write("Input your height: ");


            // Read the input text or number into h variable
            string h = Console.ReadLine();

            // Converts the h into a height number if possible
            height = int.Parse(h);

            Console.WriteLine("You have entered the height: " + height);

            // Find the volume with basic math
            volume = width * height;

            // Output the values to console

            Console.WriteLine("Width: " + width);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Volume: " + volume);

            // Wait for user input before exiting the code.

            Console.WriteLine("Press enter to close...");
            Console.Read();


        } // Your code ends here

       
    }
}