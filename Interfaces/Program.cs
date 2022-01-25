using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Patient patient = new Patient();
            patient.PatientName("Joe Smith");
            patient.BillingInfo(1000);
            patient.PrintDiag("Diabetes");
            patient.Prescription("Insulin 100mg");

        }
    }
}
