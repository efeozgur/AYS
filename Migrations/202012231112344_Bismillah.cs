namespace AYS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bismillah : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        adSoyad = c.String(nullable: false, maxLength: 100),
                        sicilNo = c.String(nullable: false, maxLength: 8),
                        cepTelefonu = c.String(nullable: false, maxLength: 11),
                        dahiliNo1 = c.String(maxLength: 5),
                        dahiliNo2 = c.String(maxLength: 5),
                        durumu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Talep",
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
            DropTable("dbo.Talep");
            DropTable("dbo.Personel");
        }
    }
}
