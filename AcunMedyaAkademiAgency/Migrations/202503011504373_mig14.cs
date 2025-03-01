namespace AcunMedyaAkademiAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig14 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Features", "ImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Features", "ImageUrl", c => c.String());
        }
    }
}
