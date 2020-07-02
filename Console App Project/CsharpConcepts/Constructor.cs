using System;
using System.ComponentModel;

namespace Selenium_Basics.CsharpConcepts
{
    /*
     * Types of Constructor :
1.	Default Constructor or Parameter Less Constructor :- 
If a Constructor method doesn’t take any Parameter then we call it as default or Param Less constructor, These Constructor can be defined by a programmer explicitly else can be created by compiler implicitly in case of absence of it under the class.

    Sample :- 
     class Constructor
    {
        public Constructor()
        {
            Console.WriteLine("This is Default Constructor");
        }

        public void Display()
        {

            Console.WriteLine("Hi am in display");
        }
        static void Main()
        {
            Constructor cd = new Constructor();
            cd.Display();
            Console.ReadLine();
        }
        
    }
2.	Parameterized Constructor :-
A constructor with Parameter is termed as Parametrized Constructor, It can’t be called implicitly by Compiler it should be defined by Programmer explicitly.
class Constructor
    {
        int x;
        public Constructor(int i)
        {
            x = i;
            Console.WriteLine("Int value is " + i);
        }
        public void Display()
        {
            Console.WriteLine("Value of x is " + x);
        }
         static void Main()
        {
            Constructor cd = new Constructor(10);
            Constructor cd1 = new Constructor(20);
            cd.Display();
            cd1.Display();
            Console.ReadLine();
        }
    }
3.  Copy Constructor


** Why We need Constructor?
*If we will not declare, Explicitly Compiler will declare by default a constructor without Parameter. 
--First we need to Analyze whether our class needs to pass value to the variable or not , if yes then we should go with Param Construct
    So Every time When the instance of vriable will create we will get a chance of passing new values.
--1st Case Same Memory is allocated with different address to different variable instance
    class Variable
    {
       public int x = 100;
    }
    class ProgramClass
    {
        static void Main()
        {
            Variable t1 = new Variable();
            Variable t2 = new Variable();
            Console.WriteLine(t1.x +" "+t2.x);
            Console.ReadLine();
        }
    }
--2) Case Passing Value with Parameter/Main Use of Explicit Constructor for passing new value every time it execute

     */
   class Variable
    {
       public int x ;
        public Variable(int x)
        {
            this.x = x;
        }

    }
    class ProgramClass
    {
        static void Main()
        {
            Variable t1 = new Variable(10);
            Variable t2 = new Variable(20);
            Console.WriteLine(t1.x +" "+t2.x);
            Console.ReadLine();
        }
    }
}