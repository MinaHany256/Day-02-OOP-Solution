namespace Assignement
{
    enum SecurityLevel
    {
        guest, Developer, secretary, DBA
    }

    enum Gender
    {
        M,F
    }

    class HireDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return String.Format("{0:D2}/{1:D2}/{2}", Day, Month, Year);
        }

    }


    class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }
        public Gender Gender { get; set; }


        public Employee(HireDate HireDate)
        {
            this.HireDate = HireDate;
        }

        public override string ToString()
        {
            return String.Format("ID: {0}, Name: {1} , Security Level: {2}, Salary: {3:C}, Hire Date: {4}, Gender: {5}",
                              Id, Name ,SecurityLevel, Salary, HireDate, Gender);
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {

            HireDate hireDate = new HireDate(25,6,2003);

            Employee employee = new Employee(hireDate)
            {
                Id = 1,
                Name = "Test",
                SecurityLevel = SecurityLevel.guest,
                Salary = 5_000,
                Gender = Gender.M
            };

            Console.WriteLine(employee);

        }
    }
}
