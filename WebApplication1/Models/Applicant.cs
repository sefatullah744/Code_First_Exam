using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Applicant
    {
       public Applicant()
        {
            ApplicanExes =new List<ApplicanEx>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public string DOB {  get; set; }
        public int TotalEx {  get; set; }
        public string PicPath {  get; set; }
        [NotMapped]
        public HttpPostedFileBase Picture { get; set; }
        public bool IsAvailable {  get; set; }
        public List<ApplicanEx> ApplicanExes { get; set; }

    }
}