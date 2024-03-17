namespace Code_first.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Employees", newSchema: "HR");
        }
        
        public override void Down()
        {
            MoveTable(name: "HR.Employees", newSchema: "dbo");
        }
    }
}
