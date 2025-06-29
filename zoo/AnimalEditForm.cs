using Npgsql;
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
    public partial class AnimalEditForm: Form
    {
        private string connectionString = "Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_11";
        private int? animalId;

        public AnimalEditForm(int? id = null)
        {
            InitializeComponent();
            animalId = id;

            LoadSpecies();
            LoadCaretakers();
            LoadEnclosures();

            if (animalId.HasValue)
            {
                LoadAnimalData(animalId.Value);
            }
        }

        private void LoadSpecies()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var adapter = new NpgsqlDataAdapter("SELECT id, name FROM pm_11.species ORDER BY name", connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);

                    cmbSpecies.DataSource = table;
                    cmbSpecies.DisplayMember = "name";
                    cmbSpecies.ValueMember = "id";
                    cmbSpecies.SelectedIndex = -1;
                }
            }
        }

        private void LoadCaretakers()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var adapter = new NpgsqlDataAdapter("SELECT id, full_name FROM pm_11.employee ORDER BY full_name", connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);

                    cmbCaretaker.DataSource = table;
                    cmbCaretaker.DisplayMember = "full_name";
                    cmbCaretaker.ValueMember = "id";
                    cmbCaretaker.SelectedIndex = -1;
                }
            }
        }

        private void LoadEnclosures()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var adapter = new NpgsqlDataAdapter("SELECT id, name FROM pm_11.enclosure ORDER BY name", connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);

                    cmbEnclosure.DataSource = table;
                    cmbEnclosure.DisplayMember = "name";
                    cmbEnclosure.ValueMember = "id";
                    cmbEnclosure.SelectedIndex = -1;
                }
            }
        }

        private void LoadAnimalData(int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (var cmd = new NpgsqlCommand(@"SELECT name, number, arrival_date, species_id, caretaker_id, enclosure_id FROM pm_11.animal WHERE id = @id", connection))
                {
                    cmd.Parameters.AddWithValue("id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader.GetString(0);
                            numNumber.Value = reader.GetInt32(1);
                            dtpArrivalDate.Value = reader.GetDateTime(2);
                            cmbSpecies.SelectedValue = reader.GetInt32(3);
                            cmbCaretaker.SelectedValue = reader.GetInt32(4);
                            cmbEnclosure.SelectedValue = reader.GetInt32(5);
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите имя животного");
                return;
            }

            if (cmbSpecies.SelectedIndex == -1 || cmbCaretaker.SelectedIndex == -1 || cmbEnclosure.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите вид, смотрителя и вольер");
                return;
            }

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                NpgsqlCommand cmd;
                if (animalId.HasValue)
                {
                    cmd = new NpgsqlCommand(@"UPDATE pm_11.animal SET 
                            name = @name,
                            number = @number,
                            arrival_date = @arrival_date,
                            species_id = @species_id,
                            caretaker_id = @caretaker_id,
                            enclosure_id = @enclosure_id
                         WHERE id = @id", connection);
                    cmd.Parameters.AddWithValue("id", animalId.Value);
                }
                else
                {
                    cmd = new NpgsqlCommand(@"INSERT INTO pm_11.animal 
                            (name, number, arrival_date, species_id, caretaker_id, enclosure_id) 
                         VALUES 
                            (@name, @number, @arrival_date, @species_id, @caretaker_id, @enclosure_id)", connection);
                }

                cmd.Parameters.AddWithValue("name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("number", (int)numNumber.Value);
                cmd.Parameters.AddWithValue("arrival_date", dtpArrivalDate.Value.Date);
                cmd.Parameters.AddWithValue("species_id", (int)cmbSpecies.SelectedValue);
                cmd.Parameters.AddWithValue("caretaker_id", (int)cmbCaretaker.SelectedValue);
                cmd.Parameters.AddWithValue("enclosure_id", (int)cmbEnclosure.SelectedValue);

                cmd.ExecuteNonQuery();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}