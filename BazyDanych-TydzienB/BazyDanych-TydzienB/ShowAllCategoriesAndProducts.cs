using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazyDanych_TydzienB
{
    public class ShowAllCategoriesAndProducts
    {
        private ProdContext context;
        public ShowAllCategoriesAndProducts(ProdContext context)
        {
            this.context = context;
        }
        public void ShowAllCategoriesAndProductsJoin()
        {
            DbSet<Category> categories = this.context.Categories;
            DbSet<Product> products = this.context.Products;

            var queryJoin = from c in categories
                            join p in products
                            on c.CategoryId equals p.ProductId into categoryGroup
                            select new
                            {
                                CategoryName = c.Name,
                                ProductsCount = categoryGroup.Count(),
                                Products = categoryGroup
                            };

            var methodJoin = categories.GroupJoin(products, cat => cat.CategoryId, prod => prod.CategoryId,
                             (category, categoryGroup) => new
                             {
                                 CategoryName = category.Name,
                                 ProductsCount = categoryGroup.Count(),
                                 Products = categoryGroup
                             });

            foreach (var group in methodJoin)
            {
                Console.WriteLine($"CategoryName: {group.CategoryName}");
                Console.WriteLine($"PostsCount: {group.ProductsCount}");
                foreach (var product in group.Products)
                {
                    Console.WriteLine($"    ProductName: {product.Name}");
                    Console.WriteLine($"    ProductUnitsInStock: {product.UnitsInStock}");
                    Console.WriteLine($"    ProductUnitPrice: {product.UnitPrice}");
                }
                Console.WriteLine("");
            }
        }

        public void ShowAllCategoriesAndProductsNavigationProperties()
        {
            DbSet<Category> categories = this.context.Categories;

            var queryNP = from c in categories
                        select new
                        {
                            CategoryName = c.Name,
                            ProductsCount = c.Products.Count(),
                            Products = c.Products
                        };

            foreach (var group in queryNP)
            {
                Console.WriteLine($"CategoryName: {group.CategoryName}");
                Console.WriteLine($"PostsCount: {group.ProductsCount}");
                foreach (var product in group.Products)
                {
                    Console.WriteLine($"    ProductName: {product.Name}");
                    Console.WriteLine($"    ProductUnitsInStock: {product.UnitsInStock}");
                    Console.WriteLine($"    ProductUnitPrice: {product.UnitPrice}");
                }
                Console.WriteLine("");
            }
        }

        public void ShowAllCategoriesAndProductsLazyLoading()
        {
            foreach (var category in this.context.Categories)
            {
                int counter = this.context.Entry(category).Collection(c => c.Products).Query().Count();
                this.context.Entry(category).Collection(c => c.Products).Load();
            }
        }

        public void ShowAllCategoriesAndProductsEagerLoading()
        {
            DbSet<Category> categories = this.context.Categories;
            DbSet<Product> products = this.context.Products;

            var query = categories.Include(p => p.Products).ToList();

            foreach (var group in query)
            {
                Console.WriteLine($"CategoryName: {group.Name}");
                Console.WriteLine($"PostsCount: {group.Products.Count()}");
                foreach (var product in group.Products)
                {
                    Console.WriteLine($"    ProductName: {product.Name}");
                    Console.WriteLine($"    ProductUnitsInStock: {product.UnitsInStock}");
                    Console.WriteLine($"    ProductUnitPrice: {product.UnitPrice}");
                }
                Console.WriteLine("");
            }
        }
    }
}
