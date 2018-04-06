using System;
using System.Reflection;

namespace _7Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Type sampleClassType = typeof(Sample);
            ConstructorInfo[] constructors = sampleClassType.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine("CONSTRUCTOR");
                Console.WriteLine($"    Name {constructor.Name}");
                ParameterInfo[] constructorParameters = constructor.GetParameters();
                foreach (ParameterInfo parameterInfo in constructorParameters)
                {
                    Console.WriteLine($"    param {parameterInfo.Name} have type {parameterInfo.ParameterType}");
                }
                Console.WriteLine();
            }
            MethodInfo[] methods = sampleClassType.GetMethods();
            foreach (MethodInfo methodInfo in methods)
            {
                Console.WriteLine("METHOD");
                Console.WriteLine($"Name {methodInfo.Name}");
                ParameterInfo[] methodParameters = methodInfo.GetParameters();
                foreach (ParameterInfo parameterInfo in methodParameters)
                {
                    Console.WriteLine($"    param {parameterInfo.Name} have type {parameterInfo.ParameterType}");
                }
                Console.WriteLine($"    Out type is {methodInfo.ReturnType}");
                Console.WriteLine();
            }
            Console.Read();
        }
    }

    class Sample
    {
        public Sample()
        {

        }
        public Sample(int value)
        {

        }
        public int OurSampleMethod(string arg)
        {
            return arg.Length;
        }
    }
}
