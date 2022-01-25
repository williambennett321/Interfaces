using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Patient : PatientClass
    {
        public void PatientName(string name)
        {
            Console.WriteLine($"{name}");
        }
        public void BillingInfo(int totalAmount)
        {
            Console.WriteLine($"Total bill ${totalAmount}.00");
        }

        public void PrintDiag(string diagnosis)
        {
            Console.WriteLine($"Current Diagnosis: {diagnosis}");
        }

        public void Prescription(string medication)
        {
            Console.WriteLine($"Current Treatment: {medication}");
        }
    }
}
