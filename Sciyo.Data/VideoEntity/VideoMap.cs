using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sciyo.Data.VideoEntity
{
    public class VideoMap
    {
        public VideoMap(EntityTypeBuilder<Video> entityBuilder)
		{
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Name).IsRequired();
			entityBuilder.Property(t => t.YoutubeId).IsRequired();
			entityBuilder.Property(t => t.LengthInSeconds).IsRequired();
		}
    }
}