namespace Racoon.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedoccupationımage2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Occupations", "Occupationİmage1", c => c.Binary());
            AddColumn("dbo.Occupations", "Occupationİmage2", c => c.Binary());
            DropColumn("dbo.Occupations", "Occupationİmage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Occupations", "Occupationİmage", c => c.Binary());
            DropColumn("dbo.Occupations", "Occupationİmage2");
            DropColumn("dbo.Occupations", "Occupationİmage1");
        }
    }
}
