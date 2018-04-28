namespace Test.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Device",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(),
                        TypeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeviceType", t => t.TypeId)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.DeviceType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                        ParentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeviceType", t => t.ParentId)
                .Index(t => t.ParentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Device", "TypeId", "dbo.DeviceType");
            DropForeignKey("dbo.DeviceType", "ParentId", "dbo.DeviceType");
            DropIndex("dbo.DeviceType", new[] { "ParentId" });
            DropIndex("dbo.Device", new[] { "TypeId" });
            DropTable("dbo.DeviceType");
            DropTable("dbo.Device");
        }
    }
}
