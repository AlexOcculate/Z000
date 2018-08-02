using DataPhilosophiae.Config;
using System;
using System.ComponentModel;
using System.IO;
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

      public OpenRecentXuc( AppConfig appCfg )
         : this()
      {
         this.appCfg = appCfg;
         this.recentlyOpenedFileListBindingSource.DataSource = this.appCfg.RecentlyOpenedFileList;
      }
   }
}
