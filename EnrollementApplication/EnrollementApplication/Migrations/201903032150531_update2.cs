namespace EnrollementApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Address1", c => c.String());
            AddColumn("dbo.Students", "Address2", c => c.String());
            AddColumn("dbo.Students", "City", c => c.String());
            AddColumn("dbo.Students", "ZipCode", c => c.String(maxLength: 5));
            AddColumn("dbo.Students", "State", c => c.String(maxLength: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "State");
            DropColumn("dbo.Students", "ZipCode");
            DropColumn("dbo.Students", "City");
            DropColumn("dbo.Students", "Address2");
            DropColumn("dbo.Students", "Address1");
        }
    }
}
