using System;
namespace Week1Lab3_7progFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            // singe line comment
            /* This is a mult-line
                 comment 
            */
            string address;
            Console.WriteLine("Enter your address or enter 'None' if no permanent address.");
            address = Console.ReadLine();
            if (address.Equals("None"))
            {
                Console.WriteLine("Hope you find a nice place to live!");
            }
            else
            {
                Console.WriteLine("Thanks for entering your address!");
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Repeating this code 3 times");
            }
            /* The line below runs the function called “printAge” */
            printAge(address);
        }
        /*The code below goes AFTER the function called “Main” (not inside Main), 
          because this is a separate function itself. This function takes 1 input parameter 
          of type string & “void” means it returns no data.
        */
        static void printAge(string address)
        {
            Console.WriteLine("The address you entered is " + address);
        }
    }
}