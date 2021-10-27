
namespace HotelCrown.UI
{
    partial class FrmAddUpdateCustomer
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
            this.lblLocal = new System.Windows.Forms.Label();
            this.cbForeignPerson = new System.Windows.Forms.CheckBox();
            this.cbLocalPerson = new System.Windows.Forms.CheckBox();
            this.txtIdentityNumber = new System.Windows.Forms.TextBox();
            this.lblIdentityNumber = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbFemale = new System.Windows.Forms.CheckBox();
            this.cbMale = new System.Windows.Forms.CheckBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescripton = new System.Windows.Forms.Label();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLocal.Location = new System.Drawing.Point(25, 27);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(67, 20);
            this.lblLocal.TabIndex = 13;
            this.lblLocal.Text = "Uyruk *";
            // 
            // cbForeignPerson
            // 
            this.cbForeignPerson.AutoSize = true;
            this.cbForeignPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbForeignPerson.Location = new System.Drawing.Point(318, 27);
            this.cbForeignPerson.Name = "cbForeignPerson";
            this.cbForeignPerson.Size = new System.Drawing.Size(86, 24);
            this.cbForeignPerson.TabIndex = 12;
            this.cbForeignPerson.Text = "Yabancı";
            this.cbForeignPerson.UseVisualStyleBackColor = true;
            this.cbForeignPerson.CheckedChanged += new System.EventHandler(this.CbForeignPerson_CheckedChanged);
            // 
            // cbLocalPerson
            // 
            this.cbLocalPerson.AutoSize = true;
            this.cbLocalPerson.Checked = true;
            this.cbLocalPerson.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLocalPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbLocalPerson.Location = new System.Drawing.Point(170, 26);
            this.cbLocalPerson.Name = "cbLocalPerson";
            this.cbLocalPerson.Size = new System.Drawing.Size(59, 24);
            this.cbLocalPerson.TabIndex = 11;
            this.cbLocalPerson.Text = "Yerli";
            this.cbLocalPerson.UseVisualStyleBackColor = true;
            this.cbLocalPerson.CheckedChanged += new System.EventHandler(this.CbLocalPerson_CheckedChanged);
            // 
            // txtIdentityNumber
            // 
            this.txtIdentityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIdentityNumber.Location = new System.Drawing.Point(170, 128);
            this.txtIdentityNumber.Name = "txtIdentityNumber";
            this.txtIdentityNumber.Size = new System.Drawing.Size(234, 26);
            this.txtIdentityNumber.TabIndex = 10;
            this.txtIdentityNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdentityNumber_KeyPress);
            // 
            // lblIdentityNumber
            // 
            this.lblIdentityNumber.AutoSize = true;
            this.lblIdentityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdentityNumber.Location = new System.Drawing.Point(25, 134);
            this.lblIdentityNumber.Name = "lblIdentityNumber";
            this.lblIdentityNumber.Size = new System.Drawing.Size(94, 20);
            this.lblIdentityNumber.TabIndex = 9;
            this.lblIdentityNumber.Text = "Kimlik No *";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFullName.Location = new System.Drawing.Point(25, 82);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(43, 20);
            this.lblFullName.TabIndex = 8;
            this.lblFullName.Text = "Ad *";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFullName.Location = new System.Drawing.Point(170, 76);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(234, 26);
            this.txtFullName.TabIndex = 7;
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFullName_KeyPress);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(170, 189);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(234, 26);
            this.txtPhoneNumber.TabIndex = 15;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhoneNumber_KeyPress);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(25, 192);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(108, 20);
            this.lblPhoneNumber.TabIndex = 14;
            this.lblPhoneNumber.Text = "Telefon No *";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirthDate.Location = new System.Drawing.Point(25, 257);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(127, 20);
            this.lblBirthDate.TabIndex = 16;
            this.lblBirthDate.Text = "Doğum Tarihi *";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBirthDate.Location = new System.Drawing.Point(170, 256);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(234, 20);
            this.dtpBirthDate.TabIndex = 17;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGender.Location = new System.Drawing.Point(25, 323);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(84, 20);
            this.lblGender.TabIndex = 18;
            this.lblGender.Text = "Cinsiyet *";
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFemale.Location = new System.Drawing.Point(336, 323);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(68, 24);
            this.cbFemale.TabIndex = 20;
            this.cbFemale.Text = "Kadın";
            this.cbFemale.UseVisualStyleBackColor = true;
            this.cbFemale.CheckedChanged += new System.EventHandler(this.CbFemale_CheckedChanged);
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.Checked = true;
            this.cbMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMale.Location = new System.Drawing.Point(170, 322);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(69, 24);
            this.cbMale.TabIndex = 19;
            this.cbMale.Text = "Erkek";
            this.cbMale.UseVisualStyleBackColor = true;
            this.cbMale.CheckedChanged += new System.EventHandler(this.CbMale_CheckedChanged);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(170, 374);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(234, 52);
            this.rtxtDescription.TabIndex = 21;
            this.rtxtDescription.Text = "";
            // 
            // lblDescripton
            // 
            this.lblDescripton.AutoSize = true;
            this.lblDescripton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescripton.Location = new System.Drawing.Point(25, 390);
            this.lblDescripton.Name = "lblDescripton";
            this.lblDescripton.Size = new System.Drawing.Size(81, 20);
            this.lblDescripton.TabIndex = 22;
            this.lblDescripton.Text = "Açıklama";
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.Location = new System.Drawing.Point(436, 386);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(352, 40);
            this.btnSaveUpdate.TabIndex = 23;
            this.btnSaveUpdate.Text = "Kaydet";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            this.btnSaveUpdate.Click += new System.EventHandler(this.BtnSaveUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(436, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(352, 40);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmAddUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveUpdate);
            this.Controls.Add(this.lblDescripton);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.cbFemale);
            this.Controls.Add(this.cbMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.cbForeignPerson);
            this.Controls.Add(this.cbLocalPerson);
            this.Controls.Add(this.txtIdentityNumber);
            this.Controls.Add(this.lblIdentityNumber);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddUpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.CheckBox cbForeignPerson;
        private System.Windows.Forms.CheckBox cbLocalPerson;
        private System.Windows.Forms.TextBox txtIdentityNumber;
        private System.Windows.Forms.Label lblIdentityNumber;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.CheckBox cbFemale;
        private System.Windows.Forms.CheckBox cbMale;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblDescripton;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}