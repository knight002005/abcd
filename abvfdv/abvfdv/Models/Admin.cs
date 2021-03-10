using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace abvfdv.Models
{
    public class Admin
    {
        [Key]
        public int id_Khach { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string UserName { get; set; }

        public string ComfirmPassWord { get; set; }
    }
}