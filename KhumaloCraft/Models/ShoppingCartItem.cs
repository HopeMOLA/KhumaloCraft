﻿using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCartItemId { get; set; }
        public int ShoppingCartId { get; set; } // Foreign key to identify the shopping cart
        public ShoppingCart ShoppingCart { get; set; } // Navigation property
        public int ProductId { get; set; } // Foreign key to identify the product
        public Product Product { get; set; } // Navigation property
        public int Quantity { get; set; }

    }
}