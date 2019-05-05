using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
namespace MedicalEncyclopediadbms
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportDocument Report = new ReportDocument();
            Report.Load(Server.MapPath("CrystalReport4.rpt"));
            CrystalReportViewer1.ReportSource = Report;



        }
    }
}