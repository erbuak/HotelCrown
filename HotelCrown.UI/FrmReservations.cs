using HotelCrown.Data.DTOS;
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
    public partial class FrmReservations : Form
    {
        readonly Context context;
        readonly List<Reservation> reservations;
        readonly List<ReservationDTO> reservationDTOs = new List<ReservationDTO>();
        List<ReservationDTO> filteredReservationDTOs = new List<ReservationDTO>();
        string isCheckedIn = "Hayır";
        string isCheckedOut = "Hayır";

        public FrmReservations(Context context)
        {
            InitializeComponent();
            this.context = context;

            dgv.AutoGenerateColumns = false;

            reservations = context.Reservations.ToList();

            cmb.Items.Add("Giriş Tarihine Göre");
            cmb.Items.Add("Çıkış Tarihine Göre");
            cmb.SelectedIndex = 0;

            dtpFirst.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpLast.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month), 23, 59, 59);

            ListReservations(CreateResarvationDTO(reservations));
        }

        private void ListReservations(List<ReservationDTO> reservationDTOs)
        {
            dgv.DataSource = null;
            dgv.DataSource = reservationDTOs;
        }

        public List<ReservationDTO> CreateResarvationDTO(List<Reservation> reservations)
        {
            reservationDTOs.Clear();
            ReservationDTO reservationDTO;
            foreach (Reservation reservation in reservations)
            {
                reservationDTOs.Add(reservationDTO = new ReservationDTO()
                {
                    Reservation = reservation,
                    CheckInDate = reservation.CheckInDate,
                    CheckOutDate = reservation.CheckOutDate,
                    CheckedInTime = reservation.CheckedInTime,
                    CheckedOutTime = reservation.CheckedOutTime,
                    Customers = (List<Customer>)reservation.Customers,
                    Room = reservation.Room,
                });
            }

            return reservationDTOs;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            filteredReservationDTOs = reservationDTOs.Where(x => x.CustomersString.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            ListReservations(filteredReservationDTOs);
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            if(cmb.SelectedIndex == 0)
            {
                filteredReservationDTOs = reservationDTOs.
                    Where(x => x.CustomersString.
                    ToLower().
                    Contains(txtSearch.Text.ToLower())
                    && x.IsCheckedIn == isCheckedIn
                    && x.IsCheckedOut == isCheckedOut
                    && x.CheckInDate >= dtpFirst.Value
                    && x.CheckInDate <= dtpLast.Value
                    ).
                    ToList();
            } 
            else if (cmb.SelectedIndex == 1)
            {
                filteredReservationDTOs = reservationDTOs.
                    Where(x => x.CustomersString.
                    ToLower().
                    Contains(txtSearch.Text.ToLower())
                    && x.IsCheckedIn == isCheckedIn
                    && x.IsCheckedOut == isCheckedOut
                    && x.CheckOutDate >= dtpFirst.Value
                    && x.CheckOutDate <= dtpLast.Value
                    ).
                    ToList();
            }

            ListReservations(filteredReservationDTOs);
        }

        private void CbCheckIn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheckIn.Checked)
                isCheckedIn = "Evet";
            else
                isCheckedIn = "Hayır";
        }

        private void CbCheckOut_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheckOut.Checked)
                isCheckedOut = "Evet";
            else
                isCheckedOut = "Hayır";
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                ReservationDTO reservationDTO = (ReservationDTO)row.DataBoundItem;

                FrmReservation frmReservation = new FrmReservation(context, reservationDTO.Reservation);
                frmReservation.ShowDialog();

                ListReservations(CreateResarvationDTO(context.Reservations.ToList()));
            }
        }

        private void DtpFirst_ValueChanged(object sender, EventArgs e)
        {
            if (new DateTime(dtpFirst.Value.Year, dtpFirst.Value.Month, dtpFirst.Value.Day)
                >= new DateTime(dtpLast.Value.Year, dtpLast.Value.Month, dtpLast.Value.Day))
            {
                //dtpFirst.Value = dtpFirst.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtpLast.Value = new DateTime(dtpFirst.Value.Year, dtpFirst.Value.Month, DateTime.DaysInMonth(dtpFirst.Value.Year, dtpFirst.Value.Month), 23, 59, 59);
            }
        }

        private void DtpLast_ValueChanged(object sender, EventArgs e)
        {
            if (new DateTime(dtpFirst.Value.Year, dtpFirst.Value.Month, dtpFirst.Value.Day)
                >= new DateTime(dtpLast.Value.Year, dtpLast.Value.Month, dtpLast.Value.Day))
            {
                MessageBox.Show("ikinci tarih ilk tarihten ilerde olmalıdır.");
                dtpLast.Value = new DateTime(dtpFirst.Value.Year, dtpFirst.Value.Month, DateTime.DaysInMonth(dtpFirst.Value.Year, dtpFirst.Value.Month), 23, 59, 59);
            }
        }
    }
}
