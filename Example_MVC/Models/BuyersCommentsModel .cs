using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example_MVC.Models
{
    public class BuyersCommentsModel
    {
        public int BuyersID { get; set; }
        public string BuyersName { get; set; }
        public string StarRating { get; set; }
        public string CommentsTitle { get; set; }
        public string Comments { get; set; }
        public DateTime Date { get; set; }
    }
}