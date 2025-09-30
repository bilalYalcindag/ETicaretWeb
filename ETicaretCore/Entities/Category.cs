

using System.ComponentModel.DataAnnotations;

namespace ETicaretCore.Entities
{
   public class Category : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Kategori Adı")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        [Display(Name = "Aktif Mi?")]
        public bool IsActive { get; set; }
        [Display(Name = "Oluşturulma Tarihi"), ScaffoldColumn(false)]

        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Display(Name = "Üst Menude Goster")]
        public bool IsTopMenu { get; set; }
        public int ParentId { get; set; }
        public int OrderNo { get; set; }
        public IList<Product>? Products { get; set; }

    }
}
