using DataPhilosophiae.Config;
using DataPhilosophiae.Delegates;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Tile;
using System;
using System.Drawing;
using System.Linq;

namespace DataPhilosophiae
{
   public partial class OpenRecentXuc : DevExpress.XtraEditors.XtraUserControl
   {
      public event ReOpenFileDelegate ReOpenFile;

      private AppConfig appCfg;
      private BackstageViewControl backStageView;

      public OpenRecentXuc()
      {
         this.InitializeComponent();
      }

      public OpenRecentXuc(AppConfig appCfg, BackstageViewControl bsv)
         : this()
      {
         this.appCfg = appCfg;
         this.recentlyOpenedFileListBindingSource.DataSource = this.appCfg.RecentlyOpenedFileList;
         this.backStageView = bsv;
      }

      private void tileView1_ItemCustomize(object sender, TileViewItemCustomizeEventArgs e)
      {
         TileView view = sender as TileView;
         if((bool) view.GetRowCellValue(e.RowHandle, this.colAvailable) == true)
         {
            e.Item.Elements[3].Text = string.Empty;
            e.Item.Elements[3].Appearance.Normal.BackColor = Color.Transparent;
         }
      }

      private void tileView1_ItemClick(object sender, TileViewItemClickEventArgs e)
      {
         TileViewItem tvi = e.Item;

         string filename = tvi.Text;
         string pathname = tvi.Text2;
         this.ReOpenFile?.Invoke(filename, pathname);
         if(this.backStageView != null)
         {
            //BackstageViewTabItem fqn = this.backStageView.SelectedTab;
            this.backStageView.Close();
         }
      }
   }
}
