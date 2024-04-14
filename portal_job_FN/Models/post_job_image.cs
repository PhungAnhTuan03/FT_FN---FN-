namespace portal_job_FN.Models
{
    public class post_job_image
    {
        public int Id { get; set; }
        public string? post_image_url { get; set; }
        public int post_job_id { get; set; }
        public post_job? post_Job { get; set; }
    }
}
