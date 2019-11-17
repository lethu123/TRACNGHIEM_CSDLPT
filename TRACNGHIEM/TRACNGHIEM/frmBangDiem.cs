﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace TRACNGHIEM
{
    public partial class frmBangDiem : Form
    {
        private String maLop = "", maMH = "";
        private int dem = 0;
        private int lan = 1;
        public frmBangDiem()
        {
            InitializeComponent();
        }

        private void bANGDIEMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBangDiem.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tNDataSet);

        }

        private void frmBangDiem_Load(object sender, EventArgs e)
        {
            Program.connstr1 = Program.connstr;
            tNDataSet.EnforceConstraints = false;

            // Lấy kết danh sách phân mảnh đổ vào combobox
            cbbCoSo.DataSource = Program.bds_dspm.DataSource;
            cbbCoSo.DisplayMember = "TENCS";
            cbbCoSo.ValueMember = "TENSERVER";
            
            

            // this.sP_DSMHDKTableAdapter.Fill(this.tNDataSet.SP_DSMHDK, "TH04");
            // TODO: This line of code loads data into the 'tNDataSet.BANGDIEM' table. You can move, or remove it, as needed.
            //this.tbBangDiem.Connection.ConnectionString = Program.connstr;
            //this.tbBangDiem.Fill(this.tNDataSet.BANGDIEM);

            if (Program.mGroup == "Truong")
            {
                cbbCoSo.Enabled = true;
                cbbCoSo.SelectedIndex = 1;
            } else if(Program.mGroup == "Coso")
            {
                cbbCoSo.Enabled = false;
                cbbCoSo.SelectedIndex = Program.mCoSo;
            }
            dem++;

            this.dSLOPDKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSLOPDKTableAdapter.Fill(this.tNDataSet.DSLOPDK);
            cbbLop.SelectedIndex = 0;

            this.sP_DSMHDKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DSMHDKTableAdapter.Fill(this.tNDataSet.SP_DSMHDK, cbbLop.SelectedValue.ToString());
            cbbMH.SelectedIndex = 0;

            this.sP_DSLanThiDKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DSLanThiDKTableAdapter.Fill(this.tNDataSet.SP_DSLanThiDK, cbbMH.SelectedValue.ToString(), cbbLop.SelectedValue.ToString());
            cbbLThi.SelectedIndex = 0;

            this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_XemKetQuaSVTableAdapter.Fill(this.tNDataSet.SP_XemKetQuaSV, cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));


        }

        private void btnInDSBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            rpBangDiem rpBD = new rpBangDiem(cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));
            rpBD.lbLop.Text = cbbLop.Text;
            rpBD.lbMH.Text = cbbMH.Text;
            rpBD.lbLanThi.Text = cbbLThi.Text;
            ReportPrintTool report = new ReportPrintTool(rpBD);
            report.ShowPreviewDialog();

        }

        private void btnThoatBDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo);
            //if (dr == DialogResult.Yes)
            //{
            //    Application.ExitThread();
            //}

            this.Close();
        }

        private void frmBangDiem_FormClosing(object sender, FormClosingEventArgs e)
        {

            //DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo);
            //if (dr == DialogResult.Yes)
            //{
            //    Application.ExitThread();

            //}
           // else e.Cancel = true;

        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbLop.SelectedValue != null)
                {
                    
                    Console.WriteLine(cbbLop.SelectedValue.ToString());
                    this.sP_DSMHDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                    this.sP_DSMHDKTableAdapter.Fill(this.tNDataSet.SP_DSMHDK, cbbLop.SelectedValue.ToString());
                    cbbMH.SelectedIndex = 0;
                    

                    this.sP_DSLanThiDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                    this.sP_DSLanThiDKTableAdapter.Fill(this.tNDataSet.SP_DSLanThiDK, cbbMH.SelectedValue.ToString(), cbbLop.SelectedValue.ToString());
                    cbbLThi.SelectedIndex = 0;

                    this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr1;
                    this.sP_XemKetQuaSVTableAdapter.Fill(this.tNDataSet.SP_XemKetQuaSV, cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));


                }
            }
            catch (Exception) { };
        }

        private void cbbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbTenMonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void fillToolStripButton1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void cbbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbLop.SelectedValue != null)
                {
                   
                    Console.WriteLine(cbbLop.SelectedValue.ToString());
                   
                    if (cbbMH.SelectedValue != null)
                    {
                        
                        Console.WriteLine(cbbMH.SelectedValue.ToString());
                        this.sP_DSLanThiDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                        this.sP_DSLanThiDKTableAdapter.Fill(this.tNDataSet.SP_DSLanThiDK,  cbbMH.SelectedValue.ToString(), cbbLop.SelectedValue.ToString());
                        cbbLThi.SelectedIndex = 0;

                        this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr1;
                        this.sP_XemKetQuaSVTableAdapter.Fill(this.tNDataSet.SP_XemKetQuaSV, cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));


                    }
                }
            }
            catch (Exception) { };
        }

        private void cbbLThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbLop.SelectedValue != null)
                {
                    if (cbbMH.SelectedValue != null)
                    {
                        if (cbbLThi.SelectedValue != null)
                        {
                            // continuos
                            this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr1;
                            this.sP_XemKetQuaSVTableAdapter.Fill(this.tNDataSet.SP_XemKetQuaSV, cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));
                           

                        }
                    }
                }
            }
            catch (Exception) { };
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maLopToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

       

        private void cbbCoSo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbbCoSo.SelectedValue != null && dem !=0)
            {

                Program.servername1 = cbbCoSo.SelectedValue.ToString();
                if (Program.KetNoiCosoKhac() == 0) return;
                else
                {
                    this.dSLOPDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                    this.dSLOPDKTableAdapter.Fill(this.tNDataSet.DSLOPDK);
                    cbbLop.SelectedIndex = 0;
                    
                    this.sP_DSMHDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                    this.sP_DSMHDKTableAdapter.Fill(this.tNDataSet.SP_DSMHDK, cbbLop.SelectedValue.ToString());
                    cbbMH.SelectedIndex = 0;

                    this.sP_DSLanThiDKTableAdapter.Connection.ConnectionString = Program.connstr1;
                    this.sP_DSLanThiDKTableAdapter.Fill(this.tNDataSet.SP_DSLanThiDK, cbbMH.SelectedValue.ToString(), cbbLop.SelectedValue.ToString());
                    cbbLThi.SelectedIndex = 0;

                    this.sP_XemKetQuaSVTableAdapter.Connection.ConnectionString = Program.connstr1;
                    this.sP_XemKetQuaSVTableAdapter.Fill(this.tNDataSet.SP_XemKetQuaSV, cbbLop.SelectedValue.ToString(), cbbMH.SelectedValue.ToString(), short.Parse(cbbLThi.SelectedValue.ToString()));

                }
            }
        }
        
    }
}