using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sciyo.Data.PlaylistEntity
{
    public class PlaylistMap
    {
        public PlaylistMap(EntityTypeBuilder<Playlist> entityBuilder)
		{
			entityBuilder.HasKey(t => t.Id);
			entityBuilder.Property(t => t.Name).IsRequired();
			entityBuilder.Property(t => t.Description).IsRequired();
		}
    }
}