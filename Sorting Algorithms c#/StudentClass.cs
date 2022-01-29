using System;
namespace Project1
{
    public class StudentClass
    {
        public string FirstName;
        public string LastName;
        public string Class;
        public int StudentId;
        public int DateOfBirth;
        public double Gpa;

        public StudentClass()
        {

        }

        public StudentClass(string firstName, string lastName, string studentClass, int studentId
            , int dob, int gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Class = studentClass;
            this.StudentId = studentId;
            DateOfBirth = dob;
            Gpa = gpa;
        }


        public StudentClass(string firstName, String lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void setAll (string firstName, string lastName, string studentClass, int studentId
            , int dob, int gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Class = studentClass;
            this.StudentId = studentId;
            DateOfBirth = dob;
            Gpa = gpa;
        }




        public void setFirstName(string fname)
        {
            FirstName = fname;
        }

        public string getFirstName()
        {
            return FirstName;
        }
        public void setLastName(string lname)
        {
            LastName = lname;
        }

        public string getLastName()
        {
            return LastName;
        }

        public void setstudentID(int studentid)
        {
            StudentId = studentid;

        }

        public int getstudentId()
        {
            return StudentId;

        }

        public string toString()
        {
            return "Student information\nName: " + FirstName + "\nClass: " + Class + "\nStudent ID: " + StudentId + "\nBirth Date:" + DateOfBirth + "\nGPA:" + Gpa;




        }

    }
    //+ {1}" + "\nClass: {2} " + "\nStudent ID: {3}" + "\nBirth Date: {4}" + "\nGPA: {5}
   // FirstName +LastName+ Class +StudentId +DateOfBirth+""+Gpa;




}

