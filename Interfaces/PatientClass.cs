using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    // Abstract: Constructors, static members, fast, class can only have one abstract class
    // Interfaces: no constructors, no static members, slow, multiple inheritence
    interface PatientClass
    {
        void PatientName(string name);
        void BillingInfo(int total);
        void PrintDiag(string diagnosis);

        void Prescription(string medication);




        

        
    }
}
