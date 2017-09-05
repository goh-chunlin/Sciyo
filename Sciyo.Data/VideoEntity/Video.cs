using System;

namespace Sciyo.Data.VideoEntity
{
    public class Video : BaseEntity
    {
        public string Name { get; set; }

		public string YoutubeId { get; set; }

		public int LengthInSecond { get; set; }
    }
}
