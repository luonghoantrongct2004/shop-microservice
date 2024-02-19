﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shop.Services.ProductAPI.Models
{
    [Table("ProductVideo")]
    public class ProductVideo
    {
        [Key]
        public int VideoId { get; set; }
        public int ProductId { get; set; }
        public string VideoUrl { get; set; }
        public string? VideoLocalPath { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Product Product { get; set; }

    }
}
