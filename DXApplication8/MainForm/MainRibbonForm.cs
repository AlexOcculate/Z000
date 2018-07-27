using System;
using System.Linq;

namespace MainForm
{
   public partial class MainRibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
   {
      public MainRibbonForm()
      {
         this.InitializeComponent();
         // Handling the QueryControl event that will populate all automatically generated Documents
         this.tabbedView1.QueryControl += this.tabbedView1_QueryControl;
      }

      private void MainRibbonForm_Load(object sender, EventArgs e)
      {
         //TODO: App.Config!!!
         string skinStyle = "The Bezier";
         DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinStyle);
      }

      private void skinsColorMixerBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         DevExpress.XtraEditors.ColorWheel.ColorWheelForm cwForm = new DevExpress.XtraEditors.ColorWheel.ColorWheelForm();
         cwForm.Show();
      }

      // Assigning a required content for each auto generated Document
      private void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
      {
         if(e.Document == this.xtraUserControl1Document)
         {
            e.Control = new MainForm.XtraUserControl1( );
         }

         if(e.Control == null)
         {
            e.Control = new System.Windows.Forms.Control( );
         }
      }
   }
}
