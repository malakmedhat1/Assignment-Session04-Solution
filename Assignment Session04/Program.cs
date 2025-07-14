namespace Assignment_Session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            /// Example:
            /// Input: 5
            /// Output: 1, 2, 3, 4, 5
            /// 

            Console.Write("Enter Your Number : ");
            int.TryParse(Console.ReadLine(), out int Number);

            for (int i = 1; i <= Number; i++) {
                Console.WriteLine(i);
            }

            #endregion

            Console.WriteLine();
            Console.WriteLine("**************** Next Question ****************************");

            #region Q2 - Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            /// Example:
            /// Input: 5
            /// Output: 5 10 15 20 25 30 35 40 45 50 55 60

            Console.Write("Enter Your Number : ");
            int.TryParse(Console.ReadLine(), out int TableNumber);

            for (int i = 1; i <= 12; i++) {
                Console.WriteLine($"{TableNumber} * {i} = {TableNumber * i}");
            }
            #endregion

            Console.WriteLine();
            Console.WriteLine("**************** Next Question ****************************");

            #region Q3 - Write a program that allows the user to insert a number then print all even numbers between 1 to this number.
            /// Example:
            /// Input: 15
            /// Output: 2 4 6 8 10 12 14

            Console.Write("Enter Your Number : ");
            int.TryParse(Console.ReadLine(), out int EvenNumber);

            for (int i = 1; i <= EvenNumber; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }

            #endregion

            Console.WriteLine();
            Console.WriteLine("**************** Next Question ****************************");

            #region Q4 - Write a program that takes two integers then prints the power.
            /// Example:
            /// Input: 4 3
            /// Output: 64
            /// Hint: how to calculate 4^3 = 4 * 4 * 4 = 64

            Console.Write("Enter Base Number : ");
            int.TryParse(Console.ReadLine(), out int BaseNumber);
            Console.Write("Enter Power Number : ");
            int.TryParse(Console.ReadLine(), out int PowerNumber);

            int result = 1;
            for (int i = 1; i <= PowerNumber; i++) {
                result *= BaseNumber;
            }
            Console.WriteLine($"The result of {BaseNumber} raised to the power of {PowerNumber} is: {result}");

            #endregion

            Console.WriteLine();
            Console.WriteLine("**************** Next Question ****************************");

            #region Q5 - Write a program to enter marks of five subjects and calculate total, average and percentage marks.
            /// Example:
            /// Input: 95 76 58 90 89
            /// Output: 
            /// Total marks = 408
            /// Average Marks = 81
            /// Percentage = 81

            Console.Write("Enter marks for 5 subjects separated by space: ");
            string input = Console.ReadLine();
            string[] marksInput = input.Split(' ');

            int totalMarks = 0;
            foreach (string mark in marksInput) {
                if (int.TryParse(mark, out int subjectMark)) {
                    totalMarks += subjectMark;
                } else {
                    Console.WriteLine("Invalid input. Please enter valid integers.");
                    return;
                }
            }

            int numberOfSubjects = marksInput.Length;
            double averageMarks = (double)totalMarks / numberOfSubjects;
            double percentage = (double)totalMarks / (numberOfSubjects * 100) * 100; 

            Console.WriteLine($"Total marks = {totalMarks}");
            Console.WriteLine($"Average Marks = {averageMarks:F2}");
            Console.WriteLine($"Percentage = {percentage:F2}%");

            #endregion

            Console.WriteLine();
            Console.WriteLine("**************** Next Question ****************************");

            #region Q6 - Write a program to allow the user to enter a string and print the REVERSE of it.

            Console.Write("Enter a string to reverse : ");
            string inputString = Console.ReadLine();

            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);

            string reversedString = new string(charArray);
            Console.WriteLine($"Reversed String: {reversedString}");

            // Alternatively, using a loop to reverse the string

            Console.Write("Reversed String using loop: ");
            for (int i = inputString.Length - 1; i >= 0; i--) {
                Console.Write(inputString[i]);
            }

            #endregion

            Console.WriteLine();
            Console.WriteLine("**************** Next Question ****************************");

            #region Q7 - Write a program to allow the user to enter an int and print the REVERSED of it.

            Console.Write("Enter an integer to reverse: ");
            if (int.TryParse(Console.ReadLine(), out int inputInt))
            {
                int reversedInt = 0;
                while (inputInt > 0)
                {
                    int digit = inputInt % 10;
                    reversedInt = reversedInt * 10 + digit;
                    inputInt /= 10;
                }
                Console.WriteLine($"Reversed Integer: {reversedInt}");
            }
            else
                Console.WriteLine("Invalid input. Please enter a valid integer.");

            #endregion

            Console.WriteLine();
            Console.WriteLine("**************** Next Question ****************************");

            #region Q8 - Write a program to find prime numbers within a range of numbers.
            /// Test Data:
            /// Input starting number of range: 1
            /// Input ending number of range: 50
            /// Expected Output:
            /// The prime numbers between 1 and 50 are:
            /// 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47

            Console.Write("Enter starting number of range: ");
            int.TryParse(Console.ReadLine(), out int startRange);
            Console.Write("Enter ending number of range: ");
            int.TryParse(Console.ReadLine(), out int endRange);

            Console.WriteLine($"The prime numbers between {startRange} and {endRange} are:");
            for (int number = startRange; number <= endRange; number++)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                }
            }
            
            Console.WriteLine(); 
            #endregion

            Console.WriteLine();
            Console.WriteLine("**************** Next Question ****************************");

            #region Q9 - Write a program to convert a decimal number into binary without using an array.
            /// Test Data:
            /// Input: 25
            /// Output: The Binary of 25 is 11001

            Console.Write("Enter a decimal number to convert to binary: ");
            if (int.TryParse(Console.ReadLine(), out int decimalNumber))
            {
                string binaryRepresentation = string.Empty;
                int number = decimalNumber;
                while (number > 0)
                {
                    binaryRepresentation = (number % 2) + binaryRepresentation;
                    number /= 2;
                }
                Console.WriteLine($"The Binary of {decimalNumber} is {binaryRepresentation}");
            }
            else
                Console.WriteLine("Invalid input. Please enter a valid integer.");

            #endregion

            Console.WriteLine();
            Console.WriteLine("**************** Next Question ****************************");

            #region Q10 - Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3) and determines whether these points lie on a single straight line.

            /// The program checks if the three points are collinear using the area of the triangle method.

            Console.Write("Enter x1: ");
            int.TryParse(Console.ReadLine(), out int x1);
            Console.Write("Enter y1: ");
            int.TryParse(Console.ReadLine(), out int y1);
            Console.Write("Enter x2: ");
            int.TryParse(Console.ReadLine(), out int x2);
            Console.Write("Enter y2: ");
            int.TryParse(Console.ReadLine(), out int y2);
            Console.Write("Enter x3: ");
            int.TryParse(Console.ReadLine(), out int x3);
            Console.Write("Enter y3: ");
            int.TryParse(Console.ReadLine(), out int y3);

            double slope1 = (double)(y2 - y1) / (x2 - x1);
            double slope2 = (double)(y3 - y2) / (x3 - x2);
            if (slope1 == slope2)
                Console.WriteLine("The points are collinear.");
            else
                Console.WriteLine("The points are not collinear.");

            #endregion

            Console.WriteLine();
            Console.WriteLine("**************** Next Question ****************************");

            #region Q11 - Write a program that prints an identity matrix using a for loop.
            /// The program takes a value n from the user and shows the identity table of size n * n.

            Console.Write("Enter the size of the identity matrix (n): ");   
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                Console.WriteLine($"Identity Matrix of size {n}x{n}:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                            Console.Write("1 ");
                        else
                            Console.Write("0 ");
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            #endregion

            Console.WriteLine();
            Console.WriteLine("**************** Finished Assignment ****************************");

        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
