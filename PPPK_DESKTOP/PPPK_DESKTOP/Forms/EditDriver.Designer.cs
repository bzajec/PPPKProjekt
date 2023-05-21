
namespace PPPK_DESKTOP.Forms
{
    partial class EditDriver
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
            this.tbDriversLicence = new System.Windows.Forms.TextBox();
            this.tbMobileNumber = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblDriversLicence = new System.Windows.Forms.Label();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDriversLicence
            // 
            this.tbDriversLicence.Location = new System.Drawing.Point(222, 167);
            this.tbDriversLicence.Name = "tbDriversLicence";
            this.tbDriversLicence.Size = new System.Drawing.Size(100, 20);
            this.tbDriversLicence.TabIndex = 15;
            // 
            // tbMobileNumber
            // 
            this.tbMobileNumber.Location = new System.Drawing.Point(222, 88);
            this.tbMobileNumber.Name = "tbMobileNumber";
            this.tbMobileNumber.Size = new System.Drawing.Size(100, 20);
            this.tbMobileNumber.TabIndex = 14;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(222, 13);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 13;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(222, 239);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 12;
            this.btnCancle.Text = "Odustani";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEdit.Location = new System.Drawing.Point(86, 239);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Uredi";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblDriversLicence
            // 
            this.lblDriversLicence.AutoSize = true;
            this.lblDriversLicence.Location = new System.Drawing.Point(12, 170);
            this.lblDriversLicence.Name = "lblDriversLicence";
            this.lblDriversLicence.Size = new System.Drawing.Size(112, 13);
            this.lblDriversLicence.TabIndex = 10;
            this.lblDriversLicence.Text = "Broj vozacke dozvole:";
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Location = new System.Drawing.Point(12, 91);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(69, 13);
            this.lblMobileNumber.TabIndex = 9;
            this.lblMobileNumber.Text = "Broj mobača:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(27, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Ime:";
            // 
            // EditDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 289);
            this.Controls.Add(this.tbDriversLicence);
            this.Controls.Add(this.tbMobileNumber);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblDriversLicence);
            this.Controls.Add(this.lblMobileNumber);
            this.Controls.Add(this.lblName);
            this.Name = "EditDriver";
            this.Text = "EditDriver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDriversLicence;
        private System.Windows.Forms.TextBox tbMobileNumber;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblDriversLicence;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.Label lblName;
    }
}