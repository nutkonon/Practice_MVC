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

        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50)]
        [Remote("RemoteValidation", "ItemEF", ErrorMessage = "Name Already Exist. Please choose another Name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Category is Required")]
        [StringLength(50)]
        public string Category { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        public decimal? Price { get; set; }
    }
}
