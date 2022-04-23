
namespace Proje_Hastane
{
    partial class frmgirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgirisler));
            this.BtnHastaGirişi = new System.Windows.Forms.Button();
            this.BtnDoktorGirişi = new System.Windows.Forms.Button();
            this.BtnSekreterGirişi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnHastaGirişi
            // 
            this.BtnHastaGirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHastaGirişi.BackgroundImage")));
            this.BtnHastaGirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastaGirişi.Location = new System.Drawing.Point(21, 184);
            this.BtnHastaGirişi.Name = "BtnHastaGirişi";
            this.BtnHastaGirişi.Size = new System.Drawing.Size(222, 147);
            this.BtnHastaGirişi.TabIndex = 0;
            this.BtnHastaGirişi.UseVisualStyleBackColor = true;
            this.BtnHastaGirişi.Click += new System.EventHandler(this.BtnHastaGirişi_Click);
            // 
            // BtnDoktorGirişi
            // 
            this.BtnDoktorGirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoktorGirişi.BackgroundImage")));
            this.BtnDoktorGirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktorGirişi.Location = new System.Drawing.Point(268, 184);
            this.BtnDoktorGirişi.Name = "BtnDoktorGirişi";
            this.BtnDoktorGirişi.Size = new System.Drawing.Size(222, 147);
            this.BtnDoktorGirişi.TabIndex = 1;
            this.BtnDoktorGirişi.UseVisualStyleBackColor = true;
            this.BtnDoktorGirişi.Click += new System.EventHandler(this.BtnDoktorGirişi_Click);
            // 
            // BtnSekreterGirişi
            // 
            this.BtnSekreterGirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSekreterGirişi.BackgroundImage")));
            this.BtnSekreterGirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSekreterGirişi.Location = new System.Drawing.Point(526, 184);
            this.BtnSekreterGirişi.Name = "BtnSekreterGirişi";
            this.BtnSekreterGirişi.Size = new System.Drawing.Size(222, 147);
            this.BtnSekreterGirişi.TabIndex = 2;
            this.BtnSekreterGirişi.UseVisualStyleBackColor = true;
            this.BtnSekreterGirişi.Click += new System.EventHandler(this.BtnSekreterGirişi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktorlar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreterler";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(471, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 55);
            this.label4.TabIndex = 7;
            this.label4.Text = "DEMİRBAŞ HOSPİTAL";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-1, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 145);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Location = new System.Drawing.Point(-1, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 19);
            this.panel2.TabIndex = 9;
            // 
            // frmgirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(795, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSekreterGirişi);
            this.Controls.Add(this.BtnDoktorGirişi);
            this.Controls.Add(this.BtnHastaGirişi);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmgirisler";
            this.Text = "DEMİRBAŞ HOSPİTAL GİRİŞ";
            this.Load += new System.EventHandler(this.frmgirisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHastaGirişi;
        private System.Windows.Forms.Button BtnDoktorGirişi;
        private System.Windows.Forms.Button BtnSekreterGirişi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

