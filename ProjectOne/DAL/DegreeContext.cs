using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectOne.Models;
using System.Data.Entity;

namespace ProjectOne.DAL
{
    public class DegreeContext : DbContext
    {
        public DegreeContext() :base("DegreeContext")
        {

        }

        public DbSet<Users> User { get; set; }
        public DbSet<Degrees> Degree { get; set; }
        public DbSet<DegreeQuestions> DegreeQuestion { get; set; }
    }
}