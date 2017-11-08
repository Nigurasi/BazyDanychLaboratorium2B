using System;
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
    public partial class Summary : Form
    {
        public Summary(List<string> boughtProducts, decimal myPrice)
        {
            InitializeComponent();

            foreach(var item in boughtProducts)
            {
                BoughtItems.Items.Add(item);
            }

            Price.Text = myPrice.ToString();
        }

        private void BoughtItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
