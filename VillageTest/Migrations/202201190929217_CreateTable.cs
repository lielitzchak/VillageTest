namespace VillageTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Residents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FathersName = c.String(),
                        Gender = c.Int(nullable: false),
                        IsBornInVillage = c.Boolean(nullable: false),
                        BirthDay = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }

        
        public override void Down()
        {
            DropTable("dbo.Residents");
        }
    }
}
