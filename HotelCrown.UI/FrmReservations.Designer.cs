
namespace HotelCrown.UI
{
    partial class FrmReservations
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomersString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.lblDates = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbCheckOut = new System.Windows.Forms.CheckBox();
            this.dtpFirst = new System.Windows.Forms.DateTimePicker();
            this.cbCheckIn = new System.Windows.Forms.CheckBox();
            this.dtpLast = new System.Windows.Forms.DateTimePicker();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomName,
            this.CustomersString,
            this.CheckInDate,
            this.CheckOutDate,
            this.In,
            this.Out});
            this.dgv.Location = new System.Drawing.Point(12, 238);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(776, 200);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.HeaderText = "Oda Adı";
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            // 
            // CustomersString
            // 
            this.CustomersString.DataPropertyName = "CustomersString";
            this.CustomersString.HeaderText = "Müşteri Adları";
            this.CustomersString.Name = "CustomersString";
            this.CustomersString.ReadOnly = true;
            // 
            // CheckInDate
            // 
            this.CheckInDate.DataPropertyName = "CheckInDate";
            this.CheckInDate.HeaderText = "Giriş Tarihi";
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.ReadOnly = true;
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.DataPropertyName = "CheckOutDate";
            this.CheckOutDate.HeaderText = "Çıkış Tarihi";
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.ReadOnly = true;
            // 
            // In
            // 
            this.In.DataPropertyName = "IsCheckedIn";
            this.In.HeaderText = "Giriş Yapıldı Mı?";
            this.In.Name = "In";
            this.In.ReadOnly = true;
            // 
            // Out
            // 
            this.Out.DataPropertyName = "IsCheckedOut";
            this.Out.HeaderText = "Çıkış Yapıldı Mı?";
            this.Out.Name = "Out";
            this.Out.ReadOnly = true;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.cmb);
            this.gbFilter.Controls.Add(this.lblDates);
            this.gbFilter.Controls.Add(this.btnFilter);
            this.gbFilter.Controls.Add(this.cbCheckOut);
            this.gbFilter.Controls.Add(this.dtpFirst);
            this.gbFilter.Controls.Add(this.cbCheckIn);
            this.gbFilter.Controls.Add(this.dtpLast);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbFilter.Location = new System.Drawing.Point(373, 12);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(415, 203);
            this.gbFilter.TabIndex = 7;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filtrele";
            // 
            // cmb
            // 
            this.cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(10, 62);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(239, 28);
            this.cmb.TabIndex = 20;
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDates.Location = new System.Drawing.Point(6, 30);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(119, 20);
            this.lblDates.TabIndex = 19;
            this.lblDates.Text = "İki Tarih Arası";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilter.Location = new System.Drawing.Point(6, 163);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(400, 34);
            this.btnFilter.TabIndex = 18;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // cbCheckOut
            // 
            this.cbCheckOut.AutoSize = true;
            this.cbCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbCheckOut.Location = new System.Drawing.Point(283, 93);
            this.cbCheckOut.Name = "cbCheckOut";
            this.cbCheckOut.Size = new System.Drawing.Size(124, 24);
            this.cbCheckOut.TabIndex = 17;
            this.cbCheckOut.Text = "Çıkış Yapılmış";
            this.cbCheckOut.UseVisualStyleBackColor = true;
            this.cbCheckOut.CheckedChanged += new System.EventHandler(this.CbCheckOut_CheckedChanged);
            // 
            // dtpFirst
            // 
            this.dtpFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpFirst.Location = new System.Drawing.Point(10, 94);
            this.dtpFirst.Name = "dtpFirst";
            this.dtpFirst.Size = new System.Drawing.Size(239, 26);
            this.dtpFirst.TabIndex = 15;
            this.dtpFirst.ValueChanged += new System.EventHandler(this.DtpFirst_ValueChanged);
            // 
            // cbCheckIn
            // 
            this.cbCheckIn.AutoSize = true;
            this.cbCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbCheckIn.Location = new System.Drawing.Point(283, 61);
            this.cbCheckIn.Name = "cbCheckIn";
            this.cbCheckIn.Size = new System.Drawing.Size(123, 24);
            this.cbCheckIn.TabIndex = 16;
            this.cbCheckIn.Text = "Giriş Yapılmış";
            this.cbCheckIn.UseVisualStyleBackColor = true;
            this.cbCheckIn.CheckedChanged += new System.EventHandler(this.CbCheckIn_CheckedChanged);
            // 
            // dtpLast
            // 
            this.dtpLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpLast.Location = new System.Drawing.Point(10, 126);
            this.dtpLast.Name = "dtpLast";
            this.dtpLast.Size = new System.Drawing.Size(239, 26);
            this.dtpLast.TabIndex = 14;
            this.dtpLast.ValueChanged += new System.EventHandler(this.DtpLast_ValueChanged);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbSearch.Location = new System.Drawing.Point(12, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(334, 203);
            this.gbSearch.TabIndex = 8;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Müşteri Adı İle Ara";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(6, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(322, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // FrmReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rezervasyonlar";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckBox cbCheckOut;
        private System.Windows.Forms.DateTimePicker dtpFirst;
        private System.Windows.Forms.CheckBox cbCheckIn;
        private System.Windows.Forms.DateTimePicker dtpLast;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomersString;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Out;
    }
}