namespace IJSE.POS.DataAccess.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dbinit : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Customers", newName: "Customer");
            RenameTable(name: "dbo.Invoices", newName: "Invoice");
            RenameTable(name: "dbo.InvoiceDetails", newName: "InvoiceDetail");
            RenameTable(name: "dbo.ItemDetails", newName: "ItemDetail");
            RenameTable(name: "dbo.Items", newName: "Item");
            RenameTable(name: "dbo.SystemUsers", newName: "SystemUser");
            DropColumn("dbo.SystemUser", "UserRole");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SystemUser", "UserRole", c => c.String());
            RenameTable(name: "dbo.SystemUser", newName: "SystemUsers");
            RenameTable(name: "dbo.Item", newName: "Items");
            RenameTable(name: "dbo.ItemDetail", newName: "ItemDetails");
            RenameTable(name: "dbo.InvoiceDetail", newName: "InvoiceDetails");
            RenameTable(name: "dbo.Invoice", newName: "Invoices");
            RenameTable(name: "dbo.Customer", newName: "Customers");
        }
    }
}
