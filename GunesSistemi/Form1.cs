using GunesSistemi.Models;
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

            //MessageBox.Show(nameof(GokCismiBase)); // "GokCismiBase"

            if (gokCismi.GetType() == typeof(Yildiz))
            {
                Yildiz yildiz = gokCismi as Yildiz; // gokCismi as Yildiz: (Yildiz)gokCismi
                MessageBox.Show($"Id: {yildiz.Id}\nAd�: {yildiz.Adi}\nYar� �ap: {yildiz.YariCap}\nS�cakl�k: {yildiz.SicaklikC} C ({yildiz.SicaklikF} F)", nameof(Yildiz));
            }
            else if (gokCismi.GetType() == typeof(Gezegen))
            {
                Gezegen gezegen = gokCismi as Gezegen;
                string yasam = gezegen.YasamVarMi ? "Var" : "Yok";
                MessageBox.Show($"Id: {gezegen.Id}\nAd�: {gezegen.Adi}\nYar� �ap: {gezegen.YariCap}\nYa�am: {yasam}", nameof(Gezegen));
            }
            else
            {
                Uydu uydu = gokCismi as Uydu;
                MessageBox.Show($"Id: {uydu.Id}\nAd�: {uydu.Adi}\nYar� �ap: {uydu.YariCap}", nameof(Uydu));
            }
        }
    }
}