using DevExpress.Customization;
using DevExpress.XtraEditors.ColorWheel;
using DevExpress.XtraSplashScreen;
using System;
using System.Linq;

namespace SkinDefaultHeadStart
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      public Form1()
      {
         InitializeComponent( );
      }

      private void colorSwatchesBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         using( SvgSkinPaletteSelector svgSkinPaletteSelector = new SvgSkinPaletteSelector( this ) )
         {
            svgSkinPaletteSelector.ShowDialog( );
         }
      }

      private void colorMixerBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         ColorWheelForm cwForm = new ColorWheelForm( );
         cwForm.Show( );
      }

      private void splashscreenBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         SplashScreenManager.ShowForm( typeof( SplashScreen1 ) );
         //SplashScreenManager.CloseForm( );
      }
   }
}
