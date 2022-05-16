// Starting with .NET 6, the project template for new C# console apps generates the following code in the Program.cs file:



                    // // See https://aka.ms/new-console-template for more information
                    // Console.WriteLine("Hello, World!");


// The new output uses recent C# features that simplify the code you need to write for a program. For .NET 5
// and earlier versions, the console app template generates the following code:


                using System;

                namespace MyApp // Note: actual namespace depends on the project name.
                {
                    internal class Program
                    {
                        static void Main(string[] args)
                        {
                            Console.WriteLine("Hello Worldssssssss");
                            // int number = 5;
                            // Console.WriteLine(number);


                             string number;
            Console.WriteLine("Enter a number:");
            number = Console.ReadLine();

            Console.WriteLine($"You entered :{(object)number}");
            Console.ReadLine();




class Program
    {
        static void Main(string[] args)
        {
            int area, length, width;
            Console.Write("Please write the length of your rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please write the width of your rectangle: ");
            width = Convert.ToInt32(Console.ReadLine());
            area = length * width;
            Console.WriteLine("The area of rectangle : {0}", area);
            Console.ReadKey();
        }
    }

        }










static void Main(string[] args)
        {
            int squareheight,area,perimeter;
            Console.Write("What is the height of your square? :");
            squareheight = Convert.ToInt32(Console.ReadLine());
            area = squareheight * squareheight;
            perimeter = 4 * squareheight;
            Console.WriteLine("Area : {0}\nPerimeter : {1}",area,perimeter); //   "\n"--> new line
            Console.ReadKey();
        }

                    }
                }



    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         int number;
    //         Console.Write("Enter a number:");
    //         number = Convert.ToInt32(Console.ReadLine());

    //         Console.WriteLine("You entered :{0}",number);
    //         Console.ReadLine();
    //     }
    // }
