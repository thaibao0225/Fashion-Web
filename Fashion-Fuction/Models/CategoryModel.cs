using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Fuction.Models
{
    public class CategoryModel
    {
        public string category_Id { get; set; } = string.Empty;

        [DisplayName("Name")]
        public string category_Name { get; set; } = string.Empty;

        [DisplayName("Description")]
        public string category_Description { get; set; } = string.Empty;
        public int category_NumberOfProduct { get; set; } = 0;
    }
}
