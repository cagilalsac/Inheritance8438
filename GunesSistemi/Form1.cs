using GunesSistemi.Models.Bases;
using GunesSistemi.Services;
using GunesSistemi.Services.Bases;

namespace GunesSistemi
{
    public partial class Form1 : Form
    {
        IGokCismiService _servis = new GokCismiService();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GokCismiBase[] gokCisimleri = _servis.Listele();
            
            dgvGokCisimleri.DataSource = gokCisimleri;
            dgvGokCisimleri.ClearSelection();
        }

        private void dgvGokCisimleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvGokCisimleri.SelectedRows[0].Cells[0].Value);
            GokCismiBase gokCismi = _servis.DetayGetir(id);
            MessageBox.Show($"Id: {gokCismi.Id}\nAdý: {gokCismi.Adi}\nYarý Çap: {gokCismi.YariCap}");
        }
    }
}