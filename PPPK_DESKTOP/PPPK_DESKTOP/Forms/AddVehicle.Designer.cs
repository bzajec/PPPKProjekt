
namespace PPPK_DESKTOP.Forms
{
    partial class AddVehicle
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
            this.lblTypeOfVehicle = new System.Windows.Forms.Label();
            this.lblMarkaOfVehicle = new System.Windows.Forms.Label();
            this.lblYearOfProduction = new System.Windows.Forms.Label();
            this.lblKilometri = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.tbTypeOfVehicle = new System.Windows.Forms.TextBox();
            this.tbMarkaVehicle = new System.Windows.Forms.TextBox();
            this.tbYearOfProduction = new System.Windows.Forms.TextBox();
            this.tbKilometri = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTypeOfVehicle
            // 
            this.lblTypeOfVehicle.AutoSize = true;
            this.lblTypeOfVehicle.Location = new System.Drawing.Point(13, 39);
            this.lblTypeOfVehicle.Name = "lblTypeOfVehicle";
            this.lblTypeOfVehicle.Size = new System.Drawing.Size(55, 13);
            this.lblTypeOfVehicle.TabIndex = 0;
            this.lblTypeOfVehicle.Text = "Tip vozila:";
            // 
            // lblMarkaOfVehicle
            // 
            this.lblMarkaOfVehicle.AutoSize = true;
            this.lblMarkaOfVehicle.Location = new System.Drawing.Point(13, 97);
            this.lblMarkaOfVehicle.Name = "lblMarkaOfVehicle";
            this.lblMarkaOfVehicle.Size = new System.Drawing.Size(70, 13);
            this.lblMarkaOfVehicle.TabIndex = 1;
            this.lblMarkaOfVehicle.Text = "Marka vozila:";
            // 
            // lblYearOfProduction
            // 
            this.lblYearOfProduction.AutoSize = true;
            this.lblYearOfProduction.Location = new System.Drawing.Point(13, 162);
            this.lblYearOfProduction.Name = "lblYearOfProduction";
            this.lblYearOfProduction.Size = new System.Drawing.Size(99, 13);
            this.lblYearOfProduction.TabIndex = 2;
            this.lblYearOfProduction.Text = "Godina prozvodnje:";
            // 
            // lblKilometri
            // 
            this.lblKilometri.AutoSize = true;
            this.lblKilometri.Location = new System.Drawing.Point(12, 224);
            this.lblKilometri.Name = "lblKilometri";
            this.lblKilometri.Size = new System.Drawing.Size(133, 13);
            this.lblKilometri.TabIndex = 3;
            this.lblKilometri.Text = "Inicijalno stanje kilometara:";
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(100, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(212, 280);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 5;
            this.btnCancle.Text = "Nista";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // tbTypeOfVehicle
            // 
            this.tbTypeOfVehicle.Location = new System.Drawing.Point(229, 39);
            this.tbTypeOfVehicle.Name = "tbTypeOfVehicle";
            this.tbTypeOfVehicle.Size = new System.Drawing.Size(100, 20);
            this.tbTypeOfVehicle.TabIndex = 6;
            // 
            // tbMarkaVehicle
            // 
            this.tbMarkaVehicle.Location = new System.Drawing.Point(229, 94);
            this.tbMarkaVehicle.Name = "tbMarkaVehicle";
            this.tbMarkaVehicle.Size = new System.Drawing.Size(100, 20);
            this.tbMarkaVehicle.TabIndex = 7;
            // 
            // tbYearOfProduction
            // 
            this.tbYearOfProduction.Location = new System.Drawing.Point(229, 155);
            this.tbYearOfProduction.Name = "tbYearOfProduction";
            this.tbYearOfProduction.Size = new System.Drawing.Size(100, 20);
            this.tbYearOfProduction.TabIndex = 8;
            // 
            // tbKilometri
            // 
            this.tbKilometri.Location = new System.Drawing.Point(229, 221);
            this.tbKilometri.Name = "tbKilometri";
            this.tbKilometri.Size = new System.Drawing.Size(100, 20);
            this.tbKilometri.TabIndex = 9;
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 341);
            this.Controls.Add(this.tbKilometri);
            this.Controls.Add(this.tbYearOfProduction);
            this.Controls.Add(this.tbMarkaVehicle);
            this.Controls.Add(this.tbTypeOfVehicle);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblKilometri);
            this.Controls.Add(this.lblYearOfProduction);
            this.Controls.Add(this.lblMarkaOfVehicle);
            this.Controls.Add(this.lblTypeOfVehicle);
            this.Name = "AddVehicle";
            this.Text = "AddVehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeOfVehicle;
        private System.Windows.Forms.Label lblMarkaOfVehicle;
        private System.Windows.Forms.Label lblYearOfProduction;
        private System.Windows.Forms.Label lblKilometri;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox tbTypeOfVehicle;
        private System.Windows.Forms.TextBox tbMarkaVehicle;
        private System.Windows.Forms.TextBox tbYearOfProduction;
        private System.Windows.Forms.TextBox tbKilometri;
    }
}