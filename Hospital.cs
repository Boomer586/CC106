using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Patient_Record
{
    class hospital
    {
        internal string name = "Maria Santos";
        internal int age = 28;
        internal string diagnosis = "Allergy";
    }

    class Program
    {
        static void Main(string[] args)
        {
            hospital c = new hospital();

            Console.WriteLine("\n ===Hospital Patient Record===");
            Console.WriteLine("Patient Name: " + c.name);
            Console.WriteLine("Age: " + c.age);
            Console.WriteLine("Diagnosis: " + c.diagnosis);
        }
    }

}
