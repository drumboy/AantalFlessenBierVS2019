namespace AantalFlessenBierVS2019
{
    partial class frmAantalBakkenBier
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
            this.lblAantalFlessenBier = new System.Windows.Forms.Label();
            this.txtAantalFlessenBier = new System.Windows.Forms.TextBox();
            this.btnBerekenAantalBakkenBier = new System.Windows.Forms.Button();
            this.lblAantalBakkenBier = new System.Windows.Forms.Label();
            this.lblOutputAantalBakkenBier = new System.Windows.Forms.Label();
            this.lblRestFlessenBier = new System.Windows.Forms.Label();
            this.lblOutputRestFlessenBier = new System.Windows.Forms.Label();
            this.lblAantalSixPacks = new System.Windows.Forms.Label();
            this.lblOutputAantalSixPacks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAantalFlessenBier
            // 
            this.lblAantalFlessenBier.AutoSize = true;
            this.lblAantalFlessenBier.Location = new System.Drawing.Point(4, 13);
            this.lblAantalFlessenBier.Name = "lblAantalFlessenBier";
            this.lblAantalFlessenBier.Size = new System.Drawing.Size(97, 13);
            this.lblAantalFlessenBier.TabIndex = 0;
            this.lblAantalFlessenBier.Text = "Aantal Flessen Bier";
            // 
            // txtAantalFlessenBier
            // 
            this.txtAantalFlessenBier.Location = new System.Drawing.Point(108, 8);
            this.txtAantalFlessenBier.Name = "txtAantalFlessenBier";
            this.txtAantalFlessenBier.Size = new System.Drawing.Size(291, 20);
            this.txtAantalFlessenBier.TabIndex = 1;
            this.txtAantalFlessenBier.TextChanged += new System.EventHandler(this.txtAantalFlessenBier_TextChanged);
            // 
            // btnBerekenAantalBakkenBier
            // 
            this.btnBerekenAantalBakkenBier.Location = new System.Drawing.Point(7, 42);
            this.btnBerekenAantalBakkenBier.Name = "btnBerekenAantalBakkenBier";
            this.btnBerekenAantalBakkenBier.Size = new System.Drawing.Size(392, 23);
            this.btnBerekenAantalBakkenBier.TabIndex = 2;
            this.btnBerekenAantalBakkenBier.Text = "Bereken Aantal Bakken Bier";
            this.btnBerekenAantalBakkenBier.UseVisualStyleBackColor = true;
            this.btnBerekenAantalBakkenBier.Click += new System.EventHandler(this.btnBerekenAantalBakkenBier_Click);
            // 
            // lblAantalBakkenBier
            // 
            this.lblAantalBakkenBier.AutoSize = true;
            this.lblAantalBakkenBier.Location = new System.Drawing.Point(14, 85);
            this.lblAantalBakkenBier.Name = "lblAantalBakkenBier";
            this.lblAantalBakkenBier.Size = new System.Drawing.Size(99, 13);
            this.lblAantalBakkenBier.TabIndex = 3;
            this.lblAantalBakkenBier.Text = "Aantal bakken bier:";
            // 
            // lblOutputAantalBakkenBier
            // 
            this.lblOutputAantalBakkenBier.AutoSize = true;
            this.lblOutputAantalBakkenBier.Location = new System.Drawing.Point(130, 84);
            this.lblOutputAantalBakkenBier.Name = "lblOutputAantalBakkenBier";
            this.lblOutputAantalBakkenBier.Size = new System.Drawing.Size(13, 13);
            this.lblOutputAantalBakkenBier.TabIndex = 4;
            this.lblOutputAantalBakkenBier.Text = "0";
            // 
            // lblRestFlessenBier
            // 
            this.lblRestFlessenBier.AutoSize = true;
            this.lblRestFlessenBier.Location = new System.Drawing.Point(14, 147);
            this.lblRestFlessenBier.Name = "lblRestFlessenBier";
            this.lblRestFlessenBier.Size = new System.Drawing.Size(88, 13);
            this.lblRestFlessenBier.TabIndex = 5;
            this.lblRestFlessenBier.Text = "Rest flessen bier:";
            // 
            // lblOutputRestFlessenBier
            // 
            this.lblOutputRestFlessenBier.AutoSize = true;
            this.lblOutputRestFlessenBier.Location = new System.Drawing.Point(130, 147);
            this.lblOutputRestFlessenBier.Name = "lblOutputRestFlessenBier";
            this.lblOutputRestFlessenBier.Size = new System.Drawing.Size(13, 13);
            this.lblOutputRestFlessenBier.TabIndex = 6;
            this.lblOutputRestFlessenBier.Text = "0";
            // 
            // lblAantalSixPacks
            // 
            this.lblAantalSixPacks.AutoSize = true;
            this.lblAantalSixPacks.Location = new System.Drawing.Point(14, 114);
            this.lblAantalSixPacks.Name = "lblAantalSixPacks";
            this.lblAantalSixPacks.Size = new System.Drawing.Size(81, 13);
            this.lblAantalSixPacks.TabIndex = 7;
            this.lblAantalSixPacks.Text = "Aantal 6 packs:";
            // 
            // lblOutputAantalSixPacks
            // 
            this.lblOutputAantalSixPacks.AutoSize = true;
            this.lblOutputAantalSixPacks.Location = new System.Drawing.Point(130, 114);
            this.lblOutputAantalSixPacks.Name = "lblOutputAantalSixPacks";
            this.lblOutputAantalSixPacks.Size = new System.Drawing.Size(13, 13);
            this.lblOutputAantalSixPacks.TabIndex = 8;
            this.lblOutputAantalSixPacks.Text = "0";
            // 
            // frmAantalBakkenBier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 171);
            this.Controls.Add(this.lblOutputAantalSixPacks);
            this.Controls.Add(this.lblAantalSixPacks);
            this.Controls.Add(this.lblOutputRestFlessenBier);
            this.Controls.Add(this.lblRestFlessenBier);
            this.Controls.Add(this.lblOutputAantalBakkenBier);
            this.Controls.Add(this.lblAantalBakkenBier);
            this.Controls.Add(this.btnBerekenAantalBakkenBier);
            this.Controls.Add(this.txtAantalFlessenBier);
            this.Controls.Add(this.lblAantalFlessenBier);
            this.MaximumSize = new System.Drawing.Size(427, 210);
            this.MinimumSize = new System.Drawing.Size(427, 210);
            this.Name = "frmAantalBakkenBier";
            this.Text = "Bereken Aantal Bakken Bier (VS 2019)";
            this.Load += new System.EventHandler(this.frmAantalBakkenBier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAantalFlessenBier;
        private System.Windows.Forms.TextBox txtAantalFlessenBier;
        private System.Windows.Forms.Button btnBerekenAantalBakkenBier;
        private System.Windows.Forms.Label lblAantalBakkenBier;
        private System.Windows.Forms.Label lblOutputAantalBakkenBier;
        private System.Windows.Forms.Label lblRestFlessenBier;
        private System.Windows.Forms.Label lblOutputRestFlessenBier;
        private System.Windows.Forms.Label lblAantalSixPacks;
        private System.Windows.Forms.Label lblOutputAantalSixPacks;
    }
}

