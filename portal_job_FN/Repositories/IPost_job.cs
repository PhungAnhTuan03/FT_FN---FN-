using portal_job_FN.Models;

namespace portal_job_FN.Repositories
{
    public interface IPost_job
    {
        Task<IEnumerable<post_job>> GetAllAsync();
        Task<post_job> GetByIdAsync(int id);
        Task AddAsync(post_job post_Job);
        Task UpdateAsync(post_job post_Job);
        Task DeleteAsync(int id);

    }
}
