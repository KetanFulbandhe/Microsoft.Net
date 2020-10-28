using System;
/*Q2. Create a class person having virtual method
 public virtual string  dojob(){ “doing job”}
create three child class programmer,dancer and singer.
In programmer class override virtual method
    public override string  dojob(){ “doing coding”}
    programmer class also has method public void testing{  “I am testing code also” }
In  singer class override virtual method
    public override string  dojob(){ “singing”}
In dancer class no method available.
Create array of person class and call dojob() method.
Also call testing method of programmer class in a loop*/

namespace ConsoleApp_A2
{
    class person
    {
        public virtual string  dojob()
        {
            return "doing job";
        }
    }
    class programmer:person
    {
        public override string  dojob()
        {
            return "doing coding";
        }
        public void testing()
        {
            Console.WriteLine("I am testing code also");
        }
    }
    class dancer:person
    {

    }
    class singer:person
    {
        public override string  dojob()
        {
            return "singing";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person[] pArr = new person[4];

            pArr[0] = new person();
            pArr[1] = new programmer();
            pArr[2] = new singer();
            pArr[3] = new dancer();

            foreach(person p in pArr)
            {
                Console.WriteLine(p.dojob());
                if (p is programmer)
                    ((programmer)p).testing();
            }

            Console.ReadLine();
        }
    }
}
