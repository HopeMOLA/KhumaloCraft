using KhumaloCraft.Models;

namespace KhumaloCraft.ViewModels
{
    public class ProductSearchViewModel
    {
        public string SearchTerm { get; set; }
        public List<Product> Results { get; set; }
    }
}
