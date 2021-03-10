namespace abvfdv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        id_Khach = c.Int(nullable: false, identity: true),
                        email = c.String(nullable: false),
                        password = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        ComfirmPassWord = c.String(),
                    })
                .PrimaryKey(t => t.id_Khach);
            
            CreateTable(
                "dbo.danhmucs",
                c => new
                    {
                        ma_danh_muc = c.Int(nullable: false, identity: true),
                        ten_danh_muc = c.String(),
                    })
                .PrimaryKey(t => t.ma_danh_muc);
            
            CreateTable(
                "dbo.nhacungcaps",
                c => new
                    {
                        ma_nha_cung_cap = c.Int(nullable: false, identity: true),
                        ten_nha_cung_cap = c.String(),
                        dia_chi = c.String(),
                    })
                .PrimaryKey(t => t.ma_nha_cung_cap);
            
            AddColumn("dbo.khachhangs", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.khachhangs", "LastName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.khachhangs", "LastName");
            DropColumn("dbo.khachhangs", "FirstName");
            DropTable("dbo.nhacungcaps");
            DropTable("dbo.danhmucs");
            DropTable("dbo.Admins");
        }
    }
}
