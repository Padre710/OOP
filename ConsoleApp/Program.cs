using System;

namespace ConsoleApp
{

                                                             // ENCAPSULATION EXAMPLE
    //class Rectangle
    //{
    //    public double length;
    //    public double width;

    //    public double GetArea()
    //    {
    //        return length * width;
    //    }

    //    public void display()
    //    {
    //        Console.WriteLine("Length : {0}", length);
    //        Console.WriteLine("width : {0}", width);
    //        Console.WriteLine("Area : {0}", GetArea());
    //    }

    //    public void RectanglePrompt ()
    //    {

    //    }
    //} // we begin a new class here.
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Console.WriteLine("Hello World!");
    //        Rectangle r = new Rectangle();
    //        //  r.length = 4.5;
    //        //  r.width = 3.5;
    //        Console.WriteLine("what is the length :");
    //        r.length = double.Parse(Console.ReadLine());
    //        Console.WriteLine("width? :");
    //        r.width = double.Parse(Console.ReadLine());
    //        r.display();
    //    }
    //}

                                                     //// ABSTRACTION EXAMPLE

    //abstract class Animal
    //{

    //    public abstract void animalSound();

    //    public void sleep()
    //    {
    //        Console.WriteLine("Zzz");
    //    }
    //}

                                                          //// INHERITANCE EXAMPLE
    //class Pig : Animal
    //{
    //    public override void animalSound()
    //    {

    //        Console.WriteLine("The pig says: wee wee");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Pig myPig = new Pig(); 
    //        myPig.animalSound();  
    //        myPig.sleep();  
    //    }
    //}
                                                        //// POLYMORPHISM EXAMPLE
    class datatypes
    {
        void print(int i)
        {
            Console.WriteLine("Print int: {0}", i);
        }
        void print(double f)
        {
            Console.WriteLine("Print float: {0}", f);
        }
        void print(string s)
        {
            Console.WriteLine("Print string: {0}", s);
        }
        static void Main(string[] args)
        {
            datatypes d = new datatypes();

            d.print(5);
            d.print(500.263);
            d.print("C# Programming language");
            
        }
    }





}





