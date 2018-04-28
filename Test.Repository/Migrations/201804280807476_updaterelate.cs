namespace Test.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updaterelate : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.RoleMenu", name: "RoleId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.RoleMenu", name: "MenuId", newName: "RoleId");
            RenameColumn(table: "dbo.RoleMenu", name: "__mig_tmp__0", newName: "MenuId");
            RenameIndex(table: "dbo.RoleMenu", name: "IX_RoleId", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.RoleMenu", name: "IX_MenuId", newName: "IX_RoleId");
            RenameIndex(table: "dbo.RoleMenu", name: "__mig_tmp__0", newName: "IX_MenuId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.RoleMenu", name: "IX_MenuId", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.RoleMenu", name: "IX_RoleId", newName: "IX_MenuId");
            RenameIndex(table: "dbo.RoleMenu", name: "__mig_tmp__0", newName: "IX_RoleId");
            RenameColumn(table: "dbo.RoleMenu", name: "MenuId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.RoleMenu", name: "RoleId", newName: "MenuId");
            RenameColumn(table: "dbo.RoleMenu", name: "__mig_tmp__0", newName: "RoleId");
        }
    }
}
