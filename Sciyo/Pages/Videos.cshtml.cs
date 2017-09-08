using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sciyo.Data.VideoEntity;
using Sciyo.Data.PlaylistEntity;
using Sciyo.Models;
using Sciyo.Data;
using Microsoft.AspNetCore.Authorization;

namespace Sciyo.Pages
{
    [Authorize]
    public class VideosModel : PageModel
    {
        private readonly IRepository<Playlist> _repoPlaylist;
        private readonly IRepository<Video> _repoVideo;

        public VideosModel(IRepository<Playlist> repoPlaylist, IRepository<Video> repoVideo)
        {
            _repoPlaylist = repoPlaylist;
            _repoVideo = repoVideo;
        }

        public IEnumerable<VideoViewModel> Videos { get; set; }

        public void OnGet()
        {
            Videos = _repoVideo.GetAll().Select(v => 
                new VideoViewModel{
                    Name = v.Name,
                    YoutubeId = v.YoutubeId,
                    LengthInSecond = v.LengthInSecond
                }
            ).ToList();
        }
    }
}
