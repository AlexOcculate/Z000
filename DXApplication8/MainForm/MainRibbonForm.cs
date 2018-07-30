using DataPhilosophiae.Config.Model;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

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
         if( this.SaveFileDialogHelper( ) != DialogResult.OK )
         {
            e.Cancel = true;
         }
      }

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
               this.msgCollXuc = new DataPhilosophiae.MessageXuc( ) { Dock = DockStyle.Fill };
            }
            return this.msgCollXuc;
         }
      }
      #endregion

      private DataStoreConfig dsConfig;

      private void fileNewBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
         if( this.SaveFileDialogHelper( ) != DialogResult.OK )
         {
            return;
         }
         this.DefaultFileName = this.builtinDefaultFilename;
         this.MsgCollXuc.Info( "New file '{0}'!", Path.Combine( this.DefaultPath, this.builtinDefaultFilename ) );
         this.UpdateFileNameLabel( );
         return;
      }
      private void fileOpenBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
         if( this.SaveFileDialogHelper( ) != DialogResult.OK )
         {
            return;
         }
         if( this.OpenFileDialogHelper( ) != DialogResult.OK )
         {
            return;
         }

         string fqn = Path.Combine( this.DefaultPath, this.DefaultFileName );
         this.dsConfig = DataStoreConfig.Load( fqn );
         if( this.dsConfig == null )
         {
            return;
         }
         this.DsCollXuc.SetConfig( this.dsConfig );
      }
      private void fileSaveBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.SaveFileDialogHelper( );
      }
      private void fileSaveAsBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
         this.SaveFileDialogHelper( true );
      }
      private void fileCloseBarButtonItem_ItemClick( object sender, ItemClickEventArgs e )
      {
         if( this.SaveFileDialogHelper( ) != DialogResult.OK )
         {
            return;
         }
         this.MsgCollXuc.Info( "File '{0}' closed!", Path.Combine( this.DefaultPath, this.DefaultFileName ) );

         this.DefaultFileName = this.builtinDefaultFilename;
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
            this.UpdateOpenRecentList( dialog.FileName );
            this.FileOpened = true;
            this.MsgCollXuc.Info( "File '{0}' opened.", dialog.FileName );
            this.UpdateFileNameLabel( );
            this.UpdateFileStatusLabel( );
         }
         else
         {
            this.MsgCollXuc.Warn( "Open operation canceled!" );
         }
         return dialogResult;
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
                     //System.IO.File.WriteAllText( dialog.FileName, this.mainModule.Text );
                     this.DefaultFileName = Path.GetFileName( dialog.FileName );
                     this.DefaultPath = Path.GetDirectoryName( dialog.FileName );
                     //                     this.UpdateOpenRecentList( dialog.FileName );
                     this.MsgCollXuc.Info( "File '{0}' saved.", dialog.FileName );
                  }
                  break;
               case DialogResult.No:
                  this.MsgCollXuc.Warn( "File '{0}' not saved.", this.DefaultFileName );
                  break;
               case DialogResult.Cancel:
                  this.MsgCollXuc.Warn( "Save operation canceled: '{0}'!", this.DefaultFileName );
                  return DialogResult.Cancel;
            }
         }
         this.NeedToSave = false;
         this.UpdateFileNameLabel( );
         this.UpdateFileStatusLabel( );
         return this.dialogResult = DialogResult.OK;
      }

      private void UpdateFileNameLabel()
      {
         //         this.fileNameLabelControl.Text = this.FileOpened ? Path.GetFileName( this.DefaultFileName ) : "Empty";
      }

      private void UpdateFileStatusLabel()
      {
         //         this.fileStatusLabelControl.Text = this.NeedToSave ? "Dirty" : "Clean";
      }
      private void UpdateOpenRecentList( string item )
      {
         //Strings s = this.openRecentBarListItem.Strings;
         //s.Insert( 0, item );
         //if( s.Count > 10 )
         //{
         //   s.RemoveAt( s.Count - 1 );
         //}
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

   }
}
