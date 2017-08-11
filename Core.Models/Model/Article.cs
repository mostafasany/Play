using GalaSoft.MvvmLight;

namespace Core.Models.Model
{
    public class Article : ViewModelBase
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    }
}
