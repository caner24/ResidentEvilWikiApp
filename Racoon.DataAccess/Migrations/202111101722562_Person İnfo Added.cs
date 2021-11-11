namespace Racoon.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonİnfoAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Personİnfo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Personİnfo");
        }
    }
}
