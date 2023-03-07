using System;

namespace U11DataStruct
{
    struct Names
    {
        public string name;
        public string surname;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Names test_struct = new Names();

            Console.Write("Please input a first name: ");
            test_struct.name = Console.ReadLine();
            Console.Write("Please input a surname: ");
            test_struct.surname = Console.ReadLine();

            string full_name = test_struct.name + " " + test_struct.surname;

            Console.Write($"Struct name: {full_name}\n");
        }
    }
}
