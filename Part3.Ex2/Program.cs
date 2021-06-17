using System;

namespace Part3.Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var highSchoolTeacher = new HighSchoolTeacher()
            {
                IdentityNumber = "ID001",
                Name = "Hung Kito",
                BaseSalary = 100,
                Level = 2,
                Bonus = 100,
                IsSenion = false,
                HighSchoolCode = "HS001"
            };
            Console.WriteLine(highSchoolTeacher.CalculateSalary());
            var universityTeacher = new UnviversityTeacher()
            {
                IdentityNumber = "ID002",
                Name = "Hung Phung",
                BaseSalary = 600000,
                Level = 2,
                Bonus = 9000,
                IsSenion = true,
                EnglishLevel = 3,
                UniversityCode = "UN001"
            };
            Console.WriteLine(universityTeacher.CalculateSalary());
        }
    }
}