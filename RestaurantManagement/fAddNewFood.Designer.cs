namespace RestaurantManagement
{
    partial class fAddNewFood
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
            lbFoodName = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lbFoodCategory = new System.Windows.Forms.Label();
            tbFoodName = new System.Windows.Forms.TextBox();
            cbbFoodCategory = new System.Windows.Forms.ComboBox();
            btnAddNewFood = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            nmPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nmPrice).BeginInit();
            SuspendLayout();
            // 
            // lbFoodName
            // 
            lbFoodName.AutoSize = true;
            lbFoodName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbFoodName.Location = new System.Drawing.Point(12, 55);
            lbFoodName.Name = "lbFoodName";
            lbFoodName.Size = new System.Drawing.Size(112, 25);
            lbFoodName.TabIndex = 0;
            lbFoodName.Text = "Food Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 188);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 25);
            label2.TabIndex = 2;
            label2.Text = "Price:";
            // 
            // lbFoodCategory
            // 
            lbFoodCategory.AutoSize = true;
            lbFoodCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbFoodCategory.Location = new System.Drawing.Point(12, 124);
            lbFoodCategory.Name = "lbFoodCategory";
            lbFoodCategory.Size = new System.Drawing.Size(92, 25);
            lbFoodCategory.TabIndex = 3;
            lbFoodCategory.Text = "Category:";
            // 
            // tbFoodName
            // 
            tbFoodName.Location = new System.Drawing.Point(157, 56);
            tbFoodName.Name = "tbFoodName";
            tbFoodName.Size = new System.Drawing.Size(278, 27);
            tbFoodName.TabIndex = 4;
            // 
            // cbbFoodCategory
            // 
            cbbFoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbFoodCategory.FormattingEnabled = true;
            cbbFoodCategory.Location = new System.Drawing.Point(157, 125);
            cbbFoodCategory.Name = "cbbFoodCategory";
            cbbFoodCategory.Size = new System.Drawing.Size(278, 28);
            cbbFoodCategory.TabIndex = 5;
            // 
            // btnAddNewFood
            // 
            btnAddNewFood.Location = new System.Drawing.Point(228, 231);
            btnAddNewFood.Name = "btnAddNewFood";
            btnAddNewFood.Size = new System.Drawing.Size(94, 29);
            btnAddNewFood.TabIndex = 7;
            btnAddNewFood.Text = "Add";
            btnAddNewFood.UseVisualStyleBackColor = true;
            btnAddNewFood.Click += btnAddNewFood_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(341, 231);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "CLose";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // nmPrice
            // 
            nmPrice.Location = new System.Drawing.Point(157, 188);
            nmPrice.Name = "nmPrice";
            nmPrice.Size = new System.Drawing.Size(278, 27);
            nmPrice.TabIndex = 9;
            // 
            // fAddNewFood
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(490, 309);
            Controls.Add(nmPrice);
            Controls.Add(btnClose);
            Controls.Add(btnAddNewFood);
            Controls.Add(cbbFoodCategory);
            Controls.Add(tbFoodName);
            Controls.Add(lbFoodCategory);
            Controls.Add(label2);
            Controls.Add(lbFoodName);
            Name = "fAddNewFood";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Add New Food";
            ((System.ComponentModel.ISupportInitialize)nmPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFoodCategory;
        private System.Windows.Forms.TextBox tbFoodName;
        private System.Windows.Forms.ComboBox cbbFoodCategory;
        private System.Windows.Forms.Button btnAddNewFood;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown nmPrice;
    }
}