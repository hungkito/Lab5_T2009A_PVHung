using System;

namespace Part3.Ex2
{
    public class UnviversityTeacher: AbstractTearcher
    {

        public string UniversityCode { get; set; }

        public int EnglishLevel { get; set; }
        
        public override double CalculateSalary()
        {
            if (Bonus > 10000)
            {
                throw new AmountException("Bonus is more than 100000", Name);
            }
            var salary = BaseSalary * Level + ((BaseSalary/10) * EnglishLevel) + Bonus;
            if (IsSenion && salary < 60000)
            {
                throw new AmountException("Senior Lecture gets less than 60,000 salary", Name);
            }

            return salary;
        }
    }
}