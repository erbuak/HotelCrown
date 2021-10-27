
namespace HotelCrown.UI
{
    partial class FrmServices
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.btnCancel);
            this.gb.Controls.Add(this.nudPrice);
            this.gb.Controls.Add(this.txtName);
            this.gb.Controls.Add(this.btnSaveUpdate);
            this.gb.Controls.Add(this.lblServicePrice);
            this.gb.Controls.Add(this.lblServiceName);
            this.gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb.Location = new System.Drawing.Point(482, 12);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(306, 270);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            this.gb.Text = "Servis Ekle / Düzenle";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(22, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(260, 41);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Düzenlemeyi İptal Et";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(83, 100);
            this.nudPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(199, 26);
            this.nudPrice.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(83, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 26);
            this.txtName.TabIndex = 3;
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.Location = new System.Drawing.Point(22, 149);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(260, 41);
            this.btnSaveUpdate.TabIndex = 2;
            this.btnSaveUpdate.Text = "Kaydet";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            this.btnSaveUpdate.Click += new System.EventHandler(this.BtnSaveUpdate_Click);
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblServicePrice.Location = new System.Drawing.Point(18, 102);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(48, 20);
            this.lblServicePrice.TabIndex = 1;
            this.lblServicePrice.Text = "Fiyat";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblServiceName.Location = new System.Drawing.Point(18, 46);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(31, 20);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "Ad";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adi,
            this.Fiyati});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(445, 270);
            this.dgv.TabIndex = 1;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellDoubleClick);
            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_KeyDown);
            // 
            // Adi
            // 
            this.Adi.DataPropertyName = "ServiceName";
            this.Adi.HeaderText = "Adı";
            this.Adi.Name = "Adi";
            this.Adi.ReadOnly = true;
            // 
            // Fiyati
            // 
            this.Fiyati.DataPropertyName = "UnitPrice";
            this.Fiyati.HeaderText = "Fiyatı";
            this.Fiyati.Name = "Fiyati";
            this.Fiyati.ReadOnly = true;
            // 
            // FrmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Servisler";
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyati;
        private System.Windows.Forms.Button btnCancel;
    }
}