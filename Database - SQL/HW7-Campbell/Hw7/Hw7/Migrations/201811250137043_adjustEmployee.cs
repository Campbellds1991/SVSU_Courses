namespace Hw7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adjustEmployee : DbMigration
    {
        public override void Up()
        {
            
            DropForeignKey("dbo.EmployeeSkills", "EmployeeID", "dbo.Employee");
            DropForeignKey("dbo.WorksIn", "EmployeeID", "dbo.Employee");
            DropIndex("dbo.WorksIn", new[] { "EmployeeID" });
            DropIndex("dbo.EmployeeSkills", new[] { "EmployeeID" });
            DropPrimaryKey("dbo.WorksIn");
            DropPrimaryKey("dbo.Employee");
            DropPrimaryKey("dbo.EmployeeSkills");
            AlterColumn("dbo.WorksIn", "EmployeeID", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Employee", "EmployeeID", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Employee", "EmployeeSupervisor", c => c.String(maxLength: 10));
            AlterColumn("dbo.EmployeeSkills", "EmployeeID", c => c.String(nullable: false, maxLength: 10));
            AddPrimaryKey("dbo.WorksIn", new[] { "EmployeeID", "WorkCenterID" });
            AddPrimaryKey("dbo.Employee", "EmployeeID");
            AddPrimaryKey("dbo.EmployeeSkills", new[] { "EmployeeID", "SkillID" });
            CreateIndex("dbo.WorksIn", "EmployeeID");
            CreateIndex("dbo.Employee", "EmployeeSupervisor");
            CreateIndex("dbo.EmployeeSkills", "EmployeeID");
            AddForeignKey("dbo.Employee", "EmployeeSupervisor", "dbo.Employee", "EmployeeID");
            AddForeignKey("dbo.EmployeeSkills", "EmployeeID", "dbo.Employee", "EmployeeID", cascadeDelete: true);
            AddForeignKey("dbo.WorksIn", "EmployeeID", "dbo.Employee", "EmployeeID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorksIn", "EmployeeID", "dbo.Employee");
            DropForeignKey("dbo.EmployeeSkills", "EmployeeID", "dbo.Employee");
            DropForeignKey("dbo.Employee", "EmployeeSupervisor", "dbo.Employee");
            DropIndex("dbo.EmployeeSkills", new[] { "EmployeeID" });
            DropIndex("dbo.Employee", new[] { "EmployeeSupervisor" });
            DropIndex("dbo.WorksIn", new[] { "EmployeeID" });
            DropPrimaryKey("dbo.EmployeeSkills");
            DropPrimaryKey("dbo.Employee");
            DropPrimaryKey("dbo.WorksIn");
            AlterColumn("dbo.EmployeeSkills", "EmployeeID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Employee", "EmployeeSupervisor", c => c.String());
            AlterColumn("dbo.Employee", "EmployeeID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.WorksIn", "EmployeeID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.EmployeeSkills", new[] { "EmployeeID", "SkillID" });
            AddPrimaryKey("dbo.Employee", "EmployeeID");
            AddPrimaryKey("dbo.WorksIn", new[] { "EmployeeID", "WorkCenterID" });
            CreateIndex("dbo.EmployeeSkills", "EmployeeID");
            CreateIndex("dbo.WorksIn", "EmployeeID");
            AddForeignKey("dbo.WorksIn", "EmployeeID", "dbo.Employee", "EmployeeID", cascadeDelete: true);
            AddForeignKey("dbo.EmployeeSkills", "EmployeeID", "dbo.Employee", "EmployeeID", cascadeDelete: true);
        }
    }
}
