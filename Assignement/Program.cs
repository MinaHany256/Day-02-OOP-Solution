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

    class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public string? HireDate { get; set; }
        public Gender Gender { get; set; }


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

            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Test",
                SecurityLevel = SecurityLevel.guest,
                Salary = 5_000,
                HireDate = "25/6/2003",
                Gender = Gender.M
            };

            Console.WriteLine(employee);

        }
    }
}
