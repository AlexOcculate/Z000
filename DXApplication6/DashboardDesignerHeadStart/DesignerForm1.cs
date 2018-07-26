using DevExpress.XtraBars;
using DevExpress.XtraMap;
using System;
using System.Data;
using System.Windows.Forms;

namespace DashboardDesignerHeadStart
{
   public partial class DesignerForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
   {
      public DesignerForm1()
      {
         InitializeComponent( );
         dashboardDesigner.LoadDashboard( @"..\..\Dashboards\dashboard1.xml" );
      }
   }
}
