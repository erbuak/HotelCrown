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
    public partial class FrmAddReservation : Form
    {
        readonly Context context;
        readonly Room room;
        readonly List<Reservation> reservations;
        readonly List<Button> btnSelectedsIn = new List<Button>();  
        readonly List<Button> btnSelectedsOut = new List<Button>();
        readonly List<Customer> selectedCustomers = new List<Customer>();
        readonly Calendar calendar = new GregorianCalendar();
        readonly List<int> years = new List<int>() { DateTime.Now.Year, DateTime.Now.Year + 1, DateTime.Now.Year + 2 };
        readonly List<int> yearsOut = new List<int>() { DateTime.Now.Year, DateTime.Now.Year + 1, DateTime.Now.Year + 2 };
        readonly List<int> months = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        readonly List<int> monthsOut = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        readonly Button selectedButtonIn = new Button();
        Customer customer;
        Reservation reservation;
        DateTime checkInDate;
        DateTime checkOutDate;
        Button btnSelectedIn;
        Button btnSelectedOut;
        List<Reservation> nextReservations;
        List<Customer> customers;

        public FrmAddReservation(Context context, Room room)
        {
            InitializeComponent();

            this.context = context;
            this.room = room;

            reservations = context.Reservations.Where(x => x.RoomId == room.Id).ToList();

            dgvCustomers.AutoGenerateColumns = false;
            dgvSelectedCustomers.AutoGenerateColumns = false;

            customers = context.Customers.ToList();

            ListCustomers();

            lblRoomName2.Text = room.RoomName;
            selectedButtonIn.Tag = DateTime.Now.Day;

            cmbYearsIn.DataSource = years;
            cmbYearsIn.SelectedItem = DateTime.Now.Year;
            cmbMonthsIn.DataSource = months;
            cmbMonthsIn.SelectedItem = DateTime.Now.Month;

            cmbYearsOut.DataSource = yearsOut;
            cmbYearsOut.SelectedItem = DateTime.Now.Year;
            cmbMonthsOut.DataSource = monthsOut;
            cmbMonthsOut.SelectedItem = DateTime.Now.Month;

            CreateCalendarIn();
        }

        private void TxtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            customers = context.Customers.Where(x => x.IdentityNumber.Contains(txtSearchCustomer.Text) || x.FullName.Contains(txtSearchCustomer.Text)).ToList();
            ListCustomers();
        }

        private void ListCustomers()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = customers;
        }

        private void ListSelectedCustomers()
        {
            dgvSelectedCustomers.DataSource = null;
            dgvSelectedCustomers.DataSource = selectedCustomers;
        }

        private void DgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCustomers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCustomers.SelectedRows[0];
                customer = (Customer)row.DataBoundItem;
                customers.Remove(customer);
                selectedCustomers.Add(customer);
                ListCustomers();
                ListSelectedCustomers();
            }
        }

        private void DgvSelectedCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvSelectedCustomers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSelectedCustomers.SelectedRows[0];
                customer = (Customer)row.DataBoundItem;
                selectedCustomers.Remove(customer);
                customers.Add(customer);
                ListCustomers();
                ListSelectedCustomers();
            }
        }

        private void CreateCalendarIn()
        {
            pnlIn.Controls.Clear();
            int daysInMonth = calendar.GetDaysInMonth((int)cmbYearsIn.SelectedItem, (int)cmbMonthsIn.SelectedItem);
            int counter = 1;
            for (int i = 0; i < (int)Math.Ceiling((decimal)daysInMonth / 7); i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (counter <= daysInMonth)
                    {
                        CreateCalendarDayIn(counter, i, j);
                        counter++;
                    }
                }
            }
        }

        private void CreateCalendarDayIn(int counter, int i, int j)
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
                Tag = new DateTime((int)cmbYearsIn.SelectedItem, (int)cmbMonthsIn.SelectedItem, counter, 12, 0, 0)
            };
            pnlIn.Controls.Add(btnDay);
            btnDay.Click += BtnDayIn_Click;

            DateTime dt = (DateTime)btnDay.Tag;

            if (reservations.Count > 0) 
            {
                foreach (Reservation reservation in reservations)
                {
                    if (dt < reservation.CheckOutDate && dt.AddHours(2) >= reservation.CheckInDate || dt < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59))
                    {
                        btnDay.Enabled = false;
                        btnDay.BackColor = Color.Orange;
                    }
                }
            } 
            else
            {
                if (dt < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59))
                {
                    btnDay.Enabled = false;
                    btnDay.BackColor = Color.Orange;
                }
            }
        }

        private void BtnDayIn_Click(object sender, EventArgs e)
        {
            btnSelectedIn = (Button)sender;
            btnSelectedsIn.Add(btnSelectedIn);
            for (int i = 0; i < btnSelectedsIn.Count; i++)
            {
                btnSelectedsIn[btnSelectedsIn.Count - 1].BackColor = Color.Blue;

                if (i < btnSelectedsIn.Count - 1)
                {
                    btnSelectedsIn[i].BackColor = Color.DarkGray;
                }
            }

            pnlOut.Enabled = true;
            checkInDate = (DateTime)btnSelectedIn.Tag;
            checkInDate = checkInDate.AddHours(2);
            lblDates2.Text = checkInDate.ToString("d.M.y");

            nextReservations = context.Reservations.Where(x => x.CheckInDate > checkInDate && x.RoomId == room.Id).ToList();
            lblInfo.Text = "";
            CreateCalendarOut();

        }

        private void CreateCalendarOut()
        {
            pnlOut.Controls.Clear();
            int daysInMonth = calendar.GetDaysInMonth((int)cmbYearsOut.SelectedItem, (int)cmbMonthsOut.SelectedItem);
            int counter = 1;
            for (int i = 0; i < (int)Math.Ceiling((decimal)daysInMonth / 7); i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (counter <= daysInMonth)
                    {
                        CreateCalendarDayOut(counter, i, j);
                        counter++;
                    }
                }
            }
        }

        private void CreateCalendarDayOut(int counter, int i, int j)
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
                Tag = new DateTime((int)cmbYearsOut.SelectedItem, (int)cmbMonthsOut.SelectedItem, counter, 12, 0, 0)
            };
            pnlOut.Controls.Add(btnDay);
            btnDay.Click += BtnDayOut_Click;

            DateTime dt = (DateTime)btnDay.Tag;

            if (reservations.Count > 0)
            {
                foreach (Reservation reservation in reservations)
                {
                    if (dt < reservation.CheckOutDate && dt.AddHours(2) > reservation.CheckInDate || dt < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59) || (DateTime)btnSelectedIn.Tag >= dt)
                    {
                        btnDay.Enabled = false;
                        btnDay.BackColor = Color.Orange;
                    }
                }
            } 
            else
            {
                if(dt < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59) || (DateTime)btnSelectedIn.Tag >= dt)
                {
                    btnDay.Enabled = false;
                    btnDay.BackColor = Color.Orange;
                }
            }

            if(nextReservations.Count > 0)
            {
                foreach (Reservation nextReservation in nextReservations)
                {
                    if (dt.AddHours(2) > nextReservation.CheckInDate)
                    {
                        btnDay.Enabled = false;
                        btnDay.BackColor = Color.Orange;
                    }
                }
            }
        }

        private void BtnDayOut_Click(object sender, EventArgs e)
        {
            btnSelectedOut = (Button)sender;
            btnSelectedsOut.Add(btnSelectedOut);
            for (int i = 0; i < btnSelectedsOut.Count; i++)
            {
                btnSelectedsOut[btnSelectedsOut.Count - 1].BackColor = Color.Blue;

                if (i < btnSelectedsOut.Count - 1)
                {
                    btnSelectedsOut[i].BackColor = Color.DarkGray;
                }
            }

            checkOutDate = (DateTime)btnSelectedOut.Tag;
            lblDates2.Text += " - " + checkOutDate.ToString("d.M.y");
            int reservationDays = (checkOutDate.AddHours(2) - checkInDate).Days;
            lblInfo.Visible = true;
            lblInfo.Text = (reservationDays+1) + " gece " + reservationDays + " gün!";
        }

        private void CmbYearsIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMonthsIn.DataSource = months;
            cmbMonthsIn.SelectedItem = DateTime.Now.Month;
            CreateCalendarIn();
        }

        private void CmbMonthsIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateCalendarIn();
        }

        private void CmbYearsOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(btnSelectedIn != null) { 
            cmbMonthsOut.DataSource = months;
            cmbMonthsOut.SelectedItem = cmbMonthsOut.SelectedItem;
            CreateCalendarOut();
            }
        }

        private void CmbMonthsOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnSelectedIn != null)
            {
                CreateCalendarOut();
            }
        }

        private void BtnSaveReservation_Click(object sender, EventArgs e)
        {
            if(customer == null)
            {
                MessageBox.Show("Rezervasyon sahibi seçimini yapınız!");
            } 
            else if(checkOutDate.Year == 1 || checkOutDate.Year == 1)
            {
                MessageBox.Show("Rezervasyon giriş ve çıkış tarihlerini belirleyiniz.!");
            } else
            {

                reservation = new Reservation
                {
                    RoomId = room.Id,
                    Customers = selectedCustomers,
                    CheckInDate = checkInDate,
                    CheckOutDate = checkOutDate
                };

                context.Reservations.Add(reservation);
                context.SaveChanges();

                Close();
            }
        }
    }
}