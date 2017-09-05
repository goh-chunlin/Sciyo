using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sciyo.Data.VideoEntity
{
	public interface IVideoRepository
	{
		// Create
		Task AddVideoAsync(Video video);

		// Read
		IEnumerable<Video> GetAllVideos();
		Task<Video> GetVideoAsync(Int64 id);

		// Update
		Task UpdateVideoAsync(Video video);

		// Delete
		Task DeleteVideoAsync(Int64 id);
	}
}