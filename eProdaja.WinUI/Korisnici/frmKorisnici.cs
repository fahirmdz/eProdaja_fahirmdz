﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja.Model.Requests;
using Flurl.Http;


namespace eProdaja.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _apiService=new APIService("korisnici");

        public frmKorisnici()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest
            {
                Ime=txtPretragaKorisnika.Text
            };
            dgrvKorisnici.AutoGenerateColumns = false;
            dgrvKorisnici.DataSource = await _apiService.Get<List<Model.Korisnik>>(search);
        }

        private void dgrvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgrvKorisnici.SelectedRows[0].Cells[0].Value;
            var frm = new frmKorisniciDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private void dgrvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
