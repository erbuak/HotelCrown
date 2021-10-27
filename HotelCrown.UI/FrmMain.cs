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
    public partial class FrmMain : Form
    {
        readonly Context context = new Context();
        List<Room> rooms;
        readonly List<int> capacities = new List<int>();
        List<Reservation> reservations = new List<Reservation>();

        public FrmMain()
        {
            InitializeComponent();
            ListRooms();
            ListCapacities();
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now.AddDays(1);
            rooms = context.Rooms.ToList();
        }

        private void MiReservations_Click(object sender, EventArgs e)
        {
            FrmReservations frmReservations = new FrmReservations(context);
            frmReservations.ShowDialog();
        }

        private void MiServices_Click(object sender, EventArgs e)
        {
            FrmServices frmServices = new FrmServices(context);
            frmServices.ShowDialog();
        }

        private void MiFeatures_Click(object sender, EventArgs e)
        {
            FrmFeatures frmFeatures = new FrmFeatures(context);
            frmFeatures.ShowDialog();
        }

        private void MiAddRooms_Click(object sender, EventArgs e)
        {
            FrmAddUpdateRoom frmAddUpdateRooms = new FrmAddUpdateRoom(context);
            frmAddUpdateRooms.ShowDialog();
            pnl.Controls.Clear();
            ListRooms();
        }

        private void MiCustomers_Click(object sender, EventArgs e)
        {
            FrmCustomers frmCustomers = new FrmCustomers(context);
            frmCustomers.ShowDialog();
        }

        public void RefreshFromOtherForm(object sender, EventArgs e)
        {
            ListRooms();
            ListCapacities();
        }

        private void ListRooms()
        {
            pnl.Controls.Clear();
            rooms = context.Rooms.ToList();
            int counter = 1;
            for(int i = 0; i < (int)Math.Ceiling((decimal)rooms.Count / 7); i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if(counter <= rooms.Count)
                    {
                        CreateRoomView(i, j, rooms[counter-1]);
                        counter++;
                    }   
                }
            }
        }

        private void ListCapacities()
        {
            cmbRoomCapacity.DataSource = null;
            capacities.Clear();
            foreach (Room room in rooms)
            {
                if (!capacities.Contains(room.Capacity))
                    capacities.Add(room.Capacity);
            }
            capacities.Sort();
            cmbRoomCapacity.DataSource = capacities;
        }

        private void ListRooms(List<Reservation> reservations)
        {
            pnl.Controls.Clear();
            if(capacities.Count > 0)
            {
                rooms = context.Rooms.Where(x => x.Capacity == (int)cmbRoomCapacity.SelectedItem).ToList();
            }
            

            foreach (Reservation reservation in reservations)
            {
                var room = context.Rooms.FirstOrDefault(x => x.Reservations.Any(y => y.RoomId == reservation.RoomId));
                rooms.Remove(room);
            }

            int counter = 1;
            for (int i = 0; i < (int)Math.Ceiling((decimal)rooms.Count / 7); i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (counter <= rooms.Count)
                    {
                        CreateRoomView(i, j, rooms[counter - 1]);
                        counter++;
                    }
                }
            }
        }

        private void CreateRoomView(int i,int j, Room room)
        {
            Label lbl = new Label
            {
                Size = new Size(100, 94),
                BackColor = Color.SkyBlue,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Left = j * 111,
                Top = i * 105,
                Text = room.RoomName,
                Tag = room
            };
            lbl.Click += Lbl_Click;
            pnl.Controls.Add(lbl);
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            FrmRoom frmRoom = new FrmRoom(context, (Room)lbl.Tag, this);
            frmRoom.ShowDialog();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            DateTime selectedCheckInDate = new DateTime(dtpCheckIn.Value.Year, dtpCheckIn.Value.Month, dtpCheckIn.Value.Day, 14, 0, 0);
            DateTime selectedCheckOutDate = new DateTime(dtpCheckOut.Value.Year, dtpCheckOut.Value.Month, dtpCheckOut.Value.Day, 12, 0, 0);

            reservations = context.Reservations.Where(x =>
                selectedCheckInDate >= x.CheckInDate && selectedCheckInDate < x.CheckOutDate
                ).ToList();

                ListRooms(reservations);
            btnCancelFilter.Visible = true;
        }

        private void DtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            if (new DateTime(dtpCheckIn.Value.Year, dtpCheckIn.Value.Month, dtpCheckIn.Value.Day)
                >= new DateTime(dtpCheckOut.Value.Year, dtpCheckOut.Value.Month, dtpCheckOut.Value.Day))
            {
                dtpCheckOut.Value = dtpCheckIn.Value.AddDays(1);
            }
        }

        private void DtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckIn.Value > dtpCheckOut.Value)
            {
                MessageBox.Show("Çıkış tarihi giriş tarihinden ilerde olmalıdır.");
                dtpCheckOut.Value = dtpCheckIn.Value.AddDays(1);
            }
        }

        private void BtnCancelFilter_Click(object sender, EventArgs e)
        {
            ListRooms();
            btnCancelFilter.Visible = false;
        }
    }
}


