using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OVERAS.Models
{
    public class customert
    {

        [Key]
        [Display(Name = "customer ID")]
        public int cid { get; set; }
        [Display(Name = "first name ")]
        public string fname { get; set; }
        [Display(Name = "mname ")]
        public string mname { get; set; }
        [Display(Name = "Last name ")]
        public string lname { get; set; }
        [Display(Name = "currentaddress ")]
        public string currentaddress { get; set; }
        [Display(Name = "ffname ")]
        public string ffname { get; set; }
        [Display(Name = "mmname ")]
        public string mmname { get; set; }
        [Display(Name = "llname ")]
        public string llname { get; set; }
     
    }
   
}


/*
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace OVERS.Models
{
    public class Customer
    {
         [Key]
        [Display(Name ="Customer ID")]
        public int cid { get; set; }
        [Display(Name ="First Name")]
        public string fname { get; set; }
        [Display(Name = "Last Name")]
        public string lname { get; set; }
        [Display(Name = "Current Address")]
        public string currentaddress { get; set; }
        [Display(Name = "Country")]
        public string country { get; set; }

    }
}
*/