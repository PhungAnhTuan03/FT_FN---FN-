using portal_job_FN.Models;

namespace portal_job_FN.Repositories
{
    public interface IMajor
    {
        Task<IEnumerable<Major>> GetAllAsync();
    }
}
