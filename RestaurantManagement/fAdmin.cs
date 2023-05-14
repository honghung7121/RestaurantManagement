using RestaurantManagement.DAL;
using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadFood();
        }

        #region Method

        public void LoadFood()
        {
            lvFood.Items.Clear();
            List<Food> list = FoodDAO.GetAllFood();
            foreach (Food food in list)
            {
                ListViewItem lsvItem = new ListViewItem(food.Id.ToString());
                lsvItem.SubItems.Add(food.Name);
                lsvItem.SubItems.Add(food.IdFoodCategory.ToString());
                lsvItem.SubItems.Add(food.Price.ToString());
                lvFood.Items.Add(lsvItem);
            }
        }
        #endregion


        #region Event
        private void btnAddNewFood_Click(object sender, EventArgs e)
        {
            fAddNewFood fAddNewFood = new fAddNewFood();
            fAddNewFood.ShowDialog();
            LoadFood();
        }
        private void lvFood_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                tbID.Text = e.Item.SubItems[0].Text;
                tbFoodName.Text = e.Item.SubItems[1].Text;
                int idCategory = Convert.ToInt32(e.Item.SubItems[2].Text);
                tbCategory.Text = FoodCategoryDAO.GetCategoryByID(idCategory);
                tbCategory.Tag = idCategory;
                tbPrice.Text = e.Item.SubItems[3].Text;
            }
        }
        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Search Food Name...")
            {
                tbSearch.Text = "";
                tbSearch.ForeColor = Color.Black;
            }
        }
        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                tbSearch.Text = "Search Food Name...";
                tbSearch.ForeColor = Color.Silver;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            LinQ linQ = new LinQ();
            lvFood.Items.Clear();
            List<Food> list = linQ.GetFoodByName(tbSearch.Text);
            foreach (Food food in list)
            {
                ListViewItem lsvItem = new ListViewItem(food.Id.ToString());
                lsvItem.SubItems.Add(food.Name);
                lsvItem.SubItems.Add(food.IdFoodCategory.ToString());
                lsvItem.SubItems.Add(food.Price.ToString());
                lvFood.Items.Add(lsvItem);
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbID.Text);
            if (id != null)
            {
                DialogResult result = MessageBox.Show("Do you want delete this food?", "Notification", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    return;
                }
                FoodDAO dao = new();
                dao.DeleteFood(id);
                LoadFood();
            }
            else
            {
                MessageBox.Show("You have to pick the food to delete!");
            }
        }
        #endregion



        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbID.Text);
            string foodName = tbFoodName.Text;
            int idCategory = Convert.ToInt32(tbCategory.Tag);
            double price = Convert.ToDouble(tbPrice.Text);
            FoodDAO dao = new();
            dao.UpdateFood(id, foodName, idCategory, price);
            LoadFood();
        }
    }
}
