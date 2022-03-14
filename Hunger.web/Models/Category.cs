using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Hunger.web.Models
{
    [Table("Category")]
    public class Category

    {
        public int Id { get; set; }

        [Display(Name = "Product Type")]
        [Required]
        public string ProductTypes { get; set; }


        //public Product Product { get; set; }
    }
}
