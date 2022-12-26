using API.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
	public class JobService : IJobService
	{
        private readonly ApplicationDbContext dbContext;

        public JobService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<JobModel>> List()
        {
            try
            {
                var jobs = await (from job in dbContext.Jobs
                                  select new JobModel()
                                  {
                                      Id = job.Id,
                                      Name = job.Name,
                                      Duration = job.Duration
                                  }).ToListAsync();

                return jobs;
            }
            catch (Exception e)
            {

                throw;
            }
          
        }
    }
}
