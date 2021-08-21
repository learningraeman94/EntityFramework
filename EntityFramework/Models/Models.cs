using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class JournalContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Dicti> Dicti { get; set; }
        public string DbPath { get; private set; }
        public JournalContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}App.db";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
    }
}
