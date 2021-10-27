
namespace HotelCrown.UI
{
    partial class FrmRoom
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
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.FeaturesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateRoom = new System.Windows.Forms.Button();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblRoomName2 = new System.Windows.Forms.Label();
            this.lblCapacity2 = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRoomName.Location = new System.Drawing.Point(27, 23);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(36, 20);
            this.lblRoomName.TabIndex = 0;
            this.lblRoomName.Text = "Ad:";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCapacity.Location = new System.Drawing.Point(27, 78);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(89, 20);
            this.lblCapacity.TabIndex = 1;
            this.lblCapacity.Text = "Kapasite: ";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeaturesName});
            this.dgv.Location = new System.Drawing.Point(31, 206);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(348, 119);
            this.dgv.TabIndex = 2;
            // 
            // FeaturesName
            // 
            this.FeaturesName.DataPropertyName = "FeatureName";
            this.FeaturesName.HeaderText = "Oda Özelliği";
            this.FeaturesName.Name = "FeaturesName";
            this.FeaturesName.ReadOnly = true;
            // 
            // updateRoom
            // 
            this.updateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateRoom.Location = new System.Drawing.Point(31, 382);
            this.updateRoom.Name = "updateRoom";
            this.updateRoom.Size = new System.Drawing.Size(348, 34);
            this.updateRoom.TabIndex = 3;
            this.updateRoom.Text = "Odayı Düzenle";
            this.updateRoom.UseVisualStyleBackColor = true;
            this.updateRoom.Click += new System.EventHandler(this.UpdateRoom_Click);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddReservation.Location = new System.Drawing.Point(410, 382);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(348, 34);
            this.btnAddReservation.TabIndex = 4;
            this.btnAddReservation.Text = "Rezervasyon Oluştur";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.BtnAddReservation_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(27, 137);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 20);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Fiyat:";
            // 
            // lblRoomName2
            // 
            this.lblRoomName2.AutoSize = true;
            this.lblRoomName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRoomName2.Location = new System.Drawing.Point(145, 23);
            this.lblRoomName2.Name = "lblRoomName2";
            this.lblRoomName2.Size = new System.Drawing.Size(66, 20);
            this.lblRoomName2.TabIndex = 6;
            this.lblRoomName2.Text = "Oda Adı";
            // 
            // lblCapacity2
            // 
            this.lblCapacity2.AutoSize = true;
            this.lblCapacity2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCapacity2.Location = new System.Drawing.Point(145, 78);
            this.lblCapacity2.Name = "lblCapacity2";
            this.lblCapacity2.Size = new System.Drawing.Size(71, 20);
            this.lblCapacity2.TabIndex = 7;
            this.lblCapacity2.Text = "Kapasite";
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice2.Location = new System.Drawing.Point(145, 137);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(43, 20);
            this.lblPrice2.TabIndex = 8;
            this.lblPrice2.Text = "Fiyat";
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrice2);
            this.Controls.Add(this.lblCapacity2);
            this.Controls.Add(this.lblRoomName2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.updateRoom);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblRoomName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Room";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button updateRoom;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeaturesName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblRoomName2;
        private System.Windows.Forms.Label lblCapacity2;
        private System.Windows.Forms.Label lblPrice2;
    }
}