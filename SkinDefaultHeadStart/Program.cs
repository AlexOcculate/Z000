using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
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
         BonusSkins.Register( );
         SkinManager.EnableFormSkins( );

         //TODO: App.Config!!!
         string skinStyle = "The Bezier";
         //string skinStyle = "Visual Studio 2013 Blue";
         //string skinStyle = "Metropolis Dark";
         //string skinStyle = "Office 2016 Colorful";
         //stringt skinStyle = "Visual Studio 2013 Blue";
         UserLookAndFeel.Default.SetSkinStyle( skinStyle );
         //
         Application.EnableVisualStyles( );
         Application.SetCompatibleTextRenderingDefault( false );
         Application.Run( new Form1( ) );
      }
   }
}
