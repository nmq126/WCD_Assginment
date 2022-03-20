﻿namespace AssignmentWCD.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Thumbnail { get; set; }
        public double Price { get; set; }
        public virtual Category Category { get; set; }
    }
}