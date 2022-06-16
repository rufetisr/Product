namespace ProductForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(455, 244);
            this.listBox1.TabIndex = 0;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_btn.Location = new System.Drawing.Point(12, 279);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(455, 39);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Add Product";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.edit_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edit_btn.Location = new System.Drawing.Point(12, 393);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(455, 39);
            this.edit_btn.TabIndex = 1;
            this.edit_btn.Text = "Edit Product";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.remove_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remove_btn.Location = new System.Drawing.Point(12, 334);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(455, 39);
            this.remove_btn.TabIndex = 1;
            this.remove_btn.Text = "Remove Product";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.clear_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear_btn.Location = new System.Drawing.Point(12, 451);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(455, 39);
            this.clear_btn.TabIndex = 1;
            this.clear_btn.Text = "Clear List";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProductForm.Properties.Resources.istockphoto_1248542684_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(479, 502);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.listBox1);
            this.MinimumSize = new System.Drawing.Size(497, 549);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public ListBox listBox1;
        private Button add_btn;
        private Button edit_btn;
        private Button remove_btn;
        private Button clear_btn;
    }
}