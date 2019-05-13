using System;

namespace LabExc1._2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool doContinue;
            do
            {
                Result();
                Console.WriteLine("Do you want to continue?(y/n)");
                char response = char.Parse(Console.ReadLine());
                if (response == 'y')
                {
                    doContinue = true;
                }
                else
                {
                    doContinue = false;
                }
            } while (doContinue);

            Console.ReadLine();

        }

        static void Result()
        {
            Course crs1 = new Course("c#", "25", "Irakleous");
            Console.WriteLine(crs1.ToString());
            Student sdnt1 = new Student("Eugenia", 25, 1, crs1);
            Console.WriteLine(sdnt1.ToString());

            Console.WriteLine("Enter the mark");
            int mark = int.Parse(Console.ReadLine());


            string grade = MarksToGrades(mark);

            Console.WriteLine("The grate is {0}:", grade);
            if (grade == "F")
            {
                sdnt1.EnrollToCourse(crs1);
                Console.WriteLine(" Ela to Septemvrh");
            }
            else
            { 
                sdnt1.WithdrawCourse();
                Console.WriteLine("Perases");
            }
            Console.WriteLine(sdnt1.ToString());
        }

        static string MarksToGrades(int mark)
        {
            string grade;
            if (mark >= 80 && mark <= 100)
            {
                grade = "A";
            }
            else if (mark >= 70 && mark <= 79)
            {
                grade = "B";
            }
            else if (mark >= 60)
            {
                grade = "C";
            }
            else if (mark >= 50 && mark <= 59)
            {
                grade = "D";
            }
            else if (mark >= 0 && mark < 49)
            {
                grade = "F";
            }
            else
            {
                grade = "wrong mark";
            }
            return grade;
        }


    }
}
class Course
{
    public string courseName;
    public string code;
    public string instructorName;

    public Course()
    {

    }

    public Course(string crsName, string cd, string instrctrName) 
    {
        courseName = crsName;
        code = cd;
        instructorName = instrctrName;
    }


    public override string ToString()
    {
        return "Course Name = " + courseName + " Code = " + code + " Instructor Name = " + instructorName;
    }
}
class Student
{
    public string studentName;
    public int age;
    public int level { get; set;}
    private Course enrollToCourse;              

    public Student()
    {

    }

    public Student(string stdntName, int Age, int lvl, Course enrllCrse)
    {
        studentName = stdntName;
        age = Age;
        level = lvl;
        enrollToCourse = enrllCrse;
    }

    public void EnrollToCourse(Course course)             
    {
        if (age >= 18)                                   
        {
            this.enrollToCourse = course;
        }
        else
        {
            Console.WriteLine("No ability to get any courses!");
        }
    }

    public void WithdrawCourse()
    {
        this.enrollToCourse = null;
    }


    public override string ToString()
    {
        return "Student Name = " + studentName + " Age = " + age + " Level = " + level + " Enroll To Course =" + enrollToCourse;
    }
}

