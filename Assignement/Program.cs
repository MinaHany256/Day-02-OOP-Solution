using System.Reflection;
using System.Xml.Linq;

namespace Assignement
{


    #region Enums
    enum SecurityLevel
    {
        guest, Developer, secretary, DBA, SecurityOfficer
    }

    enum Gender
    {
        M, F
    } 
    #endregion

    class HireDate
    {
        #region Properties
        public int Day { get; }
        public int Month { get; }
        public int Year { get; } 
        #endregion

        #region Constructors
        public HireDate(int day, int month, int year)
        {
            if (day < 0 || day > 31 || month < 1 || month > 12 || year > DateTime.Now.Year)
            {
                day = 1;
                month = 1;
                year = 1900;
            }

            Day = day;
            Month = month;
            Year = year;
        } 
        #endregion

        #region Methods
        public override string ToString()
        {
            return String.Format("{0:D2}/{1:D2}/{2}", Day, Month, Year);
        } 
        #endregion

    }

    class Employee
    {
        #region Setters and Getters
        //private int Id;
        //private string Name;
        //private SecurityLevel SecurityLevel;
        //private decimal Salary;
        //private HireDate HireDate;
        //private Gender Gender;

        //public int GetID()
        //{
        //    return Id;
        //}

        //public void SetID(int id)
        //{
        //    if (id < 0)
        //    {
        //        Id = 0;
        //    }
        //    else
        //    {
        //        Id = id;
        //    }
        //}

        //public string GetName()
        //{
        //    return Name;
        //}

        //public void SetName(string name)
        //{
        //    if (name is null)
        //    {
        //        Name = "Unknown";
        //    }
        //    else
        //    {
        //        Name = name;
        //    }
        //}

        //public SecurityLevel GetSecurity()
        //{
        //    return SecurityLevel;
        //}

        //public void SetSecurity(SecurityLevel security)
        //{
        //    SecurityLevel = security;
        //}

        //public decimal GetSalary()
        //{
        //    return Salary;
        //}

        //public void SetSalary(decimal salary)
        //{
        //    if (salary < 0)
        //    {
        //        Salary = 0;
        //    }
        //    else
        //    {
        //        Salary = salary;
        //    }
        //}

        //public HireDate GetHireDate()
        //{
        //    return HireDate;
        //}

        //public void SetHireDate(HireDate hireDate)
        //{
        //   HireDate = hireDate;
        //}

        //public Gender GetGender()
        //{
        //    return Gender;
        //}

        //public void SetGender(Gender gender)
        //{
        //    Gender = gender;
        //} 
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }
        public Gender Gender { get; set; }
        #endregion

        #region Constructors
        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HireDate HireDate, Gender gender)
        {
            Id = id < 0 ? 0 : id;
            Name = string.IsNullOrWhiteSpace(name) ? "Unknown" : name;
            SecurityLevel = securityLevel;
            Salary = salary < 0 ? 0 : salary;
            this.HireDate = HireDate;
            Gender = gender;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return String.Format("ID: {0}, Name: {1} , Security Level: {2}, Salary: {3:C}, Hire Date: {4}, Gender: {5}",
                              Id, Name, SecurityLevel, Salary, HireDate, Gender);
        } 
        #endregion

    }

    internal class Program
    {
        #region Method Question 04
        static int boxing = 0;
        static int unboxing = 0;
        static int CompareEmployeesByHireDate(Employee x, Employee y)
        {
            boxing++;
            unboxing++;

            if (x.HireDate.Year != y.HireDate.Year)
                return x.HireDate.Year.CompareTo(y.HireDate.Year);
            if (x.HireDate.Month != y.HireDate.Month)
                return x.HireDate.Month.CompareTo(y.HireDate.Month);
            return x.HireDate.Day.CompareTo(y.HireDate.Day);
        } 
        #endregion


        static void Main(string[] args)
        {

            HireDate hireDate = new HireDate(25, 6, 2003);
            Employee employee = new Employee(1, "Mina", SecurityLevel.guest, 5_000, hireDate, Gender.M);
            //Console.WriteLine(employee);



            #region Question 03

            HireDate hireDate01 = new HireDate(25, 6, 2003);
            HireDate hireDate02 = new HireDate(15, 8, 1987);
            HireDate hireDate03 = new HireDate(22, 1, 1945);


            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(1, "DBA", SecurityLevel.DBA, 5_000, hireDate01, Gender.M);
            EmpArr[1] = new Employee(2, "Guest", SecurityLevel.guest, 10_000, hireDate02, Gender.F);
            EmpArr[2] = new Employee(3, "SecurityOfficer", SecurityLevel.SecurityOfficer, 6_000, hireDate03, Gender.M);

            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp);
            }




            #endregion


            #region Question 04

            Array.Sort(EmpArr, CompareEmployeesByHireDate);


            Console.WriteLine("Employees after sorting:");
            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp);
            }


            Console.WriteLine($"Boxing operations: {boxing}");
            Console.WriteLine($"Unboxing operations: {unboxing}");


            #endregion
        }
    }
}
