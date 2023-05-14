using RestaurantManagement.DAL;
using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class fManagement : Form
    {
        public fManagement()
        {
            InitializeComponent();
            LoadTable();
            LoadFoodCategory();
        }
        #region Method
        private void LoadTable()
        {
            flTable.Controls.Clear();
            List<Table> tableList = TableDAO.loadTableList();
            foreach (Table table in tableList)
            {
                Button btnTable = new Button
                {
                    Width = 90,
                    Height = 90,
                    BackColor = Color.Bisque,
                    Tag = table
                };
                btnTable.Click += BtnTable_Click;
                string status = "Empty";
                if (table.Status)
                {
                    btnTable.BackColor = Color.Cyan;
                    status = "Full";
                }
                btnTable.Text = table.Name + Environment.NewLine + status;
                flTable.Controls.Add(btnTable);
            }
            ccbTable.DataSource = tableList;
            ccbTable.DisplayMember = "Name";
        }
        private void LoadFoodCategory()
        {
            List<FoodCategory> list = FoodCategoryDAO.GetAllFoodCategory();
            cbbCategory.DataSource = list;
            cbbCategory.DisplayMember = "Name";
        }
        private void LoadFoodByCategory(int id)
        {
            List<Food> list = FoodDAO.GetFoodByCategory(id);
            if (list.Count != 0)
            {
                ccbFood.DataSource = list;
                ccbFood.DisplayMember = "Name";
            }
            else
            {
                ccbFood.DataSource = null;
            }
        }
        private void ShowBill(int tableID)
        {
            foodList.Items.Clear();
            double total = 0;
            List<BillToShow> listBill = ShowToBillDAO.ShowBill(tableID);
            foreach (BillToShow bill in listBill)
            {
                ListViewItem lsvItem = new ListViewItem(bill.FoodName.ToString());
                lsvItem.SubItems.Add(bill.Price.ToString("c3", new CultureInfo("vi-VN")));
                lsvItem.SubItems.Add(bill.Count.ToString());
                lsvItem.SubItems.Add(bill.Total.ToString("c3", new CultureInfo("vi-VN")));
                total += bill.Total;
                foodList.Items.Add(lsvItem);
            }
            tbTotal.BackColor = Color.White;
            tbTotal.ForeColor = Color.Green;
            tbTotal.Text = total.ToString("c3", new CultureInfo("vi-VN"));
        }


        #endregion

        #region Event
        private void BtnTable_Click(object? sender, EventArgs e)
        {
            Button btnTable = (Button)sender;
            Table table = (Table)btnTable.Tag;
            foodList.Tag = table;
            ShowBill(table.Id);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiShowInfo_Click(object sender, EventArgs e)
        {
            fAccountProfile fAccountProfile = new fAccountProfile();
            fAccountProfile.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAdmin fAdmin = new fAdmin();
            fAdmin.ShowDialog();
            this.Show();
        }
        private void ccbFoodCategorySelect(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            FoodCategory foodCategory = (FoodCategory)cb.SelectedItem;
            LoadFoodByCategory(foodCategory.Id);
        }
        private void btnAddNewFood_Click(object sender, EventArgs e)
        {
            Table table = foodList.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Choose Table please!");
            }
            else
            {
                int idBill = BillDAO.CheckOutBillTableId(table.Id);
                int foodID = ((Food)ccbFood.SelectedItem).Id;
                int count = (int)nnFoodCount.Value;
                if (idBill == -1)
                {
                    BillDAO.InsertNewBill(table.Id);
                    BillInfoDAO.InsertNewBillInfo(BillDAO.GetMaxIdBill(), foodID, count);
                }
                else
                {
                    BillInfoDAO.InsertNewBillInfo(idBill, foodID, count);
                }
                ShowBill(table.Id);
                LoadTable();
            }


        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = foodList.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Choose Table please!");
            }
            else
            {
                int idBill = BillDAO.CheckOutBillTableId(table.Id);
                BillDAO.CheckOutBill(idBill, table.Id);
                LoadTable();
                ShowBill(table.Id);
            }
        }
        private void btnSwapTable_Click(object sender, EventArgs e)
        {
            Table table = foodList.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Choose Table please!");
            }
            else
            {
                int idBill = BillDAO.CheckOutBillTableId(table.Id);
                Table newTable = (Table)ccbTable.SelectedItem;
                BillDAO.SwapTable(idBill, table.Id, newTable.Id);
                LoadTable();
            }
        }
        #endregion
    }
}
