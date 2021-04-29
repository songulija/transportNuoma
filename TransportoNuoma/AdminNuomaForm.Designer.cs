namespace TransportoNuoma
{
    partial class AdminNuomaForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.addNuomaPanel = new System.Windows.Forms.Panel();
            this.addNuoma = new System.Windows.Forms.Button();
            this.updateNuomaShow = new System.Windows.Forms.Button();
            this.AddNuomaShow = new System.Windows.Forms.Button();
            this.getNuoma = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addNuomaTransId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addNuomaKlientoNr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updateNuomaPanel = new System.Windows.Forms.Panel();
            this.updateNuomaKlientoNr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateNuomaTransId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateNuoma = new System.Windows.Forms.Button();
            this.updateNuomaNuomosNr = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.addNuomaRezId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TransportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.addNuomaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.updateNuomaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(137, 28);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // TransportPanel
            // 
            this.TransportPanel.Controls.Add(this.updateNuomaPanel);
            this.TransportPanel.Controls.Add(this.label5);
            this.TransportPanel.Controls.Add(this.dataGridView2);
            this.TransportPanel.Controls.Add(this.addNuomaPanel);
            this.TransportPanel.Controls.Add(this.updateNuomaShow);
            this.TransportPanel.Controls.Add(this.AddNuomaShow);
            this.TransportPanel.Controls.Add(this.getNuoma);
            this.TransportPanel.Controls.Add(this.dataGridView1);
            this.TransportPanel.Controls.Add(this.label1);
            this.TransportPanel.Location = new System.Drawing.Point(12, 46);
            this.TransportPanel.Name = "TransportPanel";
            this.TransportPanel.Size = new System.Drawing.Size(558, 584);
            this.TransportPanel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Transportai";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(18, 206);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(528, 111);
            this.dataGridView2.TabIndex = 18;
            // 
            // addNuomaPanel
            // 
            this.addNuomaPanel.Controls.Add(this.addNuomaRezId);
            this.addNuomaPanel.Controls.Add(this.label2);
            this.addNuomaPanel.Controls.Add(this.addNuomaKlientoNr);
            this.addNuomaPanel.Controls.Add(this.label9);
            this.addNuomaPanel.Controls.Add(this.addNuomaTransId);
            this.addNuomaPanel.Controls.Add(this.label8);
            this.addNuomaPanel.Controls.Add(this.addNuoma);
            this.addNuomaPanel.Location = new System.Drawing.Point(18, 352);
            this.addNuomaPanel.Name = "addNuomaPanel";
            this.addNuomaPanel.Size = new System.Drawing.Size(189, 187);
            this.addNuomaPanel.TabIndex = 5;
            this.addNuomaPanel.Visible = false;
            // 
            // addNuoma
            // 
            this.addNuoma.Location = new System.Drawing.Point(20, 137);
            this.addNuoma.Name = "addNuoma";
            this.addNuoma.Size = new System.Drawing.Size(158, 33);
            this.addNuoma.TabIndex = 14;
            this.addNuoma.Text = "Add Nuoma";
            this.addNuoma.UseVisualStyleBackColor = true;
            this.addNuoma.Click += new System.EventHandler(this.addNuoma_Click);
            // 
            // updateNuomaShow
            // 
            this.updateNuomaShow.Location = new System.Drawing.Point(202, 323);
            this.updateNuomaShow.Name = "updateNuomaShow";
            this.updateNuomaShow.Size = new System.Drawing.Size(110, 23);
            this.updateNuomaShow.TabIndex = 4;
            this.updateNuomaShow.Text = "Update Nuoma";
            this.updateNuomaShow.UseVisualStyleBackColor = true;
            this.updateNuomaShow.Click += new System.EventHandler(this.updateNuomaShow_Click);
            // 
            // AddNuomaShow
            // 
            this.AddNuomaShow.Location = new System.Drawing.Point(110, 323);
            this.AddNuomaShow.Name = "AddNuomaShow";
            this.AddNuomaShow.Size = new System.Drawing.Size(86, 23);
            this.AddNuomaShow.TabIndex = 3;
            this.AddNuomaShow.Text = "Add Nuoma";
            this.AddNuomaShow.UseVisualStyleBackColor = true;
            this.AddNuomaShow.Click += new System.EventHandler(this.AddNuomaShow_Click);
            // 
            // getNuoma
            // 
            this.getNuoma.Location = new System.Drawing.Point(18, 323);
            this.getNuoma.Name = "getNuoma";
            this.getNuoma.Size = new System.Drawing.Size(86, 23);
            this.getNuoma.TabIndex = 2;
            this.getNuoma.Text = "Get Nuoma";
            this.getNuoma.UseVisualStyleBackColor = true;
            this.getNuoma.Click += new System.EventHandler(this.getNuoma_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 134);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuoma";
            // 
            // addNuomaTransId
            // 
            this.addNuomaTransId.Location = new System.Drawing.Point(20, 26);
            this.addNuomaTransId.Name = "addNuomaTransId";
            this.addNuomaTransId.Size = new System.Drawing.Size(158, 20);
            this.addNuomaTransId.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Trans_Id";
            // 
            // addNuomaKlientoNr
            // 
            this.addNuomaKlientoNr.Location = new System.Drawing.Point(20, 67);
            this.addNuomaKlientoNr.Name = "addNuomaKlientoNr";
            this.addNuomaKlientoNr.Size = new System.Drawing.Size(158, 20);
            this.addNuomaKlientoNr.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Kliento_nr";
            // 
            // updateNuomaPanel
            // 
            this.updateNuomaPanel.Controls.Add(this.updateNuomaNuomosNr);
            this.updateNuomaPanel.Controls.Add(this.label14);
            this.updateNuomaPanel.Controls.Add(this.updateNuomaKlientoNr);
            this.updateNuomaPanel.Controls.Add(this.label3);
            this.updateNuomaPanel.Controls.Add(this.updateNuomaTransId);
            this.updateNuomaPanel.Controls.Add(this.label4);
            this.updateNuomaPanel.Controls.Add(this.updateNuoma);
            this.updateNuomaPanel.Location = new System.Drawing.Point(213, 352);
            this.updateNuomaPanel.Name = "updateNuomaPanel";
            this.updateNuomaPanel.Size = new System.Drawing.Size(200, 187);
            this.updateNuomaPanel.TabIndex = 23;
            this.updateNuomaPanel.Visible = false;
            // 
            // updateNuomaKlientoNr
            // 
            this.updateNuomaKlientoNr.Location = new System.Drawing.Point(20, 67);
            this.updateNuomaKlientoNr.Name = "updateNuomaKlientoNr";
            this.updateNuomaKlientoNr.Size = new System.Drawing.Size(169, 20);
            this.updateNuomaKlientoNr.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kliento_nr";
            // 
            // updateNuomaTransId
            // 
            this.updateNuomaTransId.Location = new System.Drawing.Point(20, 26);
            this.updateNuomaTransId.Name = "updateNuomaTransId";
            this.updateNuomaTransId.Size = new System.Drawing.Size(169, 20);
            this.updateNuomaTransId.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Trans_Id";
            // 
            // updateNuoma
            // 
            this.updateNuoma.Location = new System.Drawing.Point(20, 137);
            this.updateNuoma.Name = "updateNuoma";
            this.updateNuoma.Size = new System.Drawing.Size(169, 33);
            this.updateNuoma.TabIndex = 14;
            this.updateNuoma.Text = "Update nuoma";
            this.updateNuoma.UseVisualStyleBackColor = true;
            this.updateNuoma.Click += new System.EventHandler(this.updateNuoma_Click);
            // 
            // updateNuomaNuomosNr
            // 
            this.updateNuomaNuomosNr.Location = new System.Drawing.Point(20, 111);
            this.updateNuomaNuomosNr.Name = "updateNuomaNuomosNr";
            this.updateNuomaNuomosNr.Size = new System.Drawing.Size(169, 20);
            this.updateNuomaNuomosNr.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Nuomos_nr";
            // 
            // addNuomaRezId
            // 
            this.addNuomaRezId.Location = new System.Drawing.Point(20, 111);
            this.addNuomaRezId.Name = "addNuomaRezId";
            this.addNuomaRezId.Size = new System.Drawing.Size(158, 20);
            this.addNuomaRezId.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Rez id";
            // 
            // AdminNuomaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 656);
            this.Controls.Add(this.TransportPanel);
            this.Controls.Add(this.backButton);
            this.Name = "AdminNuomaForm";
            this.Text = "AdminNuomaForm";
            this.TransportPanel.ResumeLayout(false);
            this.TransportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.addNuomaPanel.ResumeLayout(false);
            this.addNuomaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.updateNuomaPanel.ResumeLayout(false);
            this.updateNuomaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel TransportPanel;
        private System.Windows.Forms.Panel updateNuomaPanel;
        private System.Windows.Forms.TextBox updateNuomaNuomosNr;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox updateNuomaKlientoNr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox updateNuomaTransId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updateNuoma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel addNuomaPanel;
        private System.Windows.Forms.TextBox addNuomaKlientoNr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addNuomaTransId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addNuoma;
        private System.Windows.Forms.Button updateNuomaShow;
        private System.Windows.Forms.Button AddNuomaShow;
        private System.Windows.Forms.Button getNuoma;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addNuomaRezId;
        private System.Windows.Forms.Label label2;
    }
}