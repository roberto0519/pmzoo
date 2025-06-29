using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace zoo
{
    public partial class ReservesForm : Form
    {
        private string connectionString = "Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_11;Search Path=pm_11";

        public ReservesForm()
        {
            InitializeComponent();
            LoadZapovedniks();
            LoadReserves();
        }

        private void LoadZapovedniks()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var adapter = new NpgsqlDataAdapter("SELECT * FROM pm_11.zapovednik", connection);
                var table = new DataTable();
                adapter.Fill(table);
                zapovednikGridView.DataSource = table;
            }
        }

        private void LoadReserves()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var adapter = new NpgsqlDataAdapter("SELECT * FROM pm_11.reserve", connection);
                var table = new DataTable();
                adapter.Fill(table);
                reserveGridView.DataSource = table;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}