
namespace HotelCrown.UI
{
    partial class FrmMain
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
            this.ms = new System.Windows.Forms.MenuStrip();
            this.miReservations = new System.Windows.Forms.ToolStripMenuItem();
            this.miServices = new System.Windows.Forms.ToolStripMenuItem();
            this.MiCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.miFeatures = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbRoomCapacity = new System.Windows.Forms.ComboBox();
            this.lblRoomCapacity = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.btnCancelFilter = new System.Windows.Forms.Button();
            this.ms.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms
            // 
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miReservations,
            this.miServices,
            this.MiCustomers,
            this.miAddRooms,
            this.miFeatures});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(800, 24);
            this.ms.TabIndex = 0;
            this.ms.Text = "menuStrip1";
            // 
            // miReservations
            // 
            this.miReservations.Name = "miReservations";
            this.miReservations.Size = new System.Drawing.Size(97, 20);
            this.miReservations.Text = "Rezervasyonlar";
            this.miReservations.Click += new System.EventHandler(this.MiReservations_Click);
            // 
            // miServices
            // 
            this.miServices.Name = "miServices";
            this.miServices.Size = new System.Drawing.Size(62, 20);
            this.miServices.Text = "Servisler";
            this.miServices.Click += new System.EventHandler(this.MiServices_Click);
            // 
            // MiCustomers
            // 
            this.MiCustomers.Name = "MiCustomers";
            this.MiCustomers.Size = new System.Drawing.Size(72, 20);
            this.MiCustomers.Text = "Müşteriler";
            this.MiCustomers.Click += new System.EventHandler(this.MiCustomers_Click);
            // 
            // miAddRooms
            // 
            this.miAddRooms.Name = "miAddRooms";
            this.miAddRooms.Size = new System.Drawing.Size(65, 20);
            this.miAddRooms.Text = "Oda Ekle";
            this.miAddRooms.Click += new System.EventHandler(this.MiAddRooms_Click);
            // 
            // miFeatures
            // 
            this.miFeatures.Name = "miFeatures";
            this.miFeatures.Size = new System.Drawing.Size(95, 20);
            this.miFeatures.Text = "Oda Özellikleri";
            this.miFeatures.Click += new System.EventHandler(this.MiFeatures_Click);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCheckOut.Location = new System.Drawing.Point(118, 82);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(290, 26);
            this.dtpCheckOut.TabIndex = 2;
            this.dtpCheckOut.Value = new System.DateTime(2021, 10, 26, 20, 20, 0, 0);
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.DtpCheckOut_ValueChanged);
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCheckIn.Location = new System.Drawing.Point(118, 36);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(290, 26);
            this.dtpCheckIn.TabIndex = 3;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.DtpCheckIn_ValueChanged);
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCheckInDate.Location = new System.Drawing.Point(12, 41);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(100, 20);
            this.lblCheckInDate.TabIndex = 7;
            this.lblCheckInDate.Text = "Giriş Tarihi:";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCheckOut.Location = new System.Drawing.Point(12, 87);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(101, 20);
            this.lblCheckOut.TabIndex = 8;
            this.lblCheckOut.Text = "Çıkış Tarihi:";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilter.Location = new System.Drawing.Point(508, 82);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(280, 26);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // cmbRoomCapacity
            // 
            this.cmbRoomCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRoomCapacity.FormattingEnabled = true;
            this.cmbRoomCapacity.Location = new System.Drawing.Point(624, 38);
            this.cmbRoomCapacity.Name = "cmbRoomCapacity";
            this.cmbRoomCapacity.Size = new System.Drawing.Size(164, 28);
            this.cmbRoomCapacity.TabIndex = 10;
            this.cmbRoomCapacity.Text = "1";
            // 
            // lblRoomCapacity
            // 
            this.lblRoomCapacity.AutoSize = true;
            this.lblRoomCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRoomCapacity.Location = new System.Drawing.Point(518, 41);
            this.lblRoomCapacity.Name = "lblRoomCapacity";
            this.lblRoomCapacity.Size = new System.Drawing.Size(94, 20);
            this.lblRoomCapacity.TabIndex = 11;
            this.lblRoomCapacity.Text = "Kişi Sayısı:";
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.Location = new System.Drawing.Point(16, 146);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(772, 292);
            this.pnl.TabIndex = 12;
            // 
            // btnCancelFilter
            // 
            this.btnCancelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancelFilter.Location = new System.Drawing.Point(508, 114);
            this.btnCancelFilter.Name = "btnCancelFilter";
            this.btnCancelFilter.Size = new System.Drawing.Size(280, 26);
            this.btnCancelFilter.TabIndex = 13;
            this.btnCancelFilter.Text = "Filtreyi Sıfırla";
            this.btnCancelFilter.UseVisualStyleBackColor = true;
            this.btnCancelFilter.Visible = false;
            this.btnCancelFilter.Click += new System.EventHandler(this.BtnCancelFilter_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelFilter);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.lblRoomCapacity);
            this.Controls.Add(this.cmbRoomCapacity);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.ms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.ms;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Crown";
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem miServices;
        private System.Windows.Forms.ToolStripMenuItem MiCustomers;
        private System.Windows.Forms.ToolStripMenuItem miReservations;
        private System.Windows.Forms.ToolStripMenuItem miAddRooms;
        private System.Windows.Forms.ToolStripMenuItem miFeatures;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbRoomCapacity;
        private System.Windows.Forms.Label lblRoomCapacity;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btnCancelFilter;
    }
}