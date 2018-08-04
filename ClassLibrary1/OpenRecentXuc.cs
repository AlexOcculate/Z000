using DataPhilosophiae.Config;
using DevExpress.XtraGrid.Views.Tile;
using System;
using System.Drawing;
using System.Linq;

namespace DataPhilosophiae
{
   public partial class OpenRecentXuc : DevExpress.XtraEditors.XtraUserControl
   {
      private AppConfig appCfg;

      public OpenRecentXuc()
      {
         this.InitializeComponent();
      }

      public OpenRecentXuc(AppConfig appCfg)
         : this()
      {
         this.appCfg = appCfg;
         this.recentlyOpenedFileListBindingSource.DataSource = this.appCfg.RecentlyOpenedFileList;
      }
      private void tileView1_ItemCustomize( object sender, TileViewItemCustomizeEventArgs e )
      {
         TileView view = sender as TileView;
         if( (bool) view.GetRowCellValue( e.RowHandle, this.colAvailable ) == true )
         {
            e.Item.Elements[ 3 ].Text = string.Empty;
            e.Item.Elements[ 3 ].Appearance.Normal.BackColor = Color.Transparent;
         }
      }

      private void tileView1_ItemClick( object sender, TileViewItemClickEventArgs e )
      {

      }
   }
}
