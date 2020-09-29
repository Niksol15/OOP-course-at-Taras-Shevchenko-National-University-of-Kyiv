using System;

namespace Temp
{
    class ClassA: ClassB
    {
       public void Method1()
        {
            System.Console.WriteLine("A");
            base.Method1();
        }
    }
    class ClassC
    {

    }

    class ClassB
    {
        public void Method1()
        {
            Console.WriteLine("B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            ClassB b = new ClassB();
            b = a;
            a = (ClassA)b;
            a.Method1();
            Console.ReadKey();
        }
    }
}
