using HotelCrown.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCrown.UI
{
    public partial class FrmReservation : Form
    {

        readonly Context context;
        readonly Reservation reservation;
        readonly Calendar calendar = new GregorianCalendar(); 
        readonly List<Button> btnSelecteds = new List<Button>();    
        readonly List<int> years = new List<int>() { DateTime.Now.Year, DateTime.Now.Year + 1, DateTime.Now.Year + 2 };
        readonly List<int> months = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        readonly List<Reservation> nextReservations;
        List<ReservationService> reservationServices;
        Button btnSelected;

        public FrmReservation(Context context, Reservation reservation)
        {
            InitializeComponent();
            this.context = context;
            this.reservation = reservation;

            nextReservations = context.Reservations.Where(x => x.CheckInDate > reservation.CheckOutDate && x.RoomId == reservation.RoomId).ToList();

            lblCheckInDate2.Text = reservation.CheckInDate.ToString("d.M.y");
            lblCheckOutDate2.Text = reservation.CheckOutDate.ToString("d.M.y");
            lblRoomName2.Text = reservation.Room.RoomName;
            
            dgvCustomers.AutoGenerateColumns = false;
            dgvServices.AutoGenerateColumns = false;
            dgvCustomers.DataSource = reservation.Customers.ToList();

            cmbYears.DataSource = years;
            cmbYears.SelectedItem = reservation.CheckOutDate.Year;
            cmbMonths.DataSource = months;
            cmbMonths.SelectedItem = reservation.CheckOutDate.Month;

            ListServicesDGV();
            ListServicesCMB();
            CalculatePrices();
            CreateCalendar();

            if (reservation.IsPaid)
            {
                btnGetPaid.Enabled = false;
                btnGetPaidAndCheckOut.Enabled = false;
                btnReservationCancel.Enabled = false;
                btnChangeCheckOutDate.Visible = false;
                gb.Visible = false;
                if(reservation.ReservationServices != null)
                {
                    if(!reservation.IsPaidServices)
                    {
                        btngetPaidServicesAndCheckOut.Enabled = true;
                    } 
                    else
                    {
                        btngetPaidServicesAndCheckOut.Enabled = false;
                    }    
                } 
                else
                {
                    btngetPaidServicesAndCheckOut.Enabled = true;
                }
            }

            if(reservation.IsPaid && !reservation.IsPaidServices && reservation.CheckedOutTime == null && reservation.ReservationServices != null)
            {
                btngetPaidServicesAndCheckOut.Enabled = true;
            }
            
            if(reservation.CheckedInTime != null)
            {
                btnReservationCancel.Enabled = false;
                btnGetPaid.Enabled = false;
                btnCheckedIn.Enabled = false;
            }
            else
            {
                btngetPaidServicesAndCheckOut.Enabled = false;
                btnGetPaidAndCheckOut.Enabled = false;
            }

            if(reservation.CheckedOutTime != null)
            {
                btnGetPaid.Enabled = false;
                btnGetPaidAndCheckOut.Enabled = false;
                btnReservationCancel.Enabled = false;
                btngetPaidServicesAndCheckOut.Enabled = false;
                btngetPaidServicesAndCheckOut.Enabled = false;
                btnAddService.Enabled = false;
                btnChangeCheckOutDate.Visible = false;
                gb.Visible = false;
            }
        }

        private void ListServicesDGV()
        {
            reservationServices = context.ReservationServices.Where(x => x.ReservationId == reservation.Id).ToList();
            dgvServices.DataSource = null;
            dgvServices.DataSource = reservationServices;
        }

        private void ListServicesCMB()
        {
            cmbServices.DataSource = context.Services.ToList();
            cmbServices.DisplayMember = "ServiceName";
            cmbServices.ValueMember = "Id";
        }

        private void CalculatePrices()
        {
            decimal rooomPrice = 0;
            decimal servicePrices = 0;

            reservationServices = context.ReservationServices.Where(x => x.ReservationId == reservation.Id).ToList();

            rooomPrice = (reservation.Room.Price * (reservation.CheckOutDate.AddHours(2) - reservation.CheckInDate).Days);

            foreach (ReservationService reservationService in reservationServices)
            {
                servicePrices += reservationService.UnitPrice * reservationService.Quantity;
            }

            lblRoomPrice2.Text = rooomPrice + " ₺";
            lblServicePrices2.Text = servicePrices + " ₺";
            lblTotalPrice2.Text = (rooomPrice + servicePrices) + " ₺";
            
            if(reservation.IsPaid)
            {
                lblRoomPrice2.Text += " (Ödendi)";
            }
            if(reservation.IsPaidServices)
            {
                lblServicePrices2.Text += " (Ödendi)";
            }
            if(reservation.IsPaid && reservation.IsPaidServices)
            {
                lblTotalPrice2.Text += " (Ödendi)";
            }
        }

        private void BtnAddService_Click(object sender, EventArgs e)
        {
            Service service = (Service)cmbServices.SelectedItem;

            ReservationService reservationService = new ReservationService
            {
                ReservationId = reservation.Id,
                ServiceId = service.Id,
                ServiceName = service.ServiceName,
                UnitPrice = service.UnitPrice,
                Quantity = 1
            };

            context.ReservationServices.Add(reservationService);
            context.SaveChanges();

            ListServicesDGV();
            CalculatePrices();
        }

        private void BtnCheckedIn_Click(object sender, EventArgs e)
        {
            reservation.CheckedInTime = DateTime.Now;
            context.SaveChanges();

            btnCheckedIn.Enabled = false;
            
            Close();
        }

        private void BtnGetPaid_Click(object sender, EventArgs e)
        {
            reservation.IsPaid = true;
            context.SaveChanges();

            btnGetPaid.Enabled = false;
            btnGetPaidAndCheckOut.Enabled = false;
            btnReservationCancel.Enabled = false;
            btnChangeCheckOutDate.Visible = false;
            gb.Visible = false;
            if (reservation.CheckedInTime != null)
            {
                btngetPaidServicesAndCheckOut.Enabled = true;
                btngetPaidServicesAndCheckOut.Enabled = true;
            }
            CalculatePrices();
        }

        private void BtnGetPaidServicesAndCheckOut_Click(object sender, EventArgs e)
        {
            reservation.IsPaidServices = true;
            reservation.CheckedOutTime = DateTime.Now;
            context.SaveChanges();

            btngetPaidServicesAndCheckOut.Enabled = false;
            btnAddService.Enabled = false;
            btnChangeCheckOutDate.Visible = false;
            gb.Visible = false;

            CalculatePrices();
            Close();
        }

        private void BtnGetPaidAndCheckOut_Click(object sender, EventArgs e)
        {
            reservation.IsPaid = true;
            reservation.IsPaidServices = true;
            reservation.CheckedOutTime = DateTime.Now;
            if (reservation.ReservationServices == null)
            {
                reservation.IsPaidServices = true;
            }
            context.SaveChanges();

            btnGetPaid.Enabled = false;
            btnGetPaidAndCheckOut.Enabled = false;
            btnReservationCancel.Enabled = false;
            btngetPaidServicesAndCheckOut.Enabled = false;
            btnAddService.Enabled = false;
            btnChangeCheckOutDate.Visible = false;
            gb.Visible = false;

            CalculatePrices();
            Close();
        }

        private void BtnReservationCancel_Click(object sender, EventArgs e)
        {
            context.Reservations.Remove(reservation);
            context.SaveChanges();

            Close();
        }

        private void DgvServices_KeyDown(object sender, KeyEventArgs e)
        {
            if(dgvServices.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvServices.SelectedRows[0];
                ReservationService reservationService = (ReservationService)row.DataBoundItem;

                if (e.KeyCode == Keys.Delete && !reservation.IsPaidServices)
                {
                    context.ReservationServices.Remove(reservationService);
                    context.SaveChanges();

                    ListServicesDGV();
                    CalculatePrices();
                }
            }
        }

        private void CreateCalendar()
        {
            pnlIn.Controls.Clear();
            int daysInMonth = calendar.GetDaysInMonth((int)cmbYears.SelectedItem, (int)cmbMonths.SelectedItem);
            int counter = 1;
            for (int i = 0; i < (int)Math.Ceiling((decimal)daysInMonth / 7); i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (counter <= daysInMonth)
                    {
                        CreateCalendarDay(counter, i, j);
                        counter++;
                    }
                }
            }
        }

        private void CreateCalendarDay(int counter, int i, int j)
        {            
            Button btnDay;
            btnDay = new Button
            {
                BackColor = Color.DarkGray,
                ForeColor = Color.White,
                Size = new Size(24, 24),
                Left = 3 + 25 * j,
                Top = 25 * i,
                Text = counter.ToString(),
                Font = new Font("Arial", 5, FontStyle.Regular),
                Tag = new DateTime((int)cmbYears.SelectedItem, (int)cmbMonths.SelectedItem, counter, 12, 0, 0)
            };
            pnlIn.Controls.Add(btnDay);
            btnDay.Click += BtnDay_Click;

            foreach (Reservation nextReservation in nextReservations)
            {
                DateTime dt = (DateTime)btnDay.Tag;

                if (dt <= reservation.CheckOutDate || dt.AddHours(2) >= nextReservation.CheckInDate || dt <= DateTime.Now)
                {
                    btnDay.Enabled = false;
                    btnDay.BackColor = Color.Orange;
                }
            }

            if(nextReservations.Count < 1)
            {
                DateTime dt = (DateTime)btnDay.Tag;
                if (dt <= reservation.CheckOutDate)
                {
                    btnDay.Enabled = false;
                    btnDay.BackColor = Color.Orange;
                }
            }
        }

        private void BtnDay_Click(object sender, EventArgs e)
        {  
            btnSelected = (Button)sender;
            btnSelecteds.Add(btnSelected);
            for (int i=0; i < btnSelecteds.Count; i++)
            {
                btnSelecteds[btnSelecteds.Count - 1].BackColor = Color.Blue;

                if(i < btnSelecteds.Count - 1)
                {
                    btnSelecteds[i].BackColor = Color.DarkGray;
                }
            }
            if(!reservation.IsPaid)
            {
                btnChangeCheckOutDate.Enabled = true;
            }
        }

        private void CmbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMonths.DataSource = months;
            cmbMonths.SelectedItem = reservation.CheckOutDate.Month;
            CreateCalendar();
        }

        private void CmbMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateCalendar();
        }

        private void BtnChangeCheckOutDate_Click(object sender, EventArgs e)
        {
            reservation.CheckOutDate = new DateTime((int)cmbYears.SelectedItem, (int)cmbMonths.SelectedItem, Convert.ToInt32(btnSelected.Text), 12, 0, 0);
            context.SaveChanges();

            MessageBox.Show("Rezervasyon çıkış tarihi ileri bir tarihe alınmıştır.");

            Close();
        }
    }
}


