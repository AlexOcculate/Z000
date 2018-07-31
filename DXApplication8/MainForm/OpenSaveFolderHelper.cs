using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DataPhilosophiae
{
   public partial class OpenSaveFolderHelper : Component
   {
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

      public string DefaultFileName
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

      public bool FileOpened
      {
         get;
         set;
      }

      public bool NeedToSave
      {
         get;
         set;
      }

      public DialogResult dialogResult;

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

      public OpenSaveFolderHelper()
      {
         InitializeComponent( );
      }

      public OpenSaveFolderHelper( IContainer container )
      {
         container.Add( this );

         InitializeComponent( );
      }
      public DialogResult OpenFileDialogHelper()
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
            //this.MsgCollXuc.Warn( "Open operation canceled!" );
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
                     this.DefaultFileName = Path.GetFileName( dialog.FileName );
                     this.DefaultPath = Path.GetDirectoryName( dialog.FileName );
                     return this.dialogResult = DialogResult.OK;
                  }
                  break;
               case DialogResult.No:
                  //this.MsgCollXuc.Warn( "File '{0}' not saved.", this.DefaultFileName );
                  break;
               case DialogResult.Cancel:
                  //this.MsgCollXuc.Warn( "Save operation canceled: '{0}'!", this.DefaultFileName );
                  return this.dialogResult = DialogResult.Cancel;
            }
         }
         //this.NeedToSave = false;
         //this.UpdateFileNameLabel();
         //this.UpdateFileStatusLabel();
         return this.dialogResult = DialogResult.Ignore;
      }
   }
}
