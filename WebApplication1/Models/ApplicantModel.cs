using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ApplicantModel : DbContext
    {
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<ApplicanEx>ApplicanExes { get; set; }
    }
}