using FrontToBackIntroTask.Models.Base;

namespace FrontToBackIntroTask.Models
{
    public class Image : BaseEntity
    {
        public string Url { get; set; }
        public bool IsPrimary { get; set; } = false;
        public Product Product { get; set; }

    }
}
