namespace Example_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("ItemList")]
    public partial class ItemList
    {   
        public int ID { get; set; }

        [StringLength(50)]
        [Remote("RemoteValidation", "ItemEF", ErrorMessage = "Name Already Exist. Please choose another Name.")]
        public string Name { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        public decimal? Price { get; set; }
    }
}
