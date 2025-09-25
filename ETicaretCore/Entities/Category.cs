﻿

namespace ETicaretCore.Entities
{
   public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsTopMenu { get; set; }
        public int ParentId { get; set; }
        public int OrderNo { get; set; }
        public IList<Product>? Products { get; set; }

    }
}
