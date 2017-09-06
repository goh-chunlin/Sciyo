using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sciyo.Data.PlaylistEntity;
using Sciyo.Data.VideoEntity;

namespace Sciyo.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new PlaylistMap(modelBuilder.Entity<Playlist>());
            new VideoMap(modelBuilder.Entity<Video>());
        }
    }
}
