using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja.Model;

namespace eProdaja.WinUI.Proizvodi
{
    public partial class frmProizvodi : Form
    {
        private readonly APIService _vrsteProizvoda = new APIService("VrsteProizvoda");
        private readonly APIService _jediniceMjere = new APIService("JediniceMjere");

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
            result.Insert(0,new VrsteProizvoda());
            cmbVrstaProizvoda.DataSource = result;
            cmbVrstaProizvoda.DisplayMember = nameof(VrsteProizvoda.Naziv);
            cmbVrstaProizvoda.ValueMember = nameof(VrsteProizvoda.VrstaId);
        }

        private async Task LoadJediniceMjere()
        {
            var result = await _jediniceMjere.Get<List<JediniceMjere>>(null);
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
    }
}
