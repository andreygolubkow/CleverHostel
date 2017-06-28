namespace HostelData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Start : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applicants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BaseDocuments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DocumentDate = c.DateTime(nullable: false),
                        Points = c.Int(nullable: false),
                        Comments = c.String(),
                        Name = c.String(),
                        Verdict = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Applicant_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Applicants", t => t.Applicant_Id)
                .Index(t => t.Applicant_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Room = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Sex = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        Group_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StudentGroups", t => t.Group_Id)
                .Index(t => t.Group_Id);
            
            CreateTable(
                "dbo.StudentGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Num = c.String(),
                        Faculty = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentBaseDocuments",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        BaseDocument_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.BaseDocument_Id })
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.BaseDocuments", t => t.BaseDocument_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.BaseDocument_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Group_Id", "dbo.StudentGroups");
            DropForeignKey("dbo.StudentBaseDocuments", "BaseDocument_Id", "dbo.BaseDocuments");
            DropForeignKey("dbo.StudentBaseDocuments", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.BaseDocuments", "Applicant_Id", "dbo.Applicants");
            DropForeignKey("dbo.Applicants", "Department_Id", "dbo.Departments");
            DropIndex("dbo.StudentBaseDocuments", new[] { "BaseDocument_Id" });
            DropIndex("dbo.StudentBaseDocuments", new[] { "Student_Id" });
            DropIndex("dbo.Students", new[] { "Group_Id" });
            DropIndex("dbo.BaseDocuments", new[] { "Applicant_Id" });
            DropIndex("dbo.Applicants", new[] { "Department_Id" });
            DropTable("dbo.StudentBaseDocuments");
            DropTable("dbo.StudentGroups");
            DropTable("dbo.Students");
            DropTable("dbo.BaseDocuments");
            DropTable("dbo.Departments");
            DropTable("dbo.Applicants");
        }
    }
}
