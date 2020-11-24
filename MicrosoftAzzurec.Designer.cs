namespace oktobar2015
{
    partial class MicrosoftAzzurec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicrosoftAzzurec));
            this.groupBoxTip = new System.Windows.Forms.GroupBox();
            this.radioButtonStandardan = new System.Windows.Forms.RadioButton();
            this.radioButtonDijeljen = new System.Windows.Forms.RadioButton();
            this.radioButtonBesplatan = new System.Windows.Forms.RadioButton();
            this.trackBarProtok = new System.Windows.Forms.TrackBar();
            this.labelProtok = new System.Windows.Forms.Label();
            this.labelBrojSajtova = new System.Windows.Forms.Label();
            this.labelBrojVM = new System.Windows.Forms.Label();
            this.trackBarBrojSajtova = new System.Windows.Forms.TrackBar();
            this.trackBarBrojVM = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxProtok = new System.Windows.Forms.TextBox();
            this.textBoxBrojSajtova = new System.Windows.Forms.TextBox();
            this.textBoxBrojVM = new System.Windows.Forms.TextBox();
            this.labelOkvirnaCijena = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProtok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrojSajtova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrojVM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTip
            // 
            this.groupBoxTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTip.Controls.Add(this.radioButtonStandardan);
            this.groupBoxTip.Controls.Add(this.radioButtonDijeljen);
            this.groupBoxTip.Controls.Add(this.radioButtonBesplatan);
            this.groupBoxTip.Location = new System.Drawing.Point(16, 13);
            this.groupBoxTip.Name = "groupBoxTip";
            this.groupBoxTip.Size = new System.Drawing.Size(538, 61);
            this.groupBoxTip.TabIndex = 0;
            this.groupBoxTip.TabStop = false;
            this.groupBoxTip.Text = "TIP";
            this.groupBoxTip.Enter += new System.EventHandler(this.groupBoxTip_Enter);
            // 
            // radioButtonStandardan
            // 
            this.radioButtonStandardan.AutoSize = true;
            this.radioButtonStandardan.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButtonStandardan.Location = new System.Drawing.Point(455, 16);
            this.radioButtonStandardan.Name = "radioButtonStandardan";
            this.radioButtonStandardan.Size = new System.Drawing.Size(80, 42);
            this.radioButtonStandardan.TabIndex = 2;
            this.radioButtonStandardan.TabStop = true;
            this.radioButtonStandardan.Text = "Standardan";
            this.radioButtonStandardan.UseVisualStyleBackColor = true;
            this.radioButtonStandardan.CheckedChanged += new System.EventHandler(this.groupBoxTip_Enter);
            // 
            // radioButtonDijeljen
            // 
            this.radioButtonDijeljen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonDijeljen.AutoSize = true;
            this.radioButtonDijeljen.Location = new System.Drawing.Point(224, 26);
            this.radioButtonDijeljen.Name = "radioButtonDijeljen";
            this.radioButtonDijeljen.Size = new System.Drawing.Size(59, 17);
            this.radioButtonDijeljen.TabIndex = 1;
            this.radioButtonDijeljen.TabStop = true;
            this.radioButtonDijeljen.Text = "Dijeljen";
            this.radioButtonDijeljen.UseVisualStyleBackColor = true;
            this.radioButtonDijeljen.CheckedChanged += new System.EventHandler(this.groupBoxTip_Enter);
            // 
            // radioButtonBesplatan
            // 
            this.radioButtonBesplatan.AutoSize = true;
            this.radioButtonBesplatan.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButtonBesplatan.Location = new System.Drawing.Point(3, 16);
            this.radioButtonBesplatan.Name = "radioButtonBesplatan";
            this.radioButtonBesplatan.Size = new System.Drawing.Size(72, 42);
            this.radioButtonBesplatan.TabIndex = 0;
            this.radioButtonBesplatan.TabStop = true;
            this.radioButtonBesplatan.Text = "Besplatan";
            this.radioButtonBesplatan.UseVisualStyleBackColor = true;
            this.radioButtonBesplatan.CheckedChanged += new System.EventHandler(this.groupBoxTip_Enter);
            // 
            // trackBarProtok
            // 
            this.trackBarProtok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarProtok.Enabled = false;
            this.trackBarProtok.LargeChange = 1;
            this.trackBarProtok.Location = new System.Drawing.Point(3, 20);
            this.trackBarProtok.Name = "trackBarProtok";
            this.trackBarProtok.Size = new System.Drawing.Size(397, 55);
            this.trackBarProtok.TabIndex = 1;
            this.trackBarProtok.TickFrequency = 20;
            this.trackBarProtok.Scroll += new System.EventHandler(this.trackBarProtok_Scroll);
            // 
            // labelProtok
            // 
            this.labelProtok.AutoSize = true;
            this.labelProtok.Location = new System.Drawing.Point(3, 0);
            this.labelProtok.Name = "labelProtok";
            this.labelProtok.Size = new System.Drawing.Size(41, 13);
            this.labelProtok.TabIndex = 2;
            this.labelProtok.Text = "Protok:";
            // 
            // labelBrojSajtova
            // 
            this.labelBrojSajtova.AutoSize = true;
            this.labelBrojSajtova.Location = new System.Drawing.Point(3, 78);
            this.labelBrojSajtova.Name = "labelBrojSajtova";
            this.labelBrojSajtova.Size = new System.Drawing.Size(65, 13);
            this.labelBrojSajtova.TabIndex = 4;
            this.labelBrojSajtova.Text = "Broj sajtova:";
            // 
            // labelBrojVM
            // 
            this.labelBrojVM.AutoSize = true;
            this.labelBrojVM.Location = new System.Drawing.Point(3, 156);
            this.labelBrojVM.Name = "labelBrojVM";
            this.labelBrojVM.Size = new System.Drawing.Size(47, 13);
            this.labelBrojVM.TabIndex = 6;
            this.labelBrojVM.Text = "Broj VM:";
            // 
            // trackBarBrojSajtova
            // 
            this.trackBarBrojSajtova.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarBrojSajtova.Enabled = false;
            this.trackBarBrojSajtova.Location = new System.Drawing.Point(3, 98);
            this.trackBarBrojSajtova.Name = "trackBarBrojSajtova";
            this.trackBarBrojSajtova.Size = new System.Drawing.Size(397, 55);
            this.trackBarBrojSajtova.TabIndex = 3;
            this.trackBarBrojSajtova.Scroll += new System.EventHandler(this.trackBarBrojSajtova_Scroll);
            // 
            // trackBarBrojVM
            // 
            this.trackBarBrojVM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarBrojVM.Enabled = false;
            this.trackBarBrojVM.Location = new System.Drawing.Point(3, 176);
            this.trackBarBrojVM.Name = "trackBarBrojVM";
            this.trackBarBrojVM.Size = new System.Drawing.Size(397, 57);
            this.trackBarBrojVM.TabIndex = 5;
            this.trackBarBrojVM.Scroll += new System.EventHandler(this.trackBarBrojVM_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::oktobar2015.Properties.Resources.Slika;
            this.pictureBox1.Location = new System.Drawing.Point(0, 363);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxProtok
            // 
            this.textBoxProtok.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxProtok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProtok.Enabled = false;
            this.textBoxProtok.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProtok.Location = new System.Drawing.Point(406, 20);
            this.textBoxProtok.Name = "textBoxProtok";
            this.textBoxProtok.Size = new System.Drawing.Size(129, 38);
            this.textBoxProtok.TabIndex = 8;
            this.textBoxProtok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBrojSajtova
            // 
            this.textBoxBrojSajtova.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxBrojSajtova.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBrojSajtova.Enabled = false;
            this.textBoxBrojSajtova.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBrojSajtova.Location = new System.Drawing.Point(406, 98);
            this.textBoxBrojSajtova.Name = "textBoxBrojSajtova";
            this.textBoxBrojSajtova.Size = new System.Drawing.Size(129, 38);
            this.textBoxBrojSajtova.TabIndex = 9;
            this.textBoxBrojSajtova.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBrojVM
            // 
            this.textBoxBrojVM.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxBrojVM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBrojVM.Enabled = false;
            this.textBoxBrojVM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBrojVM.Location = new System.Drawing.Point(406, 176);
            this.textBoxBrojVM.Name = "textBoxBrojVM";
            this.textBoxBrojVM.Size = new System.Drawing.Size(129, 38);
            this.textBoxBrojVM.TabIndex = 10;
            this.textBoxBrojVM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelOkvirnaCijena
            // 
            this.labelOkvirnaCijena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOkvirnaCijena.AutoSize = true;
            this.labelOkvirnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOkvirnaCijena.Location = new System.Drawing.Point(330, 331);
            this.labelOkvirnaCijena.Name = "labelOkvirnaCijena";
            this.labelOkvirnaCijena.Size = new System.Drawing.Size(224, 18);
            this.labelOkvirnaCijena.TabIndex = 11;
            this.labelOkvirnaCijena.Text = "Okvirna cijena:                 0.00KM";
            this.labelOkvirnaCijena.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.trackBarBrojVM, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxBrojVM, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxProtok, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxBrojSajtova, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelProtok, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBarProtok, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackBarBrojSajtova, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelBrojVM, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelBrojSajtova, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.291667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.04167F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.291667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.04167F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.291667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.04167F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 236);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // MicrosoftAzzurec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelOkvirnaCijena);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxTip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(528, 505);
            this.Name = "MicrosoftAzzurec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microsoft Azure Calculator";
            this.groupBoxTip.ResumeLayout(false);
            this.groupBoxTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProtok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrojSajtova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrojVM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTip;
        private System.Windows.Forms.RadioButton radioButtonStandardan;
        private System.Windows.Forms.RadioButton radioButtonDijeljen;
        private System.Windows.Forms.RadioButton radioButtonBesplatan;
        private System.Windows.Forms.TrackBar trackBarProtok;
        private System.Windows.Forms.Label labelProtok;
        private System.Windows.Forms.Label labelBrojSajtova;
        private System.Windows.Forms.Label labelBrojVM;
        private System.Windows.Forms.TrackBar trackBarBrojSajtova;
        private System.Windows.Forms.TrackBar trackBarBrojVM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxProtok;
        private System.Windows.Forms.TextBox textBoxBrojSajtova;
        private System.Windows.Forms.TextBox textBoxBrojVM;
        private System.Windows.Forms.Label labelOkvirnaCijena;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

