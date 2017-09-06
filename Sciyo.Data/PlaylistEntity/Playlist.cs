using System;
using System.Collections.Generic;
using Sciyo.Data.VideoEntity;

namespace Sciyo.Data.PlaylistEntity
{
    public class Playlist : BaseEntity
    {
        public string Name { get; set; }

		public string Description { get; set; }

		public virtual ICollection<Video> Videos { get; set; }
    }
}