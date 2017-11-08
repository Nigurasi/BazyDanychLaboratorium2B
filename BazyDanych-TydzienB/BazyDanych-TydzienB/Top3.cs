using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazyDanych_TydzienB
{
    public partial class Top3 : Form
    {
        public Top3(IQueryable<Category> query, string Title)
        {
            InitializeComponent();
            Info.Text = Title;
            top3Stats.Text = "";
            int i = 1;
            if(Title == "Most Products Categories")
            {
                foreach (var item in query)
                {
                    top3Stats.Text += $"{i}. CategoryName: {item.Name}\n    NumberOfProducts: {item.Products.Count}\n\n";
                    i++;
                }
            } else if (Title == "Cheapest Product Categories")
            {
                foreach (var item in query)
                {
                    decimal cheapest;
                    string productName;
                    if(item.Products.Count == 0)
                    {
                        cheapest = 0;
                        productName = "None";

                    } else
                    {
                        cheapest = item.Products.Min(p => p.UnitPrice);
                        productName = item.Products.Find(p => p.UnitPrice == cheapest).Name;
                    }

                    top3Stats.Text += $"{i}. CategoryName: {item.Name}\n";
                    top3Stats.Text += $"    CheapestProduct: {productName}\n";
                    top3Stats.Text += $"        Price: {cheapest}\n\n";
                    i++;
                }
            }
        }

        private void top3Stats_Click(object sender, EventArgs e)
        {

        }
    }
}
