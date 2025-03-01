namespace AcunMedyaAkademiAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProjectDetails", "ProjectDetail_ProjectDetailId", "dbo.ProjectDetails");
            DropIndex("dbo.ProjectDetails", new[] { "ProjectDetail_ProjectDetailId" });
            DropColumn("dbo.ProjectDetails", "ProjectDetail_ProjectDetailId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProjectDetails", "ProjectDetail_ProjectDetailId", c => c.Int());
            CreateIndex("dbo.ProjectDetails", "ProjectDetail_ProjectDetailId");
            AddForeignKey("dbo.ProjectDetails", "ProjectDetail_ProjectDetailId", "dbo.ProjectDetails", "ProjectDetailId");
        }
    }
}
