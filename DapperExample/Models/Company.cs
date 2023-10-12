namespace DapperExample.Models
{
    public class Company
    {
        public int company_id { get; set; }
        public string? company_name { get; set; }
        public string? founding_date { get; set; }
        
        //JOIN sorgusu kullanabilmek için veri tabanında bu kolonda bulunmaktadır
        //veri tekrarı olmaması için model'e eklemedim
        //public string employee_id { get; set; } 
    }
}