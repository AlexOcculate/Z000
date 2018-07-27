using System;

namespace DashboardDesignerHeadStart
{
   public partial class DesignerForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
   {
      public DesignerForm1()
      {
         this.InitializeComponent();
         // WinForms Controls > Build an Application > Skins
         //
         // To register bonus skins in code, first ensure that your project references the DevExpress.BonusSkins
         // assembly. Then call the DevExpress.UserSkins.BonusSkins.Register method before the main application
         // form runs.
         //
         // private static void Main()
         // {
         //   DevExpress.UserSkins.BonusSkins.Register( );
         //   DevExpress.Skins.SkinManager.EnableFormSkins( );
         //   //
         //   Application.EnableVisualStyles( );
         //   Application.SetCompatibleTextRenderingDefault( false );
         //   Application.Run( new Form1( ) );
         // }

         //TODO: App.Config!!!
         string skinStyle = "The Bezier";
         //string skinStyle = "Visual Studio 2013 Blue";
         //string skinStyle = "Metropolis Dark";
         //string skinStyle = "Office 2016 Colorful";
         //stringt skinStyle = "Visual Studio 2013 Blue";
         //foreach( SkinContainer cnt in SkinManager.Default.Skins )
         //{
         //   //( cnt.SkinName );
         //}
         DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinStyle);
         this.dashboardDesigner.LoadDashboard(@"..\..\Dashboards\dashboard1.xml");
      }
   }
}
