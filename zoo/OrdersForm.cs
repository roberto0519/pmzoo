using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace zoo
{
    public partial class OrdersForm : Form
    {
        private string connectionString = "Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_11;Search Path=pm_11";

        public OrdersForm()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders(bool onlyOverdue = false)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT 
                                    zo.order_number AS ""Номер заказа"",
                                    zo.order_date AS ""Дата заказа"",
                                    zo.arrival_date AS ""Дата прибытия"",
                                    zo.applicant_number AS ""Номер заявителя"",
                                    CASE 
                                        WHEN zo.arrival_date < CURRENT_DATE THEN 'Просрочен'
                                        ELSE 'В срок'
                                    END AS ""Статус""
                                FROM pm_11.zoo_order zo";

                if (onlyOverdue)
                {
                    query += " WHERE zo.arrival_date < CURRENT_DATE";
                }

                var adapter = new NpgsqlDataAdapter(query, connection);
                var table = new DataTable();
                adapter.Fill(table);

                orderGridView.DataSource = table;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders(chkOverdueOnly.Checked);
        }

        private void chkOverdueOnly_CheckedChanged(object sender, EventArgs e)
        {
            LoadOrders(chkOverdueOnly.Checked);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}