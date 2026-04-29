using FrontToBackIntroTask.Models.Base;

namespace FrontToBackIntroTask.Models
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Image> Images { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
    }
}
