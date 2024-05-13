
namespace GUI
{
    partial class frmLop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingNavigatorLop = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaLopHoc = new System.Windows.Forms.TextBox();
            this.txtTenLopHoc = new System.Windows.Forms.TextBox();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.cmbKhoiLop = new System.Windows.Forms.ComboBox();
            this.cmbNamHoc = new System.Windows.Forms.ComboBox();
            this.cmbGiaoVien = new System.Windows.Forms.ComboBox();
            this.btnLuuDS = new System.Windows.Forms.Button();
            this.btnThemKhoiLop = new System.Windows.Forms.Button();
            this.btnThemNamHoc = new System.Windows.Forms.Button();
            this.btnThemGV = new System.Windows.Forms.Button();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.colMaLopHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLopHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhoiLop = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNamHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaGiaoVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLop)).BeginInit();
            this.bindingNavigatorLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemGV);
            this.panel1.Controls.Add(this.btnThemNamHoc);
            this.panel1.Controls.Add(this.btnThemKhoiLop);
            this.panel1.Controls.Add(this.btnLuuDS);
            this.panel1.Controls.Add(this.cmbGiaoVien);
            this.panel1.Controls.Add(this.cmbNamHoc);
            this.panel1.Controls.Add(this.cmbKhoiLop);
            this.panel1.Controls.Add(this.txtSiSo);
            this.panel1.Controls.Add(this.txtTenLopHoc);
            this.panel1.Controls.Add(this.txtMaLopHoc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 662);
            this.panel1.TabIndex = 0;
            // 
            // bindingNavigatorLop
            // 
            this.bindingNavigatorLop.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorLop.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorLop.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorLop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorLop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem});
            this.bindingNavigatorLop.Location = new System.Drawing.Point(298, 0);
            this.bindingNavigatorLop.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorLop.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorLop.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorLop.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorLop.Name = "bindingNavigatorLop";
            this.bindingNavigatorLop.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorLop.Size = new System.Drawing.Size(742, 33);
            this.bindingNavigatorLop.TabIndex = 1;
            this.bindingNavigatorLop.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // dgvLop
            // 
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLopHoc,
            this.colTenLopHoc,
            this.colMaKhoiLop,
            this.colSiSo,
            this.colMaNamHoc,
            this.colMaGiaoVien});
            this.dgvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLop.Location = new System.Drawing.Point(298, 33);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 62;
            this.dgvLop.RowTemplate.Height = 28;
            this.dgvLop.Size = new System.Drawing.Size(742, 629);
            this.dgvLop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên lớp học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sĩ số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khối lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Năm học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giáo viên chủ nhiệm";
            // 
            // txtMaLopHoc
            // 
            this.txtMaLopHoc.Location = new System.Drawing.Point(16, 61);
            this.txtMaLopHoc.Name = "txtMaLopHoc";
            this.txtMaLopHoc.Size = new System.Drawing.Size(205, 26);
            this.txtMaLopHoc.TabIndex = 1;
            // 
            // txtTenLopHoc
            // 
            this.txtTenLopHoc.Location = new System.Drawing.Point(16, 113);
            this.txtTenLopHoc.Name = "txtTenLopHoc";
            this.txtTenLopHoc.Size = new System.Drawing.Size(205, 26);
            this.txtTenLopHoc.TabIndex = 1;
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(16, 165);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(205, 26);
            this.txtSiSo.TabIndex = 1;
            // 
            // cmbKhoiLop
            // 
            this.cmbKhoiLop.FormattingEnabled = true;
            this.cmbKhoiLop.Location = new System.Drawing.Point(16, 217);
            this.cmbKhoiLop.Name = "cmbKhoiLop";
            this.cmbKhoiLop.Size = new System.Drawing.Size(205, 28);
            this.cmbKhoiLop.TabIndex = 2;
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.Location = new System.Drawing.Point(16, 271);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(205, 28);
            this.cmbNamHoc.TabIndex = 2;
            // 
            // cmbGiaoVien
            // 
            this.cmbGiaoVien.FormattingEnabled = true;
            this.cmbGiaoVien.Location = new System.Drawing.Point(16, 325);
            this.cmbGiaoVien.Name = "cmbGiaoVien";
            this.cmbGiaoVien.Size = new System.Drawing.Size(205, 28);
            this.cmbGiaoVien.TabIndex = 2;
            // 
            // btnLuuDS
            // 
            this.btnLuuDS.Location = new System.Drawing.Point(89, 391);
            this.btnLuuDS.Name = "btnLuuDS";
            this.btnLuuDS.Size = new System.Drawing.Size(84, 29);
            this.btnLuuDS.TabIndex = 3;
            this.btnLuuDS.Text = "Lưu";
            this.btnLuuDS.UseVisualStyleBackColor = true;
            this.btnLuuDS.Click += new System.EventHandler(this.btnLuuDS_Click);
            // 
            // btnThemKhoiLop
            // 
            this.btnThemKhoiLop.Location = new System.Drawing.Point(227, 217);
            this.btnThemKhoiLop.Name = "btnThemKhoiLop";
            this.btnThemKhoiLop.Size = new System.Drawing.Size(45, 29);
            this.btnThemKhoiLop.TabIndex = 3;
            this.btnThemKhoiLop.Text = "+";
            this.btnThemKhoiLop.UseVisualStyleBackColor = true;
            this.btnThemKhoiLop.Click += new System.EventHandler(this.btnThemKhoiLop_Click);
            // 
            // btnThemNamHoc
            // 
            this.btnThemNamHoc.Location = new System.Drawing.Point(227, 268);
            this.btnThemNamHoc.Name = "btnThemNamHoc";
            this.btnThemNamHoc.Size = new System.Drawing.Size(45, 31);
            this.btnThemNamHoc.TabIndex = 3;
            this.btnThemNamHoc.Text = "+";
            this.btnThemNamHoc.UseVisualStyleBackColor = true;
            this.btnThemNamHoc.Click += new System.EventHandler(this.btnThemNamHoc_Click);
            // 
            // btnThemGV
            // 
            this.btnThemGV.Location = new System.Drawing.Point(227, 325);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(45, 31);
            this.btnThemGV.TabIndex = 3;
            this.btnThemGV.Text = "+";
            this.btnThemGV.UseVisualStyleBackColor = true;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorSaveItem.Text = "toolStripButton1";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // colMaLopHoc
            // 
            this.colMaLopHoc.DataPropertyName = "MaLopHoc";
            this.colMaLopHoc.HeaderText = "Mã lớp học";
            this.colMaLopHoc.MinimumWidth = 8;
            this.colMaLopHoc.Name = "colMaLopHoc";
            this.colMaLopHoc.Width = 150;
            // 
            // colTenLopHoc
            // 
            this.colTenLopHoc.DataPropertyName = "TenLopHoc";
            this.colTenLopHoc.HeaderText = "Tên lớp học";
            this.colTenLopHoc.MinimumWidth = 8;
            this.colTenLopHoc.Name = "colTenLopHoc";
            this.colTenLopHoc.Width = 150;
            // 
            // colMaKhoiLop
            // 
            this.colMaKhoiLop.DataPropertyName = "KhoiLop";
            this.colMaKhoiLop.HeaderText = "Khối lớp";
            this.colMaKhoiLop.MinimumWidth = 8;
            this.colMaKhoiLop.Name = "colMaKhoiLop";
            this.colMaKhoiLop.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaKhoiLop.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMaKhoiLop.Width = 150;
            // 
            // colSiSo
            // 
            this.colSiSo.DataPropertyName = "SiSo";
            this.colSiSo.HeaderText = "Sĩ số";
            this.colSiSo.MinimumWidth = 8;
            this.colSiSo.Name = "colSiSo";
            this.colSiSo.Width = 150;
            // 
            // colMaNamHoc
            // 
            this.colMaNamHoc.HeaderText = "Năm học";
            this.colMaNamHoc.MinimumWidth = 8;
            this.colMaNamHoc.Name = "colMaNamHoc";
            this.colMaNamHoc.Width = 150;
            // 
            // colMaGiaoVien
            // 
            this.colMaGiaoVien.HeaderText = "Mã giáo viên";
            this.colMaGiaoVien.MinimumWidth = 8;
            this.colMaGiaoVien.Name = "colMaGiaoVien";
            this.colMaGiaoVien.Width = 150;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 662);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.bindingNavigatorLop);
            this.Controls.Add(this.panel1);
            this.Name = "frmLop";
            this.Text = "frmLop";
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLop)).EndInit();
            this.bindingNavigatorLop.ResumeLayout(false);
            this.bindingNavigatorLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bindingNavigatorLop;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnThemGV;
        private System.Windows.Forms.Button btnThemNamHoc;
        private System.Windows.Forms.Button btnThemKhoiLop;
        private System.Windows.Forms.Button btnLuuDS;
        private System.Windows.Forms.ComboBox cmbGiaoVien;
        private System.Windows.Forms.ComboBox cmbNamHoc;
        private System.Windows.Forms.ComboBox cmbKhoiLop;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.TextBox txtTenLopHoc;
        private System.Windows.Forms.TextBox txtMaLopHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLopHoc;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaKhoiLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiSo;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNamHoc;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaGiaoVien;
    }
}