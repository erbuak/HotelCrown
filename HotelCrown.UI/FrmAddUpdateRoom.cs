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
    public partial class FrmAddUpdateRoom : Form
    {
        readonly Context context;
        readonly List<Feature> selectedFeatures = new List<Feature>();
        readonly List<Feature> unSelectedFeatures = new List<Feature>();
        
        Room room;
        private event EventHandler UpdatedRoom;
        

        public FrmAddUpdateRoom(Context context)
        {
            InitializeComponent();
            this.context = context;
            dgv.AutoGenerateColumns = false;

            selectedFeatures = context.Features.Where(x => x.IsStandard == true).ToList();
            unSelectedFeatures = context.Features.Where(x => x.IsStandard == false).ToList();

            if(unSelectedFeatures.Count < 1)
            {
                cmbFeature.Enabled = false;
                btnSelect.Enabled = false;
            }

            ListFeaturesCMB();
            ListFeaturesGRD();
        }

        public FrmAddUpdateRoom(Context context, Room room, FrmMain frmMain)
        {
            InitializeComponent();
            this.context = context;
            this.room = room;
            this.Text = "Oda Güncelle";
            btnDelete.Visible = true;
            btnSaveUpdate.Text = "Güncelle";
            dgv.AutoGenerateColumns = false;

            UpdatedRoom += frmMain.RefreshFromOtherForm;

            unSelectedFeatures = context.Features.Where(x => x.IsStandard == false).ToList();

            if (unSelectedFeatures.Count < 1)
            {
                cmbFeature.Enabled = false;
                btnSelect.Enabled = false;
            }

            foreach (Feature feature in room.Features)
            {
                unSelectedFeatures.Remove(feature);
            }

            txtName.Text = room.RoomName;
            nudCapacity.Value = room.Capacity;
            nudPrice.Value = room.Price;
            selectedFeatures = room.Features.ToList();
            cmbFeature.DataSource = unSelectedFeatures;

            ListFeaturesCMB();
            ListFeaturesGRD();
        }

        private void BtnSaveUpdate_Click(object sender, EventArgs e)
        {
            if(room == null)
            {
                room = new Room
                {
                    RoomName = txtName.Text.Trim(),
                    Capacity = (int)nudCapacity.Value,
                    Price = nudPrice.Value,
                    Features = selectedFeatures
                };

                context.Rooms.Add(room);
                context.SaveChanges();
                Close();
            }
            else
            {
                room.RoomName = txtName.Text.Trim();
                room.Capacity = (int)nudCapacity.Value;
                room.Price = nudPrice.Value;
                room.Features = selectedFeatures;

                UpdatedRoom?.Invoke(this, EventArgs.Empty);

                context.SaveChanges();
                Close();
            }         
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            selectedFeatures.Add((Feature)cmbFeature.SelectedItem);
            unSelectedFeatures.Remove((Feature)cmbFeature.SelectedItem);
            if(unSelectedFeatures.Count > 0)
            {
                cmbFeature.SelectedItem = unSelectedFeatures[0];
            } 
            else
            {
                cmbFeature.Enabled = false;
                btnSelect.Enabled = false;
            }
            ListFeaturesCMB();
            ListFeaturesGRD();
        }

        private void ListFeaturesCMB()
        {
            cmbFeature.DataSource = null;
            cmbFeature.DataSource = unSelectedFeatures;
            cmbFeature.DisplayMember = "FeatureName";
            cmbFeature.ValueMember = "Id";
        }

        private void ListFeaturesGRD()
        {
            dgv.DataSource = null;
            if(selectedFeatures.Count > 0)
                dgv.DataSource = selectedFeatures;
        }

        private void Dgv_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridViewRow row = dgv.SelectedRows[0];
            Feature feature = (Feature)row.DataBoundItem;
            if (e.KeyCode == Keys.Delete)
            {
                if (!feature.IsStandard)
                {
                    unSelectedFeatures.Add(feature);
                    selectedFeatures.Remove(feature);
                    ListFeaturesCMB();
                    ListFeaturesGRD();

                    if(!btnSelect.Enabled)
                    {
                        cmbFeature.Enabled = true;
                        btnSelect.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Standart özellikler oda özelliklerinden çıkarılamaz.");
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            context.Rooms.Remove(room);
            context.SaveChanges();

            UpdatedRoom?.Invoke(this, EventArgs.Empty);

            Close();
        }
    }
}
