namespace BazyDanych_TydzienB
{
    partial class Summary
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
            this.label1 = new System.Windows.Forms.Label();
            this.BoughtItems = new System.Windows.Forms.ListBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bought Items";
            // 
            // BoughtItems
            // 
            this.BoughtItems.FormattingEnabled = true;
            this.BoughtItems.Location = new System.Drawing.Point(12, 37);
            this.BoughtItems.Name = "BoughtItems";
            this.BoughtItems.Size = new System.Drawing.Size(260, 121);
            this.BoughtItems.TabIndex = 1;
            this.BoughtItems.SelectedIndexChanged += new System.EventHandler(this.BoughtItems_SelectedIndexChanged);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 226);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(260, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Info.Location = new System.Drawing.Point(74, 181);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(61, 25);
            this.Info.TabIndex = 4;
            this.Info.Text = "Price";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Price.Location = new System.Drawing.Point(162, 181);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(24, 25);
            this.Price.TabIndex = 5;
            this.Price.Text = "0";
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.BoughtItems);
            this.Controls.Add(this.label1);
            this.Name = "Summary";
            this.Text = "Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox BoughtItems;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label Price;
    }
}