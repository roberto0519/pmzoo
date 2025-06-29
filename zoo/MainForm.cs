using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zoo
{
    public partial class MainForm: Form
    {
        private string username;
        private bool isAdmin;
        public MainForm(string username, bool isAdmin)
        {
            InitializeComponent();
            this.username = username;
            this.isAdmin = isAdmin;

            lblWelcome.Text = $"Добро пожаловать, {username}!";

            if (!isAdmin)
            {
                btnOrders.Visible = false;
            }
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            new AnimalsForm().ShowDialog();

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            new OrdersForm().ShowDialog();

        }

        private void btnReserves_Click(object sender, EventArgs e)
        {
            new ReservesForm().ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
