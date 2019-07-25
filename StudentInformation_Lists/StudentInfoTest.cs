using System;

namespace StudentInformation_Lists
{
    class StudentInfoTest
    {
        static void Main(string[] args)
        {
            Greeting();
            
        }

        public static string Greeting()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Type \"add\" to add and \"learn\" to learn or \"exit\" to exit");
            return Console.ReadLine().ToLower();
           
        }

        // public static void StudentChooser(int studentNumber)
        //{
        //    string userKnowMore = "y";
        //    do
        //    {
        //        if (.NumberValidator(studentNumber))
        //        {
        //            Information student1 = new Information(studentNumber, extraChoice);
        //            Console.WriteLine(student1.StudentInformationFinder());

        //            Console.WriteLine("Would you like to know more about this student? y/n");
        //            userKnowMore = Console.ReadLine().ToLower();
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid number");
        //            break;
        //        }
        //    } while (userKnowMore == "y");
        //}

         public static int StudentInputReader()
        {
            while (true)
            {
                string userInput = Console.ReadLine().ToLower();

                try
                {
                    return int.Parse(userInput);
                }
                catch (Exception)
                {
                    int studentIndex = Information.StudentIndex(userInput);
                    if (studentIndex != -1)
                    {
                        return studentIndex;
                    }
                    Console.WriteLine("Invalid. Enter a number from 1-10 or the student's first name.");
                }  
            }  
         }

    }

}

