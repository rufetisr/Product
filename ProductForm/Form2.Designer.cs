namespace ProductForm
{
    partial class Form2
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
            this.prd_Cost = new System.Windows.Forms.TextBox();
            this.txtbox3 = new System.Windows.Forms.TextBox();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.prd_Name = new System.Windows.Forms.TextBox();
            this.prd_Country = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prd_Cost
            // 
            this.prd_Cost.Location = new System.Drawing.Point(12, 225);
            this.prd_Cost.Name = "prd_Cost";
            this.prd_Cost.Size = new System.Drawing.Size(475, 27);
            this.prd_Cost.TabIndex = 0;
            this.prd_Cost.TextChanged += new System.EventHandler(this.prd_Cost_TextChanged);
            // 
            // txtbox3
            // 
            this.txtbox3.Location = new System.Drawing.Point(12, 192);
            this.txtbox3.Name = "txtbox3";
            this.txtbox3.ReadOnly = true;
            this.txtbox3.Size = new System.Drawing.Size(125, 27);
            this.txtbox3.TabIndex = 0;
            this.txtbox3.Text = "Product cost:";
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(12, 16);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.ReadOnly = true;
            this.txtbox1.Size = new System.Drawing.Size(125, 27);
            this.txtbox1.TabIndex = 0;
            this.txtbox1.Text = "Product name:";
            // 
            // prd_Name
            // 
            this.prd_Name.Location = new System.Drawing.Point(12, 49);
            this.prd_Name.Name = "prd_Name";
            this.prd_Name.Size = new System.Drawing.Size(475, 27);
            this.prd_Name.TabIndex = 0;
            this.prd_Name.TextChanged += new System.EventHandler(this.prd_Name_TextChanged);
            // 
            // prd_Country
            // 
            this.prd_Country.Location = new System.Drawing.Point(12, 136);
            this.prd_Country.Name = "prd_Country";
            this.prd_Country.Size = new System.Drawing.Size(475, 27);
            this.prd_Country.TabIndex = 0;
            this.prd_Country.TextChanged += new System.EventHandler(this.prd_Name_TextChanged);
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(12, 103);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.ReadOnly = true;
            this.txtbox2.Size = new System.Drawing.Size(125, 27);
            this.txtbox2.TabIndex = 0;
            this.txtbox2.Text = "Origin country:";
            // 
            // ok_btn
            // 
            this.ok_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ok_btn.Location = new System.Drawing.Point(12, 283);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(125, 36);
            this.ok_btn.TabIndex = 1;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_btn.Location = new System.Drawing.Point(362, 283);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(125, 36);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProductForm.Properties.Resources.photo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 345);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.prd_Name);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.txtbox3);
            this.Controls.Add(this.prd_Country);
            this.Controls.Add(this.prd_Cost);
            this.MinimumSize = new System.Drawing.Size(517, 392);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox prd_Cost;
        private TextBox txtbox3;
        private TextBox txtbox1;
        public TextBox prd_Name;
        public TextBox prd_Country;
        private TextBox txtbox2;
        private Button ok_btn;
        private Button cancel_btn;
    }
}