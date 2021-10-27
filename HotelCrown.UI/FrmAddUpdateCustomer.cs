using HotelCrown.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCrown.UI
{
    public partial class FrmAddUpdateCustomer : Form
    {
        readonly Context context;
        Customer customer;

        public FrmAddUpdateCustomer(Context context)
        {
            InitializeComponent();
            this.context = context;
        }

        public FrmAddUpdateCustomer(Context context, Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            this.context = context;
            btnDelete.Visible = true;

            cbLocalPerson.Checked = customer.Local;
            txtFullName.Text = customer.FullName;
            txtIdentityNumber.Text = customer.IdentityNumber;
            txtPhoneNumber.Text = customer.PhoneNumber;
            dtpBirthDate.Value = customer.BirthDate;
            cbMale.Checked = customer.Gender;
            rtxtDescription.Text = customer.Description;

            btnSaveUpdate.Text = "Güncelle";
            this.Text = "Müşteri Güncelle";
        }

        private void BtnSaveUpdate_Click(object sender, EventArgs e)
        {
            if(customer == null)
            {
                customer = new Customer
                {
                    Local = cbLocalPerson.Checked,
                    FullName = txtFullName.Text.Trim(),
                    IdentityNumber = txtIdentityNumber.Text.Trim(),
                    PhoneNumber = txtPhoneNumber.Text.Trim(),
                    BirthDate = dtpBirthDate.Value,
                    Gender = cbMale.Checked,
                    Description = rtxtDescription.Text.Trim()
                };

                if (txtFullName.Text.Trim() == string.Empty || txtIdentityNumber.Text.Trim() == string.Empty || txtPhoneNumber.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("* ile işaretli tüm alanları eksiksiz doldurunuz!");
                } 
                else
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                    Close();
                }
            } 
            else
            {
                customer.Local = cbLocalPerson.Checked;
                customer.FullName = txtFullName.Text.Trim();
                customer.IdentityNumber = txtIdentityNumber.Text.Trim();
                customer.PhoneNumber = txtPhoneNumber.Text.Trim();
                customer.BirthDate = dtpBirthDate.Value;
                customer.Gender = cbMale.Checked;
                customer.Description = rtxtDescription.Text.Trim();

                if (txtFullName.Text.Trim() == string.Empty || txtIdentityNumber.Text.Trim() == string.Empty || txtPhoneNumber.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("* ile işaretli tüm alanları eksiksiz doldurunuz!");
                }
                else
                {
                    context.SaveChanges();
                    Close();
                }
            }
        }

        private void CbLocalPerson_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLocalPerson.Checked)
            {
                cbForeignPerson.Checked = false;
                lblIdentityNumber.Text = "Kimlik No:";
            }
            else
                cbForeignPerson.Checked = true;
        }

        private void CbForeignPerson_CheckedChanged(object sender, EventArgs e)
        {
            if (cbForeignPerson.Checked)
            {
                cbLocalPerson.Checked = false;
                lblIdentityNumber.Text = "Pasaport No:";
            }
            else
                cbLocalPerson.Checked = true;
        }

        private void CbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMale.Checked)
                cbFemale.Checked = false;
            else
                cbFemale.Checked = true;
        }

        private void CbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFemale.Checked)
                cbMale.Checked = false;
            else
                cbMale.Checked = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
            Close();
        }

        private void TxtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPhoneNumber.Text.Length > 69)
            {
                MessageBox.Show("Ad 70 karakterden büyük olamaz!");
                e.Handled = true;
            }
        }

        private void TxtIdentityNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtPhoneNumber.Text.Length > 10)
            {
                MessageBox.Show("Kimlik / Pasaport No 11 haneden büyük olamaz!");
                e.Handled = true;
            }
        }

        private void TxtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if(txtPhoneNumber.Text.Length > 14)
            {
                MessageBox.Show("Telefon Numarası 15 haneden büyük olamaz!");
                e.Handled = true;
            }
        }
    }
}
