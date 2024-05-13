
namespace GUI
{
    partial class frmHocLuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocLuc));
            this.bindingNavigatorHocLuc = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dgvHocLuc = new System.Windows.Forms.DataGridView();
            this.colMaHocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemCanTren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemCanDuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemKhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocLuc)).BeginInit();
            this.bindingNavigatorHocLuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocLuc)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorHocLuc
            // 
            this.bindingNavigatorHocLuc.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorHocLuc.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorHocLuc.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorHocLuc.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorHocLuc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorHocLuc.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorHocLuc.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorHocLuc.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorHocLuc.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorHocLuc.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorHocLuc.Name = "bindingNavigatorHocLuc";
            this.bindingNavigatorHocLuc.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.bindingNavigatorHocLuc.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorHocLuc.Size = new System.Drawing.Size(1067, 38);
            this.bindingNavigatorHocLuc.TabIndex = 0;
            this.bindingNavigatorHocLuc.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 31);
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
            // dgvHocLuc
            // 
            this.dgvHocLuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocLuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHocLuc,
            this.colTenHocLuc,
            this.colDiemCanTren,
            this.colDiemCanDuoi,
            this.colDiemKhong});
            this.dgvHocLuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocLuc.Location = new System.Drawing.Point(0, 38);
            this.dgvHocLuc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHocLuc.Name = "dgvHocLuc";
            this.dgvHocLuc.RowHeadersWidth = 62;
            this.dgvHocLuc.RowTemplate.Height = 28;
            this.dgvHocLuc.Size = new System.Drawing.Size(1067, 524);
            this.dgvHocLuc.TabIndex = 1;
            // 
            // colMaHocLuc
            // 
            this.colMaHocLuc.DataPropertyName = "MaHocLuc";
            this.colMaHocLuc.HeaderText = "Mã học lực";
            this.colMaHocLuc.MinimumWidth = 8;
            this.colMaHocLuc.Name = "colMaHocLuc";
            this.colMaHocLuc.Width = 150;
            // 
            // colTenHocLuc
            // 
            this.colTenHocLuc.DataPropertyName = "TenHocLuc";
            this.colTenHocLuc.HeaderText = "Tên học lực";
            this.colTenHocLuc.MinimumWidth = 8;
            this.colTenHocLuc.Name = "colTenHocLuc";
            this.colTenHocLuc.Width = 150;
            // 
            // colDiemCanTren
            // 
            this.colDiemCanTren.DataPropertyName = "DiemCanTren";
            this.colDiemCanTren.HeaderText = "Điểm cận trên";
            this.colDiemCanTren.MinimumWidth = 8;
            this.colDiemCanTren.Name = "colDiemCanTren";
            this.colDiemCanTren.Width = 150;
            // 
            // colDiemCanDuoi
            // 
            this.colDiemCanDuoi.DataPropertyName = "DiemCanDuoi";
            this.colDiemCanDuoi.HeaderText = "Điểm cận dưới";
            this.colDiemCanDuoi.MinimumWidth = 8;
            this.colDiemCanDuoi.Name = "colDiemCanDuoi";
            this.colDiemCanDuoi.Width = 150;
            // 
            // colDiemKhong
            // 
            this.colDiemKhong.DataPropertyName = "DiemKhongChe";
            this.colDiemKhong.HeaderText = "Điểm khống";
            this.colDiemKhong.MinimumWidth = 8;
            this.colDiemKhong.Name = "colDiemKhong";
            this.colDiemKhong.Width = 150;
            // 
            // frmHocLuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.dgvHocLuc);
            this.Controls.Add(this.bindingNavigatorHocLuc);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHocLuc";
            this.Text = "frmHocLuc";
            this.Load += new System.EventHandler(this.frmHocLuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocLuc)).EndInit();
            this.bindingNavigatorHocLuc.ResumeLayout(false);
            this.bindingNavigatorHocLuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocLuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigatorHocLuc;
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
        private System.Windows.Forms.DataGridView dgvHocLuc;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHocLuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHocLuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemCanTren;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemCanDuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemKhong;
    }
}