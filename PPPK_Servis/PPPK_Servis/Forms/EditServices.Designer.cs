
namespace PPPK_Servis.Forms
{
    partial class EditServices
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
            this.lbVehicles = new System.Windows.Forms.ListBox();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblVehicles = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblGodina = new System.Windows.Forms.Label();
            this.lblKilometri = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbVehicles
            // 
            this.lbVehicles.FormattingEnabled = true;
            this.lbVehicles.Location = new System.Drawing.Point(12, 50);
            this.lbVehicles.Name = "lbVehicles";
            this.lbVehicles.Size = new System.Drawing.Size(193, 186);
            this.lbVehicles.TabIndex = 0;
            this.lbVehicles.SelectedIndexChanged += new System.EventHandler(this.lbVehicles_SelectedIndexChanged);
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(12, 297);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(193, 186);
            this.lbItems.TabIndex = 1;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(397, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 61);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Dodaj servis";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(397, 277);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(154, 61);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Dodaj item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblVehicles
            // 
            this.lblVehicles.AutoSize = true;
            this.lblVehicles.Location = new System.Drawing.Point(12, 13);
            this.lblVehicles.Name = "lblVehicles";
            this.lblVehicles.Size = new System.Drawing.Size(38, 13);
            this.lblVehicles.TabIndex = 4;
            this.lblVehicles.Text = "Vozilo:";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(12, 260);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(32, 13);
            this.lblItems.TabIndex = 5;
            this.lblItems.Text = "Itemi:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(476, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Natrag";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(250, 79);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(52, 13);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Tip vozila";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(250, 122);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(67, 13);
            this.lblMarka.TabIndex = 8;
            this.lblMarka.Text = "Marka vozila";
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Location = new System.Drawing.Point(250, 165);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(41, 13);
            this.lblGodina.TabIndex = 9;
            this.lblGodina.Text = "Godina";
            // 
            // lblKilometri
            // 
            this.lblKilometri.AutoSize = true;
            this.lblKilometri.Location = new System.Drawing.Point(250, 208);
            this.lblKilometri.Name = "lblKilometri";
            this.lblKilometri.Size = new System.Drawing.Size(46, 13);
            this.lblKilometri.TabIndex = 10;
            this.lblKilometri.Text = "Kilometri";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(253, 374);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 11;
            this.lblItem.Text = "Item";
            // 
            // EditServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 495);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblKilometri);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lblVehicles);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.lbVehicles);
            this.Name = "EditServices";
            this.Text = "EditServices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbVehicles;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblVehicles;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Label lblKilometri;
        private System.Windows.Forms.Label lblItem;
    }
}