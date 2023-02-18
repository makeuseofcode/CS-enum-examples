using System;

namespace enum_example
{
    class Program
    {
        enum Weekday
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            // Access enum #1
            string friday = Enum.GetName(typeof(Weekday), Weekday.Friday);
            Console.WriteLine("Thank God it's " + friday + "!"); // Output = Thank God it's Friday!

            // Access enum #2
            Weekday tuesday = (Weekday)2;
            Console.WriteLine("Today is " + tuesday); // Output = Today is Tuesday

            // Access enum #3
            Console.WriteLine(Weekday.Thursday + " is the new " + Weekday.Friday); // Output = Thursday is the new Friday

            // Access enum #4
            int mondayIndex = (int)Weekday.Monday;
            Console.WriteLine(mondayIndex); // Output = 1

            // Compare enum #1
            Console.WriteLine("");
            Weekday day1 = Weekday.Monday;
            Weekday day2 = Weekday.Tuesday;

            if (day1 == day2)
            {
                Console.WriteLine("The days are the same.");
            }
            else
            {
                Console.WriteLine("The days are different.");
            }

            // Compare enum #2
            if (day1.Equals(day2))
            {
                Console.WriteLine("The days are the same.");
            }
            else
            {
                Console.WriteLine("The days are different.");
            }

            // Compare enum #3
            Weekday valueToCompare = Weekday.Wednesday;
            switch (valueToCompare)
            {
                case Weekday.Monday:
                    Console.WriteLine("I need coffee.");
                    break;
                case Weekday.Tuesday:
                    Console.WriteLine("I need coffee.");
                    break;
                case Weekday.Wednesday:
                    Console.WriteLine("I need coffee.");
                    break;
                case Weekday.Thursday:
                    Console.WriteLine("Thursday is the new Friday!");
                    break;
                case Weekday.Friday:
                    Console.WriteLine("Thank God it's Friday!");
                    break;
                case Weekday.Saturday:
                    Console.WriteLine("My favorite day!");
                    break;
                case Weekday.Sunday:
                    Console.WriteLine("My other favorite day!");
                    break;
                default:
                    Console.WriteLine("Invalid day of the week.");
                    break;
            }

            // Iterate over enums #1
            Console.WriteLine("");
            foreach (Weekday day in Enum.GetValues(typeof(Weekday)))
            {
                //Console.WriteLine((int)day); // To print the index
                Console.WriteLine(day); // To print the text value
            }

            // Iterate over enums #2
            Console.WriteLine("");
            foreach (string name in Enum.GetNames(typeof(Weekday)))
            {
                //int index = (int)(Weekday)Enum.Parse(typeof(Weekday), name);
                //Console.WriteLine(index); // To print the index

                Console.WriteLine(name); // To print the text value
            }
        }
    }
}
