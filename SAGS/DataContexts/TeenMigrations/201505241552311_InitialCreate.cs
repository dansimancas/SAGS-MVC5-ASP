namespace SAGS.DataContexts.TeenMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Lastname = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        City = c.String(nullable: false),
                        DocumentTypeID = c.Int(nullable: false),
                        Identification = c.Long(nullable: false),
                        TeenMedicalHistory_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medical histories", t => t.TeenMedicalHistory_Id, cascadeDelete: true)
                .Index(t => t.TeenMedicalHistory_Id);
            
            CreateTable(
                "dbo.Medical histories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MemberId = c.Int(nullable: false),
                        Observations = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teens", "TeenMedicalHistory_Id", "dbo.Medical histories");
            DropIndex("dbo.Teens", new[] { "TeenMedicalHistory_Id" });
            DropTable("dbo.Medical histories");
            DropTable("dbo.Teens");
        }
    }
}
