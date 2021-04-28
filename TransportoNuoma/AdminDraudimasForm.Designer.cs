namespace TransportoNuoma
{
    partial class AdminDraudimasForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.TransportPanel = new System.Windows.Forms.Panel();
            this.updateDraudimasPanel = new System.Windows.Forms.Panel();
            this.updateDraudTiekId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateDraudTiekPav = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateDraudTIek = new System.Windows.Forms.Button();
            this.addDraudimasPanel = new System.Windows.Forms.Panel();
            this.addDraudTIek = new System.Windows.Forms.Button();
            this.addDraudTiekPav = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateDraudTiekShow = new System.Windows.Forms.Button();
            this.addDraudTiekShow = new System.Windows.Forms.Button();
            this.getDraudTiek = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TransportPanel.SuspendLayout();
            this.updateDraudimasPanel.SuspendLayout();
            this.addDraudimasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(13, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(137, 28);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // TransportPanel
            // 
            this.TransportPanel.Controls.Add(this.updateDraudimasPanel);
            this.TransportPanel.Controls.Add(this.addDraudimasPanel);
            this.TransportPanel.Controls.Add(this.updateDraudTiekShow);
            this.TransportPanel.Controls.Add(this.addDraudTiekShow);
            this.TransportPanel.Controls.Add(this.getDraudTiek);
            this.TransportPanel.Controls.Add(this.dataGridView1);
            this.TransportPanel.Controls.Add(this.label1);
            this.TransportPanel.Location = new System.Drawing.Point(24, 47);
            this.TransportPanel.Name = "TransportPanel";
            this.TransportPanel.Size = new System.Drawing.Size(384, 584);
            this.TransportPanel.TabIndex = 3;
            // 
            // updateDraudimasPanel
            // 
            this.updateDraudimasPanel.Controls.Add(this.updateDraudTiekId);
            this.updateDraudimasPanel.Controls.Add(this.label3);
            this.updateDraudimasPanel.Controls.Add(this.updateDraudTiekPav);
            this.updateDraudimasPanel.Controls.Add(this.label4);
            this.updateDraudimasPanel.Controls.Add(this.updateDraudTIek);
            this.updateDraudimasPanel.Location = new System.Drawing.Point(204, 247);
            this.updateDraudimasPanel.Name = "updateDraudimasPanel";
            this.updateDraudimasPanel.Size = new System.Drawing.Size(165, 145);
            this.updateDraudimasPanel.TabIndex = 17;
            this.updateDraudimasPanel.Visible = false;
            // 
            // updateDraudTiekId
            // 
            this.updateDraudTiekId.Location = new System.Drawing.Point(20, 67);
            this.updateDraudTiekId.Name = "updateDraudTiekId";
            this.updateDraudTiekId.Size = new System.Drawing.Size(126, 20);
            this.updateDraudTiekId.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tiekejo Id";
            // 
            // updateDraudTiekPav
            // 
            this.updateDraudTiekPav.Location = new System.Drawing.Point(20, 27);
            this.updateDraudTiekPav.Name = "updateDraudTiekPav";
            this.updateDraudTiekPav.Size = new System.Drawing.Size(126, 20);
            this.updateDraudTiekPav.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pavadinimas";
            // 
            // updateDraudTIek
            // 
            this.updateDraudTIek.Location = new System.Drawing.Point(20, 93);
            this.updateDraudTIek.Name = "updateDraudTIek";
            this.updateDraudTIek.Size = new System.Drawing.Size(126, 33);
            this.updateDraudTIek.TabIndex = 14;
            this.updateDraudTIek.Text = "Update";
            this.updateDraudTIek.UseVisualStyleBackColor = true;
            this.updateDraudTIek.Click += new System.EventHandler(this.updateDraudTIek_Click);
            // 
            // addDraudimasPanel
            // 
            this.addDraudimasPanel.Controls.Add(this.addDraudTIek);
            this.addDraudimasPanel.Controls.Add(this.addDraudTiekPav);
            this.addDraudimasPanel.Controls.Add(this.label2);
            this.addDraudimasPanel.Location = new System.Drawing.Point(18, 248);
            this.addDraudimasPanel.Name = "addDraudimasPanel";
            this.addDraudimasPanel.Size = new System.Drawing.Size(178, 102);
            this.addDraudimasPanel.TabIndex = 5;
            this.addDraudimasPanel.Visible = false;
            // 
            // addDraudTIek
            // 
            this.addDraudTIek.Location = new System.Drawing.Point(20, 59);
            this.addDraudTIek.Name = "addDraudTIek";
            this.addDraudTIek.Size = new System.Drawing.Size(126, 33);
            this.addDraudTIek.TabIndex = 14;
            this.addDraudTIek.Text = "Add";
            this.addDraudTIek.UseVisualStyleBackColor = true;
            this.addDraudTIek.Click += new System.EventHandler(this.addDraudTIek_Click);
            // 
            // addDraudTiekPav
            // 
            this.addDraudTiekPav.Location = new System.Drawing.Point(20, 26);
            this.addDraudTiekPav.Name = "addDraudTiekPav";
            this.addDraudTiekPav.Size = new System.Drawing.Size(126, 20);
            this.addDraudTiekPav.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pavadinimas";
            // 
            // updateDraudTiekShow
            // 
            this.updateDraudTiekShow.Location = new System.Drawing.Point(259, 218);
            this.updateDraudTiekShow.Name = "updateDraudTiekShow";
            this.updateDraudTiekShow.Size = new System.Drawing.Size(110, 23);
            this.updateDraudTiekShow.TabIndex = 4;
            this.updateDraudTiekShow.Text = "Update Draudimas";
            this.updateDraudTiekShow.UseVisualStyleBackColor = true;
            this.updateDraudTiekShow.Click += new System.EventHandler(this.updateDraudTiekShow_Click);
            // 
            // addDraudTiekShow
            // 
            this.addDraudTiekShow.Location = new System.Drawing.Point(134, 218);
            this.addDraudTiekShow.Name = "addDraudTiekShow";
            this.addDraudTiekShow.Size = new System.Drawing.Size(119, 23);
            this.addDraudTiekShow.TabIndex = 3;
            this.addDraudTiekShow.Text = "Add Draudimas";
            this.addDraudTiekShow.UseVisualStyleBackColor = true;
            this.addDraudTiekShow.Click += new System.EventHandler(this.addDraudTiekShow_Click);
            // 
            // getDraudTiek
            // 
            this.getDraudTiek.Location = new System.Drawing.Point(18, 219);
            this.getDraudTiek.Name = "getDraudTiek";
            this.getDraudTiek.Size = new System.Drawing.Size(110, 23);
            this.getDraudTiek.TabIndex = 2;
            this.getDraudTiek.Text = "Get Draudimas";
            this.getDraudTiek.UseVisualStyleBackColor = true;
            this.getDraudTiek.Click += new System.EventHandler(this.getDraudTiek_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 171);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Draudimo tiekejai";
            // 
            // AdminDraudimasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 639);
            this.Controls.Add(this.TransportPanel);
            this.Controls.Add(this.backButton);
            this.Name = "AdminDraudimasForm";
            this.Text = "AdminDraudimasForm";
            this.TransportPanel.ResumeLayout(false);
            this.TransportPanel.PerformLayout();
            this.updateDraudimasPanel.ResumeLayout(false);
            this.updateDraudimasPanel.PerformLayout();
            this.addDraudimasPanel.ResumeLayout(false);
            this.addDraudimasPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel TransportPanel;
        private System.Windows.Forms.Panel updateDraudimasPanel;
        private System.Windows.Forms.TextBox updateDraudTiekId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox updateDraudTiekPav;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updateDraudTIek;
        private System.Windows.Forms.Panel addDraudimasPanel;
        private System.Windows.Forms.Button addDraudTIek;
        private System.Windows.Forms.TextBox addDraudTiekPav;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateDraudTiekShow;
        private System.Windows.Forms.Button addDraudTiekShow;
        private System.Windows.Forms.Button getDraudTiek;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}