using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretCore.Entities
{
   public class Brand : IEntity
    {
        public int Id { get ; set ;}
        [Display(Name = "Marka Adı")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }
        public string? Logo { get; set; }
        [Display(Name = "Aktif Mi?")]
        public bool IsActive { get; set; }
        [Display(Name = "Oluşturulma Tarihi"),ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Display(Name = "Sıra No")]
        public int OrderNo { get; set; }
        public IList<Product>? Products { get; set; }

    }
}
