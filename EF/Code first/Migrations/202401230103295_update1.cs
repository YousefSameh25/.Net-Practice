namespace Code_first.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "HR.Employees", name: "Name", newName: "FullName");
            AddColumn("HR.Employees", "BirthDate", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("HR.Employees", "DepartmentId", c => c.Int(nullable: false));
            AlterColumn("HR.Employees", "FullName", c => c.String(maxLength: 100));
            AlterColumn("HR.Employees", "Age", c => c.Int());
            CreateIndex("HR.Employees", "DepartmentId");
            AddForeignKey("HR.Employees", "DepartmentId", "dbo.Departments", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("HR.Employees", "DepartmentId", "dbo.Departments");
            DropIndex("HR.Employees", new[] { "DepartmentId" });
            AlterColumn("HR.Employees", "Age", c => c.Int(nullable: false));
            AlterColumn("HR.Employees", "FullName", c => c.String());
            DropColumn("HR.Employees", "DepartmentId");
            DropColumn("HR.Employees", "BirthDate");
            RenameColumn(table: "HR.Employees", name: "FullName", newName: "Name");
        }
    }
}
