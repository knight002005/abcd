using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace abvfdv.Models
{
    [Table("danhmucs")]
    public class danhmuc
    {
        [Key]
        public int ma_danh_muc { get; set; }

        public string ten_danh_muc { get; set; }
    }
}