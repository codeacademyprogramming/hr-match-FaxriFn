namespace TaskWinform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Server1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CVs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        Surname = c.String(maxLength: 30),
                        GenderId = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        EducationId = c.Int(nullable: false),
                        ExperienceId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        Min_Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tel_Number = c.String(),
                        Experiences_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Educations", t => t.EducationId, cascadeDelete: true)
                .ForeignKey("dbo.Experiences", t => t.Experiences_Id)
                .ForeignKey("dbo.Genders", t => t.GenderId, cascadeDelete: true)
                .Index(t => t.GenderId)
                .Index(t => t.EducationId)
                .Index(t => t.CategoryId)
                .Index(t => t.CityId)
                .Index(t => t.Experiences_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SignUpIsverens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Advertisement_Name = c.String(),
                        Company_Name = c.String(),
                        CategoryId = c.Int(nullable: false),
                        Work_Info = c.String(),
                        City = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EducationId = c.Int(nullable: false),
                        ExperienceId = c.Int(nullable: false),
                        Tel = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Educations", t => t.EducationId, cascadeDelete: true)
                .ForeignKey("dbo.Experiences", t => t.ExperienceId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.EducationId)
                .Index(t => t.ExperienceId);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Experience1 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Gender1 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SignUps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Email = c.String(),
                        StatusId = c.Int(nullable: false),
                        Password = c.String(),
                        RandomCode = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SignUps", "StatusId", "dbo.Status");
            DropForeignKey("dbo.CVs", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.SignUpIsverens", "ExperienceId", "dbo.Experiences");
            DropForeignKey("dbo.CVs", "Experiences_Id", "dbo.Experiences");
            DropForeignKey("dbo.SignUpIsverens", "EducationId", "dbo.Educations");
            DropForeignKey("dbo.SignUpIsverens", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.CVs", "EducationId", "dbo.Educations");
            DropForeignKey("dbo.CVs", "CityId", "dbo.Cities");
            DropForeignKey("dbo.CVs", "CategoryId", "dbo.Categories");
            DropIndex("dbo.SignUps", new[] { "StatusId" });
            DropIndex("dbo.SignUpIsverens", new[] { "ExperienceId" });
            DropIndex("dbo.SignUpIsverens", new[] { "EducationId" });
            DropIndex("dbo.SignUpIsverens", new[] { "CategoryId" });
            DropIndex("dbo.CVs", new[] { "Experiences_Id" });
            DropIndex("dbo.CVs", new[] { "CityId" });
            DropIndex("dbo.CVs", new[] { "CategoryId" });
            DropIndex("dbo.CVs", new[] { "EducationId" });
            DropIndex("dbo.CVs", new[] { "GenderId" });
            DropTable("dbo.Status");
            DropTable("dbo.SignUps");
            DropTable("dbo.Genders");
            DropTable("dbo.Experiences");
            DropTable("dbo.SignUpIsverens");
            DropTable("dbo.Educations");
            DropTable("dbo.Cities");
            DropTable("dbo.CVs");
            DropTable("dbo.Categories");
        }
    }
}
