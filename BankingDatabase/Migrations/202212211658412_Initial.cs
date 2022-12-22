namespace BankingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Number = c.String(),
                        Balance = c.Single(nullable: false),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Sum = c.Single(nullable: false),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        CardFrom_Id = c.Guid(),
                        CardTo_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cards", t => t.CardFrom_Id)
                .ForeignKey("dbo.Cards", t => t.CardTo_Id)
                .Index(t => t.CardFrom_Id)
                .Index(t => t.CardTo_Id);
            
            CreateTable(
                "dbo.RoleUsers",
                c => new
                    {
                        Role_Id = c.Guid(nullable: false),
                        User_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_Id, t.User_Id })
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Role_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "CardTo_Id", "dbo.Cards");
            DropForeignKey("dbo.Transactions", "CardFrom_Id", "dbo.Cards");
            DropForeignKey("dbo.Cards", "User_Id", "dbo.Users");
            DropForeignKey("dbo.RoleUsers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.RoleUsers", "Role_Id", "dbo.Roles");
            DropIndex("dbo.RoleUsers", new[] { "User_Id" });
            DropIndex("dbo.RoleUsers", new[] { "Role_Id" });
            DropIndex("dbo.Transactions", new[] { "CardTo_Id" });
            DropIndex("dbo.Transactions", new[] { "CardFrom_Id" });
            DropIndex("dbo.Cards", new[] { "User_Id" });
            DropTable("dbo.RoleUsers");
            DropTable("dbo.Transactions");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Cards");
        }
    }
}
