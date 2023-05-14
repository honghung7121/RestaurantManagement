namespace RestaurantManagement
{
    partial class fManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManagement));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            accountsInfomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsmiShowInfo = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel2 = new System.Windows.Forms.Panel();
            foodList = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            panel3 = new System.Windows.Forms.Panel();
            nnFoodCount = new System.Windows.Forms.NumericUpDown();
            btnAddNewFood = new System.Windows.Forms.Button();
            ccbFood = new System.Windows.Forms.ComboBox();
            cbbCategory = new System.Windows.Forms.ComboBox();
            panel4 = new System.Windows.Forms.Panel();
            btnSwapTable = new System.Windows.Forms.Button();
            ccbTable = new System.Windows.Forms.ComboBox();
            btnCheckOut = new System.Windows.Forms.Button();
            tbTotal = new System.Windows.Forms.TextBox();
            lbTotal = new System.Windows.Forms.Label();
            lbDiscount = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ptLogo = new System.Windows.Forms.PictureBox();
            flTable = new System.Windows.Forms.FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nnFoodCount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptLogo).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { adminToolStripMenuItem, accountsInfomationToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1034, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // accountsInfomationToolStripMenuItem
            // 
            accountsInfomationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiShowInfo, exitToolStripMenuItem });
            accountsInfomationToolStripMenuItem.Name = "accountsInfomationToolStripMenuItem";
            accountsInfomationToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            accountsInfomationToolStripMenuItem.Text = "Account's Infomation";
            // 
            // tsmiShowInfo
            // 
            tsmiShowInfo.Name = "tsmiShowInfo";
            tsmiShowInfo.Size = new System.Drawing.Size(210, 26);
            tsmiShowInfo.Text = "Show information";
            tsmiShowInfo.Click += tsmiShowInfo_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(foodList);
            panel2.Location = new System.Drawing.Point(412, 134);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(436, 440);
            panel2.TabIndex = 2;
            // 
            // foodList
            // 
            foodList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            foodList.GridLines = true;
            foodList.HideSelection = false;
            foodList.Location = new System.Drawing.Point(3, 3);
            foodList.Name = "foodList";
            foodList.Size = new System.Drawing.Size(430, 437);
            foodList.TabIndex = 0;
            foodList.UseCompatibleStateImageBehavior = false;
            foodList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Food Name";
            columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Price";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Count";
            columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader3.Width = 55;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Total";
            columnHeader4.Width = 130;
            // 
            // panel3
            // 
            panel3.Controls.Add(nnFoodCount);
            panel3.Controls.Add(btnAddNewFood);
            panel3.Controls.Add(ccbFood);
            panel3.Controls.Add(cbbCategory);
            panel3.Location = new System.Drawing.Point(425, 47);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(413, 81);
            panel3.TabIndex = 2;
            // 
            // nnFoodCount
            // 
            nnFoodCount.Location = new System.Drawing.Point(303, 46);
            nnFoodCount.Name = "nnFoodCount";
            nnFoodCount.Size = new System.Drawing.Size(94, 27);
            nnFoodCount.TabIndex = 3;
            nnFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddNewFood
            // 
            btnAddNewFood.Location = new System.Drawing.Point(303, 12);
            btnAddNewFood.Name = "btnAddNewFood";
            btnAddNewFood.Size = new System.Drawing.Size(94, 29);
            btnAddNewFood.TabIndex = 2;
            btnAddNewFood.Text = "Add Food";
            btnAddNewFood.UseVisualStyleBackColor = true;
            btnAddNewFood.Click += btnAddNewFood_Click;
            // 
            // ccbFood
            // 
            ccbFood.FormattingEnabled = true;
            ccbFood.Location = new System.Drawing.Point(12, 46);
            ccbFood.Name = "ccbFood";
            ccbFood.Size = new System.Drawing.Size(285, 28);
            ccbFood.TabIndex = 1;
            ccbFood.Text = "Food";
            // 
            // cbbCategory
            // 
            cbbCategory.FormattingEnabled = true;
            cbbCategory.Location = new System.Drawing.Point(12, 12);
            cbbCategory.Name = "cbbCategory";
            cbbCategory.Size = new System.Drawing.Size(285, 28);
            cbbCategory.TabIndex = 0;
            cbbCategory.Text = "Category";
            cbbCategory.SelectedIndexChanged += ccbFoodCategorySelect;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSwapTable);
            panel4.Controls.Add(ccbTable);
            panel4.Controls.Add(btnCheckOut);
            panel4.Controls.Add(tbTotal);
            panel4.Controls.Add(lbTotal);
            panel4.Controls.Add(lbDiscount);
            panel4.Controls.Add(numericUpDown1);
            panel4.Controls.Add(ptLogo);
            panel4.Location = new System.Drawing.Point(854, 47);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(168, 527);
            panel4.TabIndex = 3;
            // 
            // btnSwapTable
            // 
            btnSwapTable.Location = new System.Drawing.Point(35, 218);
            btnSwapTable.Name = "btnSwapTable";
            btnSwapTable.Size = new System.Drawing.Size(94, 29);
            btnSwapTable.TabIndex = 9;
            btnSwapTable.Text = "Swap Table";
            btnSwapTable.UseVisualStyleBackColor = true;
            btnSwapTable.Click += btnSwapTable_Click;
            // 
            // ccbTable
            // 
            ccbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ccbTable.FormattingEnabled = true;
            ccbTable.Location = new System.Drawing.Point(3, 184);
            ccbTable.Name = "ccbTable";
            ccbTable.Size = new System.Drawing.Size(162, 28);
            ccbTable.TabIndex = 8;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCheckOut.Location = new System.Drawing.Point(20, 450);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new System.Drawing.Size(128, 55);
            btnCheckOut.TabIndex = 7;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // tbTotal
            // 
            tbTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tbTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            tbTotal.Location = new System.Drawing.Point(3, 381);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new System.Drawing.Size(162, 38);
            tbTotal.TabIndex = 6;
            tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTotal.Location = new System.Drawing.Point(3, 355);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new System.Drawing.Size(49, 23);
            lbTotal.TabIndex = 5;
            lbTotal.Text = "Total";
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbDiscount.Location = new System.Drawing.Point(0, 282);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new System.Drawing.Size(80, 23);
            lbDiscount.TabIndex = 4;
            lbDiscount.Text = "Discount";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(3, 308);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(162, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // ptLogo
            // 
            ptLogo.Image = (System.Drawing.Image)resources.GetObject("ptLogo.Image");
            ptLogo.Location = new System.Drawing.Point(0, 0);
            ptLogo.Name = "ptLogo";
            ptLogo.Size = new System.Drawing.Size(165, 151);
            ptLogo.TabIndex = 0;
            ptLogo.TabStop = false;
            // 
            // flTable
            // 
            flTable.AutoScroll = true;
            flTable.Location = new System.Drawing.Point(12, 47);
            flTable.Name = "flTable";
            flTable.Size = new System.Drawing.Size(394, 527);
            flTable.TabIndex = 0;
            // 
            // fManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1034, 589);
            Controls.Add(flTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Management";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nnFoodCount).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsInfomationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowInfo;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView foodList;
        private System.Windows.Forms.NumericUpDown nnFoodCount;
        private System.Windows.Forms.Button btnAddNewFood;
        private System.Windows.Forms.ComboBox ccbFood;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox ptLogo;
        private System.Windows.Forms.FlowLayoutPanel flTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox ccbTable;
        private System.Windows.Forms.Button btnSwapTable;
    }
}