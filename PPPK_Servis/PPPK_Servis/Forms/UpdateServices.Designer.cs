
namespace PPPK_Servis.Forms
{
    partial class UpdateServices
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblVehicles = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.lbVehicles = new System.Windows.Forms.ListBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblKilometri = new System.Windows.Forms.Label();
            this.lblGodina = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(476, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Natrag";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(12, 256);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(32, 13);
            this.lblItems.TabIndex = 12;
            this.lblItems.Text = "Itemi:";
            // 
            // lblVehicles
            // 
            this.lblVehicles.AutoSize = true;
            this.lblVehicles.Location = new System.Drawing.Point(12, 9);
            this.lblVehicles.Name = "lblVehicles";
            this.lblVehicles.Size = new System.Drawing.Size(38, 13);
            this.lblVehicles.TabIndex = 11;
            this.lblVehicles.Text = "Vozilo:";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(394, 275);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(154, 61);
            this.btnAddItem.TabIndex = 10;
            this.btnAddItem.Text = "Dodaj item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(394, 136);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 61);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Ažuriraj servis";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(12, 293);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(193, 186);
            this.lbItems.TabIndex = 8;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // lbVehicles
            // 
            this.lbVehicles.FormattingEnabled = true;
            this.lbVehicles.Location = new System.Drawing.Point(12, 46);
            this.lbVehicles.Name = "lbVehicles";
            this.lbVehicles.Size = new System.Drawing.Size(193, 186);
            this.lbVehicles.TabIndex = 7;
            this.lbVehicles.SelectedIndexChanged += new System.EventHandler(this.lbVehicles_SelectedIndexChanged);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(251, 375);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 18;
            this.lblItem.Text = "Item";
            // 
            // lblKilometri
            // 
            this.lblKilometri.AutoSize = true;
            this.lblKilometri.Location = new System.Drawing.Point(248, 209);
            this.lblKilometri.Name = "lblKilometri";
            this.lblKilometri.Size = new System.Drawing.Size(46, 13);
            this.lblKilometri.TabIndex = 17;
            this.lblKilometri.Text = "Kilometri";
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Location = new System.Drawing.Point(248, 166);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(41, 13);
            this.lblGodina.TabIndex = 16;
            this.lblGodina.Text = "Godina";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(248, 123);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(67, 13);
            this.lblMarka.TabIndex = 15;
            this.lblMarka.Text = "Marka vozila";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(248, 80);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(52, 13);
            this.lblType.TabIndex = 14;
            this.lblType.Text = "Tip vozila";
            // 
            // UpdateServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 495);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblKilometri);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lblVehicles);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.lbVehicles);
            this.Name = "UpdateServices";
            this.Text = "UpdateServices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblVehicles;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.ListBox lbVehicles;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblKilometri;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblType;
    }
}