using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name="Urun Id")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name="Urun Adi")]
        public string? Name { get; set; }

        [Required]
        [Range(0,1000000)]
        [Display(Name="Urun Fiyat")]
        public decimal? Price { get; set; }

        [Display(Name="Urun Resim")]
        public string? Image { get; set; }

        [Required]
        [Display(Name="Aktif Mi")]
        public bool IsActive { get; set; }

        [Required]
        [Display(Name="Urun Kategorisi")]
        public int? CategoryId { get; set; }
        
    }
}