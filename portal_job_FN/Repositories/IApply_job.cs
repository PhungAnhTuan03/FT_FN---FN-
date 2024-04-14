using portal_job_FN.Models;

namespace portal_job_FN.Repositories
{
    public interface IApply_job
    {
        Task<IEnumerable<apply_job>> GetAllAsync();
        Task<apply_job> GetByIdAsync(int id);
        Task AddAsync(apply_job apply_Job);
        Task UpdateAsync(apply_job apply_Job);
        Task DeleteAsync(int id);
    }
}
