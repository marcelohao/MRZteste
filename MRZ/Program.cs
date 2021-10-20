using System;
using nuMRZ;

namespace MRZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.FirstName = "Marcelo";
            cust.Age = 38;
            cust.DateOfBirth = new DateTime(1982, 12, 14);
            cust.DocumentNumber = "FFYY1234";
            cust.DocumentType = "PASSPORT";
            cust.DocumentTypeDescription = "BRAZILIAN PASSPORT";
            cust.ExpireDate = new DateTime(2022, 12, 14);
            cust.FullName = "Marcelo Henrique Onofre Oliveira";
            cust.Gender = "Male";
            cust.IssueDate = new DateTime(2012, 12, 14);
            cust.IssuingAuthority = "PF";
            cust.IssuingCountryIso = "BRA";
            cust.IssuingCountryName = "BRAZIL";
            cust.IsValid = true;
            cust.LastName = "ONOFRE OLIVEIRA";
            cust.NationalityIso = "BRA";
            cust.NationalityName = "BRAZILIAN";
            cust.PlaceOfBirth = "BRAZIL";

            nuMRZ.MRZParser geraMRZ = new MRZParser();
            Console.WriteLine("String MRZ:");
            Console.WriteLine(geraMRZ.CreatMrz(cust, false));

            Customer cust2 = geraMRZ.Parse(geraMRZ.CreatMrz(cust, true));

            Console.ReadKey();
        }
    }
}
