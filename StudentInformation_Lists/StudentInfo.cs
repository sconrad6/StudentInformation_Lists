using System;
using System.Collections.Generic;

namespace StudentInformation_Lists
{
    public class StudentInfo
    {
        
        // find the information from the student depending on the user's informaton choice
        // and prints accordingly
        public string StudentInformationFinder()
        {
           int studentIndex = Information.studentNumber;
            List<string> studentNames = Information.students;
 
            switch (Information.extraChoice)
            {
                case 1:
                    return $"{studentNames[studentIndex]} is from {Information.hometowns[studentIndex]}.";
                case 2:
                    return $"{studentNames[studentIndex]}'s favorite food is {Information.foods[studentIndex]}.";
                case 3:
                    return $"{studentNames[studentIndex]} has {Information.plants[studentIndex]} plants.";
                case 4:
                    return $"{studentNames[studentIndex]}'s favorite drink is {Information.drinks[studentIndex]}";
                default:
                    return "Invalid number";
            }
        }

        // Returns the student index number when the user enters a name as text.
        //Returns -1 if that student doesnt exist
        public static int StudentIndex(string userInput)
        {
            for (int i = 0; i < Information.students.Count; i++)
            {
                if (userInput == Information.students[i].ToLower())
                {
                    return i + 1;
                }
            }
            return -1;
        }

    }
}
