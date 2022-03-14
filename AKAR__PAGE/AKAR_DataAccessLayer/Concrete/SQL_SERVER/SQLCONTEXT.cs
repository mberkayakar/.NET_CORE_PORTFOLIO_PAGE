using AKAR_EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR_DataAccessLayer.Concrete.SQL_SERVER
{
    public class SQLCONTEXT:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=AKARPABDB; Integrated Security=True");
        }

        public DbSet<Email> Emails { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Interesting> Interestings { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<TypeWritterText> typeWritterTexts { get; set; }





    }
}
