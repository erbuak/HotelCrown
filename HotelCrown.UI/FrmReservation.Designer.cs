
namespace HotelCrown.UI
{
    partial class FrmReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbServices = new System.Windows.Forms.ComboBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnReservationCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRoomName2 = new System.Windows.Forms.Label();
            this.lblCheckInDate2 = new System.Windows.Forms.Label();
            this.lblCheckOutDate2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice2 = new System.Windows.Forms.Label();
            this.lblServicePrices2 = new System.Windows.Forms.Label();
            this.lblRoomPrice2 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblServicePrices = new System.Windows.Forms.Label();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.btnGetPaid = new System.Windows.Forms.Button();
            this.btnGetPaidAndCheckOut = new System.Windows.Forms.Button();
            this.btnCheckedIn = new System.Windows.Forms.Button();
            this.btngetPaidServicesAndCheckOut = new System.Windows.Forms.Button();
            this.gb = new System.Windows.Forms.GroupBox();
            this.pnlIn = new System.Windows.Forms.Panel();
            this.cmbMonths = new System.Windows.Forms.ComboBox();
            this.cmbYears = new System.Windows.Forms.ComboBox();
            this.btnChangeCheckOutDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oda Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(162, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Misafirler";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adi});
            this.dgvCustomers.Location = new System.Drawing.Point(24, 171);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.Size = new System.Drawing.Size(354, 94);
            this.dgvCustomers.TabIndex = 2;
            // 
            // Adi
            // 
            this.Adi.DataPropertyName = "FullName";
            this.Adi.HeaderText = "Ad";
            this.Adi.Name = "Adi";
            this.Adi.ReadOnly = true;
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToResizeRows = false;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceName,
            this.UnitPrice,
            this.Date});
            this.dgvServices.Location = new System.Drawing.Point(417, 41);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(354, 73);
            this.dgvServices.TabIndex = 3;
            this.dgvServices.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvServices_KeyDown);
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.HeaderText = "Servis Adı";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Fiyatı";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Tarih";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(559, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Servisler";
            // 
            // cmbServices
            // 
            this.cmbServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbServices.FormattingEnabled = true;
            this.cmbServices.Location = new System.Drawing.Point(417, 135);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(157, 28);
            this.cmbServices.TabIndex = 6;
            // 
            // btnAddService
            // 
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddService.Location = new System.Drawing.Point(591, 135);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(180, 28);
            this.btnAddService.TabIndex = 7;
            this.btnAddService.Text = "Servis Ekle";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.BtnAddService_Click);
            // 
            // btnReservationCancel
            // 
            this.btnReservationCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReservationCancel.Location = new System.Drawing.Point(417, 309);
            this.btnReservationCancel.Name = "btnReservationCancel";
            this.btnReservationCancel.Size = new System.Drawing.Size(354, 29);
            this.btnReservationCancel.TabIndex = 8;
            this.btnReservationCancel.Text = "Rezervasyon İptal Et";
            this.btnReservationCancel.UseVisualStyleBackColor = true;
            this.btnReservationCancel.Click += new System.EventHandler(this.BtnReservationCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Çıkış Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giriş Tarihi:";
            // 
            // lblRoomName2
            // 
            this.lblRoomName2.AutoSize = true;
            this.lblRoomName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRoomName2.Location = new System.Drawing.Point(106, 9);
            this.lblRoomName2.Name = "lblRoomName2";
            this.lblRoomName2.Size = new System.Drawing.Size(52, 20);
            this.lblRoomName2.TabIndex = 11;
            this.lblRoomName2.Text = "Oda 1";
            // 
            // lblCheckInDate2
            // 
            this.lblCheckInDate2.AutoSize = true;
            this.lblCheckInDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCheckInDate2.Location = new System.Drawing.Point(141, 49);
            this.lblCheckInDate2.Name = "lblCheckInDate2";
            this.lblCheckInDate2.Size = new System.Drawing.Size(89, 20);
            this.lblCheckInDate2.TabIndex = 12;
            this.lblCheckInDate2.Text = "22.10.2021";
            // 
            // lblCheckOutDate2
            // 
            this.lblCheckOutDate2.AutoSize = true;
            this.lblCheckOutDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCheckOutDate2.Location = new System.Drawing.Point(141, 94);
            this.lblCheckOutDate2.Name = "lblCheckOutDate2";
            this.lblCheckOutDate2.Size = new System.Drawing.Size(89, 20);
            this.lblCheckOutDate2.TabIndex = 13;
            this.lblCheckOutDate2.Text = "24.10.2021";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalPrice2);
            this.groupBox1.Controls.Add(this.lblServicePrices2);
            this.groupBox1.Controls.Add(this.lblRoomPrice2);
            this.groupBox1.Controls.Add(this.lblTotalPrice);
            this.groupBox1.Controls.Add(this.lblServicePrices);
            this.groupBox1.Controls.Add(this.lblRoomPrice);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(30, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 149);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ücret Bilgileri";
            // 
            // lblTotalPrice2
            // 
            this.lblTotalPrice2.AutoSize = true;
            this.lblTotalPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice2.Location = new System.Drawing.Point(189, 120);
            this.lblTotalPrice2.Name = "lblTotalPrice2";
            this.lblTotalPrice2.Size = new System.Drawing.Size(27, 20);
            this.lblTotalPrice2.TabIndex = 20;
            this.lblTotalPrice2.Text = "80";
            // 
            // lblServicePrices2
            // 
            this.lblServicePrices2.AutoSize = true;
            this.lblServicePrices2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblServicePrices2.Location = new System.Drawing.Point(189, 78);
            this.lblServicePrices2.Name = "lblServicePrices2";
            this.lblServicePrices2.Size = new System.Drawing.Size(27, 20);
            this.lblServicePrices2.TabIndex = 19;
            this.lblServicePrices2.Text = "50";
            // 
            // lblRoomPrice2
            // 
            this.lblRoomPrice2.AutoSize = true;
            this.lblRoomPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRoomPrice2.Location = new System.Drawing.Point(189, 39);
            this.lblRoomPrice2.Name = "lblRoomPrice2";
            this.lblRoomPrice2.Size = new System.Drawing.Size(27, 20);
            this.lblRoomPrice2.TabIndex = 18;
            this.lblRoomPrice2.Text = "30";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.Location = new System.Drawing.Point(28, 120);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(121, 20);
            this.lblTotalPrice.TabIndex = 17;
            this.lblTotalPrice.Text = "Toplam Ücret:";
            // 
            // lblServicePrices
            // 
            this.lblServicePrices.AutoSize = true;
            this.lblServicePrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblServicePrices.Location = new System.Drawing.Point(28, 78);
            this.lblServicePrices.Name = "lblServicePrices";
            this.lblServicePrices.Size = new System.Drawing.Size(136, 20);
            this.lblServicePrices.TabIndex = 16;
            this.lblServicePrices.Text = "Servis Ücretleri:";
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRoomPrice.Location = new System.Drawing.Point(28, 39);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(100, 20);
            this.lblRoomPrice.TabIndex = 15;
            this.lblRoomPrice.Text = "Oda Ücreti:";
            // 
            // btnGetPaid
            // 
            this.btnGetPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetPaid.Location = new System.Drawing.Point(417, 204);
            this.btnGetPaid.Name = "btnGetPaid";
            this.btnGetPaid.Size = new System.Drawing.Size(354, 29);
            this.btnGetPaid.TabIndex = 15;
            this.btnGetPaid.Text = "Ödeme Al";
            this.btnGetPaid.UseVisualStyleBackColor = true;
            this.btnGetPaid.Click += new System.EventHandler(this.BtnGetPaid_Click);
            // 
            // btnGetPaidAndCheckOut
            // 
            this.btnGetPaidAndCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetPaidAndCheckOut.Location = new System.Drawing.Point(417, 274);
            this.btnGetPaidAndCheckOut.Name = "btnGetPaidAndCheckOut";
            this.btnGetPaidAndCheckOut.Size = new System.Drawing.Size(354, 29);
            this.btnGetPaidAndCheckOut.TabIndex = 16;
            this.btnGetPaidAndCheckOut.Text = "Ödeme Al ve Çıkış Yap";
            this.btnGetPaidAndCheckOut.UseVisualStyleBackColor = true;
            this.btnGetPaidAndCheckOut.Click += new System.EventHandler(this.BtnGetPaidAndCheckOut_Click);
            // 
            // btnCheckedIn
            // 
            this.btnCheckedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheckedIn.Location = new System.Drawing.Point(417, 169);
            this.btnCheckedIn.Name = "btnCheckedIn";
            this.btnCheckedIn.Size = new System.Drawing.Size(354, 29);
            this.btnCheckedIn.TabIndex = 18;
            this.btnCheckedIn.Text = "Giriş Yap";
            this.btnCheckedIn.UseVisualStyleBackColor = true;
            this.btnCheckedIn.Click += new System.EventHandler(this.BtnCheckedIn_Click);
            // 
            // btngetPaidServicesAndCheckOut
            // 
            this.btngetPaidServicesAndCheckOut.Enabled = false;
            this.btngetPaidServicesAndCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngetPaidServicesAndCheckOut.Location = new System.Drawing.Point(417, 239);
            this.btngetPaidServicesAndCheckOut.Name = "btngetPaidServicesAndCheckOut";
            this.btngetPaidServicesAndCheckOut.Size = new System.Drawing.Size(354, 29);
            this.btngetPaidServicesAndCheckOut.TabIndex = 19;
            this.btngetPaidServicesAndCheckOut.Text = "Servisler İçin Ödeme Al ve Çıkış Yap";
            this.btngetPaidServicesAndCheckOut.UseVisualStyleBackColor = true;
            this.btngetPaidServicesAndCheckOut.Click += new System.EventHandler(this.BtnGetPaidServicesAndCheckOut_Click);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.pnlIn);
            this.gb.Controls.Add(this.cmbMonths);
            this.gb.Controls.Add(this.cmbYears);
            this.gb.Location = new System.Drawing.Point(417, 358);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(180, 200);
            this.gb.TabIndex = 20;
            this.gb.TabStop = false;
            this.gb.Text = "Çıkış Tarihi";
            // 
            // pnlIn
            // 
            this.pnlIn.Location = new System.Drawing.Point(1, 65);
            this.pnlIn.Name = "pnlIn";
            this.pnlIn.Size = new System.Drawing.Size(178, 129);
            this.pnlIn.TabIndex = 7;
            // 
            // cmbMonths
            // 
            this.cmbMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMonths.FormattingEnabled = true;
            this.cmbMonths.Location = new System.Drawing.Point(95, 19);
            this.cmbMonths.Name = "cmbMonths";
            this.cmbMonths.Size = new System.Drawing.Size(79, 28);
            this.cmbMonths.TabIndex = 6;
            this.cmbMonths.Text = "10";
            this.cmbMonths.SelectedIndexChanged += new System.EventHandler(this.CmbMonths_SelectedIndexChanged);
            // 
            // cmbYears
            // 
            this.cmbYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYears.FormattingEnabled = true;
            this.cmbYears.Location = new System.Drawing.Point(15, 19);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(74, 28);
            this.cmbYears.TabIndex = 5;
            this.cmbYears.Text = "2021";
            this.cmbYears.SelectedIndexChanged += new System.EventHandler(this.CmbYears_SelectedIndexChanged);
            // 
            // btnChangeCheckOutDate
            // 
            this.btnChangeCheckOutDate.Enabled = false;
            this.btnChangeCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangeCheckOutDate.Location = new System.Drawing.Point(604, 364);
            this.btnChangeCheckOutDate.Name = "btnChangeCheckOutDate";
            this.btnChangeCheckOutDate.Size = new System.Drawing.Size(167, 194);
            this.btnChangeCheckOutDate.TabIndex = 21;
            this.btnChangeCheckOutDate.Text = "Çıkış Tarihini Değiştir";
            this.btnChangeCheckOutDate.UseVisualStyleBackColor = true;
            this.btnChangeCheckOutDate.Click += new System.EventHandler(this.BtnChangeCheckOutDate_Click);
            // 
            // FrmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnChangeCheckOutDate);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.btngetPaidServicesAndCheckOut);
            this.Controls.Add(this.btnCheckedIn);
            this.Controls.Add(this.btnGetPaidAndCheckOut);
            this.Controls.Add(this.btnGetPaid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCheckOutDate2);
            this.Controls.Add(this.lblCheckInDate2);
            this.Controls.Add(this.lblRoomName2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReservationCancel);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.cmbServices);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rezervasyon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbServices;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnReservationCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRoomName2;
        private System.Windows.Forms.Label lblCheckInDate2;
        private System.Windows.Forms.Label lblCheckOutDate2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblServicePrices;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label lblTotalPrice2;
        private System.Windows.Forms.Label lblServicePrices2;
        private System.Windows.Forms.Label lblRoomPrice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.Button btnGetPaid;
        private System.Windows.Forms.Button btnGetPaidAndCheckOut;
        private System.Windows.Forms.Button btnCheckedIn;
        private System.Windows.Forms.Button btngetPaidServicesAndCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Panel pnlIn;
        private System.Windows.Forms.ComboBox cmbMonths;
        private System.Windows.Forms.ComboBox cmbYears;
        private System.Windows.Forms.Button btnChangeCheckOutDate;
    }
}