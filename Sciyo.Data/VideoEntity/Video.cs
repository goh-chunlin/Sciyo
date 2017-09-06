using System;
using Sciyo.Data.PlaylistEntity;

namespace Sciyo.Data.VideoEntity
{
    public class Video : BaseEntity
    {
        public string Name { get; set; }

		public string YoutubeId { get; set; }

		public int LengthInSecond { get; set; }

        public Int64 PlaylistId { get; set; }
        public virtual Playlist Playlist { get; set; }
    }
}
