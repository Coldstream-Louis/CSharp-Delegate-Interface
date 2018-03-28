using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IGreeting {
        void GreetingPeople(string name);
    }

    public class Python3Greeting : IGreeting {
        public void GreetingPeople(string name) {
            Console.WriteLine("print('Hello, "+name+"!')");
        }
    }
    public class CppGreeting : IGreeting {
        public void GreetingPeople(string name) {
            Console.WriteLine("cout<<'Hello, "+name+"!'<<endl;");
        }
    }
    public class JavaGreeting : IGreeting {
        public void GreetingPeople(string name) {
            Console.WriteLine("System.out.println('Hello, "+name+"!');");
        }
    }
    public class CSharpGreeting : IGreeting {
        public void GreetingPeople(string name) {
            Console.WriteLine("Console.WriteLine('Hello, "+name+"!');");
        }
    }
    
    class Program
    {
        private static void GreetPeople(string name, IGreeting MakeGreeting) {
            MakeGreeting.GreetingPeople(name);
        }

        static void Main(string[] args) {
            GreetPeople("Jessica", new Python3Greeting());
            GreetPeople("Francis", new CppGreeting());
            GreetPeople("Alice", new JavaGreeting());
            GreetPeople("Katherine", new CSharpGreeting());
            Console.ReadKey();
        }
    }
}
