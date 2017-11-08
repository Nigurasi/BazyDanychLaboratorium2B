namespace BazyDanych_TydzienB
{
    partial class CategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BazyDanych_TydzienB_ProdContextDataSet = new BazyDanych_TydzienB._BazyDanych_TydzienB_ProdContextDataSet();
            this.categoriesTableAdapter = new BazyDanych_TydzienB._BazyDanych_TydzienB_ProdContextDataSetTableAdapters.CategoriesTableAdapter();
            this.save = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BazyDanych_TydzienB_ProdContextDataSet1 = new BazyDanych_TydzienB._BazyDanych_TydzienB_ProdContextDataSet1();
            this.productsTableAdapter = new BazyDanych_TydzienB._BazyDanych_TydzienB_ProdContextDataSet1TableAdapters.ProductsTableAdapter();
            this.buy = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.basket = new System.Windows.Forms.ListBox();
            this.addToBasket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.top3Most = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.orderByName = new System.Windows.Forms.CheckBox();
            this.OrderByPrize = new System.Windows.Forms.CheckBox();
            this.top3Cheapest = new System.Windows.Forms.Button();
            this.CompanyName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BazyDanych_TydzienB_ProdContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BazyDanych_TydzienB_ProdContextDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoriesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this._BazyDanych_TydzienB_ProdContextDataSet;
            // 
            // _BazyDanych_TydzienB_ProdContextDataSet
            // 
            this._BazyDanych_TydzienB_ProdContextDataSet.DataSetName = "_BazyDanych_TydzienB_ProdContextDataSet";
            this._BazyDanych_TydzienB_ProdContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(3, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(228, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.unitsInStockDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn1,
            this.unitPriceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 246);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(577, 183);
            this.dataGridView2.TabIndex = 2;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // unitsInStockDataGridViewTextBoxColumn
            // 
            this.unitsInStockDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn.HeaderText = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn.Name = "unitsInStockDataGridViewTextBoxColumn";
            // 
            // categoryIdDataGridViewTextBoxColumn1
            // 
            this.categoryIdDataGridViewTextBoxColumn1.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn1.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn1.Name = "categoryIdDataGridViewTextBoxColumn1";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this._BazyDanych_TydzienB_ProdContextDataSet1;
            // 
            // _BazyDanych_TydzienB_ProdContextDataSet1
            // 
            this._BazyDanych_TydzienB_ProdContextDataSet1.DataSetName = "_BazyDanych_TydzienB_ProdContextDataSet1";
            this._BazyDanych_TydzienB_ProdContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // buy
            // 
            this.buy.Location = new System.Drawing.Point(796, 406);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(99, 23);
            this.buy.TabIndex = 3;
            this.buy.Text = "Buy";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Info.Location = new System.Drawing.Point(615, 178);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(44, 18);
            this.Info.TabIndex = 4;
            this.Info.Text = "None";
            // 
            // basket
            // 
            this.basket.FormattingEnabled = true;
            this.basket.Location = new System.Drawing.Point(586, 228);
            this.basket.Name = "basket";
            this.basket.Size = new System.Drawing.Size(309, 147);
            this.basket.TabIndex = 6;
            // 
            // addToBasket
            // 
            this.addToBasket.Location = new System.Drawing.Point(586, 406);
            this.addToBasket.Name = "addToBasket";
            this.addToBasket.Size = new System.Drawing.Size(99, 23);
            this.addToBasket.TabIndex = 7;
            this.addToBasket.Text = "Add to basket";
            this.addToBasket.UseVisualStyleBackColor = true;
            this.addToBasket.Click += new System.EventHandler(this.AddToBasket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(583, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Price:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.price.Location = new System.Drawing.Point(635, 380);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(16, 18);
            this.price.TabIndex = 9;
            this.price.Text = "0";
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(691, 406);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(99, 23);
            this.remove.TabIndex = 10;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(678, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Search for Products";
            // 
            // filterBox
            // 
            this.filterBox.Location = new System.Drawing.Point(598, 31);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(288, 20);
            this.filterBox.TabIndex = 13;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(598, 85);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(288, 23);
            this.search.TabIndex = 14;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // top3Most
            // 
            this.top3Most.Location = new System.Drawing.Point(3, 31);
            this.top3Most.Name = "top3Most";
            this.top3Most.Size = new System.Drawing.Size(228, 23);
            this.top3Most.TabIndex = 15;
            this.top3Most.Text = "Show Top 3 Most Products Categories";
            this.top3Most.UseVisualStyleBackColor = true;
            this.top3Most.Click += new System.EventHandler(this.Top3Most_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(586, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "None";
            // 
            // orderByName
            // 
            this.orderByName.AutoSize = true;
            this.orderByName.Location = new System.Drawing.Point(598, 62);
            this.orderByName.Name = "orderByName";
            this.orderByName.Size = new System.Drawing.Size(97, 17);
            this.orderByName.TabIndex = 19;
            this.orderByName.Text = "Order by Name";
            this.orderByName.UseVisualStyleBackColor = true;
            // 
            // OrderByPrize
            // 
            this.OrderByPrize.AutoSize = true;
            this.OrderByPrize.Location = new System.Drawing.Point(701, 62);
            this.OrderByPrize.Name = "OrderByPrize";
            this.OrderByPrize.Size = new System.Drawing.Size(92, 17);
            this.OrderByPrize.TabIndex = 20;
            this.OrderByPrize.Text = "Order by Prize";
            this.OrderByPrize.UseVisualStyleBackColor = true;
            // 
            // top3Cheapest
            // 
            this.top3Cheapest.Location = new System.Drawing.Point(237, 31);
            this.top3Cheapest.Name = "top3Cheapest";
            this.top3Cheapest.Size = new System.Drawing.Size(228, 23);
            this.top3Cheapest.TabIndex = 21;
            this.top3Cheapest.Text = "Show Top 3 Cheapest Product Categories";
            this.top3Cheapest.UseVisualStyleBackColor = true;
            this.top3Cheapest.Click += new System.EventHandler(this.Top3Cheapest_Click);
            // 
            // CompanyName
            // 
            this.CompanyName.Location = new System.Drawing.Point(725, 380);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(170, 20);
            this.CompanyName.TabIndex = 22;
            this.CompanyName.Text = "CompanyName";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 441);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.top3Cheapest);
            this.Controls.Add(this.OrderByPrize);
            this.Controls.Add(this.orderByName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.top3Most);
            this.Controls.Add(this.search);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addToBasket);
            this.Controls.Add(this.basket);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BazyDanych_TydzienB_ProdContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BazyDanych_TydzienB_ProdContextDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _BazyDanych_TydzienB_ProdContextDataSet _BazyDanych_TydzienB_ProdContextDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private _BazyDanych_TydzienB_ProdContextDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridView dataGridView2;
        private _BazyDanych_TydzienB_ProdContextDataSet1 _BazyDanych_TydzienB_ProdContextDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private _BazyDanych_TydzienB_ProdContextDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.ListBox basket;
        private System.Windows.Forms.Button addToBasket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button top3Most;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox orderByName;
        private System.Windows.Forms.CheckBox OrderByPrize;
        private System.Windows.Forms.Button top3Cheapest;
        private System.Windows.Forms.TextBox CompanyName;
    }
}