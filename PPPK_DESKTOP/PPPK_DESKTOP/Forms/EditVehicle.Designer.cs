
namespace PPPK_DESKTOP.Forms
{
    partial class EditVehicle
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
            this.tbKilometri = new System.Windows.Forms.TextBox();
            this.tbYearOfProduction = new System.Windows.Forms.TextBox();
            this.tbMarkaVehicle = new System.Windows.Forms.TextBox();
            this.tbTypeOfVehicle = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblKilometri = new System.Windows.Forms.Label();
            this.lblYearOfProduction = new System.Windows.Forms.Label();
            this.lblMarkaOfVehicle = new System.Windows.Forms.Label();
            this.lblTypeOfVehicle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbKilometri
            // 
            this.tbKilometri.Location = new System.Drawing.Point(233, 201);
            this.tbKilometri.Name = "tbKilometri";
            this.tbKilometri.Size = new System.Drawing.Size(100, 20);
            this.tbKilometri.TabIndex = 19;
            // 
            // tbYearOfProduction
            // 
            this.tbYearOfProduction.Location = new System.Drawing.Point(233, 135);
            this.tbYearOfProduction.Name = "tbYearOfProduction";
            this.tbYearOfProduction.Size = new System.Drawing.Size(100, 20);
            this.tbYearOfProduction.TabIndex = 18;
            // 
            // tbMarkaVehicle
            // 
            this.tbMarkaVehicle.Location = new System.Drawing.Point(233, 74);
            this.tbMarkaVehicle.Name = "tbMarkaVehicle";
            this.tbMarkaVehicle.Size = new System.Drawing.Size(100, 20);
            this.tbMarkaVehicle.TabIndex = 17;
            // 
            // tbTypeOfVehicle
            // 
            this.tbTypeOfVehicle.Location = new System.Drawing.Point(233, 19);
            this.tbTypeOfVehicle.Name = "tbTypeOfVehicle";
            this.tbTypeOfVehicle.Size = new System.Drawing.Size(100, 20);
            this.tbTypeOfVehicle.TabIndex = 16;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(216, 260);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 15;
            this.btnCancle.Text = "Nista";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEdit.Location = new System.Drawing.Point(104, 260);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Uredi";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblKilometri
            // 
            this.lblKilometri.AutoSize = true;
            this.lblKilometri.Location = new System.Drawing.Point(16, 204);
            this.lblKilometri.Name = "lblKilometri";
            this.lblKilometri.Size = new System.Drawing.Size(133, 13);
            this.lblKilometri.TabIndex = 13;
            this.lblKilometri.Text = "Inicijalno stanje kilometara:";
            // 
            // lblYearOfProduction
            // 
            this.lblYearOfProduction.AutoSize = true;
            this.lblYearOfProduction.Location = new System.Drawing.Point(17, 142);
            this.lblYearOfProduction.Name = "lblYearOfProduction";
            this.lblYearOfProduction.Size = new System.Drawing.Size(99, 13);
            this.lblYearOfProduction.TabIndex = 12;
            this.lblYearOfProduction.Text = "Godina prozvodnje:";
            // 
            // lblMarkaOfVehicle
            // 
            this.lblMarkaOfVehicle.AutoSize = true;
            this.lblMarkaOfVehicle.Location = new System.Drawing.Point(17, 77);
            this.lblMarkaOfVehicle.Name = "lblMarkaOfVehicle";
            this.lblMarkaOfVehicle.Size = new System.Drawing.Size(70, 13);
            this.lblMarkaOfVehicle.TabIndex = 11;
            this.lblMarkaOfVehicle.Text = "Marka vozila:";
            // 
            // lblTypeOfVehicle
            // 
            this.lblTypeOfVehicle.AutoSize = true;
            this.lblTypeOfVehicle.Location = new System.Drawing.Point(17, 19);
            this.lblTypeOfVehicle.Name = "lblTypeOfVehicle";
            this.lblTypeOfVehicle.Size = new System.Drawing.Size(55, 13);
            this.lblTypeOfVehicle.TabIndex = 10;
            this.lblTypeOfVehicle.Text = "Tip vozila:";
            // 
            // EditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 306);
            this.Controls.Add(this.tbKilometri);
            this.Controls.Add(this.tbYearOfProduction);
            this.Controls.Add(this.tbMarkaVehicle);
            this.Controls.Add(this.tbTypeOfVehicle);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblKilometri);
            this.Controls.Add(this.lblYearOfProduction);
            this.Controls.Add(this.lblMarkaOfVehicle);
            this.Controls.Add(this.lblTypeOfVehicle);
            this.Name = "EditVehicle";
            this.Text = "EditVehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKilometri;
        private System.Windows.Forms.TextBox tbYearOfProduction;
        private System.Windows.Forms.TextBox tbMarkaVehicle;
        private System.Windows.Forms.TextBox tbTypeOfVehicle;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblKilometri;
        private System.Windows.Forms.Label lblYearOfProduction;
        private System.Windows.Forms.Label lblMarkaOfVehicle;
        private System.Windows.Forms.Label lblTypeOfVehicle;
    }
}