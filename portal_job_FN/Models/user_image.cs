namespace portal_job_FN.Models
{
    public class user_image
    {
        public int Id { get; set; }
        public string? applicationUser_image_url {  get; set; }
        public string? applicationUser_id { get; set; }
        public ApplicationUser? applicationUser { get; set; }
    }
}
