using System;
using System.Linq;
using System.Windows.Forms;

namespace DataPhilosophiae
{
   public partial class MainRibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
   {
      public MainRibbonForm()
      {
         this.InitializeComponent( );
         //
         this.dsCollDockPanel.ControlContainer.Controls.Add( this.DsCollXuc );
         this.mdiCollDockPanel.ControlContainer.Controls.Add( this.MdiCollXuc );
         this.dviCollDockPanel.ControlContainer.Controls.Add( this.DviCollXuc );
         this.msgCollDockPanel.ControlContainer.Controls.Add( this.MsgCollXuc );
      }

      private void MainRibbonForm_Load( object sender, EventArgs e )
      {
         //TODO: App.Config!!!
         string skinStyle = "The Bezier";
         DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle( skinStyle );
         this.MsgCollXuc.Info( "the number {0:#,##0}!", 100 );
         this.MsgCollXuc.Error( "the number {0:#,##0}!", 100 );
         this.MsgCollXuc.Warn( "the number {0:#,##0}!", 100 );
      }

      #region --- External Controls ---
      private DataPhilosophiae.DataStoreCollectionXuc dsCollXuc;

      public DataStoreCollectionXuc DsCollXuc
      {
         get
         {
            if( this.dsCollXuc == null )
            {
               this.dsCollXuc = new DataPhilosophiae.DataStoreCollectionXuc( ) { Dock = DockStyle.Fill };
            }
            return this.dsCollXuc;
         }
      }

      private DataPhilosophiae.XtraUserControl2 mdiCollXuc;

      public XtraUserControl2 MdiCollXuc
      {
         get
         {
            if( this.mdiCollXuc == null )
            {
               this.mdiCollXuc = new DataPhilosophiae.XtraUserControl2( ) { Dock = DockStyle.Fill };
            }
            return this.mdiCollXuc;
         }
      }

      private DataPhilosophiae.XtraUserControl3 dviCollXuc;

      public XtraUserControl3 DviCollXuc
      {
         get
         {
            if( this.dviCollXuc == null )
            {
               this.dviCollXuc = new DataPhilosophiae.XtraUserControl3( ) { Dock = DockStyle.Fill };
            }
            return this.dviCollXuc;
         }
      }

      private DataPhilosophiae.MessageXuc msgCollXuc;

      public MessageXuc MsgCollXuc
      {
         get
         {
            if( this.msgCollXuc == null )
            {
               this.msgCollXuc = new DataPhilosophiae.MessageXuc() { Dock = DockStyle.Fill };
            }
            return this.msgCollXuc;
         }
      }
      #endregion

      private void skinsColorMixerBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         DevExpress.XtraEditors.ColorWheel.ColorWheelForm cwForm = new DevExpress.XtraEditors.ColorWheel.ColorWheelForm( );
         cwForm.Show( );
      }

      private void dockManager1_ClosingPanel( object sender, DevExpress.XtraBars.Docking.DockPanelCancelEventArgs e )
      {
         e.Panel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
      }

      private void dsCollBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.dsCollDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
      }

      private void mdiCollBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.mdiCollDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
      }

      private void dviCollBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.dviCollDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
      }

      private void messagesBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.msgCollDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
      }
   }
}
