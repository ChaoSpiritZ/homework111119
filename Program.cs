using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_111119
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1();
            //Question2();
            //Question3();
            //Question4();
        }
        /// <summary>
        /// hard question, also testing how this function summary works, oh i see... interesting....
        /// </summary>
        private static void Question4()
        {
            Console.WriteLine("Enter the number of classes: ");
            int numOfClasses = int.Parse(Console.ReadLine());
            int[][] classes = new int[numOfClasses][];
            int numOfStudents;

            for (int i = 0; i < numOfClasses; i++)
            {
                Console.WriteLine($"how many students are in class #{i + 1}");
                numOfStudents = int.Parse(Console.ReadLine());
                classes[i] = new int[numOfStudents];
            }

            for (int i = 0; i < classes.Length; i++)
            {
                for (int j = 0; j < classes[i].Length; j++)
                {
                    Console.WriteLine($"Enter the grade of student #{j + 1} from class #{i + 1}");
                    classes[i][j] = int.Parse(Console.ReadLine());
                }
            }
            //just showing the grades
            for (int i = 0; i < classes.Length; i++)
            {
                for (int j = 0; j < classes[i].Length; j++)
                {
                    Console.Write(classes[i][j] + " ");
                }
                Console.WriteLine();
            }
            double highestAverage = -1;
            int currentSum = 0;
            double currentClassAverage = -1;
            int bestClass = -1;
            for (int i = 0; i < classes.Length; i++)
            {
                for (int j = 0; j < classes[i].Length; j++)
                {
                    currentSum += classes[i][j];
                }
                currentClassAverage = (double)currentSum / classes[i].Length;
                if (currentClassAverage > highestAverage)
                {
                    highestAverage = currentClassAverage;
                    bestClass = i + 1;
                }
                currentSum = 0;
            }
            Console.WriteLine("The class with the highest average is:");
            Console.WriteLine($"Class {bestClass} with the average of {highestAverage}!");
        }

        private static void Question3()
        {
            int tries = 0;
            int chosenRow;
            int chosenCol;
            int subs = 0;

            int[,] board = new int[3, 3];
            Random rng = new Random();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = rng.Next(0, 2);
                    if (board[i, j] == 1)
                    {
                        subs++;
                    }
                    Console.Write(board[i, j] + " "); //cheat sheet
                }
                Console.WriteLine();
            }

            if (subs == 0)
            {
                Console.WriteLine("no enemies today, captain!");
                return;
            }
            else
            {
                Console.WriteLine($"Enemy subs ahead! i see {subs} of them!");
            }

            Console.WriteLine("Enter a row number then a column number of your target (zero based): ");
            do
            {
                chosenRow = int.Parse(Console.ReadLine());
                chosenCol = int.Parse(Console.ReadLine());
                tries++;
                if (board[chosenRow, chosenCol] == 1)
                {
                    Console.WriteLine("Enemy sub down!");
                    subs--;
                    board[chosenRow, chosenCol] = 0;
                }
                else
                {
                    Console.WriteLine("we missed them this time!");
                }
            }
            while (subs > 0);
            Console.WriteLine($"we have crushed them! after {tries} tries!");
        }

        private static void Question2()
        {
            Random rngsus = new Random();
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rngsus.Next(1, 11);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter a number (1-10) to get the slots it is in");
            int num = int.Parse(Console.ReadLine());

            //Console.WriteLine("number " + num + " is found in slots:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == num)
                    {
                        Console.WriteLine($"({i},{j})");
                    }
                }
            }
        }

        private static void Question1()
        {
            Console.Write("Enter the number of students in the class: ");
            int studentNum = int.Parse(Console.ReadLine());
            int[] students = new int[studentNum];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Enter a grade for student #{i + 1}");
                students[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < students.Length; i++)
            {
                sum += students[i];
            }
            Console.WriteLine("Sum of all grades: " + sum);
            double average = (double)sum / (double)studentNum;
            Console.WriteLine("Average grade: " + average);
        }
    }
}
