namespace abvfdv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.gias",
                c => new
                    {
                        ma_gia = c.Int(nullable: false, identity: true),
                        gia_goc = c.Int(nullable: false),
                        gia_khuyen_mai = c.Int(nullable: false),
                        ngay_ap_dung = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ma_gia);
            
            CreateTable(
                "dbo.hoadons",
                c => new
                    {
                        ma_hd = c.Int(nullable: false, identity: true),
                        ma_kh = c.Int(nullable: false),
                        tong_tien = c.Int(nullable: false),
                        trang_thai = c.Int(nullable: false),
                        ghi_chu = c.String(),
                        ngay_tao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ma_hd);
            
            CreateTable(
                "dbo.khachhangs",
                c => new
                    {
                        ma_khach_hang = c.Int(nullable: false, identity: true),
                        email = c.String(nullable: false),
                        password = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        ComfirmPassWord = c.String(),
                    })
                .PrimaryKey(t => t.ma_khach_hang);
            
            CreateTable(
                "dbo.sanphams",
                c => new
                    {
                        ma_sp = c.Int(nullable: false, identity: true),
                        ten_sp = c.String(),
                        ma_gia = c.Int(nullable: false),
                        ma_ncc = c.Int(nullable: false),
                        ma_danh_muc = c.Int(nullable: false),
                        trang_thai = c.Boolean(nullable: false),
                        ghi_chu = c.String(),
                        xuat_xu = c.String(),
                        mo_ta = c.String(),
                        hinh_anh = c.String(),
                    })
                .PrimaryKey(t => t.ma_sp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.sanphams");
            DropTable("dbo.khachhangs");
            DropTable("dbo.hoadons");
            DropTable("dbo.gias");
        }
    }
}
