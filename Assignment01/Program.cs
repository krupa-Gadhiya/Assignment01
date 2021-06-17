using System;
namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            int choice;
            int length;
            int width;
            length = ValidInput("Length");
            width = ValidInput("width");

            Console.WriteLine($"Rectangle lenght is {length} and width is {width}.\n");
            Rectangle customRect = new Rectangle(length, width);
            r = customRect;

            choice = MenuSelection();

            while (choice != 7)
            {
                int result;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Rectangle Length is: {r.GetLength()}\n");
                        break;
                    case 2:
                        result = ValidInput("length");
                        r.SetLength(result);
                        break;
                    case 3:
                        Console.WriteLine($"Rectangle width is: {r.GetWidth()}\n");
                        break;
                    case 4:
                        result = ValidInput("width");
                        r.SetWidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"Rectangle Perimeter of {r.GetLength()} and {r.GetWidth()} is: {r.GetPerimeter()}\n");
                        break;
                    case 6:
                        Console.WriteLine($"Rectangle Area of {r.GetLength()} and {r.GetWidth()} is: {r.GetArea()}\n");
                        break;
                    default:
                        break;
                }

                choice = MenuSelection();

            }
        }
        public static int MenuSelection()
        {
            string takeInput = "";
            bool validSelection = false;
            int takeInpuInt;

            while (validSelection == false)
            {
                Console.WriteLine("1.Get Rectangle Length");
                Console.WriteLine("2.Change Rectangle Length");
                Console.WriteLine("3.Get Rectanglewidth");
                Console.WriteLine("4.Change Rectangle width");
                Console.WriteLine("5.Get Rectangle Perimeter");
                Console.WriteLine("6.Get Rectangle Area");
                Console.WriteLine("7.Exit\n");

                Console.WriteLine("Please select an option:\n");
                takeInput = Console.ReadLine();
                takeInpuInt = int.Parse(takeInput);

                if (takeInpuInt <= 0 || takeInpuInt > 7)
                {
                    Console.WriteLine("Chosse correct option\n");
                }
                else
                {
                    validSelection = true;
                }
            }

            Console.WriteLine();
            return int.Parse(takeInput);
        }

        public static int ValidInput(string userNumber)
        {
            int valiDate = 0;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {userNumber} :");
                string takeInput = Console.ReadLine();
                valiDate = int.Parse(takeInput);

                if (valiDate <= 0)
                {
                    Console.WriteLine("That's not a valid input please, please Enter value again.\n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"Rectangle {userNumber} is: {valiDate}\n");
                }
            }

            return valiDate;
        }
    }
}
