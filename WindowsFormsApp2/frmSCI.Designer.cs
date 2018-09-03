namespace ShotChangeIndexer
{
    partial class frmSCI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSCI));
            this.lblFile = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFFmpeg = new System.Windows.Forms.TextBox();
            this.btnBrowseFF = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lstFound = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.nmrSensi = new System.Windows.Forms.NumericUpDown();
            this.lblSens = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSensi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(12, 9);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(60, 13);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "Input File";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(15, 25);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(299, 20);
            this.txtFile.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(320, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Browse...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(320, 53);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(75, 23);
            this.btnIndex.TabIndex = 3;
            this.btnIndex.Text = "Start";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnStartIndex);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "This program needs FFmpeg to execute.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Download FFmpeg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtFFmpeg
            // 
            this.txtFFmpeg.Location = new System.Drawing.Point(15, 271);
            this.txtFFmpeg.Name = "txtFFmpeg";
            this.txtFFmpeg.Size = new System.Drawing.Size(299, 20);
            this.txtFFmpeg.TabIndex = 6;
            this.txtFFmpeg.TextChanged += new System.EventHandler(this.txtFFmpeg_TextChanged);
            // 
            // btnBrowseFF
            // 
            this.btnBrowseFF.Location = new System.Drawing.Point(320, 270);
            this.btnBrowseFF.Name = "btnBrowseFF";
            this.btnBrowseFF.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFF.TabIndex = 7;
            this.btnBrowseFF.Text = "Browse...";
            this.btnBrowseFF.UseVisualStyleBackColor = true;
            this.btnBrowseFF.Click += new System.EventHandler(this.btnBrowseFF_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(12, 303);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(289, 26);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Licensed under the MIT license - get the latest release from \r\nhttps://github.com" +
    "/Nexz/sci";
            this.lblAuthor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lstFound
            // 
            this.lstFound.FormattingEnabled = true;
            this.lstFound.Location = new System.Drawing.Point(15, 82);
            this.lstFound.Name = "lstFound";
            this.lstFound.Size = new System.Drawing.Size(299, 147);
            this.lstFound.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(162, 57);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Waiting...";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(320, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 147);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save!";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nmrSensi
            // 
            this.nmrSensi.DecimalPlaces = 2;
            this.nmrSensi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmrSensi.Location = new System.Drawing.Point(82, 54);
            this.nmrSensi.Name = "nmrSensi";
            this.nmrSensi.Size = new System.Drawing.Size(73, 20);
            this.nmrSensi.TabIndex = 12;
            this.nmrSensi.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nmrSensi.ValueChanged += new System.EventHandler(this.nmrSensi_ValueChanged);
            // 
            // lblSens
            // 
            this.lblSens.AutoSize = true;
            this.lblSens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSens.Location = new System.Drawing.Point(12, 56);
            this.lblSens.Name = "lblSens";
            this.lblSens.Size = new System.Drawing.Size(69, 13);
            this.lblSens.TabIndex = 13;
            this.lblSens.Text = "Sensitivity:";
            // 
            // frmSCI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 340);
            this.Controls.Add(this.lblSens);
            this.Controls.Add(this.nmrSensi);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstFound);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnBrowseFF);
            this.Controls.Add(this.txtFFmpeg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lblFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSCI";
            this.Text = "ShotChangeIndexer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrSensi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFFmpeg;
        private System.Windows.Forms.Button btnBrowseFF;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ListBox lstFound;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nmrSensi;
        private System.Windows.Forms.Label lblSens;
    }
}

