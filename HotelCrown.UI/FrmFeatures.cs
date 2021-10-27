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
    public partial class FrmFeatures : Form
    {
        readonly Context context;
        Feature feature;
        List<Feature> features;
        string name;
        
        public FrmFeatures(Context context)
        {
            InitializeComponent();
            this.context = context;
            dgv.AutoGenerateColumns = false;
            ListingFeatures();
        }

        private void ListingFeatures()
        {
            features = context.Features.ToList();

            dgv.DataSource = null;
            dgv.DataSource = features;

            txtName.Focus();
        }

        private void BtnSaveUpdate_Click(object sender, EventArgs e)
        {
            name = txtName.Text.Trim();
            if (name == string.Empty)
            {
                MessageBox.Show("Özellik adı giriniz!");
            }
            else
            {
                if (btnSaveUpdate.Text == "Kaydet")
                {
                    feature = new Feature
                    {
                        FeatureName = txtName.Text,
                        IsStandard = cbIsStandard.Checked
                    };
                    context.Features.Add(feature);
                    context.SaveChanges();

                    txtName.Text = string.Empty;
                }
                else
                {
                    feature.FeatureName = txtName.Text;
                    feature.IsStandard = cbIsStandard.Checked;
                    context.SaveChanges();
                }
                ListingFeatures();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            btnSaveUpdate.Text = "Kaydet";
            btnCancel.Visible = false;
            txtName.Text = string.Empty;
            txtName.Focus();
        }

        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                feature = (Feature)row.DataBoundItem;
                txtName.Text = feature.FeatureName;
                cbIsStandard.Checked = feature.IsStandard;
                btnSaveUpdate.Text = "Güncelle";
                btnCancel.Visible = true;
            }
        }

        private void Dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                feature = (Feature)row.DataBoundItem;

                if (e.KeyCode == Keys.Delete)
                {
                    context.Features.Remove(feature);
                    context.SaveChanges();
                    ListingFeatures();
                }
            }
        }
    }
}
