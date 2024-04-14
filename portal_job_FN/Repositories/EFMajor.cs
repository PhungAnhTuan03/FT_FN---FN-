using Microsoft.EntityFrameworkCore;
using portal_job_FN.Data;
using portal_job_FN.Models;

namespace portal_job_FN.Repositories
{
    public class EFMajor : IMajor
    {
        private readonly ApplicationDbContext _context;
        public EFMajor(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Major>> GetAllAsync()
        {
            return await _context.majors.ToListAsync();
        }
    }
}
