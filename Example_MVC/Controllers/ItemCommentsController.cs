using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Example_MVC.Models;
using System.Dynamic;

namespace Example_MVC.Controllers
{
    public class ItemCommentsController : Controller
    {
        // GET: ItemComments
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ItemModel GetItemDetails()
        {
            ItemModel iModel = new ItemModel()
            {
                ID = 1,
                Name = "HP Printer",
                Category = "ComputerParts",
                Price = 8840,
                Comments = GetCommentList()
            };
            return iModel;
        }

        public List<BuyersCommentsModel> GetCommentList()
        {
            List<BuyersCommentsModel> CommentsList = new List<BuyersCommentsModel>();
            CommentsList.Add(new BuyersCommentsModel() { BuyersID = 1, BuyersName = "John", StarRating = "4", CommentsTitle = "Nice Product", Comments = "I Purchased it 1 week ago and it is working fine.", Date = Convert.ToDateTime("27 August 17") });
            CommentsList.Add(new BuyersCommentsModel() { BuyersID = 2, BuyersName = "Nicki", StarRating = "2", CommentsTitle = "Worst Product", Comments = "Worst Product. Don't Buy It. I got damaged one.", Date = Convert.ToDateTime("12 June 17") });
            CommentsList.Add(new BuyersCommentsModel() { BuyersID = 3, BuyersName = "Serena", StarRating = "3.5", CommentsTitle = "Satisfactory", Comments = "Go for it. It does the same job and have the less price", Date = Convert.ToDateTime("18 March 17") });
            CommentsList.Add(new BuyersCommentsModel() { BuyersID = 4, BuyersName = "William", StarRating = "4.5", CommentsTitle = "Superrr!!!", Comments = "Don't think and buy it with confidence.", Date = Convert.ToDateTime("11 November 16") });

            return CommentsList;
        }

        public ActionResult ItemCommentDisplay()
        {
            ItemModel item = GetItemDetails();
            return View(item);
        }

    }
}