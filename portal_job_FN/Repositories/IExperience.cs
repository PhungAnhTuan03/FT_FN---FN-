using portal_job_FN.Models;

namespace portal_job_FN.Repositories
{
    public interface IExperience
    {
        Task<IEnumerable<Experience>> GetAllAsync();
    }
}
