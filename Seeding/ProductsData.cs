namespace ASP.NET_MVC_Core_WebApp.Seeding;
using ViewModels.Product;

public static class ProductsData
{
    public static IEnumerable<ProductViewModel> Products = new List<ProductViewModel>()
    {
        new ProductViewModel()
        {
            Id = Guid.NewGuid(),
            Name = "Cheese",
            Price = 7.00
        },

        new ProductViewModel()
        {
            Id = Guid.NewGuid(),
            Name = "Ham",
            Price = 5.50
        },

        new ProductViewModel()
        {
            Id = Guid.NewGuid(),
            Name = "Bread",
            Price = 1.50
        }
        
    };
}
