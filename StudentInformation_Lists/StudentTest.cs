using System;

namespace StudentInformation_Lists
{
    class StudentInfoTest
    {
        static void Main(string[] args)
        {
            string userSecondChoice = "y";
            do
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Type \"add\" to add and \"learn\" to learn or \"exit\" to exit");
                string userInitialChoice = Console.ReadLine().ToLower();

                int choice = Student.UserChoiceFinder(userInitialChoice);
                Student student1 = new Student();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(student1.AddStudent());
                        break;
                    case 2:
                        student1.LearnStudent();
                        break;
                    case 3:
                        Console.WriteLine("Thank you and goodbye");
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Would you like to learn about another student? y/n");
                userSecondChoice = Console.ReadLine().ToLower();
             } while (userSecondChoice == "y");
        }

        //if the user has entered a valid number, the program will read the information the user picked
        //about thatt student to the console.  If the number is not valid, the console will print
        //"invalid number"
        static void StudentChooser(int studentNumber)
        {
            string userKnowMore = "y";
            do
            {
                if (Student.NumberValidator(studentNumber))
                {
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

    }

}
