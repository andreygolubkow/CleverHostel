namespace HostelData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartMigration : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Room = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Sex = c.Int(nullable: false),
                        Group_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .Index(t => t.Group_Id);
            
            CreateTable(
                "dbo.Groups",
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
            DropForeignKey("dbo.Students", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.StudentBaseDocuments", "BaseDocument_Id", "dbo.BaseDocuments");
            DropForeignKey("dbo.StudentBaseDocuments", "Student_Id", "dbo.Students");
            DropIndex("dbo.StudentBaseDocuments", new[] { "BaseDocument_Id" });
            DropIndex("dbo.StudentBaseDocuments", new[] { "Student_Id" });
            DropIndex("dbo.Students", new[] { "Group_Id" });
            DropTable("dbo.StudentBaseDocuments");
            DropTable("dbo.Groups");
            DropTable("dbo.Students");
            DropTable("dbo.BaseDocuments");
        }
    }
}
