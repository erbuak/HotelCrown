using HotelCrown.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCrown.UI
{
    public partial class FrmServices : Form
    {

        readonly Context context;
        Service service;
        List<Service> services;
        string name;

        public FrmServices(Context context)
        {
            this.context = context;
            InitializeComponent();
            dgv.AutoGenerateColumns = false;
            ListingServices();        
        }

        public void ListingServices()
        {
            services = context.Services.ToList();
            dgv.DataSource = null;
            dgv.DataSource = services;

            txtName.Focus();
        }

        private void BtnSaveUpdate_Click(object sender, EventArgs e)
        {
            name = txtName.Text.Trim();
            if (name == string.Empty)
            {
                MessageBox.Show("Servis adı giriniz!");       
            } 
            else
            {
                if (btnSaveUpdate.Text == "Kaydet")
                {
                    service = new Service
                    {
                        ServiceName = txtName.Text,
                        UnitPrice = nudPrice.Value
                    };

                    context.Services.Add(service);
                    context.SaveChanges();

                    txtName.Text = string.Empty;
                    nudPrice.Value = 0;
                }
                else
                {
                    service.ServiceName = txtName.Text;
                    service.UnitPrice = nudPrice.Value;
                    context.SaveChanges();
                }
                ListingServices();
            }           
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            btnSaveUpdate.Text = "Kaydet";
            btnCancel.Visible = false;
            txtName.Text = string.Empty;
            txtName.Focus();
            nudPrice.Value = 0;
        }

        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                service = (Service)row.DataBoundItem;
                txtName.Text = service.ServiceName;
                nudPrice.Value = service.UnitPrice;
                btnSaveUpdate.Text = "Güncelle";
                btnCancel.Visible = true;
            }
        }

        private void Dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if(dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                service = (Service)row.DataBoundItem;

                if (e.KeyCode == Keys.Delete)
                {
                    context.Services.Remove(service);
                    context.SaveChanges();
                    ListingServices();
                }
            }
        }
    }
}
