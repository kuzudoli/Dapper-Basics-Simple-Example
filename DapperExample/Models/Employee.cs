namespace DapperExample.Models
{
    public class Employee
    {
        public int employee_id { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public int age { get; set; }
        public string? email { get; set; }
        public string? postal_code { get; set; }
        public string? favorite_color { get; set; }
        public string? hire_date { get; set; }
        public double salary { get; set; }

        public Company? Company { get; set; }
    }
}