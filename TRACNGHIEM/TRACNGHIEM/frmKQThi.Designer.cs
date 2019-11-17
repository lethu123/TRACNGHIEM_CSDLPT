namespace TRACNGHIEM
{
    partial class frmKQThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKQThi));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.tNDataSet = new TRACNGHIEM.TNDataSet();
            this.barManager3 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnInDSBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatBDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbLThi = new System.Windows.Forms.ComboBox();
            this.sPLanThiSV = new System.Windows.Forms.BindingSource(this.components);
            this.tNDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbMHSV = new System.Windows.Forms.ComboBox();
            this.sPMonHocSV = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbLanThi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTenMonhoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sP_MonHocSVTableAdapter = new TRACNGHIEM.TNDataSetTableAdapters.SP_MonHocSVTableAdapter();
            this.sP_LanThiSVTableAdapter = new TRACNGHIEM.TNDataSetTableAdapters.SP_LanThiSVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPLanThiSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMonHocSV)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // tNDataSet
            // 
            this.tNDataSet.DataSetName = "TNDataSet";
            this.tNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager3
            // 
            this.barManager3.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager3.DockControls.Add(this.barDockControlTop);
            this.barManager3.DockControls.Add(this.barDockControlBottom);
            this.barManager3.DockControls.Add(this.barDockControlLeft);
            this.barManager3.DockControls.Add(this.barDockControlRight);
            this.barManager3.Form = this;
            this.barManager3.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnInDSBD,
            this.btnThoatBDiem});
            this.barManager3.MainMenu = this.bar4;
            this.barManager3.MaxItemId = 2;
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInDSBD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatBDiem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // btnInDSBD
            // 
            this.btnInDSBD.Caption = "In bài thi";
            this.btnInDSBD.Id = 0;
            this.btnInDSBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDSBD.ImageOptions.Image")));
            this.btnInDSBD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInDSBD.ImageOptions.LargeImage")));
            this.btnInDSBD.Name = "btnInDSBD";
            // 
            // btnThoatBDiem
            // 
            this.btnThoatBDiem.Caption = "Thoát";
            this.btnThoatBDiem.Id = 1;
            this.btnThoatBDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatBDiem.ImageOptions.Image")));
            this.btnThoatBDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoatBDiem.ImageOptions.LargeImage")));
            this.btnThoatBDiem.Name = "btnThoatBDiem";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager3;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1412, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 567);
            this.barDockControlBottom.Manager = this.barManager3;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1412, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager3;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 517);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1412, 50);
            this.barDockControlRight.Manager = this.barManager3;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 517);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.cbbLThi);
            this.groupControl1.Controls.Add(this.cbbMHSV);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.cbbLanThi);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.cbbTenMonhoc);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 50);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1412, 232);
            this.groupControl1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Xem chi tiết bài thi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbLThi
            // 
            this.cbbLThi.DataSource = this.sPLanThiSV;
            this.cbbLThi.DisplayMember = "LAN";
            this.cbbLThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLThi.FormattingEnabled = true;
            this.cbbLThi.Location = new System.Drawing.Point(627, 79);
            this.cbbLThi.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLThi.Name = "cbbLThi";
            this.cbbLThi.Size = new System.Drawing.Size(133, 24);
            this.cbbLThi.TabIndex = 11;
            this.cbbLThi.ValueMember = "LAN";
            this.cbbLThi.SelectedIndexChanged += new System.EventHandler(this.cbbLThi_SelectedIndexChanged);
            // 
            // sPLanThiSV
            // 
            this.sPLanThiSV.DataMember = "SP_LanThiSV";
            this.sPLanThiSV.DataSource = this.tNDataSetBindingSource;
            // 
            // tNDataSetBindingSource
            // 
            this.tNDataSetBindingSource.DataSource = this.tNDataSet;
            this.tNDataSetBindingSource.Position = 0;
            // 
            // cbbMHSV
            // 
            this.cbbMHSV.DataSource = this.sPMonHocSV;
            this.cbbMHSV.DisplayMember = "TENMH";
            this.cbbMHSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMHSV.FormattingEnabled = true;
            this.cbbMHSV.Location = new System.Drawing.Point(161, 79);
            this.cbbMHSV.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMHSV.Name = "cbbMHSV";
            this.cbbMHSV.Size = new System.Drawing.Size(240, 24);
            this.cbbMHSV.TabIndex = 10;
            this.cbbMHSV.ValueMember = "MAMH";
            this.cbbMHSV.SelectedIndexChanged += new System.EventHandler(this.cbbMH_SelectedIndexChanged);
            // 
            // sPMonHocSV
            // 
            this.sPMonHocSV.DataMember = "SP_MonHocSV";
            this.sPMonHocSV.DataSource = this.tNDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(513, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lần thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Môn học";
            // 
            // cbbLanThi
            // 
            this.cbbLanThi.FormattingEnabled = true;
            this.cbbLanThi.Location = new System.Drawing.Point(3906, 169);
            this.cbbLanThi.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLanThi.Name = "cbbLanThi";
            this.cbbLanThi.Size = new System.Drawing.Size(238, 24);
            this.cbbLanThi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3692, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lần thi";
            // 
            // cbbTenMonhoc
            // 
            this.cbbTenMonhoc.FormattingEnabled = true;
            this.cbbTenMonhoc.Location = new System.Drawing.Point(2736, 134);
            this.cbbTenMonhoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenMonhoc.Name = "cbbTenMonhoc";
            this.cbbTenMonhoc.Size = new System.Drawing.Size(616, 24);
            this.cbbTenMonhoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2442, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên mô học";
            // 
            // sP_MonHocSVTableAdapter
            // 
            this.sP_MonHocSVTableAdapter.ClearBeforeFill = true;
            // 
            // sP_LanThiSVTableAdapter
            // 
            this.sP_LanThiSVTableAdapter.ClearBeforeFill = true;
            // 
            // frmKQThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 567);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmKQThi";
            this.Text = "frmKQThi";
            this.Load += new System.EventHandler(this.frmKQThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPLanThiSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMonHocSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private TNDataSet tNDataSet;
        private DevExpress.XtraBars.BarManager barManager3;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnInDSBD;
        private DevExpress.XtraBars.BarButtonItem btnThoatBDiem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbLThi;
        private System.Windows.Forms.ComboBox cbbMHSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbLanThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTenMonhoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource sPMonHocSV;
        private TNDataSetTableAdapters.SP_MonHocSVTableAdapter sP_MonHocSVTableAdapter;
        private System.Windows.Forms.BindingSource sPLanThiSV;
        private System.Windows.Forms.BindingSource tNDataSetBindingSource;
        private TNDataSetTableAdapters.SP_LanThiSVTableAdapter sP_LanThiSVTableAdapter;
    }
}