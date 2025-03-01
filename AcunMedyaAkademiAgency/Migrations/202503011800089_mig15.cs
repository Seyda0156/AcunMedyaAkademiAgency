namespace AcunMedyaAkademiAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig15 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Notifications", "ImgUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Notifications", "ImgUrl", c => c.String());
        }
    }
}
