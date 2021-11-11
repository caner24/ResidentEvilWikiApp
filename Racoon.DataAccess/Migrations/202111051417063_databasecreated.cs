namespace Racoon.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databasecreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Occupations",
                c => new
                    {
                        OccupationId = c.Int(nullable: false, identity: true),
                        OccupationName = c.String(),
                        Occupationİmage = c.Binary(),
                    })
                .PrimaryKey(t => t.OccupationId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        PersonName = c.String(),
                        OccupationId = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        DateOfDeath = c.DateTime(nullable: false),
                        Sex = c.String(),
                        Status = c.String(),
                        Personİmage = c.Binary(),
                        Ocuppationİmage1 = c.Binary(),
                        Ocuppationİmage2 = c.Binary(),
                    })
                .PrimaryKey(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
            DropTable("dbo.Occupations");
        }
    }
}
