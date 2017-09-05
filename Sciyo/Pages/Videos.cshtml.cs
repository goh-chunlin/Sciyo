using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sciyo.Data.VideoEntity;
using Sciyo.Models;

namespace Sciyo.Pages
{
    public class VideoModel : PageModel
    {
        private IVideoRepository videoRepository;

        public VideoModel(IVideoRepository videoRepository)
        {
            this.videoRepository = videoRepository;
        }

        public IEnumerable<VideoViewModel> Videos { get; set; }

        public void OnGet()
        {
            Videos = videoRepository.GetAllVideos().Select(v => 
                new VideoViewModel{
                    Name = v.Name,
                    YoutubeId = v.YoutubeId,
                    LengthInSecond = v.LengthInSeconds
                }
            );
        }
    }
}
