﻿using data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lead> Leads { get; set; }
        public DbSet<History> Historys { get; set; }
        public DbSet<HistoryGroup> HistoryGroups { get; set; }
        public DbSet<HR> HRs { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Status> Statuss { get; set; }
        public DbSet<SkillsLead> SkillsLeads { get; set; }
        public DbSet<Teacher> Teacherss { get; set; }
        public DbSet<Group> Groups { get; set; }
        public ApplicationContext()
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CRMDevEducation;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HistoryGroup>().HasNoKey();
            modelBuilder.Entity<Log>().HasNoKey();
            modelBuilder.Entity<SkillsLead>().HasNoKey();
            modelBuilder.Entity<History>().HasNoKey();
            //base.OnModelCreating(modelBuilder);

        }
    }
}
