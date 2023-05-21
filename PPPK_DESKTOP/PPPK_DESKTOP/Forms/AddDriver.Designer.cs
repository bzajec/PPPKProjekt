
namespace PPPK_DESKTOP.Forms
{
    partial class AddDriver
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.lblDriversLicence = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMobileNumber = new System.Windows.Forms.TextBox();
            this.tbDriversLicence = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(27, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ime:";
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Location = new System.Drawing.Point(30, 107);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(69, 13);
            this.lblMobileNumber.TabIndex = 1;
            this.lblMobileNumber.Text = "Broj mobača:";
            // 
            // lblDriversLicence
            // 
            this.lblDriversLicence.AutoSize = true;
            this.lblDriversLicence.Location = new System.Drawing.Point(30, 186);
            this.lblDriversLicence.Name = "lblDriversLicence";
            this.lblDriversLicence.Size = new System.Drawing.Size(112, 13);
            this.lblDriversLicence.TabIndex = 2;
            this.lblDriversLicence.Text = "Broj vozacke dozvole:";
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(104, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(240, 255);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "Odustani";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(240, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 5;
            // 
            // tbMobileNumber
            // 
            this.tbMobileNumber.Location = new System.Drawing.Point(240, 104);
            this.tbMobileNumber.Name = "tbMobileNumber";
            this.tbMobileNumber.Size = new System.Drawing.Size(100, 20);
            this.tbMobileNumber.TabIndex = 6;
            // 
            // tbDriversLicence
            // 
            this.tbDriversLicence.Location = new System.Drawing.Point(240, 183);
            this.tbDriversLicence.Name = "tbDriversLicence";
            this.tbDriversLicence.Size = new System.Drawing.Size(100, 20);
            this.tbDriversLicence.TabIndex = 7;
            // 
            // AddDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 327);
            this.Controls.Add(this.tbDriversLicence);
            this.Controls.Add(this.tbMobileNumber);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDriversLicence);
            this.Controls.Add(this.lblMobileNumber);
            this.Controls.Add(this.lblName);
            this.Name = "AddDriver";
            this.Text = "AddDriver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.Label lblDriversLicence;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMobileNumber;
        private System.Windows.Forms.TextBox tbDriversLicence;
    }
}