using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Sciyo.Data.VideoEntity
{
	public class VideoRepository : IVideoRepository
	{
		private ApplicationContext dbContext;

		private DbSet<Video> videoEntity;

		public VideoRepository(ApplicationContext context)
		{
			this.dbContext = context;
			videoEntity = dbContext.Set<Video>();
		}

		public async Task AddVideoAsync(Video video)
		{
			dbContext.Entry(video).State = EntityState.Added;
			await dbContext.SaveChangesAsync();
		}

		public IEnumerable<Video> GetAllVideos()
		{
			return videoEntity.AsEnumerable();
		}

		public async Task<Video> GetVideoAsync(long id)
		{
			return await videoEntity.FirstOrDefaultAsync(v => v.Id == id);
		}

		public async Task UpdateVideoAsync(Video video)
		{
			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteVideoAsync(long id)
		{
			var selectedVideo = await GetVideoAsync(id);
			videoEntity.Remove(selectedVideo);
			await dbContext.SaveChangesAsync();
		}
	}
}