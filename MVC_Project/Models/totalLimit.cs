using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    [Table("tbl_TotalLimit")]
    public class totalLimit
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Must be Set total Limit")]
        public long Total_Limit { get; set; }
    }
}