

using System.ComponentModel.DataAnnotations;

namespace ETicaretCore.Entities
{
   public class News : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Haber Başlığı")]
        public string Name { get; set; }
        [Display(Name = "Haber Açıklaması")]
        public string Description { get; set; }
        [Display(Name = "Haber Resmi")]
        public string? ImageUrl { get; set; }
        [Display(Name = "Oluşturulma Tarihi"), ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Display(Name = "Aktif Mi?")]
        public bool IsActive { get; set; } = true;
    }
    

 }

