using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Evernote.Entities;

namespace Evernote.DataAccessLayer
{
    public class DatabaseContext : DbContext
    {
        public DbSet<EvernoteUser> Evernotes { get; set; }
        public DbSet<EvernoteNote> Notes { get; set; }
        public DbSet<EvernoteComment> Comment { get; set; }
        public DbSet<EvernoteCategory> Categories { get; set; }
        public DbSet<EvernoteLiked> Likes { get; set; }

    }
}
