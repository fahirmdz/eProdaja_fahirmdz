using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja.Model;
using eProdaja.Model.Requests;

namespace eProdaja.WinUI.Proizvodi
{
    public partial class frmProizvodi : Form
    {
        private readonly APIService _vrsteProizvoda = new APIService("VrsteProizvoda");
        private readonly APIService _jediniceMjere = new APIService("JediniceMjere");
        private readonly APIService _proizvodi = new APIService("Proizvod");


        public frmProizvodi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private async Task LoadVrsteProizvoda()
        {
            var result = await _vrsteProizvoda.Get<List<Model.VrsteProizvoda>>(null);
            if (!result.Any())
                result.Insert(0, new VrsteProizvoda());
            cmbVrstaProizvoda.DataSource = result;
            cmbVrstaProizvoda.DisplayMember = nameof(VrsteProizvoda.Naziv);
            cmbVrstaProizvoda.ValueMember = nameof(VrsteProizvoda.VrstaId);
        }

        private async Task LoadJediniceMjere()
        {
            var result = await _jediniceMjere.Get<List<JediniceMjere>>(null);
            if (!result.Any())
                result.Insert(0,new JediniceMjere());
            cmbJedMjere.DataSource = result;
            cmbJedMjere.DisplayMember = nameof(JediniceMjere.Naziv);
            cmbJedMjere.ValueMember = nameof(JediniceMjere.JedinicaMjereId);
        }

        private async void frmProizvodi_Load(object sender, EventArgs e)
        {
            await LoadJediniceMjere();
            await LoadVrsteProizvoda();
        }

        private async void cmbVrstaProizvoda_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVrstaProizvoda.SelectedValue;

            if (int.TryParse(idObj.ToString(),out int id))
            {
                await LoadProizvodi(id);
            }
        }

        private async Task LoadProizvodi(int vrstaId)
        {
            var result = await _proizvodi.Get<List<Model.Proizvod>>(new ProizvodSearchRequest{VrstaId = vrstaId});

            proizvodGrid.DataSource = result;
        }

        ProizvodUpsertRequest request = new ProizvodUpsertRequest();

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var vrstaIdObj = cmbVrstaProizvoda.SelectedValue;
            if (int.TryParse(vrstaIdObj.ToString(), out int vrstaId))
            {
                request.VrstaId = vrstaId;
            }

            var jedinicaMjereIdObj = cmbJedMjere.SelectedValue;
            if (int.TryParse(jedinicaMjereIdObj.ToString(), out int jedinicaMjereId))
            {
                request.JedinicaMjereId = jedinicaMjereId;
            }

            request.Naziv = txtNaziv.Text;
            request.Sifra = txtSifra.Text;
            request.Cijena = decimal.Parse(txtCijena.Text);

            var entity = await _proizvodi.Insert<Model.Proizvod>(request);

            if (entity != null)
                MessageBox.Show("Uspjesno dodavanje proizvoda");

            cmbJedMjere.SelectedValue = request.JedinicaMjereId;
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                request.SlikaThumb = file;

                txtSlikaInput.Text = fileName;

                Image image = Image.FromFile(fileName);

                slikaProizvod.Image = image;
            }
        }
    }
}
