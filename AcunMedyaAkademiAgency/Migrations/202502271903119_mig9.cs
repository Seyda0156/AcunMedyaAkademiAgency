namespace AcunMedyaAkademiAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        icon = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.ClientId);
            
            AddColumn("dbo.SocialMedias", "Url", c => c.String());
            DropColumn("dbo.SocialMedias", "ImgUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SocialMedias", "ImgUrl", c => c.String());
            DropColumn("dbo.SocialMedias", "Url");
            DropTable("dbo.Clients");
        }
    }
}
