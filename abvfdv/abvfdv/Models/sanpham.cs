using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace abvfdv.Models
{
    [Table("sanphams")]
    public class sanpham
    {
        [Key]
        public int ma_sp { get; set; }

        public string ten_sp { get; set; }

        public int ma_gia { get; set; }

        public int ma_ncc { get; set; }

        public int ma_danh_muc { get; set; }

        public bool trang_thai { get; set; }

        public string ghi_chu { get; set; }

        public string xuat_xu { get; set; }

        public string mo_ta { get; set; }

        public string hinh_anh { get; set; }
    }
}