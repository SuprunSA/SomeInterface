using System;

namespace SomeInterface
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public interface ISomeInterface
    {
        public int X { get; }
        public string Foo(string arg1);
        public void Bar(int number);
    }

    class A : ISomeInterface
    {
        public int X { get; }
        public int Y { get; }

        public string Foo(string arg1)
        {
            return arg1;
        }

        public void Bar(int nubmer)
        {

        }

        public A Process(A a)
        {
            return a;
        }
    }

    class B : ISomeInterface
    {
        public int X { get; }

        public string Foo(string arg1)
        {
            return arg1;
        }

        public void Bar(int nubmer)
        {

        }

        private void DoSomething(double a)
        {

        }
    }

    class Consumer
    {
        public void UseSomeInterface(ISomeInterface someInterface) { }
    }
}
