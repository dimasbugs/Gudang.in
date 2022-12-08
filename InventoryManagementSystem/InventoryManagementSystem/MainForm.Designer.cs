
namespace InventoryManagementSystem
{
    partial class MainForm
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
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUser = new InventoryManagementSystem.CustomerButton();
            this.btnGudang = new InventoryManagementSystem.CustomerButton();
            this.btnKurir = new InventoryManagementSystem.CustomerButton();
            this.btnPaket = new InventoryManagementSystem.CustomerButton();
            label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGudang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKurir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaket)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            label4.Location = new System.Drawing.Point(531, 67);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 21);
            label4.TabIndex = 13;
            label4.Text = "Paket";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnGudang);
            this.panel1.Controls.Add(this.btnKurir);
            this.panel1.Controls.Add(this.btnPaket);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 94);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(806, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Admin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(698, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gudang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(613, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kurir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(27, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gudang.in";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(-1, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 64);
            this.label1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(30, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sistem Informasi Pengelola Data Gudang";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 94);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(992, 523);
            this.panelMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(883, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnUser
            // 
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnUser.ImageHover")));
            this.btnUser.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnUser.ImageNormal")));
            this.btnUser.Location = new System.Drawing.Point(810, 17);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(33, 32);
            this.btnUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUser.TabIndex = 12;
            this.btnUser.TabStop = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnGudang
            // 
            this.btnGudang.Image = ((System.Drawing.Image)(resources.GetObject("btnGudang.Image")));
            this.btnGudang.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnGudang.ImageHover")));
            this.btnGudang.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnGudang.ImageNormal")));
            this.btnGudang.Location = new System.Drawing.Point(702, 17);
            this.btnGudang.Name = "btnGudang";
            this.btnGudang.Size = new System.Drawing.Size(33, 32);
            this.btnGudang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGudang.TabIndex = 12;
            this.btnGudang.TabStop = false;
            this.btnGudang.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnKurir
            // 
            this.btnKurir.Image = ((System.Drawing.Image)(resources.GetObject("btnKurir.Image")));
            this.btnKurir.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnKurir.ImageHover")));
            this.btnKurir.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnKurir.ImageNormal")));
            this.btnKurir.Location = new System.Drawing.Point(617, 17);
            this.btnKurir.Name = "btnKurir";
            this.btnKurir.Size = new System.Drawing.Size(33, 32);
            this.btnKurir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnKurir.TabIndex = 12;
            this.btnKurir.TabStop = false;
            this.btnKurir.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnPaket
            // 
            this.btnPaket.Image = ((System.Drawing.Image)(resources.GetObject("btnPaket.Image")));
            this.btnPaket.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnPaket.ImageHover")));
            this.btnPaket.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnPaket.ImageNormal")));
            this.btnPaket.Location = new System.Drawing.Point(535, 17);
            this.btnPaket.Name = "btnPaket";
            this.btnPaket.Size = new System.Drawing.Size(33, 32);
            this.btnPaket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPaket.TabIndex = 12;
            this.btnPaket.TabStop = false;
            this.btnPaket.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 617);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGudang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKurir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomerButton btnPaket;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private CustomerButton btnUser;
        private CustomerButton btnGudang;
        private CustomerButton btnKurir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}