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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbLoginName.Text;
            string password = txbPassword.Text;
            AccountDAO dao = new AccountDAO();
            Account account = dao.CheckLogin(userName, password);
            if (account != null)
            {
                fManagement fManagement = new fManagement();
                this.Hide();
                fManagement.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid User Name or password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the system?", "Notification", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
