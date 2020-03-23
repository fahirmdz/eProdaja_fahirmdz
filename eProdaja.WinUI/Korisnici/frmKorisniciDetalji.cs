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
using eProdaja.Model.Requests;

namespace eProdaja.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        private  APIService _apiService = new APIService("Korisnici");
        private int? _id = null;

        public frmKorisniciDetalji(int? korisnikId=null)
        {
            _id = korisnikId;
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new KorisniciInsertRequest
                {
                    Email = txtEmail.Text,
                    Ime = txtIme.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPasswordPotvrda.Text,
                    Prezime = txtPrezime.Text,
                    Telefon = txtTelefon.Text
                };

                if (_id.HasValue)
                {
                    await _apiService.Update<Korisnik>(_id, request);
                }
                else
                {
                    await _apiService.Insert<Korisnik>(request);
                }

                MessageBox.Show("Operacija uspjesna");
                this.Close();
            }
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var korisnik = await _apiService.GetById<Korisnik>(_id);
                txtKorisnickoIme.Text = korisnik.KorisnickoIme;
                txtPrezime.Text = korisnik.Prezime;
                txtIme.Text = korisnik.Ime;
                txtEmail.Text = korisnik.Email;
                txtTelefon.Text = korisnik.Telefon; 
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme,Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme,null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }
    }
}
