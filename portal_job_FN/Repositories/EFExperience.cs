﻿using Microsoft.EntityFrameworkCore;
using portal_job_FN.Data;
using portal_job_FN.Models;

namespace portal_job_FN.Repositories
{
    public class EFExperience : IExperience
    {
        private readonly ApplicationDbContext _context;
        public EFExperience(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Experience>> GetAllAsync()
        {
            return await _context.experience.ToListAsync();
        }
    }
}
