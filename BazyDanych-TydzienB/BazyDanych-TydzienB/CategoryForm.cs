using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazyDanych_TydzienB
{
    public partial class CategoryForm : Form
    {
        ProdContext pContext = new ProdContext();

        public CategoryForm()
        {
            InitializeComponent();
            Info.Text = "To buy products you have to select\ninteresting product and add to basket.";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int foundCategoryId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var query = from prod in pContext.Products
                        where prod.CategoryId == foundCategoryId
                        select prod;

            var queryMethod = pContext.Products.Where(p => p.CategoryId == foundCategoryId);
            this.productsBindingSource.DataSource = queryMethod.ToList();

            this.dataGridView2.Refresh();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this._BazyDanych_TydzienB_ProdContextDataSet1.Products);
            this.categoriesTableAdapter.Fill(this._BazyDanych_TydzienB_ProdContextDataSet.Categories);

            pContext.Categories.Load();
            pContext.Products.Load();

            this.categoriesBindingSource.DataSource = pContext.Categories.Local.ToBindingList();
            this.productsBindingSource.DataSource = pContext.Categories.Local.ToBindingList();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            pContext.SaveChanges();
            pContext.Categories.Load();
            this.dataGridView1.Refresh();

            pContext.Products.Load();
            this.dataGridView2.Refresh();
        }

        private void AddToBasket_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                string productName, productID;
                decimal productPrice, currentPrice;
                int productUnits;

                for(int i = 0; i < dataGridView2.SelectedRows.Count; i++)
                {
                    productName = dataGridView2.SelectedRows[i].Cells[1].Value.ToString();
                    productID = dataGridView2.SelectedRows[i].Cells[0].Value.ToString();
                    productUnits = Convert.ToInt32(dataGridView2.SelectedRows[i].Cells[2].Value);

                    if (productUnits == 0)
                    {
                        Debug.WriteLine($"{productName}: No units in stock.");
                        continue;
                    }
                    productPrice = Convert.ToDecimal(dataGridView2.SelectedRows[i].Cells[4].Value);

                    basket.Items.Add($"{productID} {productName}");
                    currentPrice = Convert.ToDecimal(price.Text.ToString()) + productPrice;
                    price.Text = currentPrice.ToString();

                    productUnits--;
                    var entity = pContext.Products.Find(Convert.ToInt32(productID));
                    pContext.Entry(entity).Property("UnitsInStock").CurrentValue = productUnits;
                    pContext.SaveChanges();
                    pContext.Products.Load();
                    this.dataGridView2.Refresh();
                }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string product;
            int productID;
            decimal currentPrice;
            if(basket.SelectedIndex != -1)
            {
                for(int i = 0; i < basket.SelectedItems.Count; i++)
                {
                    product = basket.SelectedItem.ToString();
                    productID = Convert.ToInt32(product.Split(' ')[0]);
                    basket.Items.Remove(basket.SelectedItems[i]);

                    var method = from p in pContext.Products
                                      where p.ProductId == productID
                                      select p;

                    foreach(var item in method)
                    {
                        currentPrice = Convert.ToDecimal(price.Text.ToString()) - item.UnitPrice;
                        price.Text = currentPrice.ToString();

                        var entity = pContext.Products.Find(Convert.ToInt32(productID));
                        pContext.Entry(entity).Property("UnitsInStock").CurrentValue = item.UnitsInStock+1;
                    }

                    pContext.SaveChanges();
                    pContext.Products.Load();
                    this.dataGridView2.Refresh();

                }
            }
        }

        private void buy_Click(object sender, EventArgs e)
        {
            List<String> boughtItems = new List<string>();
            decimal thePrice;

            if (CompanyName.Text.Equals("CompanyName") || CompanyName.Text.Equals(""))
            {
                CompanyName.Text = "Enter the Company Name.";
                return;
            }

            string companyName = CompanyName.Text;
            CompanyName.Text = "";
            CustomersHistory ch;

            var company = from c in pContext.Customers
                          where c.CompanyName == companyName
                          select c.CompanyName;

            if(company.Count() == 0)
            {
                Customer c = new Customer { CompanyName = companyName };
                pContext.Customers.Add(c);
                pContext.SaveChanges();
            }

            for (int i = 0; i < basket.Items.Count; i++)
            {
                boughtItems.Add(basket.Items[i].ToString());
                ch = new CustomersHistory { CompanyName = companyName,
                    BoughtProductID = Convert.ToInt32(basket.Items[i].ToString().Split(' ')[0]),
                    BoughtDate = DateTime.Now
                };
                pContext.CustomersHistories.Add(ch);
            }
            pContext.SaveChanges();

            while(basket.Items.Count > 0)
            {
                basket.Items.Remove(basket.Items[0]);
            }

            thePrice = Convert.ToDecimal(price.Text);
            price.Text = "0";
            var summary = new Summary(boughtItems, thePrice);
            summary.ShowDialog();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string topic = filterBox.Text;

            var categories = pContext.Categories.Include(c => c.Products).
                Where(c => c.Name.IndexOf(topic) >= 0).OrderByDescending(c => c.Products.Count);

            var products = pContext.Products
                .Where(c => c.Name.IndexOf(topic) >= 0);

            if (orderByName.Checked && !OrderByPrize.Checked)
            {
                products = products.OrderBy(p => p.Name);

            } else if (!orderByName.Checked && OrderByPrize.Checked)
            {
                products = products.OrderByDescending(p => p.UnitPrice)
                                   .OrderByDescending(p => p.UnitsInStock);
            } else
            {
                label2.Text = "Choose one order!";
                return;
            }

            label2.Text = $"Found Products: {products.Count()}\n";
            label2.Text += $"Found Categories: {categories.Count()}\n";

            foreach (var item in categories)
            {
                label2.Text += $"CategoryName: {item.Name}, CategoryID: {item.CategoryId}";
                label2.Text += "\n";
            }

            this.productsBindingSource.DataSource = products.ToList();
            this.dataGridView2.Refresh();
        }

        private void Top3Most_Click(object sender, EventArgs e)
        {
            var query = from c in pContext.Categories
                        orderby c.Products.Count descending
                        select c;

            var top3query = query.Take(3);

            var top3Form = new Top3(top3query, "Most Products Categories");
            top3Form.ShowDialog();
        }

        private void Top3Cheapest_Click(object sender, EventArgs e)
        {
            var query = from c in pContext.Categories
                        orderby c.Products.Min(p => p.UnitPrice)
                        select c;

            var top3query = query.Take(3);

            var top3Form = new Top3(top3query, "Cheapest Product Categories");
            top3Form.ShowDialog();

        }
    }
}
