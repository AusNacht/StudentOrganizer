using System;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using StudentOrganizer.Entities;

namespace StudentOrganizer.Dao
{
    public class UniversityDatabase : DbContext
    {
       public DbSet<Student> Students { get; set; }
    }
}
