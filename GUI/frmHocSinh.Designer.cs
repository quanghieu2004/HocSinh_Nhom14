
namespace GUI
{
    partial class frmHocSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocSinh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbGTinhNu = new System.Windows.Forms.CheckBox();
            this.ckbGTinhNam = new System.Windows.Forms.CheckBox();
            this.btnLuuDS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThemDanToc = new System.Windows.Forms.Button();
            this.cmbTonGiao = new System.Windows.Forms.ComboBox();
            this.cmbDanToc = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenHocSinh = new System.Windows.Forms.TextBox();
            this.txtMaHocSinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigatorHocSinh = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.colMaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinhNu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDanToc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaTonGiao = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocSinh)).BeginInit();
            this.bindingNavigatorHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbGTinhNu);
            this.panel1.Controls.Add(this.ckbGTinhNam);
            this.panel1.Controls.Add(this.btnLuuDS);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnThemDanToc);
            this.panel1.Controls.Add(this.cmbTonGiao);
            this.panel1.Controls.Add(this.cmbDanToc);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtTenHocSinh);
            this.panel1.Controls.Add(this.txtMaHocSinh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 670);
            this.panel1.TabIndex = 0;
            // 
            // ckbGTinhNu
            // 
            this.ckbGTinhNu.AutoSize = true;
            this.ckbGTinhNu.Location = new System.Drawing.Point(201, 141);
            this.ckbGTinhNu.Name = "ckbGTinhNu";
            this.ckbGTinhNu.Size = new System.Drawing.Size(55, 24);
            this.ckbGTinhNu.TabIndex = 16;
            this.ckbGTinhNu.Text = "Nữ";
            this.ckbGTinhNu.UseVisualStyleBackColor = true;
            // 
            // ckbGTinhNam
            // 
            this.ckbGTinhNam.AutoSize = true;
            this.ckbGTinhNam.Location = new System.Drawing.Point(110, 141);
            this.ckbGTinhNam.Name = "ckbGTinhNam";
            this.ckbGTinhNam.Size = new System.Drawing.Size(68, 24);
            this.ckbGTinhNam.TabIndex = 16;
            this.ckbGTinhNam.Text = "Nam";
            this.ckbGTinhNam.UseVisualStyleBackColor = true;
            // 
            // btnLuuDS
            // 
            this.btnLuuDS.Location = new System.Drawing.Point(92, 348);
            this.btnLuuDS.Name = "btnLuuDS";
            this.btnLuuDS.Size = new System.Drawing.Size(86, 40);
            this.btnLuuDS.TabIndex = 15;
            this.btnLuuDS.Text = "Lưu";
            this.btnLuuDS.UseVisualStyleBackColor = true;
            this.btnLuuDS.Click += new System.EventHandler(this.btnLuuDS_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThemDanToc
            // 
            this.btnThemDanToc.Location = new System.Drawing.Point(211, 258);
            this.btnThemDanToc.Name = "btnThemDanToc";
            this.btnThemDanToc.Size = new System.Drawing.Size(45, 33);
            this.btnThemDanToc.TabIndex = 14;
            this.btnThemDanToc.Text = "+";
            this.btnThemDanToc.UseVisualStyleBackColor = true;
            this.btnThemDanToc.Click += new System.EventHandler(this.btnThemDanToc_Click);
            // 
            // cmbTonGiao
            // 
            this.cmbTonGiao.FormattingEnabled = true;
            this.cmbTonGiao.Location = new System.Drawing.Point(12, 314);
            this.cmbTonGiao.Name = "cmbTonGiao";
            this.cmbTonGiao.Size = new System.Drawing.Size(189, 28);
            this.cmbTonGiao.TabIndex = 13;
            // 
            // cmbDanToc
            // 
            this.cmbDanToc.FormattingEnabled = true;
            this.cmbDanToc.Location = new System.Drawing.Point(14, 258);
            this.cmbDanToc.Name = "cmbDanToc";
            this.cmbDanToc.Size = new System.Drawing.Size(189, 28);
            this.cmbDanToc.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(14, 204);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(189, 26);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtTenHocSinh
            // 
            this.txtTenHocSinh.Location = new System.Drawing.Point(16, 109);
            this.txtTenHocSinh.Name = "txtTenHocSinh";
            this.txtTenHocSinh.Size = new System.Drawing.Size(189, 26);
            this.txtTenHocSinh.TabIndex = 10;
            // 
            // txtMaHocSinh
            // 
            this.txtMaHocSinh.Location = new System.Drawing.Point(16, 55);
            this.txtMaHocSinh.Name = "txtMaHocSinh";
            this.txtMaHocSinh.Size = new System.Drawing.Size(189, 26);
            this.txtMaHocSinh.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tôn giáo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dân tộc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên học sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã học sinh";
            // 
            // bindingNavigatorHocSinh
            // 
            this.bindingNavigatorHocSinh.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorHocSinh.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorHocSinh.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorHocSinh.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorHocSinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorHocSinh.Location = new System.Drawing.Point(299, 0);
            this.bindingNavigatorHocSinh.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorHocSinh.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorHocSinh.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorHocSinh.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorHocSinh.Name = "bindingNavigatorHocSinh";
            this.bindingNavigatorHocSinh.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorHocSinh.Size = new System.Drawing.Size(770, 33);
            this.bindingNavigatorHocSinh.TabIndex = 1;
            this.bindingNavigatorHocSinh.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
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
            // dgvHocSinh
            // 
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHocSinh,
            this.colHoTen,
            this.colGioiTinhNu,
            this.colDiaChi,
            this.colMaDanToc,
            this.colMaTonGiao});
            this.dgvHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocSinh.Location = new System.Drawing.Point(299, 33);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.RowHeadersWidth = 62;
            this.dgvHocSinh.RowTemplate.Height = 28;
            this.dgvHocSinh.Size = new System.Drawing.Size(770, 637);
            this.dgvHocSinh.TabIndex = 2;
            // 
            // colMaHocSinh
            // 
            this.colMaHocSinh.DataPropertyName = "MaHocSinh";
            this.colMaHocSinh.HeaderText = "Mã học sinh";
            this.colMaHocSinh.MinimumWidth = 8;
            this.colMaHocSinh.Name = "colMaHocSinh";
            this.colMaHocSinh.Width = 150;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "TenHocSinh";
            this.colHoTen.HeaderText = "Tên học sinh";
            this.colHoTen.MinimumWidth = 8;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 150;
            // 
            // colGioiTinhNu
            // 
            this.colGioiTinhNu.DataPropertyName = "GioiTinh";
            this.colGioiTinhNu.HeaderText = "Giới tính nữ";
            this.colGioiTinhNu.MinimumWidth = 8;
            this.colGioiTinhNu.Name = "colGioiTinhNu";
            this.colGioiTinhNu.Width = 150;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.MinimumWidth = 8;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Width = 150;
            // 
            // colMaDanToc
            // 
            this.colMaDanToc.DataPropertyName = "MaDanToc";
            this.colMaDanToc.HeaderText = "Dân tộc";
            this.colMaDanToc.MinimumWidth = 8;
            this.colMaDanToc.Name = "colMaDanToc";
            this.colMaDanToc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaDanToc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMaDanToc.Width = 150;
            // 
            // colMaTonGiao
            // 
            this.colMaTonGiao.DataPropertyName = "MaTonGiao";
            this.colMaTonGiao.HeaderText = "Tôn giáo";
            this.colMaTonGiao.MinimumWidth = 8;
            this.colMaTonGiao.Name = "colMaTonGiao";
            this.colMaTonGiao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaTonGiao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMaTonGiao.Width = 150;
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 670);
            this.Controls.Add(this.dgvHocSinh);
            this.Controls.Add(this.bindingNavigatorHocSinh);
            this.Controls.Add(this.panel1);
            this.Name = "frmHocSinh";
            this.Text = "frmHocSinh";
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocSinh)).EndInit();
            this.bindingNavigatorHocSinh.ResumeLayout(false);
            this.bindingNavigatorHocSinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbGTinhNu;
        private System.Windows.Forms.CheckBox ckbGTinhNam;
        private System.Windows.Forms.Button btnLuuDS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThemDanToc;
        private System.Windows.Forms.ComboBox cmbTonGiao;
        private System.Windows.Forms.ComboBox cmbDanToc;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenHocSinh;
        private System.Windows.Forms.TextBox txtMaHocSinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigatorHocSinh;
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGioiTinhNu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaDanToc;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaTonGiao;
    }
}