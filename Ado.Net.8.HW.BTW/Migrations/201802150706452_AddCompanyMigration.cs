namespace Ado.Net._8.HW.BTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TablesManufacturer", "ManufacturerDescription", c => c.String());

            CreateTable(
                    "dbo.Equipment",   
                    c => new    
                    {
                        intEquipmentID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        intGarageRoom = c.Int(nullable: false),
                        intManufacturerID = c.Int(nullable: false),
                        strManufYear = c.String(nullable: false),
                        intSNPrefixID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.intEquipmentID);

            CreateTable(
                    "dbo.Model",
                    c => new
                    {
                        intModelID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        strName = c.String(nullable: false),
                        intManufacturerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.intModelID);

            AddColumn("dbo.Model ", "intModelID", c => c.Int());
        }
        


        public override void Down()
        {
            DropColumn("dbo.TablesManufacturer", "strManufacturerChecklistId");

        }
    }
}
