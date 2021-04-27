namespace TransportoNuoma
{
    partial class MainFormAdmin
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
            this.TransportPanel = new System.Windows.Forms.Panel();
            this.addPanel = new System.Windows.Forms.Panel();
            this.addUpdateButton = new System.Windows.Forms.Button();
            this.transQrKodas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.transMarkesId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.transKaina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.transGamybM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.transSpalva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.transTipas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.transNr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateTransShow = new System.Windows.Forms.Button();
            this.AddTransportShow = new System.Windows.Forms.Button();
            this.getTransport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.UpdateTransTransId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.UpdateTransKaina = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.updateTransSpalva = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.updateTransNr = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TransportPanel.SuspendLayout();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransportPanel
            // 
            this.TransportPanel.Controls.Add(this.updatePanel);
            this.TransportPanel.Controls.Add(this.addPanel);
            this.TransportPanel.Controls.Add(this.updateTransShow);
            this.TransportPanel.Controls.Add(this.AddTransportShow);
            this.TransportPanel.Controls.Add(this.getTransport);
            this.TransportPanel.Controls.Add(this.dataGridView1);
            this.TransportPanel.Controls.Add(this.label1);
            this.TransportPanel.Location = new System.Drawing.Point(12, 28);
            this.TransportPanel.Name = "TransportPanel";
            this.TransportPanel.Size = new System.Drawing.Size(382, 631);
            this.TransportPanel.TabIndex = 0;
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.addUpdateButton);
            this.addPanel.Controls.Add(this.transQrKodas);
            this.addPanel.Controls.Add(this.label8);
            this.addPanel.Controls.Add(this.transMarkesId);
            this.addPanel.Controls.Add(this.label7);
            this.addPanel.Controls.Add(this.transKaina);
            this.addPanel.Controls.Add(this.label6);
            this.addPanel.Controls.Add(this.transGamybM);
            this.addPanel.Controls.Add(this.label5);
            this.addPanel.Controls.Add(this.transSpalva);
            this.addPanel.Controls.Add(this.label4);
            this.addPanel.Controls.Add(this.transTipas);
            this.addPanel.Controls.Add(this.label3);
            this.addPanel.Controls.Add(this.transNr);
            this.addPanel.Controls.Add(this.label2);
            this.addPanel.Location = new System.Drawing.Point(18, 249);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(178, 363);
            this.addPanel.TabIndex = 5;
            this.addPanel.Visible = false;
            // 
            // addUpdateButton
            // 
            this.addUpdateButton.Location = new System.Drawing.Point(20, 292);
            this.addUpdateButton.Name = "addUpdateButton";
            this.addUpdateButton.Size = new System.Drawing.Size(126, 33);
            this.addUpdateButton.TabIndex = 14;
            this.addUpdateButton.Text = "Add";
            this.addUpdateButton.UseVisualStyleBackColor = true;
            this.addUpdateButton.Click += new System.EventHandler(this.addUpdateButton_Click);
            // 
            // transQrKodas
            // 
            this.transQrKodas.Location = new System.Drawing.Point(20, 266);
            this.transQrKodas.Name = "transQrKodas";
            this.transQrKodas.Size = new System.Drawing.Size(126, 20);
            this.transQrKodas.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "QrKodas";
            // 
            // transMarkesId
            // 
            this.transMarkesId.Location = new System.Drawing.Point(20, 226);
            this.transMarkesId.Name = "transMarkesId";
            this.transMarkesId.Size = new System.Drawing.Size(126, 20);
            this.transMarkesId.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "MarkesId";
            // 
            // transKaina
            // 
            this.transKaina.Location = new System.Drawing.Point(20, 186);
            this.transKaina.Name = "transKaina";
            this.transKaina.Size = new System.Drawing.Size(126, 20);
            this.transKaina.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kaina";
            // 
            // transGamybM
            // 
            this.transGamybM.Location = new System.Drawing.Point(20, 146);
            this.transGamybM.Name = "transGamybM";
            this.transGamybM.Size = new System.Drawing.Size(126, 20);
            this.transGamybM.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gamybos_Metai";
            // 
            // transSpalva
            // 
            this.transSpalva.Location = new System.Drawing.Point(20, 106);
            this.transSpalva.Name = "transSpalva";
            this.transSpalva.Size = new System.Drawing.Size(126, 20);
            this.transSpalva.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Spalva";
            // 
            // transTipas
            // 
            this.transTipas.Location = new System.Drawing.Point(20, 66);
            this.transTipas.Name = "transTipas";
            this.transTipas.Size = new System.Drawing.Size(126, 20);
            this.transTipas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipas";
            // 
            // transNr
            // 
            this.transNr.Location = new System.Drawing.Point(20, 26);
            this.transNr.Name = "transNr";
            this.transNr.Size = new System.Drawing.Size(126, 20);
            this.transNr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trans_nr";
            // 
            // updateTransShow
            // 
            this.updateTransShow.Location = new System.Drawing.Point(202, 219);
            this.updateTransShow.Name = "updateTransShow";
            this.updateTransShow.Size = new System.Drawing.Size(110, 23);
            this.updateTransShow.TabIndex = 4;
            this.updateTransShow.Text = "Update Transport";
            this.updateTransShow.UseVisualStyleBackColor = true;
            this.updateTransShow.Click += new System.EventHandler(this.updateTransShow_Click);
            // 
            // AddTransportShow
            // 
            this.AddTransportShow.Location = new System.Drawing.Point(110, 219);
            this.AddTransportShow.Name = "AddTransportShow";
            this.AddTransportShow.Size = new System.Drawing.Size(86, 23);
            this.AddTransportShow.TabIndex = 3;
            this.AddTransportShow.Text = "Add Transport";
            this.AddTransportShow.UseVisualStyleBackColor = true;
            this.AddTransportShow.Click += new System.EventHandler(this.AddTransportShow_Click);
            // 
            // getTransport
            // 
            this.getTransport.Location = new System.Drawing.Point(18, 220);
            this.getTransport.Name = "getTransport";
            this.getTransport.Size = new System.Drawing.Size(86, 23);
            this.getTransport.TabIndex = 2;
            this.getTransport.Text = "Get Transport";
            this.getTransport.UseVisualStyleBackColor = true;
            this.getTransport.Click += new System.EventHandler(this.getTransport_Click);
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
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transport";
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.UpdateTransTransId);
            this.updatePanel.Controls.Add(this.label9);
            this.updatePanel.Controls.Add(this.updateButton);
            this.updatePanel.Controls.Add(this.UpdateTransKaina);
            this.updatePanel.Controls.Add(this.label12);
            this.updatePanel.Controls.Add(this.updateTransSpalva);
            this.updatePanel.Controls.Add(this.label14);
            this.updatePanel.Controls.Add(this.updateTransNr);
            this.updatePanel.Controls.Add(this.label16);
            this.updatePanel.Location = new System.Drawing.Point(204, 248);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(178, 363);
            this.updatePanel.TabIndex = 17;
            this.updatePanel.Visible = false;
            // 
            // UpdateTransTransId
            // 
            this.UpdateTransTransId.Location = new System.Drawing.Point(20, 147);
            this.UpdateTransTransId.Name = "UpdateTransTransId";
            this.UpdateTransTransId.Size = new System.Drawing.Size(126, 20);
            this.UpdateTransTransId.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "TransId";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(20, 187);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(126, 33);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // UpdateTransKaina
            // 
            this.UpdateTransKaina.Location = new System.Drawing.Point(20, 107);
            this.UpdateTransKaina.Name = "UpdateTransKaina";
            this.UpdateTransKaina.Size = new System.Drawing.Size(126, 20);
            this.UpdateTransKaina.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Kaina";
            // 
            // updateTransSpalva
            // 
            this.updateTransSpalva.Location = new System.Drawing.Point(20, 66);
            this.updateTransSpalva.Name = "updateTransSpalva";
            this.updateTransSpalva.Size = new System.Drawing.Size(126, 20);
            this.updateTransSpalva.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Spalva";
            // 
            // updateTransNr
            // 
            this.updateTransNr.Location = new System.Drawing.Point(20, 26);
            this.updateTransNr.Name = "updateTransNr";
            this.updateTransNr.Size = new System.Drawing.Size(126, 20);
            this.updateTransNr.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Trans_nr";
            // 
            // MainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 655);
            this.Controls.Add(this.TransportPanel);
            this.Name = "MainFormAdmin";
            this.Text = "Admin Window";
            this.TransportPanel.ResumeLayout(false);
            this.TransportPanel.PerformLayout();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TransportPanel;
        private System.Windows.Forms.Button updateTransShow;
        private System.Windows.Forms.Button AddTransportShow;
        private System.Windows.Forms.Button getTransport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.TextBox transQrKodas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox transMarkesId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox transKaina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox transGamybM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox transSpalva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox transTipas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox transNr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addUpdateButton;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.TextBox UpdateTransTransId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox UpdateTransKaina;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox updateTransSpalva;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox updateTransNr;
        private System.Windows.Forms.Label label16;
    }
}