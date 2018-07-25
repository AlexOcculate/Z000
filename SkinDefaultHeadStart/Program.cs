using DevExpress.LookAndFeel;
using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace SkinDefaultHeadStart
{
   internal static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      private static void Main()
      {
         // WinForms Controls > Build an Application > Skins
         // To register bonus skins in code, first ensure that your project references the DevExpress.BonusSkins
         // assembly. Then call the DevExpress.UserSkins.BonusSkins.Register method before the main application
         // form runs.
         DevExpress.UserSkins.BonusSkins.Register( );
         DevExpress.Skins.SkinManager.EnableFormSkins( );

         // WinForms Controls > Build an Application > Skins
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
         UserLookAndFeel.Default.SetSkinStyle( skinStyle );
         //
         Application.EnableVisualStyles( );
         Application.SetCompatibleTextRenderingDefault( false );
         Application.Run( new Form1( ) );
      }
   }
}
