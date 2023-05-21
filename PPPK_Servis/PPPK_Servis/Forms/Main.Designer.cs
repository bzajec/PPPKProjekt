
namespace PPPK_Servis.Forms
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
            this.lbServices = new System.Windows.Forms.ListBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnHtml = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblServisTitle = new System.Windows.Forms.Label();
            this.lblVoziloTitle = new System.Windows.Forms.Label();
            this.lblItemTitle = new System.Windows.Forms.Label();
            this.lblServis = new System.Windows.Forms.Label();
            this.lblVozilo = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblMarkaTitle = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbServices
            // 
            this.lbServices.FormattingEnabled = true;
            this.lbServices.Location = new System.Drawing.Point(13, 13);
            this.lbServices.Name = "lbServices";
            this.lbServices.Size = new System.Drawing.Size(615, 251);
            this.lbServices.TabIndex = 0;
            this.lbServices.SelectedIndexChanged += new System.EventHandler(this.lbServices_SelectedIndexChanged);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(13, 355);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(117, 39);
            this.btnAddService.TabIndex = 1;
            this.btnAddService.Text = "Dodaj";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnHtml
            // 
            this.btnHtml.Location = new System.Drawing.Point(179, 355);
            this.btnHtml.Name = "btnHtml";
            this.btnHtml.Size = new System.Drawing.Size(117, 39);
            this.btnHtml.TabIndex = 2;
            this.btnHtml.Text = "HTML";
            this.btnHtml.UseVisualStyleBackColor = true;
            this.btnHtml.Click += new System.EventHandler(this.btnHtml_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(511, 355);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 39);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Ažuriraj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(345, 355);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblServisTitle
            // 
            this.lblServisTitle.AutoSize = true;
            this.lblServisTitle.Location = new System.Drawing.Point(12, 279);
            this.lblServisTitle.Name = "lblServisTitle";
            this.lblServisTitle.Size = new System.Drawing.Size(36, 13);
            this.lblServisTitle.TabIndex = 5;
            this.lblServisTitle.Text = "Servis";
            // 
            // lblVoziloTitle
            // 
            this.lblVoziloTitle.AutoSize = true;
            this.lblVoziloTitle.Location = new System.Drawing.Point(97, 279);
            this.lblVoziloTitle.Name = "lblVoziloTitle";
            this.lblVoziloTitle.Size = new System.Drawing.Size(35, 13);
            this.lblVoziloTitle.TabIndex = 6;
            this.lblVoziloTitle.Text = "Vozilo";
            // 
            // lblItemTitle
            // 
            this.lblItemTitle.AutoSize = true;
            this.lblItemTitle.Location = new System.Drawing.Point(267, 279);
            this.lblItemTitle.Name = "lblItemTitle";
            this.lblItemTitle.Size = new System.Drawing.Size(27, 13);
            this.lblItemTitle.TabIndex = 7;
            this.lblItemTitle.Text = "Item";
            // 
            // lblServis
            // 
            this.lblServis.AutoSize = true;
            this.lblServis.Location = new System.Drawing.Point(13, 310);
            this.lblServis.Name = "lblServis";
            this.lblServis.Size = new System.Drawing.Size(0, 13);
            this.lblServis.TabIndex = 8;
            // 
            // lblVozilo
            // 
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.Location = new System.Drawing.Point(97, 310);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(0, 13);
            this.lblVozilo.TabIndex = 9;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(265, 310);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(0, 13);
            this.lblItem.TabIndex = 10;
            // 
            // lblMarkaTitle
            // 
            this.lblMarkaTitle.AutoSize = true;
            this.lblMarkaTitle.Location = new System.Drawing.Point(181, 279);
            this.lblMarkaTitle.Name = "lblMarkaTitle";
            this.lblMarkaTitle.Size = new System.Drawing.Size(37, 13);
            this.lblMarkaTitle.TabIndex = 11;
            this.lblMarkaTitle.Text = "Marka";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(181, 310);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(0, 13);
            this.lblMarka.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 406);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblMarkaTitle);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.lblServis);
            this.Controls.Add(this.lblItemTitle);
            this.Controls.Add(this.lblVoziloTitle);
            this.Controls.Add(this.lblServisTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHtml);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.lbServices);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbServices;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnHtml;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblServisTitle;
        private System.Windows.Forms.Label lblVoziloTitle;
        private System.Windows.Forms.Label lblItemTitle;
        private System.Windows.Forms.Label lblServis;
        private System.Windows.Forms.Label lblVozilo;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblMarkaTitle;
        private System.Windows.Forms.Label lblMarka;
    }
}