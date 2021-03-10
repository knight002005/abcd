using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace abvfdv.Models
{
    [Table("nhacungcaps")]
    public class nhacungcap
    {
        [Key]
        public int ma_nha_cung_cap { get; set; }

        public string ten_nha_cung_cap { get; set; }

        public string dia_chi { get; set; }
    }
}