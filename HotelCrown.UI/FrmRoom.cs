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
    public partial class FrmRoom : Form
    {
        readonly Context context;
        readonly Room room;
        readonly FrmMain frmMain;

        public FrmRoom(Context context, Room room, FrmMain frmMain)
        {
            InitializeComponent();
            this.context = context;
            this.room = room;
            this.frmMain = frmMain;
            dgv.AutoGenerateColumns = false;

            this.Text = room.RoomName;
            lblRoomName2.Text = room.RoomName;
            lblCapacity2.Text = room.Capacity.ToString();
            lblPrice2.Text = room.Price.ToString() + " ₺";
            ListRoomFeatures();
        }

        private void UpdateRoom_Click(object sender, EventArgs e)
        {
            FrmAddUpdateRoom frmAddUpdateRoom = new FrmAddUpdateRoom(context, room, frmMain);
            frmAddUpdateRoom.ShowDialog();
            Close();
        }

        private void BtnAddReservation_Click(object sender, EventArgs e)
        {
            FrmAddReservation frmAddUpdateReservation = new FrmAddReservation(context, room);
            frmAddUpdateReservation.ShowDialog();
        }

        private void ListRoomFeatures()
        {
            dgv.DataSource = null;
            dgv.DataSource = room.Features.ToList();
        }
    }
}
