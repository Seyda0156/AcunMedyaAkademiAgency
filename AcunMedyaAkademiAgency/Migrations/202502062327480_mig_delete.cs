namespace AcunMedyaAkademiAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_delete : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Teams", "Job");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "Job", c => c.String());
        }
    }
}
