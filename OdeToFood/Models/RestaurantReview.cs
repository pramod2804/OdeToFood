﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }        
        public int Rating { get; set; }
        public string Bodu { get; set; }
        public int RestaurantId { get; set; }
    }
}