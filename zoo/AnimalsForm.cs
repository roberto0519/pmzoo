using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace zoo
{
    public partial class AnimalsForm : Form
    {
        private DBContext _context;

        public AnimalsForm()
        {
            InitializeComponent();
            _context = new DBContext();
            LoadSpecies();
            LoadAnimals();
        }

        private void LoadAnimals()
        {
            var query = _context.Animals
                .Include(a => a.Species)
                .Include(a => a.Caretaker)
                .Include(a => a.Enclosure)
                .AsQueryable();

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                query = query.Where(a => EF.Functions.ILike(a.Name, $"%{txtSearch.Text}%"));
            }

            if (cmbSpecies.SelectedIndex >= 0)
            {
                int selectedSpeciesId = Convert.ToInt32(cmbSpecies.SelectedValue);
                query = query.Where(a => a.SpeciesId == selectedSpeciesId);
            }

            var animals = query.Select(a => new
            {
                a.Id,
                Имя = a.Name,
                Номер = a.Number,
                Дата_прибытия = a.ArrivalDate,
                Вид = a.Species.Name,
                Смотритель = a.Caretaker.FullName,
                Вольер = a.Enclosure.Name
            }).ToList();

            animalsGridView.DataSource = animals;
        }

        private void LoadSpecies()
        {
            var speciesList = _context.Species.ToList();
            cmbSpecies.DataSource = speciesList;
            cmbSpecies.DisplayMember = "Name";
            cmbSpecies.ValueMember = "Id";
            cmbSpecies.SelectedIndex = -1;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAnimals();
        }

        private void cmbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAnimals();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AnimalEditForm();
            if (form.ShowDialog() == DialogResult.OK) LoadAnimals();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (animalsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите животное");
                return;
            }

            int id = (int)animalsGridView.SelectedRows[0].Cells["Id"].Value;
            var form = new AnimalEditForm(id);
            if (form.ShowDialog() == DialogResult.OK) LoadAnimals();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (animalsGridView.SelectedRows.Count == 0) return;

            int id = (int)animalsGridView.SelectedRows[0].Cells["Id"].Value;

            if (MessageBox.Show("Удалить животное?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var animal = _context.Animals.Find(id);
                if (animal != null)
                {
                    _context.Animals.Remove(animal);
                    _context.SaveChanges();
                }

                LoadAnimals();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
