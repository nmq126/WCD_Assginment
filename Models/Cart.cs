using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssignmentWCD.Models
{
    public class Cart
    {
        public double TotalPrice { get; set; }
        public Dictionary<int, CartItem> ListItem { get; set; }
        public Cart()
        {
            ListItem = new Dictionary<int, CartItem>();
        }
    }
}