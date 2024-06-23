namespace DZ_21_06.Models
{
    public class Department
    {
        public string name { get; set; }
        public Boss boss { get; set; }
        public List<Employee> employees { get; set; }
        public Company company { get; set; }
    }

    public class Boss
    {
        public string name { get; set; }
        public string surname { get; set; }
    }


    public class Employee
    {
        public string name { get; set; }
        public string surname { get; set; }
    }

    public class Company
    {
        public string name { get; set; }
        public string Country { get; set; }
    }

}
