using System;

namespace Lab_2._1_Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        { 
           
       
            Console.WriteLine("Enter the Length of the Room:");
            string EntryL = Console.ReadLine();
            double length = double.Parse(EntryL);


            

            Console.WriteLine("Enter the Width of the Room:");
            string EntryW = Console.ReadLine();
            double width = double.Parse(EntryW);

           
            double perimeter = 2 * (length + width);
            Console.WriteLine("The perimeter of the room is " + perimeter);

            double area = length * width;
            Console.WriteLine(" The area of the room is " + area);

            if (area >= 650)
            {
                Console.WriteLine("This room is HUGE!");
            }
          
             
           

           


        }
    }
}
