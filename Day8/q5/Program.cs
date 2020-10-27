using System;
/*Q5. Create class Animal having virtual method speak returning string” I don’t know how to speak”.
Create a child class dog having overridden speak method returning string “Bhow BHow”.
Create a child class cat having overridden speak method returning string “mewo mewo”
Create a child class donkey does not have any method.Create class showpoly having method call who’s job is to call speak method using reference of Animal.
Create object of all child class and then call showpoly’s class call method and pass child class object.*/

namespace ConsoleApp_A5
{
    class Animal
    {
        public virtual void speak()
        {
            Console.WriteLine("I don’t know how to speak");
        }
    }
    class dog : Animal
    {
        public override void speak()
        {
            Console.WriteLine("Bhow BHow");
        }
    }
    class cat : Animal
    {
        public override void speak()
        {
            Console.WriteLine("mewo mewo");
        }
    }
    class donkey : Animal
    {
    }
    
    class showpoly
    {
        public void Call(Animal a)
        {
            a.speak();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            showpoly s = new showpoly();
            dog d = new dog();
            cat c = new cat();
            donkey dk = new donkey();
            s.Call(d);
            s.Call(c);
            s.Call(dk);

            Console.ReadLine();
        }
    }
}
