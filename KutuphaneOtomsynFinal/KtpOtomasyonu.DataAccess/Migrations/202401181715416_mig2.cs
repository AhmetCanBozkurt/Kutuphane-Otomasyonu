﻿namespace KtpOtomasyonu.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Uyeler", "UyeSoyad", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Uyeler", "UyeSoyad", c => c.String());
        }
    }
}
