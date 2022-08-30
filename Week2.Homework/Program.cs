using System;

namespace Week2.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1+2
            //Ask for the input
            Console.WriteLine("Please enter your birthday as MM/dd/yyyy:");
            //Store the input
            string birthday_input = Console.ReadLine();
            //Check if valid
            if (day_of_the_week(birthday_input))
            {
                //Convert to correct type
                DateTime birthday = DateTime.Parse(birthday_input);
                //Print out the result
                Console.WriteLine("It was " + birthday.DayOfWeek);
                //Task - 02 also in this region
                //Print out the days that passed since the birthday
                TimeSpan difference = DateTime.Today.Date - birthday;
                Console.WriteLine($"You are {difference.Days} days alive.");
            }
            else
            {
                //Catch the exception
                //Print out the error
                try
                {
                    DateTime birthday = DateTime.Parse(birthday_input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid format!");
                }
            }
            //Try converting to the correct type
            static bool day_of_the_week(string birthday_input)
            {
                if (DateTime.TryParse(birthday_input, out DateTime birthday))
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }


            //Note: Müəllim bu task ucun:
            //https://www.techiedelight.com/convert-string-to-datetime-csharp/
            //https://www.tutorialsteacher.com/csharp/csharp-datetime
            //https://stackoverflow.com/questions/449099/is-it-bad-practice-to-return-from-within-a-try-catch-finally-block
            //https://stackoverflow.com/questions/5177002/how-to-subtract-a-datetime-from-another-datetime
            //mənbələrdən istifadə etmişəm
            #endregion
            #region Task3
            //Create an array store the integers
            int[] integers = new int[3];
            //Loop to get the integers
            for (int i = 0; i < integers.Length; i++)
            {
                //Ask for an integer
                Console.WriteLine($"Input the Integer Number {i + 1}");
                //Store the value
                string inp = Console.ReadLine();
                //Check if the input is valid
                if (int.TryParse(inp, out int integer))
                {
                    integers[i] = integer;
                }
                else
                {
                    try
                    {
                        int.Parse(inp);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("This is not a valid format!");
                    }
                    return;
                }

            }
            //Print out the result
            Console.WriteLine($"The Number {comparison(integers)} is the greatest among {integers.Length}");
            //Compare the numbers
            static int comparison(int[] integers)
            {

                //Create a variable to store the highest integer
                int greatest = 0;
                //Variable to store the index of the highest integer
                int max_index = 0;
                //Loop to find the highest integer
                for (int i = 0; i < integers.Length; i++)
                {
                    if (integers[i] > greatest)
                    {
                        greatest = integers[i];
                        max_index = i;
                    }
                }
                return max_index + 1;

                //    ////2nd option to solve
                //    ////I like the first one more
                //    ////Sort the array
                //    //Array.Sort(integers);
                //    ////Return the highest
                //    //return integers.Length;
            }


            //////Note: Müəllim dynamic code istədim yazım
            //////Ona görə də rəqəmlərin sonuna "st, nd, rd"
            //////Qoymamaq üçün mən də bucür yazdım
            //////Bu mənbələrdən istifadə etdim
            //////https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/passing-arrays-as-arguments
            /////https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-6.0#system-array-sort(system-array)
            #endregion
            #region Task4
            //Ask for the input
            Console.WriteLine("Please input an integer: ");
            //Store it
            string day = Console.ReadLine();
            //Check the value
            if (int.TryParse(day, out int day_number))
            {
                //Matching the correct day name
                switch (day_number)
                {
                    case 0:
                        Console.WriteLine("Sunday");
                        break;
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("This number doesn't match any of the days of the week!");
                        break;
                }
            }
            else
            {
                //Catch the error
                try
                {
                    day_number = int.Parse(day);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid format!");
                }
            }
            #endregion
            #region Task5
            //Create the array
            int[] input_integers = new int[2];
            //Get the integers
            for (int i = 0; i < input_integers.Length; i++)
            {
                Console.WriteLine($"Enter the Integer {i + 1}");
                //Store the input
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    input_integers[i] = result;
                }
                else
                {
                    //Print out the error
                    try
                    {
                        int inp_int = int.Parse(input);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Not a valid input");
                        return;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Your input is too large!");
                        return;
                    }
                }
            }
            //Print the menu to choose from
            Console.WriteLine("Here are the options:");
            Console.WriteLine("1-Addition");
            Console.WriteLine("2-Subtraction");
            Console.WriteLine("3-Multiplication");
            Console.WriteLine("4-Divison");
            Console.WriteLine("5-Exit");
            Console.WriteLine("");
            //Ask for choice
            Console.Write("Input your choice: ");
            string inp_choice = Console.ReadLine();
            //Check the format
            if (int.TryParse(inp_choice, out int choice))
            {
                //Print out the result
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"The Addition of {input_integers[0]} and {input_integers[1]} is: {input_integers[0] + input_integers[1]}");
                        break;
                    case 2:
                        Console.WriteLine($"The Subtraction of {input_integers[0]} and {input_integers[1]} is: {input_integers[0] - input_integers[1]}");
                        break;
                    case 3:
                        Console.WriteLine($"The Multiplication of {input_integers[0]} and {input_integers[1]} is: {input_integers[0] * input_integers[1]}");
                        break;
                    case 4:
                        Console.WriteLine($"The Division of {input_integers[0]} and {input_integers[1]} is: {(float)input_integers[0] / input_integers[1]}");
                        break;
                    case 5:
                        break;
                }
            }
            else
            {
                //Print out the error
                try
                {
                    choice = int.Parse(inp_choice);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter your choice in valid format!");
                }
                return;
            }
            #endregion
            #region Task6
            //Main solution
            //Finding the palindrome number
            //Ask for the number
            Console.WriteLine("Input a number: ");
            //Store it
            string number = Console.ReadLine();
            //Check the validity
            if (int.TryParse(number, out int input_number))
            {
                //Set a counter to store "unmatches"
                int difference_counter = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    //Compare both arrays
                    if (number[i] != return_reverse(number)[i])
                    {
                        difference_counter++;
                        Console.WriteLine($"{input_number} is not a palindrome number");
                        break;
                    }
                }
                //No "unmatch" means they are same
                if (difference_counter == 0)
                {
                    Console.WriteLine($"{input_number} is a palindrome number");
                }
            }
            else
            {
                //Print out the error
                try
                {
                    input_number = int.Parse(number);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a valid input format!");
                    return;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Input is too large!");
                    return;
                }
            }

            //Function to reverse the input
            static char[] return_reverse(string number)
            {
                //Store each character individually
                char[] charArray = number.ToCharArray();
                char[] reverse_number = new char[number.Length];
                for (int i = 0; i < number.Length; i++)
                {
                    reverse_number[i] = charArray[number.Length - (i + 1)];
                }
                return reverse_number;

                //The follwing code is my second solution for this function, but I like the main one more
                ////Store each character individually
                //char[] charArray = number.ToCharArray();
                ////Reverse the characters order
                //Array.Reverse(charArray);
                //return new string(charArray);
            }

            ////Note: Aşaöıdakı mənbələrdən istifadə etmişəm
            ////https://www.c-sharpcorner.com/UploadFile/mahesh/compare-strings-in-C-Sharp/
            ////https://stackoverflow.com/questions/228038/best-way-to-reverse-a-string
            /////https://www.tutorialspoint.com/chash-program-to-return-an-array-from-methods
            #endregion
            #region Task7
            //Ask for input
            Console.WriteLine("Enter a number: ");
            //Store the input
            string number_input = Console.ReadLine();
            //Check whether the input is a number
            if (double.TryParse(number_input, out double given_number))
            {
                Console.WriteLine($"The sum of the digits of the number {given_number} is: {sumof_digits(number_input)}");
            }
            else
            {
                try
                {
                    given_number = double.Parse(number_input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a valid input!");
                    return;
                }
            }
            //Function to calculate the sumof the digits
            static int sumof_digits(string s)
            {
                int sum = 0;
                foreach (char c in s)
                {
                    sum += int.Parse(c.ToString());
                }
                return sum;
            }
            #endregion
        }
    }
}

