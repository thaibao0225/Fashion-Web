﻿using Fashion_Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Fuction.Models
{
    public class ProductModel
    {
        public string product_Id { get; set; } = string.Empty;
        public string product_Name { get; set; } = string.Empty;
        public string product_Img1 { get; set; } = string.Empty;
        public string product_Img2 { get; set; } = string.Empty;
        public string product_Img3 { get; set; } = string.Empty;
        public string product_Img4 { get; set; } = string.Empty;
        public string product_Img5 { get; set; } = string.Empty;
        public string product_Description { get; set; } = string.Empty;
        public string product_ShortDescription { get; set; } = string.Empty;
        public double product_Price { get; set; } = 0;
        public string product_Type { get; set; } = string.Empty;
        public int? product_Sold { get; set; } = 0;
        public int? product_Rate { get; set; } = 0;
        public int? product_ViewNumber { get; set; }
        public string product_CategoryId { get; set; } = string.Empty;
        //public CategoriesTable product_CategoriesTable { get; set; }
        public List<ColorInProductTable> product_colorInProductTablesList { get; set; }
        public List<SizeInProductTable> product_sizeInProductTablesList { get; set; }
        public List<CommentTable> product_CommentTableList { get; set; }
    }
}
