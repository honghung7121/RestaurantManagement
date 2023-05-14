using System.Drawing;
using System.Reflection;

namespace RestaurantManagement
{
    partial class fAdmin
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
            tcTab = new System.Windows.Forms.TabControl();
            tbBill = new System.Windows.Forms.TabPage();
            panel2 = new System.Windows.Forms.Panel();
            btnSearch = new System.Windows.Forms.Button();
            lbTo = new System.Windows.Forms.Label();
            lbFrom = new System.Windows.Forms.Label();
            dtpkToDate = new System.Windows.Forms.DateTimePicker();
            pkFromDate = new System.Windows.Forms.DateTimePicker();
            panel1 = new System.Windows.Forms.Panel();
            dtgvBills = new System.Windows.Forms.DataGridView();
            tbFood = new System.Windows.Forms.TabPage();
            panel5 = new System.Windows.Forms.Panel();
            btnDeleteFood = new System.Windows.Forms.Button();
            btnUpdateFood = new System.Windows.Forms.Button();
            btnAddNewFood = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            tbSearch = new System.Windows.Forms.TextBox();
            tbPrice = new System.Windows.Forms.TextBox();
            tbCategory = new System.Windows.Forms.TextBox();
            tbFoodName = new System.Windows.Forms.TextBox();
            tbID = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            lvFood = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            tcTab.SuspendLayout();
            tbBill.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBills).BeginInit();
            tbFood.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tcTab
            // 
            tcTab.Controls.Add(tbBill);
            tcTab.Controls.Add(tbFood);
            tcTab.Location = new Point(9, 12);
            tcTab.Name = "tcTab";
            tcTab.SelectedIndex = 0;
            tcTab.Size = new Size(933, 570);
            tcTab.TabIndex = 0;
            // 
            // tbBill
            // 
            tbBill.Controls.Add(panel2);
            tbBill.Controls.Add(panel1);
            tbBill.Location = new Point(4, 29);
            tbBill.Name = "tbBill";
            tbBill.Padding = new System.Windows.Forms.Padding(3);
            tbBill.Size = new Size(925, 537);
            tbBill.TabIndex = 0;
            tbBill.Text = "Receipt";
            tbBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(lbTo);
            panel2.Controls.Add(lbFrom);
            panel2.Controls.Add(dtpkToDate);
            panel2.Controls.Add(pkFromDate);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(913, 62);
            panel2.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(678, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new System.Windows.Forms.Padding(2);
            btnSearch.Size = new Size(116, 44);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbTo.Location = new Point(353, 22);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(31, 25);
            lbTo.TabIndex = 1;
            lbTo.Text = "To";
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbFrom.Location = new Point(19, 20);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(55, 25);
            lbFrom.TabIndex = 0;
            lbFrom.Text = "From";
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(401, 20);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(250, 27);
            dtpkToDate.TabIndex = 1;
            // 
            // pkFromDate
            // 
            pkFromDate.Location = new Point(87, 20);
            pkFromDate.Name = "pkFromDate";
            pkFromDate.Size = new Size(250, 27);
            pkFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvBills);
            panel1.Location = new Point(6, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 457);
            panel1.TabIndex = 0;
            // 
            // dtgvBills
            // 
            dtgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBills.Location = new Point(3, 3);
            dtgvBills.Name = "dtgvBills";
            dtgvBills.RowHeadersWidth = 51;
            dtgvBills.RowTemplate.Height = 29;
            dtgvBills.Size = new Size(907, 451);
            dtgvBills.TabIndex = 0;
            // 
            // tbFood
            // 
            tbFood.Controls.Add(panel5);
            tbFood.Controls.Add(panel4);
            tbFood.Controls.Add(panel3);
            tbFood.Location = new Point(4, 29);
            tbFood.Name = "tbFood";
            tbFood.Padding = new System.Windows.Forms.Padding(3);
            tbFood.Size = new Size(925, 537);
            tbFood.TabIndex = 1;
            tbFood.Text = "Food";
            tbFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnDeleteFood);
            panel5.Controls.Add(btnUpdateFood);
            panel5.Controls.Add(btnAddNewFood);
            panel5.Location = new Point(6, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(537, 45);
            panel5.TabIndex = 1;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(383, 8);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(94, 29);
            btnDeleteFood.TabIndex = 3;
            btnDeleteFood.Text = "Delete";
            btnDeleteFood.UseVisualStyleBackColor = true;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // btnUpdateFood
            // 
            btnUpdateFood.Location = new Point(219, 8);
            btnUpdateFood.Name = "btnUpdateFood";
            btnUpdateFood.Size = new Size(94, 29);
            btnUpdateFood.TabIndex = 2;
            btnUpdateFood.Text = "Update";
            btnUpdateFood.UseVisualStyleBackColor = true;
            btnUpdateFood.Click += btnUpdateFood_Click;
            // 
            // btnAddNewFood
            // 
            btnAddNewFood.Location = new Point(40, 8);
            btnAddNewFood.Name = "btnAddNewFood";
            btnAddNewFood.Size = new Size(94, 29);
            btnAddNewFood.TabIndex = 1;
            btnAddNewFood.Text = "Add";
            btnAddNewFood.UseVisualStyleBackColor = true;
            btnAddNewFood.Click += btnAddNewFood_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(tbSearch);
            panel4.Controls.Add(tbPrice);
            panel4.Controls.Add(tbCategory);
            panel4.Controls.Add(tbFoodName);
            panel4.Controls.Add(tbID);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(549, 57);
            panel4.Name = "panel4";
            panel4.Size = new Size(370, 474);
            panel4.TabIndex = 1;
            // 
            // tbSearch
            // 
            tbSearch.ForeColor = Color.Silver;
            tbSearch.Location = new Point(22, 234);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(332, 27);
            tbSearch.TabIndex = 8;
            tbSearch.Text = "Search Food Name...";
            tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            tbSearch.TextChanged += tbSearch_TextChanged;
            tbSearch.Enter += tbSearch_Enter;
            tbSearch.Leave += tbSearch_Leave;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(142, 171);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(212, 27);
            tbPrice.TabIndex = 7;
            // 
            // tbCategory
            // 
            tbCategory.Location = new Point(142, 125);
            tbCategory.Name = "tbCategory";
            tbCategory.Size = new Size(212, 27);
            tbCategory.TabIndex = 6;
            // 
            // tbFoodName
            // 
            tbFoodName.Location = new Point(142, 70);
            tbFoodName.Name = "tbFoodName";
            tbFoodName.Size = new Size(212, 27);
            tbFoodName.TabIndex = 5;
            // 
            // tbID
            // 
            tbID.AcceptsTab = true;
            tbID.Location = new Point(142, 21);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(212, 27);
            tbID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Mincho Demibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 172);
            label4.Name = "label4";
            label4.Size = new Size(59, 26);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Mincho Demibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 124);
            label3.Name = "label3";
            label3.Size = new Size(93, 26);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Mincho Demibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 69);
            label2.Name = "label2";
            label2.Size = new Size(66, 26);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Mincho Demibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(37, 26);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // panel3
            // 
            panel3.Controls.Add(lvFood);
            panel3.Location = new Point(6, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(537, 474);
            panel3.TabIndex = 0;
            // 
            // lvFood
            // 
            lvFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvFood.GridLines = true;
            lvFood.HideSelection = false;
            lvFood.Location = new Point(0, 0);
            lvFood.Name = "lvFood";
            lvFood.Size = new Size(537, 474);
            lvFood.TabIndex = 0;
            lvFood.UseCompatibleStateImageBehavior = false;
            lvFood.View = System.Windows.Forms.View.Details;
            lvFood.ItemSelectionChanged += lvFood_ItemSelectionChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 240;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ID Category";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Price";
            columnHeader4.Width = 100;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(957, 594);
            Controls.Add(tcTab);
            Name = "fAdmin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Admin";
            tcTab.ResumeLayout(false);
            tbBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBills).EndInit();
            tbFood.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tcTab;
        private System.Windows.Forms.TabPage tbBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker pkFromDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tbFood;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DataGridView dtgvBills;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Button btnAddNewFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbFoodName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvFood;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbPrice;
    }
}