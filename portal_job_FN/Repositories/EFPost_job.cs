using Microsoft.EntityFrameworkCore;
using portal_job_FN.Data;
using portal_job_FN.Models;

namespace portal_job_FN.Repositories
{
    public class EFPost_job : IPost_job
    {
        private readonly ApplicationDbContext _context;
        public EFPost_job(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<post_job>> GetAllAsync()
        {
            //bao gồm danh mục, nếu không có sẽ ko ra danh mục
            var applicationDbContext = await _context.post_Jobs
                 .Include(b => b.job_Location)
                .Include(b => b.major)
                .Include(b => b.experience)
                .Include(b => b.applicationUser)
                .ToListAsync();

            return await _context.post_Jobs.ToListAsync();
        }
        public async Task<post_job> GetByIdAsync(int id)
        {
            var applicationDbContext = await _context.post_Jobs
                .Include(b => b.job_Location)
                .Include(b => b.major)
                .Include(b => b.experience)
                .Include(b => b.applicationUser)
                .ToListAsync();
            return await _context.post_Jobs.FindAsync(id);
        }

        public async Task AddAsync(post_job post_Job)
        {
            _context.post_Jobs.Add(post_Job);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(post_job post_Job)
        {
            _context.post_Jobs.Update(post_Job);
            await _context.SaveChangesAsync();
        }

        public async Task? DeleteAsync(int id)
        {
            var post_Job = await _context.post_Jobs.FindAsync(id);
            _context.post_Jobs.Remove(post_Job);
            await _context.SaveChangesAsync();
        }


    }
}
