
using System.Windows.Forms;

namespace QuanLiHocSinh
{
    partial class fHome
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.btnHS = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnKQ = new System.Windows.Forms.Button();
            this.btnHocLuc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMon = new System.Windows.Forms.Button();
            this.btnNam = new System.Windows.Forms.Button();
            this.btnDiem = new System.Windows.Forms.Button();
            this.btnLop = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1586, 135);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.btnHS);
            this.tabPage1.Controls.Add(this.btnHome);
            this.tabPage1.Controls.Add(this.btnKQ);
            this.tabPage1.Controls.Add(this.btnHocLuc);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnMon);
            this.tabPage1.Controls.Add(this.btnNam);
            this.tabPage1.Controls.Add(this.btnDiem);
            this.tabPage1.Controls.Add(this.btnLop);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1578, 95);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1151, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 48);
            this.button4.TabIndex = 0;
            this.button4.Text = "Giáo viên";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnHS
            // 
            this.btnHS.Location = new System.Drawing.Point(1019, 23);
            this.btnHS.Name = "btnHS";
            this.btnHS.Size = new System.Drawing.Size(126, 48);
            this.btnHS.TabIndex = 0;
            this.btnHS.Text = "Học sinh";
            this.btnHS.UseVisualStyleBackColor = true;
            this.btnHS.Click += new System.EventHandler(this.btnHS_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(3, 23);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(116, 48);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnKQ
            // 
            this.btnKQ.Location = new System.Drawing.Point(887, 23);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(126, 48);
            this.btnKQ.TabIndex = 0;
            this.btnKQ.Text = "Kết quả";
            this.btnKQ.UseVisualStyleBackColor = true;
            this.btnKQ.Click += new System.EventHandler(this.btnKQ_Click);
            // 
            // btnHocLuc
            // 
            this.btnHocLuc.Location = new System.Drawing.Point(755, 23);
            this.btnHocLuc.Name = "btnHocLuc";
            this.btnHocLuc.Size = new System.Drawing.Size(126, 48);
            this.btnHocLuc.TabIndex = 0;
            this.btnHocLuc.Text = "Học lực";
            this.btnHocLuc.UseVisualStyleBackColor = true;
            this.btnHocLuc.Click += new System.EventHandler(this.btnHocLuc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hạnh kiểm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMon
            // 
            this.btnMon.Location = new System.Drawing.Point(491, 23);
            this.btnMon.Name = "btnMon";
            this.btnMon.Size = new System.Drawing.Size(126, 48);
            this.btnMon.TabIndex = 0;
            this.btnMon.Text = "Môn học";
            this.btnMon.UseVisualStyleBackColor = true;
            this.btnMon.Click += new System.EventHandler(this.btnMon_Click);
            // 
            // btnNam
            // 
            this.btnNam.Location = new System.Drawing.Point(369, 23);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(116, 48);
            this.btnNam.TabIndex = 0;
            this.btnNam.Text = "Năm học";
            this.btnNam.UseVisualStyleBackColor = true;
            // 
            // btnDiem
            // 
            this.btnDiem.Location = new System.Drawing.Point(247, 23);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(116, 48);
            this.btnDiem.TabIndex = 0;
            this.btnDiem.Text = "Điểm";
            this.btnDiem.UseVisualStyleBackColor = true;
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // btnLop
            // 
            this.btnLop.Location = new System.Drawing.Point(125, 23);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(116, 48);
            this.btnLop.TabIndex = 0;
            this.btnLop.Text = "Lớp học";
            this.btnLop.UseVisualStyleBackColor = true;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1578, 95);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(1578, 95);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tra cứu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 36);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Size = new System.Drawing.Size(1578, 95);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Trợ giúp";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1586, 889);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1586, 754);
            this.panel3.TabIndex = 1;
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 889);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fHome";
            this.Text = "Trang chủ - Phần mềm quản lí học sinh";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnHS;
        private Button btnHome;
        private Button btnMon;
        private Button btnNam;
        private Button btnDiem;
        private Button btnLop;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panel1;
        private Panel panel3;
        private Button button4;
        private Button btnKQ;
        private Button btnHocLuc;
        private Button button1;
    }
}