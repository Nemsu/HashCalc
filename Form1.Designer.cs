
namespace HashCalc
{
    partial class frmHashCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHashCalc));
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.cbbHash = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSaoChep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(53, 12);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(282, 20);
            this.txtFile.TabIndex = 0;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(341, 11);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(84, 23);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "Chọn tập tin...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(96, 36);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(329, 23);
            this.btnKiemTra.TabIndex = 2;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(15, 67);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(320, 20);
            this.txtHash.TabIndex = 3;
            // 
            // cbbHash
            // 
            this.cbbHash.FormattingEnabled = true;
            this.cbbHash.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256"});
            this.cbbHash.Location = new System.Drawing.Point(15, 38);
            this.cbbHash.Name = "cbbHash";
            this.cbbHash.Size = new System.Drawing.Size(75, 21);
            this.cbbHash.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tập tin:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 94);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(409, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.Location = new System.Drawing.Point(341, 66);
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(83, 23);
            this.btnSaoChep.TabIndex = 9;
            this.btnSaoChep.Text = "Sao chép";
            this.btnSaoChep.UseVisualStyleBackColor = true;
            this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChep_Click);
            // 
            // frmHashCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 131);
            this.Controls.Add(this.btnSaoChep);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbHash);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHashCalc";
            this.Text = "HashCalc";
            this.Load += new System.EventHandler(this.frmHashCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.ComboBox cbbHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSaoChep;
    }
}

