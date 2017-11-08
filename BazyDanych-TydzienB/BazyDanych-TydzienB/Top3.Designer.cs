namespace BazyDanych_TydzienB
{
    partial class Top3
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
            this.Info = new System.Windows.Forms.Label();
            this.top3Stats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Info.Location = new System.Drawing.Point(40, 38);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(44, 18);
            this.Info.TabIndex = 5;
            this.Info.Text = "None";
            // 
            // top3Stats
            // 
            this.top3Stats.AutoSize = true;
            this.top3Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.top3Stats.Location = new System.Drawing.Point(12, 79);
            this.top3Stats.Name = "top3Stats";
            this.top3Stats.Size = new System.Drawing.Size(44, 18);
            this.top3Stats.TabIndex = 6;
            this.top3Stats.Text = "None";
            this.top3Stats.Click += new System.EventHandler(this.top3Stats_Click);
            // 
            // Top3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 406);
            this.Controls.Add(this.top3Stats);
            this.Controls.Add(this.Info);
            this.Name = "Top3";
            this.Text = "Top3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label top3Stats;
    }
}