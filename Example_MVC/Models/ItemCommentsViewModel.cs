using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Example_MVC.Models;

namespace Example_MVC.Models
{
    public class ItemCommentsViewModel
    {
        public ItemModel item { get; set; }
        public List<BuyersCommentsModel> comments { get; set; }
    }
}