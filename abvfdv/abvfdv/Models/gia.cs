using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace abvfdv.Models
{
    [Table("gias")]
    public class gia
    {
        [Key]
        public int ma_gia { get; set; }

        public int gia_goc { get; set; }

        public int gia_khuyen_mai { get; set; }

        public DateTime ngay_ap_dung { get; set; }

    }
}