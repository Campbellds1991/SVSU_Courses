namespace Hw7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixOrders : DbMigration
    {
        public override void Up()
        {
            //DropColumn("dbo.Order", "ShipAdrsID");
            //RenameColumn(table: "dbo.Order", name: "CustomerShipAddress_ShipAddressID", newName: "ShipAdrsID");
            //RenameIndex(table: "dbo.Order", name: "IX_CustomerShipAddress_ShipAddressID", newName: "IX_ShipAdrsID");
        }
        
        public override void Down()
        {
            //RenameIndex(table: "dbo.Order", name: "IX_ShipAdrsID", newName: "IX_CustomerShipAddress_ShipAddressID");
            //RenameColumn(table: "dbo.Order", name: "ShipAdrsID", newName: "CustomerShipAddress_ShipAddressID");
            //AddColumn("dbo.Order", "ShipAdrsID", c => c.Int());
        }
    }
}
