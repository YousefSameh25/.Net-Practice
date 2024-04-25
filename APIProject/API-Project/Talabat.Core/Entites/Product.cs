namespace Talabat.Core.Entites
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }


        public int ProductBrandId { get; set; } // FK
        public ProductBrand ProductBrand { get; set; }


        public int ProductTypeId { get; set; } // FK
        public ProductType ProductType { get; set; }

    }
}
