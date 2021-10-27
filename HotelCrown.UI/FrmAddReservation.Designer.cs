
namespace HotelCrown.UI
{
    partial class FrmAddReservation
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KimlikNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.gbIn = new System.Windows.Forms.GroupBox();
            this.pnlIn = new System.Windows.Forms.Panel();
            this.cmbMonthsIn = new System.Windows.Forms.ComboBox();
            this.cmbYearsIn = new System.Windows.Forms.ComboBox();
            this.gbOut = new System.Windows.Forms.GroupBox();
            this.cmbMonthsOut = new System.Windows.Forms.ComboBox();
            this.cmbYearsOut = new System.Windows.Forms.ComboBox();
            this.pnlOut = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSaveReservation = new System.Windows.Forms.Button();
            this.lblDates = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblRoomName2 = new System.Windows.Forms.Label();
            this.lblDates2 = new System.Windows.Forms.Label();
            this.dgvSelectedCustomers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.gbIn.SuspendLayout();
            this.gbOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adi,
            this.KimlikNo});
            this.dgvCustomers.Location = new System.Drawing.Point(12, 62);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(319, 94);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomers_CellClick);
            // 
            // Adi
            // 
            this.Adi.DataPropertyName = "FullName";
            this.Adi.HeaderText = "Adı";
            this.Adi.Name = "Adi";
            this.Adi.ReadOnly = true;
            // 
            // KimlikNo
            // 
            this.KimlikNo.DataPropertyName = "IdentityNumber";
            this.KimlikNo.HeaderText = "Kimlik / Pasaport No";
            this.KimlikNo.Name = "KimlikNo";
            this.KimlikNo.ReadOnly = true;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(139, 23);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(192, 26);
            this.txtSearchCustomer.TabIndex = 1;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.TxtSearchCustomer_TextChanged);
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchCustomer.Location = new System.Drawing.Point(12, 26);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(90, 20);
            this.lblSearchCustomer.TabIndex = 2;
            this.lblSearchCustomer.Text = "Müşteri Ara";
            // 
            // gbIn
            // 
            this.gbIn.Controls.Add(this.pnlIn);
            this.gbIn.Controls.Add(this.cmbMonthsIn);
            this.gbIn.Controls.Add(this.cmbYearsIn);
            this.gbIn.Location = new System.Drawing.Point(387, 26);
            this.gbIn.Name = "gbIn";
            this.gbIn.Size = new System.Drawing.Size(180, 230);
            this.gbIn.TabIndex = 3;
            this.gbIn.TabStop = false;
            this.gbIn.Text = "Giriş Tarihi";
            // 
            // pnlIn
            // 
            this.pnlIn.Location = new System.Drawing.Point(1, 65);
            this.pnlIn.Name = "pnlIn";
            this.pnlIn.Size = new System.Drawing.Size(178, 135);
            this.pnlIn.TabIndex = 7;
            // 
            // cmbMonthsIn
            // 
            this.cmbMonthsIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMonthsIn.FormattingEnabled = true;
            this.cmbMonthsIn.Location = new System.Drawing.Point(95, 19);
            this.cmbMonthsIn.Name = "cmbMonthsIn";
            this.cmbMonthsIn.Size = new System.Drawing.Size(79, 28);
            this.cmbMonthsIn.TabIndex = 6;
            this.cmbMonthsIn.SelectedIndexChanged += new System.EventHandler(this.CmbMonthsIn_SelectedIndexChanged);
            // 
            // cmbYearsIn
            // 
            this.cmbYearsIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYearsIn.FormattingEnabled = true;
            this.cmbYearsIn.Location = new System.Drawing.Point(15, 19);
            this.cmbYearsIn.Name = "cmbYearsIn";
            this.cmbYearsIn.Size = new System.Drawing.Size(74, 28);
            this.cmbYearsIn.TabIndex = 5;
            this.cmbYearsIn.SelectedIndexChanged += new System.EventHandler(this.CmbYearsIn_SelectedIndexChanged);
            // 
            // gbOut
            // 
            this.gbOut.Controls.Add(this.cmbMonthsOut);
            this.gbOut.Controls.Add(this.cmbYearsOut);
            this.gbOut.Location = new System.Drawing.Point(604, 26);
            this.gbOut.Name = "gbOut";
            this.gbOut.Size = new System.Drawing.Size(180, 230);
            this.gbOut.TabIndex = 4;
            this.gbOut.TabStop = false;
            this.gbOut.Text = "Çıkış Tarihi";
            // 
            // cmbMonthsOut
            // 
            this.cmbMonthsOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMonthsOut.FormattingEnabled = true;
            this.cmbMonthsOut.Location = new System.Drawing.Point(95, 19);
            this.cmbMonthsOut.Name = "cmbMonthsOut";
            this.cmbMonthsOut.Size = new System.Drawing.Size(79, 28);
            this.cmbMonthsOut.TabIndex = 8;
            this.cmbMonthsOut.SelectedIndexChanged += new System.EventHandler(this.CmbMonthsOut_SelectedIndexChanged);
            // 
            // cmbYearsOut
            // 
            this.cmbYearsOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYearsOut.FormattingEnabled = true;
            this.cmbYearsOut.Location = new System.Drawing.Point(15, 19);
            this.cmbYearsOut.Name = "cmbYearsOut";
            this.cmbYearsOut.Size = new System.Drawing.Size(74, 28);
            this.cmbYearsOut.TabIndex = 7;
            this.cmbYearsOut.SelectedIndexChanged += new System.EventHandler(this.CmbYearsOut_SelectedIndexChanged);
            // 
            // pnlOut
            // 
            this.pnlOut.Enabled = false;
            this.pnlOut.Location = new System.Drawing.Point(605, 91);
            this.pnlOut.Name = "pnlOut";
            this.pnlOut.Size = new System.Drawing.Size(178, 135);
            this.pnlOut.TabIndex = 8;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.Location = new System.Drawing.Point(388, 282);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(395, 23);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Visible = false;
            // 
            // btnSaveReservation
            // 
            this.btnSaveReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveReservation.Location = new System.Drawing.Point(12, 399);
            this.btnSaveReservation.Name = "btnSaveReservation";
            this.btnSaveReservation.Size = new System.Drawing.Size(772, 39);
            this.btnSaveReservation.TabIndex = 10;
            this.btnSaveReservation.Text = "Rezervasyon Kaydet";
            this.btnSaveReservation.UseVisualStyleBackColor = true;
            this.btnSaveReservation.Click += new System.EventHandler(this.BtnSaveReservation_Click);
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDates.Location = new System.Drawing.Point(12, 352);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(74, 20);
            this.lblDates.TabIndex = 12;
            this.lblDates.Text = "Tarihler:";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRoomName.Location = new System.Drawing.Point(12, 316);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(78, 20);
            this.lblRoomName.TabIndex = 13;
            this.lblRoomName.Text = "Oda Adı:";
            // 
            // lblRoomName2
            // 
            this.lblRoomName2.AutoSize = true;
            this.lblRoomName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRoomName2.Location = new System.Drawing.Point(210, 316);
            this.lblRoomName2.Name = "lblRoomName2";
            this.lblRoomName2.Size = new System.Drawing.Size(99, 20);
            this.lblRoomName2.TabIndex = 14;
            this.lblRoomName2.Text = "__________";
            // 
            // lblDates2
            // 
            this.lblDates2.AutoSize = true;
            this.lblDates2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDates2.Location = new System.Drawing.Point(210, 352);
            this.lblDates2.Name = "lblDates2";
            this.lblDates2.Size = new System.Drawing.Size(99, 20);
            this.lblDates2.TabIndex = 16;
            this.lblDates2.Text = "__________";
            // 
            // dgvSelectedCustomers
            // 
            this.dgvSelectedCustomers.AllowUserToAddRows = false;
            this.dgvSelectedCustomers.AllowUserToDeleteRows = false;
            this.dgvSelectedCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvSelectedCustomers.Location = new System.Drawing.Point(12, 218);
            this.dgvSelectedCustomers.Name = "dgvSelectedCustomers";
            this.dgvSelectedCustomers.ReadOnly = true;
            this.dgvSelectedCustomers.RowHeadersVisible = false;
            this.dgvSelectedCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedCustomers.Size = new System.Drawing.Size(319, 87);
            this.dgvSelectedCustomers.TabIndex = 17;
            this.dgvSelectedCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSelectedCustomers_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Adı";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdentityNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "Kimlik / Pasaport No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Oda Müşterileri";
            // 
            // FrmAddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSelectedCustomers);
            this.Controls.Add(this.lblDates2);
            this.Controls.Add(this.lblRoomName2);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.lblDates);
            this.Controls.Add(this.btnSaveReservation);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pnlOut);
            this.Controls.Add(this.gbOut);
            this.Controls.Add(this.gbIn);
            this.Controls.Add(this.lblSearchCustomer);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.dgvCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rezarvasyon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.gbIn.ResumeLayout(false);
            this.gbOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KimlikNo;
        private System.Windows.Forms.GroupBox gbIn;
        private System.Windows.Forms.GroupBox gbOut;
        private System.Windows.Forms.ComboBox cmbYearsIn;
        private System.Windows.Forms.ComboBox cmbMonthsIn;
        private System.Windows.Forms.ComboBox cmbMonthsOut;
        private System.Windows.Forms.ComboBox cmbYearsOut;
        private System.Windows.Forms.Panel pnlIn;
        private System.Windows.Forms.Panel pnlOut;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSaveReservation;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblRoomName2;
        private System.Windows.Forms.Label lblDates2;
        private System.Windows.Forms.DataGridView dgvSelectedCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
    }
}