using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp
{
    public class Course
    {
        private int courseID;
        private string courseName;
        private int creditHours;
        private double assgnmtPoints;
        private double quizPoints;
        private double examPoints;
        private double projectPoints;        
        private double courseFinalPoints;
        private char courseLetterGrade;
        private double courseMax;


        // Dedault constructor
        public Course()
        {

        }
            
        // Constructor for second object
        public Course(int ID, string name, int hours, double cMax)
        {
            courseID = ID;
            courseName = name;
            creditHours = hours;
            courseMax = cMax;
        }

        // Constructor for third object
        public Course(int ID, string name, int hours, double assgnmt, double quiz, double exam, double project, double finalPoints, char letterGrade, double cMax)
        {
            courseID = ID;
            courseName = name;
            creditHours = hours;
            assgnmtPoints = assgnmt;
            quizPoints = quiz;
            examPoints = exam;
            projectPoints = project;
            courseFinalPoints = finalPoints;
            courseLetterGrade = letterGrade;
            courseMax = cMax;
        }

        // Property setting and returning 
        public int CourseID
        {
            get
            {
                return courseID;
            }
            set
            {
                courseID = value;
            }       
        }
        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }
        public int CreditHours
        {
            get
            {
                return creditHours;
            }
            set
            {
                creditHours = value; 
            }
        }        
        public double AssgnmtPoints
        {
            get
            {
                return assgnmtPoints;
            }
            set
            {
                assgnmtPoints = value; 
            }
        }
        public double QuizPoints
        {
            get
            {
                return quizPoints;
            }
            set
            {
                quizPoints = value; 
            }
        }        
        public double ExamPoints
        {
            get
            {
                return examPoints;
            }
            set
            {
                examPoints = value;
            }
        }
        public double ProjectPoints
        {
            get
            {
                return projectPoints;
            }
            set
            {
                projectPoints = value;
                DetermineCourseFinalPoint();

            }
        }
        
        // Determine couse final point based on assingments weight, quizzes weight, exams weight, and project weight
        public void DetermineCourseFinalPoint()
        {
            courseFinalPoints = assgnmtPoints + quizPoints + examPoints + projectPoints;
            courseLetterGrade = 'N';
                if(courseFinalPoints > courseMax* .89)
                    courseLetterGrade = 'A';
                else if(courseFinalPoints > courseMax* .79)
                    courseLetterGrade = 'B';
                else if(courseFinalPoints > courseMax * .69)
                    courseLetterGrade = 'C';
                else if(courseFinalPoints > courseMax * .59)
                    courseLetterGrade = 'D';
                else
                    courseLetterGrade = 'F'; 
        
        }
        
        // Return all data members using override ToString() Method
        public override string ToString()
        {
            return "\n Course ID: " + courseID + 
                "\n Course Name: " + courseName + 
                "\n Course Credit Hours: " + creditHours +
                "\n Final course points: " + courseFinalPoints + 
                "\n Final course letter grade: " + courseLetterGrade; 
        }

    }
}
