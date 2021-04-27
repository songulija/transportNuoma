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
            this.addUpdatePanel = new System.Windows.Forms.Panel();
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
            this.TransportPanel.SuspendLayout();
            this.addUpdatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TransportPanel
            // 
            this.TransportPanel.Controls.Add(this.addUpdatePanel);
            this.TransportPanel.Controls.Add(this.updateTransShow);
            this.TransportPanel.Controls.Add(this.AddTransportShow);
            this.TransportPanel.Controls.Add(this.getTransport);
            this.TransportPanel.Controls.Add(this.dataGridView1);
            this.TransportPanel.Controls.Add(this.label1);
            this.TransportPanel.Location = new System.Drawing.Point(12, 28);
            this.TransportPanel.Name = "TransportPanel";
            this.TransportPanel.Size = new System.Drawing.Size(382, 615);
            this.TransportPanel.TabIndex = 0;
            // 
            // addUpdatePanel
            // 
            this.addUpdatePanel.Controls.Add(this.addUpdateButton);
            this.addUpdatePanel.Controls.Add(this.transQrKodas);
            this.addUpdatePanel.Controls.Add(this.label8);
            this.addUpdatePanel.Controls.Add(this.transMarkesId);
            this.addUpdatePanel.Controls.Add(this.label7);
            this.addUpdatePanel.Controls.Add(this.transKaina);
            this.addUpdatePanel.Controls.Add(this.label6);
            this.addUpdatePanel.Controls.Add(this.transGamybM);
            this.addUpdatePanel.Controls.Add(this.label5);
            this.addUpdatePanel.Controls.Add(this.transSpalva);
            this.addUpdatePanel.Controls.Add(this.label4);
            this.addUpdatePanel.Controls.Add(this.transTipas);
            this.addUpdatePanel.Controls.Add(this.label3);
            this.addUpdatePanel.Controls.Add(this.transNr);
            this.addUpdatePanel.Controls.Add(this.label2);
            this.addUpdatePanel.Location = new System.Drawing.Point(18, 249);
            this.addUpdatePanel.Name = "addUpdatePanel";
            this.addUpdatePanel.Size = new System.Drawing.Size(167, 337);
            this.addUpdatePanel.TabIndex = 5;
            this.addUpdatePanel.Visible = false;
            // 
            // addUpdateButton
            // 
            this.addUpdateButton.Location = new System.Drawing.Point(17, 301);
            this.addUpdateButton.Name = "addUpdateButton";
            this.addUpdateButton.Size = new System.Drawing.Size(126, 33);
            this.addUpdateButton.TabIndex = 14;
            this.addUpdateButton.Text = "Add";
            this.addUpdateButton.UseVisualStyleBackColor = true;
            this.addUpdateButton.Click += new System.EventHandler(this.addUpdateButton_Click);
            // 
            // transQrKodas
            // 
            this.transQrKodas.Location = new System.Drawing.Point(17, 274);
            this.transQrKodas.Name = "transQrKodas";
            this.transQrKodas.Size = new System.Drawing.Size(126, 20);
            this.transQrKodas.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "QrKodas";
            // 
            // transMarkesId
            // 
            this.transMarkesId.Location = new System.Drawing.Point(17, 234);
            this.transMarkesId.Name = "transMarkesId";
            this.transMarkesId.Size = new System.Drawing.Size(126, 20);
            this.transMarkesId.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "MarkesId";
            // 
            // transKaina
            // 
            this.transKaina.Location = new System.Drawing.Point(17, 194);
            this.transKaina.Name = "transKaina";
            this.transKaina.Size = new System.Drawing.Size(126, 20);
            this.transKaina.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kaina";
            // 
            // transGamybM
            // 
            this.transGamybM.Location = new System.Drawing.Point(17, 154);
            this.transGamybM.Name = "transGamybM";
            this.transGamybM.Size = new System.Drawing.Size(126, 20);
            this.transGamybM.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gamybos_Metai";
            // 
            // transSpalva
            // 
            this.transSpalva.Location = new System.Drawing.Point(17, 114);
            this.transSpalva.Name = "transSpalva";
            this.transSpalva.Size = new System.Drawing.Size(126, 20);
            this.transSpalva.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Spalva";
            // 
            // transTipas
            // 
            this.transTipas.Location = new System.Drawing.Point(17, 74);
            this.transTipas.Name = "transTipas";
            this.transTipas.Size = new System.Drawing.Size(126, 20);
            this.transTipas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipas";
            // 
            // transNr
            // 
            this.transNr.Location = new System.Drawing.Point(17, 34);
            this.transNr.Name = "transNr";
            this.transNr.Size = new System.Drawing.Size(126, 20);
            this.transNr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 17);
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
            this.addUpdatePanel.ResumeLayout(false);
            this.addUpdatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TransportPanel;
        private System.Windows.Forms.Button updateTransShow;
        private System.Windows.Forms.Button AddTransportShow;
        private System.Windows.Forms.Button getTransport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel addUpdatePanel;
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
    }
}