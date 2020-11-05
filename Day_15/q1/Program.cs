using System;
using System.Collections.Generic;
/*Q1. Create a class Student having member rollno, name, maths, sci, eng,total
Create 5 object and store in sorted list class and display detail name wise ascending order*/

namespace SortedListStudentA1
{
    class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public int Maths { get; set; }
        public int Sci { get; set; }
        public int Eng { get; set; }
        public int Total { get; set; }

        public Student(int rollno, string name, int maths, int sci, int eng, int total)
        {
            Rollno = rollno;
            Name = name;
            Maths = maths;
            Sci = sci;
            Eng = eng;
            Total = total;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}",Rollno,Name,Maths,Sci,Eng,Total);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Wix", 50, 55, 60, 70);
            Student s2 = new Student(2, "Todd", 55, 65, 70, 80);
            Student s3 = new Student(3, "Xender", 60, 65, 70, 90);
            Student s4 = new Student(4, "Arnav", 70, 75, 80, 100);
            Student s5 = new Student(5, "Leo", 75, 80, 85, 110);

            SortedList<string,Student> StudList=new SortedList<string,Student>();
            StudList.Add(s1.Name,s1);
            StudList.Add(s2.Name,s2);
            StudList.Add(s3.Name,s3);
            StudList.Add(s4.Name,s4);
            StudList.Add(s5.Name,s5);

            foreach(KeyValuePair<string,Student> std in StudList)
                Console.WriteLine(std.ToString());
        }
    }
}
