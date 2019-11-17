using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEM
{
    public partial class frmKQThi : Form
    {
        private int dem = 0;
        public frmKQThi()
        {
            InitializeComponent();
        }

        private void bAITHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void frmKQThi_Load(object sender, EventArgs e)
        {
            //Program.username = "113";
            // TODO: This line of code loads data into the 'tNDataSet.BAITHI' table. You can move, or remove it, as needed.
            String sql = "SELECT LOP.MALOP, LOP.TENLOP FROM SINHVIEN SV inner join LOP ON(SV.MASV='" + Program.username + "' AND SV.MALOP = lOP.MALOP)";
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            String mLop = Program.myReader.GetString(0);
            String tenLop = Program.myReader.GetString(1);
           
            try
            {
                this.sP_MonHocSVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_MonHocSVTableAdapter.Fill(this.tNDataSet.SP_MonHocSV, Program.mSV);
                cbbMHSV.SelectedIndex = 0;
                this.sP_LanThiSVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LanThiSVTableAdapter.Fill(this.tNDataSet.SP_LanThiSV, Program.mSV, cbbMHSV.SelectedValue.ToString());
                cbbLThi.SelectedIndex = 0;
               
            }
            catch (Exception ex) {
                MessageBox.Show("abc" + ex.Message);
            };
            

        }

        private void cbbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                this.sP_LanThiSVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LanThiSVTableAdapter.Fill(this.tNDataSet.SP_LanThiSV, Program.mSV, cbbMHSV.SelectedValue.ToString());
                cbbLThi.SelectedIndex = 0;
            } catch(Exception ex)
            {
                MessageBox.Show("loi lay dsmh sv: " + ex);
            }
           
        }

        private void cbbLThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //this.sP_LanThiSVTableAdapter.Connection.ConnectionString = Program.connstr;
                //this.sP_LanThiSVTableAdapter.Fill(this.tNDataSet.SP_LanThiSV, Program.mSV, cbbMHSV.Text);
                //if (cbbLThi.SelectedIndex != null) cbbLThi.SelectedIndex = 0;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi lay dsmh sv: " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
