
namespace HotelCrown.UI
{
    partial class FrmCustomers
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentityNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ad,
            this.IdentityNumber,
            this.TelefonNo});
            this.dgv.Location = new System.Drawing.Point(13, 13);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(775, 369);
            this.dgv.TabIndex = 0;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellDoubleClick);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCustomer.Location = new System.Drawing.Point(12, 400);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(776, 38);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Müşteri Ekle";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "FullName";
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            // 
            // IdentityNumber
            // 
            this.IdentityNumber.DataPropertyName = "IdentityNumber";
            this.IdentityNumber.HeaderText = "Kimlik / Pasaport No";
            this.IdentityNumber.Name = "IdentityNumber";
            this.IdentityNumber.ReadOnly = true;
            // 
            // TelefonNo
            // 
            this.TelefonNo.DataPropertyName = "PhoneNumber";
            this.TelefonNo.HeaderText = "Telefon No";
            this.TelefonNo.Name = "TelefonNo";
            this.TelefonNo.ReadOnly = true;
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteriler";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentityNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonNo;
    }
}