using FrontToBackIntroTask.Models.Base;

namespace FrontToBackIntroTask.Models
{
    public class Tag:BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
