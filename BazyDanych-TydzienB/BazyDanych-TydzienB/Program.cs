using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazyDanych_TydzienB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ProdContext())
            {
                //Console.Write("Write a name of a category: ");
                //string name = Console.ReadLine();
                //AddCategory(name, db);
                //ShowAllCategoriesQuery(db);
                //ShowAllCategoriesMethod(db);

                var entity = db.Products.Find(1);
                db.Entry(entity).Property("UnitsInStock").CurrentValue = 10;
                entity = db.Products.Find(2);
                db.Entry(entity).Property("UnitsInStock").CurrentValue = 2;
                entity = db.Products.Find(3);
                db.Entry(entity).Property("UnitsInStock").CurrentValue = 5;
                db.SaveChanges();

                ShowAllCategoriesAndProducts showAll = new ShowAllCategoriesAndProducts(db);
                showAll.ShowAllCategoriesAndProductsEagerLoading();


                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();

                var categoryForm = new CategoryForm();
                categoryForm.ShowDialog();
            }
        }

        static void AddCategory(string name, ProdContext context)
        {
            var category = new Category { Name = name };
            context.Categories.Add(category);
            context.SaveChanges();
        }

        static void ShowAllCategoriesMethod(ProdContext context)
        {
            var queryDeferred = context.Categories.Select(c => c.Name);
            var queryImmediate = context.Categories.Select(c => c.Name).ToList();

            Console.WriteLine("Categories: Names: ");
            foreach (var item in queryImmediate)
            {
                Console.WriteLine(item);
            }
        }

        static void ShowAllCategoriesQuery(ProdContext context)
        {
            var query = from c in context.Categories
                        orderby c.Name descending
                        select c.Name;

            Console.WriteLine("Categories: Names: ");
            foreach(var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
