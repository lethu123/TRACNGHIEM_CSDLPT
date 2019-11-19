using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TRACNGHIEM
{
    public partial class rpKQThi1 : DevExpress.XtraReports.UI.XtraReport
    {
        public rpKQThi1(String maSV, String maMH, short lan)
        {
            InitializeComponent();
            tnDataSet1.EnforceConstraints = false;
            this.sP_INBAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_INBAITHITableAdapter.Fill(tnDataSet1.SP_INBAITHI, maSV, maMH, lan);

        }

    }
}
