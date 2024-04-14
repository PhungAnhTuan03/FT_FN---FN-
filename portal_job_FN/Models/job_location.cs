namespace portal_job_FN.Models
{
    public class job_location
    {
        public int Id { get; set; }
        public string? province_name { get; set; }
        public List<post_job>? post_Jobs { get; set; } 
        public List<ApplicationUser>? applicationUsers { get; set; }
    }
}
