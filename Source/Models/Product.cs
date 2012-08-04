using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebStoreSln.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public string ThumbUrl { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
