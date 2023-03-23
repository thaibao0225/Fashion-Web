using Fashion_Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Fuction.Models
{
    public class ProductModel
    {
        [Key]
        public string product_Id { get; set; } = string.Empty;

        [DisplayName("Name")]
        public string product_Name { get; set; } = string.Empty;

        [DisplayName("Img1")]
        public string product_Img1 { get; set; } = string.Empty;
        public IFormFile product_ImgFile1 { get; set; }

        [DisplayName("Img2")]
        public string product_Img2 { get; set; } = string.Empty;
        public IFormFile? product_ImgFile2 { get; set; }

        [DisplayName("Img3")]
        public string product_Img3 { get; set; } = string.Empty;
        public IFormFile? product_ImgFile3 { get; set; }

        [DisplayName("Img4")]
        public string product_Img4 { get; set; } = string.Empty;
        public IFormFile? product_ImgFile4 { get; set; }

        [DisplayName("Img5")]
        public string product_Img5 { get; set; } = string.Empty;
        public IFormFile? product_ImgFile5 { get; set; }

        [DisplayName("Description")]
        public string product_Description { get; set; } = string.Empty;

        [DisplayName("ShortDescription")]
        public string product_ShortDescription { get; set; } = string.Empty;

        [DisplayName("Price")]
        public double product_Price { get; set; } = 0;

        [DisplayName("Type")]
        public string product_Type { get; set; } = string.Empty;

        [DisplayName("Sold")]
        public int? product_Sold { get; set; } = 0;

        [DisplayName("Rate")]
        public int? product_Rate { get; set; } = 0;

        [DisplayName("ViewNumber")]
        public int? product_ViewNumber { get; set; }

        [DisplayName("CategoryId")]
        public string product_CategoryId { get; set; } = string.Empty;

        [DisplayName("CategoryName")]
        public string product_CategoryName { get; set; } = string.Empty;
        //public CategoriesTable product_CategoriesTable { get; set; }
        //public List<ColorInProductTable> product_colorInProductTablesList { get; set; }
        //public List<SizeInProductTable> product_sizeInProductTablesList { get; set; }
        //public List<CommentTable> product_CommentTableList { get; set; }

        [DisplayName("Color")]
        public string product_ColorName { get; set; } = string.Empty;
        [DisplayName("Size")]
        public string product_SizeName { get; set; } = string.Empty;
        [DisplayName("Quantity")]
        public string product_Quantity { get; set; } = string.Empty;
    }
}
