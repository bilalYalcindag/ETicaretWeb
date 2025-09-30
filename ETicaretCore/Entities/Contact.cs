using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretCore.Entities
{
    public class Contact : IEntity
    {
        public int Id { get ; set ; }
        [Display(Name = "Ad")]
        public string Name { get ; set ; }
        [Display(Name = "Soyad")]
        public string Surname { get; set; }
        public string Email { get; set; }
        [Display(Name = "Telefon Numarası")]
        public string? Phone { get; set; }
        [Display(Name = "Mesaj")]
        public string Message { get; set; }
        [Display(Name = "Oluşturulma Tarihi"), ScaffoldColumn(false)]

        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
