using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sciyo.Data;
using Sciyo.Data.PlaylistEntity;
using Sciyo.Models;

namespace Sciyo.Pages
{
    public class PlaylistsModel : PageModel
    {
        private readonly IRepository<Playlist> _repoPlaylist;

        public PlaylistsModel(IRepository<Playlist> repoPlaylist)
        {
            _repoPlaylist = repoPlaylist;
        }

        public IEnumerable<PlaylistViewModel> Playlists { get; set; }

        public void OnGet()
        {
            Playlists = _repoPlaylist.GetAll().Select(p => 
                new PlaylistViewModel{
                    Name = p.Name,
                    Description = p.Description
                }
            ).ToList();
        }
    }
}
