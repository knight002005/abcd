using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace abvfdv.Models
{
    [Table("hoadons")]
    public class hoadon
    {
        [Key]
        public int ma_hd { get; set; }

        public int ma_kh { get; set; }

        public int tong_tien { get; set; }

        public int trang_thai { get; set; }

        public string ghi_chu { get; set; }

        public DateTime ngay_tao { get; set; }
    }
}