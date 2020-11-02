using System;
/*Q2. Create a class student having member id, name,  marks. Write method public void give_gracemarks(int mks) when you call method with marks>5 it should throw  user define exception.
It should print name id and marks to file, using file handling topic*/
using System.IO;
namespace ConsoleApp_StudentA2
{
    public class student
    {
        static int getid;
        int id;
        string name;
        int marks;
        public student(string nm, int mrk)
        {
            id = ++getid;
            Name = nm;
            Marks = mrk;
        }
        public int ID
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
            set { name = value;}
        }
        public int Marks
        {
            get { return marks; }
            set { marks = value; }
        }
         
        public override string ToString()
        {
            return string.Format(ID + " " + Name + " " + Marks);
        }
        public void give_gracemarks(int mks)
        {
            if (mks > 5)
                throw new MyException(ID, Name, Marks, "give_gracemarks() not allowed Marks > 5");
            else
            {
                Marks += mks;
                              
            }
        }
    }
}
