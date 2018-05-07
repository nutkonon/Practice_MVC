﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example_MVC.Models
{
    public class ItemModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        //Add Navigation Property
        public List<BuyersCommentsModel> Comments { get; set; }
    }

}