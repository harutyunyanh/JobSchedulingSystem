using API.Models;

namespace API.Services
{
	public interface IJobService
	{
		Task<List<JobModel>> List();
	}
}
