﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Collage_Moodle.Models;
using System.Data.Entity;


namespace Collage_Moodle.Dal
{
    public class DAL : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Courses>().ToTable("Courses");
            modelBuilder.Entity<Exams>().ToTable("Exams");
            modelBuilder.Entity<Students>().ToTable("Students");
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Exams> Exams { get; set; }
        public DbSet<Students> Students { get; set; }

    }
}