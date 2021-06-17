using System;

namespace Part3.Ex2
{
    public class HighSchoolTeacher: AbstractTearcher
    {
        public string HighSchoolCode { get; set; }
        
        public override double CalculateSalary()
        {
            if (Bonus > 100000)
            {
                throw new AmountException("Bonus is more than 100000", Name);
            }

            var salary = BaseSalary * Level * Bonus;
            if (IsSenion && salary < 60000)
            {
                throw new AmountException("Senior Lecture gets less than 60,000 salary", Name);
            }

            return salary;
        }
    }
}