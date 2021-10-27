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
    public partial class FrmCustomers : Form
    {

        readonly Context context;

        public FrmCustomers(Context context)
        {
            InitializeComponent();          
            this.context = context;
            dgv.AutoGenerateColumns = false;
            ListCustomers();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmAddUpdateCustomer frmAddUpdateCustomer = new FrmAddUpdateCustomer(context);
            frmAddUpdateCustomer.ShowDialog();

            dgv.DataSource = null;
            dgv.DataSource = context.Customers.ToList();
        }

        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                Customer customer = (Customer)row.DataBoundItem;

                FrmAddUpdateCustomer frmAddUpdateCustomer = new FrmAddUpdateCustomer(context, customer);
                frmAddUpdateCustomer.ShowDialog();
                ListCustomers();
            }
        }

        private void ListCustomers() 
        {
            dgv.DataSource = null;
            dgv.DataSource = context.Customers.ToList();
        }
    }
}
