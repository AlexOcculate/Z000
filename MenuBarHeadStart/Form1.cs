using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Customization;
using DevExpress.XtraEditors.ColorWheel;

namespace MenuBarHeadStart
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      public Form1()
      {
         InitializeComponent( );
      }

      private void barButtonItem3_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {

      }

      private void aboutBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
            String About = "This is version 1.0 - About menu item test\n";
            MessageBox.Show(About, "This is version 1.0" );
      }

      private void deleteBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {

      }

      private void barButtonItem12_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {

      }

      private void openBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {

      }

      private void saveBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {

      }

      private void saveAsBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {

      }

      private void closeBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {

      }

      private void exitBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {

      }

      private void colorMixerBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         ColorWheelForm cwForm = new ColorWheelForm( );
         cwForm.Show( );
      }

      private void colorSwatchesBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         using( SvgSkinPaletteSelector svgSkinPaletteSelector = new SvgSkinPaletteSelector( this ) )
         {
            svgSkinPaletteSelector.ShowDialog( );
         }
      }

      private void emailBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
          
      }

      private void barButtonItem11_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {

      }
   }
}
