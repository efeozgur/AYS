namespace AYS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BilgiIslemTalep : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BilgiIslemTalep",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        talepBaslik = c.String(nullable: false, maxLength: 50),
                        talep = c.String(nullable: false),
                        talepTarihi = c.String(nullable: false, maxLength: 10),
                        talepDurumu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BilgiIslemTalep");
        }
    }
}
