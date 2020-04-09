using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MIS4200_Team11B.Models
{
    public class Recognitions
    {
        [Key]
        public int recognitionID { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is Required")]
        [StringLength(200)]
        public string description { get; set; }


        [Display(Name = "Date of Recognition")]
        [Required(ErrorMessage = "Date is Required")]
        [DataType(DataType.Date)]
        public DateTime dateOfRecognition { get; set; }


        [Display(Name = "Employee")]
        public Guid ID { get; set; }
        public virtual UserDetails UserDetails { get; set; }

        
    }
}
