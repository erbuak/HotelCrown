
namespace HotelCrown.UI
{
    partial class FrmAddUpdateRoom
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
            this.lbRoomName = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbFeature = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRoomName
            // 
            this.lbRoomName.AutoSize = true;
            this.lbRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbRoomName.Location = new System.Drawing.Point(29, 42);
            this.lbRoomName.Name = "lbRoomName";
            this.lbRoomName.Size = new System.Drawing.Size(35, 20);
            this.lbRoomName.TabIndex = 0;
            this.lbRoomName.Text = "Adı";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCapacity.Location = new System.Drawing.Point(29, 140);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(79, 20);
            this.lblCapacity.TabIndex = 1;
            this.lblCapacity.Text = "Kapasite";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(29, 239);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Fiyat";
            // 
            // cmbFeature
            // 
            this.cmbFeature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFeature.FormattingEnabled = true;
            this.cmbFeature.Location = new System.Drawing.Point(407, 37);
            this.cmbFeature.Name = "cmbFeature";
            this.cmbFeature.Size = new System.Drawing.Size(351, 28);
            this.cmbFeature.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(139, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 26);
            this.txtName.TabIndex = 6;
            // 
            // nudCapacity
            // 
            this.nudCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudCapacity.Location = new System.Drawing.Point(139, 138);
            this.nudCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(189, 26);
            this.nudCapacity.TabIndex = 7;
            this.nudCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudPrice.Location = new System.Drawing.Point(139, 239);
            this.nudPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(189, 26);
            this.nudPrice.TabIndex = 8;
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveUpdate.Location = new System.Drawing.Point(33, 316);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(725, 34);
            this.btnSaveUpdate.TabIndex = 9;
            this.btnSaveUpdate.Text = "Kaydet";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            this.btnSaveUpdate.Click += new System.EventHandler(this.BtnSaveUpdate_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelect.Location = new System.Drawing.Point(407, 84);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(351, 34);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "Ekle";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adi});
            this.dgv.Location = new System.Drawing.Point(407, 140);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(351, 125);
            this.dgv.TabIndex = 12;
            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_KeyDown);
            // 
            // Adi
            // 
            this.Adi.DataPropertyName = "FeatureName";
            this.Adi.HeaderText = "Özellik";
            this.Adi.Name = "Adi";
            this.Adi.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(33, 372);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(725, 31);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Odayı Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmAddUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSaveUpdate);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbFeature);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lbRoomName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddUpdateRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oda Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRoomName;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbFeature;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.Button btnDelete;
    }
}