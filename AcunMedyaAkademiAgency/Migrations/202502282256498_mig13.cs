namespace AcunMedyaAkademiAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig13 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Abouts", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "DateTime", c => c.DateTime(nullable: false));
        }
    }
}
