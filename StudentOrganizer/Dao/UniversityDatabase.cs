using System;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using StudentOrganizer.Entities;

namespace StudentOrganizer.Dao
{
    //Stub for future database
    public class UniversityDatabase : DbContext
    {
       public DbSet<Student> Students { get; set; }
    }
}
