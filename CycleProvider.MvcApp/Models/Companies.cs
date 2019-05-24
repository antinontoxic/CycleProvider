using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CycleProvider.MvcApp.Models
{
    public class Companies
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage ="Company without name cannot exist"), StringLength(25)]
        public string Name { get; set; }
        public string Description { get; set; }
        [DisplayName("Year of creation")]
        public int CreationYear { get; set; }
    }
}