using System;

namespace _9HardObjectCreating
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arguments = new object[] { 43 };
            Sample sample = CreateInstance<Sample>(arguments);
            Console.WriteLine(sample.OurSampleMethod("LOL"));
            Console.Read();
        }

        static T CreateInstance<T>(object[] args)
        {
            return (T)Activator.CreateInstance(typeof(T), args);
        }
    }

    class Sample
    {
        private readonly int value;

        public Sample(int value)
        {
            this.value = value;
        }
        public int OurSampleMethod(string arg)
        {
            return arg.Length + value;
        }
    }
}
