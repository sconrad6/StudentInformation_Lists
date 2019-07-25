using System;
using System.Collections.Generic;

namespace StudentInformation_Lists
{
    public class Student
    {
        public static List<string> students = new List<string>
        { "Bob", "Bill", "Nate", "Joe", "Stefan", "McKenna", "LeoJohn", "Ann", "Carmen", "Ryan" };
        public static List<string> hometowns = new List<string>
        {"Gilmington", "Exeter", "Brentwood", "Altoona", "Ann Arbor", "Altoona", "Stratham", "Stratham",
                                   "Canton", "Colchester" };
        public static List<string> foods = new List<string>
        {"carrots", "cucumbers", "chips", "pasta", "hummus", "cauliflower rice", "doughnuts", "chocolate",
                              "noodles", "bread" };
        public static List<string> plants = new List<string>
        { "3", "4", "6", "45", "100", "0", "10", "8", "2", "7" };
        public static List<string> drinks = new List<string>
        {"pop", "tea", "coffee", "kombucha","iced tea lemonade", "juice", "hot chocolate", "water", "red bull", "sock water"};

        // find the information from the student depending on the user's informaton choice
        // and prints accordingly
        public string StudentInformationFinder(int studentNumber, int extraChoice)
        {
            switch (extraChoice)
            {
                case 1:
                    return $"{students[studentNumber]} is from {hometowns[studentNumber]}.";
                case 2:
                    return $"{students[studentNumber]}'s favorite food is {foods[studentNumber]}.";
                case 3:
                    return $"{students[studentNumber]} has {plants[studentNumber]} plants.";
                case 4:
                    return $"{students[studentNumber]}'s favorite drink is {drinks[studentNumber]}";
                default:
                    return "Invalid number";
            }
        }

        // Adds a student if the user chooses to
        public string AddStudent()
        {
            Console.WriteLine("Enter the name of the student:");
            string userStudent = Console.ReadLine();
            students.Add(userStudent);

            Console.WriteLine("Enter the hometown of the student:");
            string userHometown = Console.ReadLine();
            hometowns.Add(userHometown);

            Console.WriteLine("Enter the favorite food of the student:");
            string userFood = Console.ReadLine();
            foods.Add(userFood);

            Console.WriteLine("Enter the number of plants the student has:");
            string userPlants = Console.ReadLine();
            plants.Add(userPlants);

            Console.WriteLine("Enter the student's favorite drink");
            string userDrink = Console.ReadLine();
            drinks.Add(userDrink);

            return $"Added {userStudent}";
            
        }

        // learn about a student in the lists (ie. "learn")
        //the user will enter a number or name of the student they want to learn about
        //and the program will print that information to the console
        public void LearnStudent()
        {
            string userKnowMore = "y";
                int userStudentNumber = -1;
                Console.WriteLine("Enter the number or name of the student you want to learn about! 1-10");
                string userInput = Console.ReadLine();
                try
                {
                    userStudentNumber = int.Parse(userInput);
                }
                catch (Exception)
                {
                    userStudentNumber = StudentIndex(userInput);
                }
            do
            {
                if (Student.NumberValidator(userStudentNumber))
                {
                    Console.WriteLine($"Student {userStudentNumber} is {students[userStudentNumber - 1]}.");

                    Console.WriteLine("What would you like to learn about them? \nEnter: \n1. " +
                            "For hometown \n2. For favorite food  \n3. For number of plants \n4. For favorite drink");
                    int extraChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine(StudentInformationFinder(userStudentNumber - 1, extraChoice));
                    Console.WriteLine("Would you like to know more about this student? y/n");
                    userKnowMore = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine("Invalid number");
                    break;
                }
            } while (userKnowMore == "y");

        }

       
        // Returns a number that corresponds to the action the user wants to do
        public static int UserChoiceFinder(string userInitialChoice)
        {
            if (userInitialChoice == "add")
            {
                return 1;
            }
            else if (userInitialChoice == "learn")
            {
                return 2;
            }
            return 3;
        }

        // Returns the student index number when the user enters a name as text.
        //Returns -1 if that student doesnt exist
        public int StudentIndex(string userNameEntered)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (userNameEntered == students[i].ToLower())
                {
                    return i + 1;
                }
            }
            return -1;
        }

        // validates that the user enters a number between 0 and the size of the student list 
        public static bool NumberValidator(int studentNumber)
        {
            return studentNumber > 0 && studentNumber <= students.Count;
        }
    }
}
