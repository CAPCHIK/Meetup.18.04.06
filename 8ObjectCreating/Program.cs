using System;

namespace _8ObjectCreating
{
    class Program
    {
        static void Main(string[] args)
        {
            object created = Activator.CreateInstance(typeof(Sample));
            Sample sample = (Sample)created;
            int value = sample.GetSomeValue();
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }

    class Sample
    {
        private int value = 34;
        public int GetSomeValue()
        {
            return value;
        }
    }
}
