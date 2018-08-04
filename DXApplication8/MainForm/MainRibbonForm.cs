using DataPhilosophiae.Config;
using DevExpress.Images;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DataPhilosophiae
{
   public partial class MainRibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
   {
      private static string appConfigNm = "DataPhilosophiae.Config";
      private static string appConfigPath = Path.Combine( AppDomain.CurrentDomain.BaseDirectory, "ConfigFiles" );
      private string appConfigFQN = Path.Combine( appConfigPath, appConfigNm );
      private AppConfig appCfg; // = new AppConfig( ); //.Deserialize( AppConfig.Sample( ) );

      private DataStoreConfig dsCfg;

      public MainRibbonForm()
      {
         this.appCfg = AppConfig.Load( this.appConfigFQN );
         //string e(filena = FilesHelper.FindingFileName( appConfigPath, appConfigNm, true );
         if( this.appCfg == null )
         {
            this.appCfg = new AppConfig( );
         }
         //
         this.InitializeComponent( );
         //
         this.CreateRecentItem( );
         //
         this.dsCollDockPanel.ControlContainer.Controls.Add( this.DsCollXuc );
         this.mdiCollDockPanel.ControlContainer.Controls.Add( this.MdiCollXuc );
         this.dviCollDockPanel.ControlContainer.Controls.Add( this.DviCollXuc );
         this.msgCollDockPanel.ControlContainer.Controls.Add( this.MsgCollXuc );
         DataStoreConfig.Info += this.DataStoreConfig_Info;
         DataStoreConfig.Warn += this.DataStoreConfig_Warn;
         DataStoreConfig.Error += this.DataStoreConfig_Error;
      }

      private void MainRibbonForm_Load( object sender, EventArgs e )
      {
         //TODO: App.Config!!!
         string skinStyle = "The Bezier";
         DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle( skinStyle );
      }

      private void MainRibbonForm_FormClosing( object sender, FormClosingEventArgs e )
      {
         switch( this.SaveFileDialogHelper( ) )
         {
            case DialogResult.OK:
            case DialogResult.Ignore:
               this.appCfg.Save( this.appConfigFQN );
               break;
            default:
               e.Cancel = true;
               break;
         }
      }

      #region --- External Controls ---

      #region --- DataStoreConfigXuc ---
      private void DataStoreConfig_Error( string msg )
      {
         this.MsgCollXuc.Error( msg );
      }

      private void DataStoreConfig_Warn( string msg )
      {
         this.MsgCollXuc.Warn( msg );
      }

      private void DataStoreConfig_Info( string msg )
      {
         this.MsgCollXuc.Info( msg );
      }

      private DataStoreConfigXuc dsCollXuc;

      public DataStoreConfigXuc DsCollXuc
      {
         get
         {
            if( this.dsCollXuc == null )
            {
               this.dsCollXuc = new DataStoreConfigXuc( ) { Dock = DockStyle.Fill };
            }
            return this.dsCollXuc;
         }
      }
      #endregion

      #region --- MetadataItemXuc ---
      private MetadataItemCollXuc mdiCollXuc;

      public MetadataItemCollXuc MdiCollXuc
      {
         get
         {
            if( this.mdiCollXuc == null )
            {
               this.mdiCollXuc = new MetadataItemCollXuc( ) { Dock = DockStyle.Fill };
            }
            return this.mdiCollXuc;
         }
      }
      #endregion

      #region --- DatavalueItemXuc ---
      private UserControl dviCollXuc;

      public UserControl DviCollXuc
      {
         get
         {
            if( this.dviCollXuc == null )
            {
               this.dviCollXuc = new UserControl( ) { Dock = DockStyle.Fill };
            }
            return this.dviCollXuc;
         }
      }
      #endregion

      #region --- MessageXuc ---
      private MessageXuc msgCollXuc;

      public MessageXuc MsgCollXuc
      {
         get
         {
            if( this.msgCollXuc == null )
            {
               this.msgCollXuc = new MessageXuc( ) { Dock = DockStyle.Fill };
            }
            return this.msgCollXuc;
         }
      }
      #endregion

      #endregion

      private void mainRibbonControl_ApplicationButtonClick( object sender, EventArgs e )
      {
      }

      private void fileQuickPrintBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
      }

      private void filePrintBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
      }

      private void filePrintPreviewBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
      }

      private void filePageSetupBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
      }

      private void fileExportBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
      }

      private void fileImportBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
      }

      private void skinsColorMixerBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         DevExpress.XtraEditors.ColorWheel.ColorWheelForm cwForm = new DevExpress.XtraEditors.ColorWheel.ColorWheelForm( );
         cwForm.Show( );
      }

      #region --- New / Open / Open Recent / Save / Close / Exit Menu Handlers ---

      public const string FILE_FILTERS = "DataStoreConfig (*.dsx)|*.dsx|XML files (*.xml)|*.xml|All files (*.*)|*.*";
      public string builtinDefaultPath = System.Environment.GetFolderPath( Environment.SpecialFolder.MyDocuments );
      public string builtinDefaultFilename = "dsConfig.dsx";

      private string defaultPath;

      public string DefaultPath
      {
         get
         {
            if( this.defaultPath != null )
            {
               return this.defaultPath;
            }
            return this.builtinDefaultPath;
         }
         set
         {
            if( value == this.builtinDefaultPath )
            {
               if( this.defaultPath != null )
               {
                  this.defaultPath = null;
               }
            }
            else
            {
               if( this.defaultPath != value )
               {
                  this.defaultPath = value;
               }
            }
         }
      }

      private string defaultFileName;

      private string DefaultFileName
      {
         get
         {
            if( this.defaultFileName != null )
            {
               return this.defaultFileName;
            }
            return this.builtinDefaultFilename;
         }
         set
         {
            if( value == this.builtinDefaultFilename )
            {
               if( this.defaultFileName != null )
               {
                  this.defaultFileName = null;
               }
            }
            else
            {
               if( this.defaultFileName != value )
               {
                  this.defaultFileName = value;
               }
            }
         }
      }

      private bool FileOpened
      {
         get;
         set;
      }

      private bool NeedToSave
      {
         get;
         set;
      }

      private DialogResult dialogResult;

      #region --- TODO: NEED TO FINISH THE MAGIC!!! ---
      //private string GetDefaultFilePath()
      //{
      //   // this routine appears to have the only purpose of find a file!? 
      //   string x = Path.Combine( this.DefaultPath, "SomeSubDir", this.DefaultFileName );
      //   return Path.GetDirectoryName( FilesHelper.FindingFileName( Application.StartupPath, x, true ) );
      //}
      #endregion

      #region --- New File ---
      private void fileNewBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
         if( this.SaveFileDialogHelper( ) != DialogResult.OK )
         {
            return;
         }
         if( this.SetWorkingFolderDialogHelper( ) != DialogResult.OK )
         {
            this.MsgCollXuc.Info( "New file cancelled!" );
            return;
         }
         this.DefaultFileName = this.builtinDefaultFilename;
         this.dsCfg = new DataStoreConfig( this.DefaultPath );
         this.MsgCollXuc.Info( "New file '{0}'!", Path.Combine( this.DefaultPath, this.DefaultFileName ) );
         this.UpdateFileNameLabel( );
         this.UpdateFileStatusLabel( );
         return;
      }

      private DialogResult SetWorkingFolderDialogHelper()
      {
         //string defaultFilePath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
         XtraFolderBrowserDialog dialog = this.xtraFolderBrowserDialog1;
         dialog.SelectedPath = this.DefaultPath;
         this.dialogResult = dialog.ShowDialog( );
         if( this.dialogResult == DialogResult.OK )
         {
            this.DefaultPath = dialog.SelectedPath;
         }
         return this.dialogResult;
      }

      #endregion

      #region --- Open File ---
      private void fileOpenBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
         this.FileOpened = false;
         switch( this.SaveFileDialogHelper( ) )
         {
            case DialogResult.OK:
            case DialogResult.Ignore:
               break;
            default:
               return;
         }
         if( sender != this && this.OpenFileDialogHelper( ) != DialogResult.OK )
         {
            return;
         }

         string fqn = Path.Combine( this.DefaultPath, this.DefaultFileName );
         this.dsCfg = DataStoreConfig.Load( fqn );
         if( this.dsCfg == null )
         {
            return;
         }
         this.DsCollXuc.SetConfig( this.dsCfg );
         //
         this.FileOpened = true;
         this.UpdateOpenRecentList( fqn );
         this.MsgCollXuc.Info( "File '{0}' opened.", fqn );
         this.UpdateFileNameLabel( );
         this.UpdateFileStatusLabel( );
      }

      private DialogResult OpenFileDialogHelper()
      {
         XtraOpenFileDialog dialog = this.xtraOpenFileDialog1;
         dialog.InitialDirectory = this.DefaultPath;
         dialog.ShowDragDropConfirmation = true;
         dialog.AutoUpdateFilterDescription = false;
         dialog.Filter = FILE_FILTERS;
         dialog.FileName = this.DefaultFileName;
         DialogResult dialogResult = dialog.ShowDialog( );
         if( dialogResult == DialogResult.OK )
         {
            this.DefaultFileName = Path.GetFileName( dialog.FileName );
            this.DefaultPath = Path.GetDirectoryName( dialog.FileName );
         }
         else
         {
            this.MsgCollXuc.Warn( "Open operation canceled!" );
         }
         return dialogResult;
      }
      #endregion

      #region --- Save / Save As File ---
      private void fileSaveBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         if( this.SaveFileDialogHelper( ) != DialogResult.OK )
         {
            return;
         }
         // this.UpdateOpenRecentList( dialog.FileName );
         string fqn = Path.Combine( this.DefaultPath, this.DefaultFileName );
         this.dsCfg.Save( fqn );
         this.MsgCollXuc.Info( "File '{0}' saved.", fqn );
         this.NeedToSave = false;
         this.UpdateFileNameLabel( );
         this.UpdateFileStatusLabel( );
      }

      private void fileSaveAsBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
         if( this.SaveFileDialogHelper( true ) != DialogResult.OK )
         {
            return;
         }
         string fqn = Path.Combine( this.DefaultPath, this.DefaultFileName );
         this.dsCfg.Save( fqn );
         this.MsgCollXuc.Info( "File saved as '{0}'.", fqn );
         this.NeedToSave = false;
         this.UpdateFileNameLabel( );
         this.UpdateFileStatusLabel( );
      }

      private DialogResult SaveFileDialogHelper( bool decisionTaken = false )
      {
         if( this.NeedToSave || decisionTaken )
         {
            if( !decisionTaken )
            {
               this.dialogResult = XtraMessageBox.Show( "Save your last modifications?", "Warning", MessageBoxButtons.YesNoCancel );
            }
            else
            {
               this.dialogResult = DialogResult.Yes;
            }
            switch( this.dialogResult )
            {
               case DialogResult.Yes:
                  XtraSaveFileDialog dialog = this.xtraSaveFileDialog1;
                  dialog.InitialDirectory = this.DefaultPath;
                  dialog.ShowDragDropConfirmation = true;
                  dialog.Filter = FILE_FILTERS;
                  dialog.FileName = this.DefaultFileName;
                  dialog.CreatePrompt = true;
                  dialog.OverwritePrompt = true;
                  this.dialogResult = dialog.ShowDialog( );
                  if( this.dialogResult == DialogResult.OK )
                  {
                     this.DefaultFileName = Path.GetFileName( dialog.FileName );
                     this.DefaultPath = Path.GetDirectoryName( dialog.FileName );
                     return this.dialogResult = DialogResult.OK;
                  }
                  break;
               case DialogResult.No:
                  this.MsgCollXuc.Warn( "File '{0}' not saved.", this.DefaultFileName );
                  break;
               case DialogResult.Cancel:
                  this.MsgCollXuc.Warn( "Save operation canceled: '{0}'!", this.DefaultFileName );
                  return this.dialogResult = DialogResult.Cancel;
            }
         }
         //this.NeedToSave = false;
         //this.UpdateFileNameLabel();
         //this.UpdateFileStatusLabel();
         return this.dialogResult = DialogResult.Ignore;
      }
      #endregion

      #region --- Close File ---
      private void fileCloseBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
         if( this.SaveFileDialogHelper( ) != DialogResult.OK )
         {
            return;
         }
         this.MsgCollXuc.Info( "File '{0}' closed!", Path.Combine( this.DefaultPath, this.DefaultFileName ) );

         this.DefaultFileName = this.builtinDefaultFilename;
      }
      #endregion

      private void UpdateFileNameLabel()
      {
         // this.fileNameLabelControl.Text = this.FileOpened ? Path.GetFileName( this.DefaultFileName ) : "Empty";
      }

      private void UpdateFileStatusLabel()
      {
         // this.fileStatusLabelControl.Text = this.NeedToSave ? "Dirty" : "Clean";
      }

      private void UpdateOpenRecentList( string item )
      {
         this.appCfg.AddRecentlyOpenedFile( item );
      }

      #endregion

      #region --- "Open/View" and "Close/Hide" Dockings... ---
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
      #endregion

      private void helpBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
      }

      private void aboutBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
         SplashScreenManager.ShowForm( typeof( SplashScreen1 ) );
         //... 
         SplashScreenManager.CloseForm( );
      }

      private BackstageViewTabItem rofBackstageViewTabItem;

      #region --- BackStageViewControl and RecentItemControl ---
      private void CreateRecentItem()
      {
         {
            //// WinForms Controls > DevExpress.XtraBars.Ribbon > BackstageViewTabItem > SelectedChanged
            //// To get a selected tab item or select a tab item, use:
            //BackstageViewTabItem oo = this.backstageViewControl1.SelectedTab;
            //int oo = this.backstageViewControl1.SelectedTabIndex;
            //// BackstageViewTabItem.Selected - Allows you to select a specific tab item by using this Boolean property.
            //this.backstageViewControl1.SelectedTabChanged += this.BackstageViewControl1_SelectedTabChanged;
            {
               BackstageViewButtonItem o = new BackstageViewButtonItem( )
               {
                  Caption = "New",
                  Glyph = ImageResourceCache.Default.GetImage( "office2013/actions/new_32x32.png" )
               };
               this.backstageViewControl1.Items.Add( o );
            }
            this.backstageViewControl1.Items.Add( new BackstageViewItemSeparator( ) );
            {
               BackstageViewButtonItem o = new BackstageViewButtonItem( )
               {
                  Caption = "Open",
                  // Glyph = ImageResourceCache.Default.GetImage("office2013/actions/open_32x32.png"),
               };
               this.backstageViewControl1.Items.Add( o );
            }
            {
               this.rofBackstageViewTabItem = new BackstageViewTabItem( )
               {
                  Caption = "Open Recent",
                  Name = "Open Recent",
                  //Glyph = ImageResourceCache.Default.GetImage( "office2013/actions/open_32x32.png" )
               };
               this.backstageViewControl1.Items.Add( this.rofBackstageViewTabItem );
               OpenRecentXuc xuc = new OpenRecentXuc( this.appCfg )
               {
                  Dock = DockStyle.Fill
               };
               this.rofBackstageViewTabItem.ContentControl.Controls.Add( xuc );
               xuc.ReOpenFile += this.OpenRecentXuc_ReOpenFile;
            }
            this.backstageViewControl1.Items.Add( new BackstageViewItemSeparator( ) );
            {
               BackstageViewButtonItem o = new BackstageViewButtonItem( )
               {
                  Caption = "Save",
                  //Glyph = ImageResourceCache.Default.GetImage("office2013/save/save_32x32.png")
               };
               this.backstageViewControl1.Items.Add( o );
            }
            {
               BackstageViewTabItem o = new BackstageViewTabItem( )
               {
                  Caption = "Save As...",
                  //Glyph = ImageResourceCache.Default.GetImage("office2013/save/saveas_32x32.png")
               };
               this.backstageViewControl1.Items.Add( o );
            }
            this.backstageViewControl1.Items.Add( new BackstageViewItemSeparator( ) );
            {
               BackstageViewButtonItem o = new BackstageViewButtonItem( )
               {
                  Caption = nameof( Close ),
                  //Glyph = ImageResourceCache.Default.GetImage( "office2013/actions/close_32x32.png" )
               };
               this.backstageViewControl1.Items.Add( o );
            }
            this.backstageViewControl1.Items.Add( new BackstageViewItemSeparator( ) );
            {
               BackstageViewButtonItem o = new BackstageViewButtonItem( )
               {
                  Caption = "Exit",
                  //Glyph = ImageResourceCache.Default.GetImage( "office2013/actions/close_32x32.png" )
               };
               this.backstageViewControl1.Items.Add( o );
            }
            this.backstageViewControl1.Items.Add( new BackstageViewItemSeparator( ) );
            {
               BackstageViewTabItem o = new BackstageViewTabItem( );
               o.Caption = "Export";
               SimpleButton btn = new SimpleButton( );
               btn.Text = "Export";
               btn.Location = new Point( 10, 10 );
               o.ContentControl.Controls.Add( btn );
               this.backstageViewControl1.Items.Add( o );
            }
            this.backstageViewControl1.Items.Insert( 1, new BackstageViewItemSeparator( ) );
         }
      }

      private void OpenRecentXuc_ReOpenFile( string filename, string pathname )
      {
         this.DefaultFileName = filename;
         this.DefaultPath = pathname;
         ItemClickEventArgs e = new ItemClickEventArgs( null, null );
         fileOpenBarButtonItem_ItemClick( this, e );
      }

      private void backstageViewControl1_ItemClick( object sender, BackstageViewItemEventArgs e )
      {
         //if( e.Item.Name == "Open Recent" )
         //{
         //}
      }

      private void backstageViewControl1_SelectedTabChanged( object sender, BackstageViewItemEventArgs e )
      {
         //if( e.Item.Name == "Open Recent" )
         //{
         //}
      }
      #endregion
   }
}
