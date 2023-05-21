
namespace PPPK_DESKTOP.Forms
{
    partial class AddNalogDAAB
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
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbNalogType = new System.Windows.Forms.ComboBox();
            this.tbFuel = new System.Windows.Forms.TextBox();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.tbKilometri = new System.Windows.Forms.TextBox();
            this.tbDays = new System.Windows.Forms.TextBox();
            this.tbEndCity = new System.Windows.Forms.TextBox();
            this.tbStartCity = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblKilometri = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblEndCity = new System.Windows.Forms.Label();
            this.lblStartCity = new System.Windows.Forms.Label();
            this.lblVehicles = new System.Windows.Forms.Label();
            this.lblDrivers = new System.Windows.Forms.Label();
            this.lbVehicles = new System.Windows.Forms.ListBox();
            this.lbDrivers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(444, 477);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 39;
            this.btnCancle.Text = "Odustani";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(287, 477);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cbNalogType
            // 
            this.cbNalogType.FormattingEnabled = true;
            this.cbNalogType.Location = new System.Drawing.Point(435, 420);
            this.cbNalogType.Name = "cbNalogType";
            this.cbNalogType.Size = new System.Drawing.Size(152, 21);
            this.cbNalogType.TabIndex = 37;
            // 
            // tbFuel
            // 
            this.tbFuel.Location = new System.Drawing.Point(435, 357);
            this.tbFuel.Name = "tbFuel";
            this.tbFuel.Size = new System.Drawing.Size(152, 20);
            this.tbFuel.TabIndex = 36;
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(435, 294);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(152, 20);
            this.tbSpeed.TabIndex = 35;
            // 
            // tbKilometri
            // 
            this.tbKilometri.Location = new System.Drawing.Point(435, 231);
            this.tbKilometri.Name = "tbKilometri";
            this.tbKilometri.Size = new System.Drawing.Size(152, 20);
            this.tbKilometri.TabIndex = 34;
            // 
            // tbDays
            // 
            this.tbDays.Location = new System.Drawing.Point(435, 168);
            this.tbDays.Name = "tbDays";
            this.tbDays.Size = new System.Drawing.Size(152, 20);
            this.tbDays.TabIndex = 33;
            // 
            // tbEndCity
            // 
            this.tbEndCity.Location = new System.Drawing.Point(435, 105);
            this.tbEndCity.Name = "tbEndCity";
            this.tbEndCity.Size = new System.Drawing.Size(152, 20);
            this.tbEndCity.TabIndex = 32;
            // 
            // tbStartCity
            // 
            this.tbStartCity.Location = new System.Drawing.Point(435, 42);
            this.tbStartCity.Name = "tbStartCity";
            this.tbStartCity.Size = new System.Drawing.Size(152, 20);
            this.tbStartCity.TabIndex = 31;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(284, 423);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(60, 13);
            this.lblType.TabIndex = 30;
            this.lblType.Text = "Tip naloga:";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(284, 360);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(38, 13);
            this.lblFuel.TabIndex = 29;
            this.lblFuel.Text = "Gorivo";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(284, 297);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(36, 13);
            this.lblSpeed.TabIndex = 28;
            this.lblSpeed.Text = "Brzina";
            // 
            // lblKilometri
            // 
            this.lblKilometri.AutoSize = true;
            this.lblKilometri.Location = new System.Drawing.Point(284, 234);
            this.lblKilometri.Name = "lblKilometri";
            this.lblKilometri.Size = new System.Drawing.Size(79, 13);
            this.lblKilometri.TabIndex = 27;
            this.lblKilometri.Text = "Broj kilometara:";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(284, 171);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(55, 13);
            this.lblDays.TabIndex = 26;
            this.lblDays.Text = "Broj dana:";
            // 
            // lblEndCity
            // 
            this.lblEndCity.AutoSize = true;
            this.lblEndCity.Location = new System.Drawing.Point(284, 108);
            this.lblEndCity.Name = "lblEndCity";
            this.lblEndCity.Size = new System.Drawing.Size(69, 13);
            this.lblEndCity.TabIndex = 25;
            this.lblEndCity.Text = "Završni grad:";
            // 
            // lblStartCity
            // 
            this.lblStartCity.AutoSize = true;
            this.lblStartCity.Location = new System.Drawing.Point(284, 45);
            this.lblStartCity.Name = "lblStartCity";
            this.lblStartCity.Size = new System.Drawing.Size(70, 13);
            this.lblStartCity.TabIndex = 24;
            this.lblStartCity.Text = "Početni grad:";
            // 
            // lblVehicles
            // 
            this.lblVehicles.AutoSize = true;
            this.lblVehicles.Location = new System.Drawing.Point(9, 272);
            this.lblVehicles.Name = "lblVehicles";
            this.lblVehicles.Size = new System.Drawing.Size(35, 13);
            this.lblVehicles.TabIndex = 23;
            this.lblVehicles.Text = "Vozila";
            // 
            // lblDrivers
            // 
            this.lblDrivers.AutoSize = true;
            this.lblDrivers.Location = new System.Drawing.Point(13, 9);
            this.lblDrivers.Name = "lblDrivers";
            this.lblDrivers.Size = new System.Drawing.Size(39, 13);
            this.lblDrivers.TabIndex = 22;
            this.lblDrivers.Text = "Vozači";
            // 
            // lbVehicles
            // 
            this.lbVehicles.FormattingEnabled = true;
            this.lbVehicles.Location = new System.Drawing.Point(12, 313);
            this.lbVehicles.Name = "lbVehicles";
            this.lbVehicles.Size = new System.Drawing.Size(212, 199);
            this.lbVehicles.TabIndex = 21;
            // 
            // lbDrivers
            // 
            this.lbDrivers.FormattingEnabled = true;
            this.lbDrivers.Location = new System.Drawing.Point(12, 45);
            this.lbDrivers.Name = "lbDrivers";
            this.lbDrivers.Size = new System.Drawing.Size(212, 199);
            this.lbDrivers.TabIndex = 20;
            // 
            // AddNalogDAAB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 539);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbNalogType);
            this.Controls.Add(this.tbFuel);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.tbKilometri);
            this.Controls.Add(this.tbDays);
            this.Controls.Add(this.tbEndCity);
            this.Controls.Add(this.tbStartCity);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblKilometri);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblEndCity);
            this.Controls.Add(this.lblStartCity);
            this.Controls.Add(this.lblVehicles);
            this.Controls.Add(this.lblDrivers);
            this.Controls.Add(this.lbVehicles);
            this.Controls.Add(this.lbDrivers);
            this.Name = "AddNalogDAAB";
            this.Text = "AddNalogDAAB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbNalogType;
        private System.Windows.Forms.TextBox tbFuel;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.TextBox tbKilometri;
        private System.Windows.Forms.TextBox tbDays;
        private System.Windows.Forms.TextBox tbEndCity;
        private System.Windows.Forms.TextBox tbStartCity;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblKilometri;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblEndCity;
        private System.Windows.Forms.Label lblStartCity;
        private System.Windows.Forms.Label lblVehicles;
        private System.Windows.Forms.Label lblDrivers;
        private System.Windows.Forms.ListBox lbVehicles;
        private System.Windows.Forms.ListBox lbDrivers;
    }
}