namespace Part3.Ex2
{
    public abstract class AbstractTearcher
    {
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public int Level { get; set; }
        public bool IsSenion { get; set; }
        public double Bonus { get; set; }

        public abstract double CalculateSalary();
    }
}