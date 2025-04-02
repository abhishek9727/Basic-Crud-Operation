﻿using Dal_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ProductModel
    {
        public int id { get; set; }

        public string Name { get; set; }

        public decimal? price { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public int? CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
