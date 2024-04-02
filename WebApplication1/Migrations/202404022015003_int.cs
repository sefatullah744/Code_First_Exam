namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _int : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicanExes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Designation = c.String(),
                        YearOfEx = c.Int(nullable: false),
                        AppId = c.Int(nullable: false),
                        Applicant_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Applicants", t => t.Applicant_Id)
                .Index(t => t.Applicant_Id);
            
            CreateTable(
                "dbo.Applicants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DOB = c.String(),
                        TotalEx = c.Int(nullable: false),
                        PicPath = c.String(),
                        IsAvailable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApplicanExes", "Applicant_Id", "dbo.Applicants");
            DropIndex("dbo.ApplicanExes", new[] { "Applicant_Id" });
            DropTable("dbo.Applicants");
            DropTable("dbo.ApplicanExes");
        }
    }
}
