

namespace ETicaretCore.Entities
{
   public class News : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreateDate { get; set; } 
        public bool IsActive { get; set; } = true;
    }
    

 }

