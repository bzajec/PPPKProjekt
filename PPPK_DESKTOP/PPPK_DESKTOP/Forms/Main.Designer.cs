
namespace PPPK_DESKTOP.Forms
{
    partial class Main
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
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblKilometriTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMarkaVozilaTitle = new System.Windows.Forms.Label();
            this.lblTipVozilaTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblInicijalniKilometri = new System.Windows.Forms.Label();
            this.lblGodinaProizvodnje = new System.Windows.Forms.Label();
            this.lblMarkVozila = new System.Windows.Forms.Label();
            this.lblTipVozila = new System.Windows.Forms.Label();
            this.lbVozila = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblVozackaTitle = new System.Windows.Forms.Label();
            this.lblMobitelTitle = new System.Windows.Forms.Label();
            this.lblImeTitle = new System.Windows.Forms.Label();
            this.btnDeleteDriver = new System.Windows.Forms.Button();
            this.btnEditDriver = new System.Windows.Forms.Button();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.lblVozacka = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lbVozaci = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDeleteNalog = new System.Windows.Forms.Button();
            this.btnEditNalog = new System.Windows.Forms.Button();
            this.btnAddNalog = new System.Windows.Forms.Button();
            this.cbNalozi = new System.Windows.Forms.ComboBox();
            this.lbNalozi = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnDAAB = new System.Windows.Forms.Button();
            this.btnViewXML = new System.Windows.Forms.Button();
            this.btnCreateXML = new System.Windows.Forms.Button();
            this.tcMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.tabPage1);
            this.tcMenu.Controls.Add(this.tabPage2);
            this.tcMenu.Controls.Add(this.tabPage3);
            this.tcMenu.Controls.Add(this.tabPage4);
            this.tcMenu.Location = new System.Drawing.Point(-1, 2);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(650, 305);
            this.tcMenu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblKilometriTitle);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblMarkaVozilaTitle);
            this.tabPage1.Controls.Add(this.lblTipVozilaTitle);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.lblInicijalniKilometri);
            this.tabPage1.Controls.Add(this.lblGodinaProizvodnje);
            this.tabPage1.Controls.Add(this.lblMarkVozila);
            this.tabPage1.Controls.Add(this.lblTipVozila);
            this.tabPage1.Controls.Add(this.lbVozila);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(642, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vozila";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblKilometriTitle
            // 
            this.lblKilometriTitle.AutoSize = true;
            this.lblKilometriTitle.Location = new System.Drawing.Point(233, 200);
            this.lblKilometriTitle.Name = "lblKilometriTitle";
            this.lblKilometriTitle.Size = new System.Drawing.Size(46, 13);
            this.lblKilometriTitle.TabIndex = 11;
            this.lblKilometriTitle.Text = "Kilometri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Godina proizvodnje:";
            // 
            // lblMarkaVozilaTitle
            // 
            this.lblMarkaVozilaTitle.AutoSize = true;
            this.lblMarkaVozilaTitle.Location = new System.Drawing.Point(233, 92);
            this.lblMarkaVozilaTitle.Name = "lblMarkaVozilaTitle";
            this.lblMarkaVozilaTitle.Size = new System.Drawing.Size(70, 13);
            this.lblMarkaVozilaTitle.TabIndex = 9;
            this.lblMarkaVozilaTitle.Text = "Marka vozila:";
            // 
            // lblTipVozilaTitle
            // 
            this.lblTipVozilaTitle.AutoSize = true;
            this.lblTipVozilaTitle.Location = new System.Drawing.Point(233, 38);
            this.lblTipVozilaTitle.Name = "lblTipVozilaTitle";
            this.lblTipVozilaTitle.Size = new System.Drawing.Size(55, 13);
            this.lblTipVozilaTitle.TabIndex = 8;
            this.lblTipVozilaTitle.Text = "Tip vozila:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(493, 224);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(493, 139);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Uredi";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(493, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblInicijalniKilometri
            // 
            this.lblInicijalniKilometri.AutoSize = true;
            this.lblInicijalniKilometri.Location = new System.Drawing.Point(338, 200);
            this.lblInicijalniKilometri.Name = "lblInicijalniKilometri";
            this.lblInicijalniKilometri.Size = new System.Drawing.Size(130, 13);
            this.lblInicijalniKilometri.TabIndex = 4;
            this.lblInicijalniKilometri.Text = "Inicijalno stanje kilometara";
            // 
            // lblGodinaProizvodnje
            // 
            this.lblGodinaProizvodnje.AutoSize = true;
            this.lblGodinaProizvodnje.Location = new System.Drawing.Point(338, 146);
            this.lblGodinaProizvodnje.Name = "lblGodinaProizvodnje";
            this.lblGodinaProizvodnje.Size = new System.Drawing.Size(98, 13);
            this.lblGodinaProizvodnje.TabIndex = 3;
            this.lblGodinaProizvodnje.Text = "Godina proizvodnje";
            // 
            // lblMarkVozila
            // 
            this.lblMarkVozila.AutoSize = true;
            this.lblMarkVozila.Location = new System.Drawing.Point(338, 92);
            this.lblMarkVozila.Name = "lblMarkVozila";
            this.lblMarkVozila.Size = new System.Drawing.Size(67, 13);
            this.lblMarkVozila.TabIndex = 2;
            this.lblMarkVozila.Text = "Marka vozila";
            // 
            // lblTipVozila
            // 
            this.lblTipVozila.AutoSize = true;
            this.lblTipVozila.Location = new System.Drawing.Point(338, 38);
            this.lblTipVozila.Name = "lblTipVozila";
            this.lblTipVozila.Size = new System.Drawing.Size(52, 13);
            this.lblTipVozila.TabIndex = 1;
            this.lblTipVozila.Text = "Tip vozila";
            // 
            // lbVozila
            // 
            this.lbVozila.FormattingEnabled = true;
            this.lbVozila.Location = new System.Drawing.Point(9, 6);
            this.lbVozila.Name = "lbVozila";
            this.lbVozila.Size = new System.Drawing.Size(206, 277);
            this.lbVozila.TabIndex = 0;
            this.lbVozila.SelectedIndexChanged += new System.EventHandler(this.lbVozila_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblVozackaTitle);
            this.tabPage2.Controls.Add(this.lblMobitelTitle);
            this.tabPage2.Controls.Add(this.lblImeTitle);
            this.tabPage2.Controls.Add(this.btnDeleteDriver);
            this.tabPage2.Controls.Add(this.btnEditDriver);
            this.tabPage2.Controls.Add(this.btnAddDriver);
            this.tabPage2.Controls.Add(this.lblVozacka);
            this.tabPage2.Controls.Add(this.lblPhone);
            this.tabPage2.Controls.Add(this.lblName);
            this.tabPage2.Controls.Add(this.lbVozaci);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(642, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vozaci";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblVozackaTitle
            // 
            this.lblVozackaTitle.AutoSize = true;
            this.lblVozackaTitle.Location = new System.Drawing.Point(217, 172);
            this.lblVozackaTitle.Name = "lblVozackaTitle";
            this.lblVozackaTitle.Size = new System.Drawing.Size(112, 13);
            this.lblVozackaTitle.TabIndex = 9;
            this.lblVozackaTitle.Text = "Broj vozačke dozvole:";
            // 
            // lblMobitelTitle
            // 
            this.lblMobitelTitle.AutoSize = true;
            this.lblMobitelTitle.Location = new System.Drawing.Point(217, 105);
            this.lblMobitelTitle.Name = "lblMobitelTitle";
            this.lblMobitelTitle.Size = new System.Drawing.Size(69, 13);
            this.lblMobitelTitle.TabIndex = 8;
            this.lblMobitelTitle.Text = "Broj mobača:";
            // 
            // lblImeTitle
            // 
            this.lblImeTitle.AutoSize = true;
            this.lblImeTitle.Location = new System.Drawing.Point(217, 40);
            this.lblImeTitle.Name = "lblImeTitle";
            this.lblImeTitle.Size = new System.Drawing.Size(24, 13);
            this.lblImeTitle.TabIndex = 7;
            this.lblImeTitle.Text = "Ime";
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.Location = new System.Drawing.Point(499, 172);
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDriver.TabIndex = 6;
            this.btnDeleteDriver.Text = "Izbrisi";
            this.btnDeleteDriver.UseVisualStyleBackColor = true;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);
            // 
            // btnEditDriver
            // 
            this.btnEditDriver.Location = new System.Drawing.Point(499, 105);
            this.btnEditDriver.Name = "btnEditDriver";
            this.btnEditDriver.Size = new System.Drawing.Size(75, 23);
            this.btnEditDriver.TabIndex = 5;
            this.btnEditDriver.Text = "Uredi";
            this.btnEditDriver.UseVisualStyleBackColor = true;
            this.btnEditDriver.Click += new System.EventHandler(this.btnEditDriver_Click);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(499, 40);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(75, 23);
            this.btnAddDriver.TabIndex = 4;
            this.btnAddDriver.Text = "Dodaj";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // lblVozacka
            // 
            this.lblVozacka.AutoSize = true;
            this.lblVozacka.Location = new System.Drawing.Point(338, 172);
            this.lblVozacka.Name = "lblVozacka";
            this.lblVozacka.Size = new System.Drawing.Size(109, 13);
            this.lblVozacka.TabIndex = 3;
            this.lblVozacka.Text = "Broj vozačke dozvole";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(338, 105);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(66, 13);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Broj mobaća";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(338, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(24, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ime";
            // 
            // lbVozaci
            // 
            this.lbVozaci.FormattingEnabled = true;
            this.lbVozaci.Location = new System.Drawing.Point(10, 7);
            this.lbVozaci.Name = "lbVozaci";
            this.lbVozaci.Size = new System.Drawing.Size(173, 264);
            this.lbVozaci.TabIndex = 0;
            this.lbVozaci.SelectedIndexChanged += new System.EventHandler(this.lbVozaci_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDeleteNalog);
            this.tabPage3.Controls.Add(this.btnEditNalog);
            this.tabPage3.Controls.Add(this.btnAddNalog);
            this.tabPage3.Controls.Add(this.cbNalozi);
            this.tabPage3.Controls.Add(this.lbNalozi);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(642, 279);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nalozi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDeleteNalog
            // 
            this.btnDeleteNalog.Location = new System.Drawing.Point(502, 235);
            this.btnDeleteNalog.Name = "btnDeleteNalog";
            this.btnDeleteNalog.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteNalog.TabIndex = 4;
            this.btnDeleteNalog.Text = "Izbrisi";
            this.btnDeleteNalog.UseVisualStyleBackColor = true;
            this.btnDeleteNalog.Click += new System.EventHandler(this.btnDeleteNalog_Click);
            // 
            // btnEditNalog
            // 
            this.btnEditNalog.Location = new System.Drawing.Point(362, 235);
            this.btnEditNalog.Name = "btnEditNalog";
            this.btnEditNalog.Size = new System.Drawing.Size(75, 23);
            this.btnEditNalog.TabIndex = 3;
            this.btnEditNalog.Text = "Uredi";
            this.btnEditNalog.UseVisualStyleBackColor = true;
            this.btnEditNalog.Click += new System.EventHandler(this.btnEditNalog_Click);
            // 
            // btnAddNalog
            // 
            this.btnAddNalog.Location = new System.Drawing.Point(231, 235);
            this.btnAddNalog.Name = "btnAddNalog";
            this.btnAddNalog.Size = new System.Drawing.Size(75, 23);
            this.btnAddNalog.TabIndex = 2;
            this.btnAddNalog.Text = "Dodaj";
            this.btnAddNalog.UseVisualStyleBackColor = true;
            this.btnAddNalog.Click += new System.EventHandler(this.btnAddNalog_Click);
            // 
            // cbNalozi
            // 
            this.cbNalozi.FormattingEnabled = true;
            this.cbNalozi.Location = new System.Drawing.Point(9, 238);
            this.cbNalozi.Name = "cbNalozi";
            this.cbNalozi.Size = new System.Drawing.Size(121, 21);
            this.cbNalozi.TabIndex = 1;
            // 
            // lbNalozi
            // 
            this.lbNalozi.FormattingEnabled = true;
            this.lbNalozi.Location = new System.Drawing.Point(3, 3);
            this.lbNalozi.Name = "lbNalozi";
            this.lbNalozi.Size = new System.Drawing.Size(633, 225);
            this.lbNalozi.TabIndex = 0;
            this.lbNalozi.SelectedIndexChanged += new System.EventHandler(this.lbNalozi_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnDeleteAll);
            this.tabPage4.Controls.Add(this.btnRestore);
            this.tabPage4.Controls.Add(this.btnBackup);
            this.tabPage4.Controls.Add(this.btnDAAB);
            this.tabPage4.Controls.Add(this.btnViewXML);
            this.tabPage4.Controls.Add(this.btnCreateXML);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(642, 279);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "XML";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAll.Location = new System.Drawing.Point(330, 102);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(190, 75);
            this.btnDeleteAll.TabIndex = 5;
            this.btnDeleteAll.Text = "Izbrisi sve podatke iz baze";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(102, 228);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(118, 23);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(102, 183);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(118, 23);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnDAAB
            // 
            this.btnDAAB.Location = new System.Drawing.Point(102, 128);
            this.btnDAAB.Name = "btnDAAB";
            this.btnDAAB.Size = new System.Drawing.Size(118, 23);
            this.btnDAAB.TabIndex = 2;
            this.btnDAAB.Text = "DAAB";
            this.btnDAAB.UseVisualStyleBackColor = true;
            this.btnDAAB.Click += new System.EventHandler(this.btnDAAB_Click);
            // 
            // btnViewXML
            // 
            this.btnViewXML.Location = new System.Drawing.Point(102, 74);
            this.btnViewXML.Name = "btnViewXML";
            this.btnViewXML.Size = new System.Drawing.Size(118, 23);
            this.btnViewXML.TabIndex = 1;
            this.btnViewXML.Text = "Pregled XML-a";
            this.btnViewXML.UseVisualStyleBackColor = true;
            this.btnViewXML.Click += new System.EventHandler(this.btnViewXML_Click);
            // 
            // btnCreateXML
            // 
            this.btnCreateXML.Location = new System.Drawing.Point(102, 21);
            this.btnCreateXML.Name = "btnCreateXML";
            this.btnCreateXML.Size = new System.Drawing.Size(118, 23);
            this.btnCreateXML.TabIndex = 0;
            this.btnCreateXML.Text = "Napravi XML";
            this.btnCreateXML.UseVisualStyleBackColor = true;
            this.btnCreateXML.Click += new System.EventHandler(this.btnCreateXML_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 310);
            this.Controls.Add(this.tcMenu);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tcMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lbVozila;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblInicijalniKilometri;
        private System.Windows.Forms.Label lblGodinaProizvodnje;
        private System.Windows.Forms.Label lblMarkVozila;
        private System.Windows.Forms.Label lblTipVozila;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteDriver;
        private System.Windows.Forms.Button btnEditDriver;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Label lblVozacka;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lbVozaci;
        private System.Windows.Forms.Button btnDeleteNalog;
        private System.Windows.Forms.Button btnEditNalog;
        private System.Windows.Forms.Button btnAddNalog;
        private System.Windows.Forms.ComboBox cbNalozi;
        private System.Windows.Forms.ListBox lbNalozi;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnDAAB;
        private System.Windows.Forms.Button btnViewXML;
        private System.Windows.Forms.Button btnCreateXML;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Label lblKilometriTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMarkaVozilaTitle;
        private System.Windows.Forms.Label lblTipVozilaTitle;
        private System.Windows.Forms.Label lblVozackaTitle;
        private System.Windows.Forms.Label lblMobitelTitle;
        private System.Windows.Forms.Label lblImeTitle;
    }
}