using RestaurantManagement.DAL;
using RestaurantManagement.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class fAddNewFood : Form
    {
        public fAddNewFood()
        {
            InitializeComponent();
            LoadCategoryFood();
        }

        #region Method
        private void LoadCategoryFood()
        {
            List<FoodCategory> listFoodCategory = FoodCategoryDAO.GetAllFoodCategory();
            cbbFoodCategory.DataSource = listFoodCategory;
            cbbFoodCategory.DisplayMember = "Name";
        }



        #endregion
        #region Event
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void btnAddNewFood_Click(object sender, System.EventArgs e)
        {
            this.Refresh();
            string foodName = tbFoodName.Text;
            if (foodName.Trim().Equals(""))
            {
                MessageBox.Show("The Food Name is EMPTY");
                return;
            }
            else
            {
                FoodCategory category = (FoodCategory)cbbFoodCategory.SelectedItem;
                double price = (double)nmPrice.Value;
                FoodDAO.AddnewFood(foodName, category.Id, price);
                MessageBox.Show("Add New Food Successfully");
            }
        }
        #endregion
    }
}
