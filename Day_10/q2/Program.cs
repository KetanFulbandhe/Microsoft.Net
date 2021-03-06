﻿using System;
//Q2. Create a class school, having array of student object. Create a class student having member variable rollnumber, name, marks . rollnumber should be generated by application. When you load application display school name. Display all student name and marks.

namespace ConsoleApp_StudentA2
{
    class student
    {
        static int rollno;
        int rollnumber;
        string name;
        int marks;
        public student(string nm, int mrk)
        {
            rollnumber = ++rollno;
            Name = nm;
            Mark = mrk;
        }
        public int RollNum
        { 
            get { return rollnumber; }
        }
        public string Name
        {
            get { return name; }
            set 
            {
                if (value.Length > 15)
                    throw new Exception("Name length exceed than 15 character");
                else
                    name = value;
            }
        }
        public int Mark
        {
            get { return marks; }
            set 
            {
                if (value < 0)
                    throw new Exception("Mark must be greater then zero");
                else
                    marks = value;
            }
        }
        public override string ToString()
        {
            return string.Format(RollNum+" "+Name+" "+Mark);
        }
    }
    
    class school
    {
        static school()
        {
            Console.WriteLine("\tWelcome to VITA\n");
        }
               
        student[] stu = new student[5];

        public school()
        {
            stu[0] = new student("Akshay",50);
            stu[1]=new student("Shriraj",60);
            stu[2]=new student("Ketan",70);
            stu[3]=new student("Mohit",80);
            stu[4]=new student("Kaushal",90);
        }
        public void Display()
        {
            foreach (student s in stu)
                Console.WriteLine(s); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            school scl = new school();
            scl.Display();

        }
    }
}
