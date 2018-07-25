using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DialogHeadStart
{
   public partial class Form1 : XtraForm
   {
      public Form1()
      {
         this.InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         // WinForms Controls > Build an Application > Skins
         //
         // To register bonus skins in code, first ensure that your project references the DevExpress.BonusSkins
         // assembly. Then call the DevExpress.UserSkins.BonusSkins.Register method before the main application
         // form runs.
         //
         // private static void Main()
         // {
         //   DevExpress.UserSkins.BonusSkins.Register( );
         //   DevExpress.Skins.SkinManager.EnableFormSkins( );
         //   //
         //   Application.EnableVisualStyles( );
         //   Application.SetCompatibleTextRenderingDefault( false );
         //   Application.Run( new Form1( ) );
         // }

         //TODO: App.Config!!!
         string skinStyle = "The Bezier";
         //string skinStyle = "Visual Studio 2013 Blue";
         //string skinStyle = "Metropolis Dark";
         //string skinStyle = "Office 2016 Colorful";
         //stringt skinStyle = "Visual Studio 2013 Blue";
         //foreach( SkinContainer cnt in SkinManager.Default.Skins )
         //{
         //   //( cnt.SkinName );
         //}
         DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinStyle);

         //
         //using( DevExpress.Customization.SvgSkinPaletteSelector svgSkinPaletteSelector = new DevExpress.Customization.SvgSkinPaletteSelector( this ) )
         //{
         //   svgSkinPaletteSelector.ShowDialog( );
         //}
         for(int i = 0; i < this.skinMenuBarSubItem.ItemLinks.Count; i++)
         {
            if(this.skinMenuBarSubItem.ItemLinks[i].Caption == "The Bezier")
            {
               BarButtonItem parentItem = (BarButtonItem) this.skinMenuBarSubItem.ItemLinks[i].Item;
               parentItem.Caption = "Default Skin";
               parentItem.ImageUri.Uri = "Apply";
            }
         }
      }

      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
         if(this.SaveFileDialogHelper() != DialogResult.OK)
         {
            e.Cancel = true;
         }
      }

      public const string FILE_FILTERS = "DataStoreConfig (*.dsx)|*.dsx|XML files (*.xml)|*.xml|All files (*.*)|*.*";
      public string builtinDefaultPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      public string builtinDefaultFilename = "dsConfig.dsx";

      private string defaultPath;

      public string DefaultPath
      {
         get
         {
            if(this.defaultPath != null)
            {
               return this.defaultPath;
            }
            return this.builtinDefaultPath;
         }
         set
         {
            if(value == this.builtinDefaultPath)
            {
               if(this.defaultPath != null)
               {
                  this.defaultPath = null;
               }
            } else
            {
               if(this.defaultPath != value)
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
            if(this.defaultFileName != null)
            {
               return this.defaultFileName;
            }
            return this.builtinDefaultFilename;
         }
         set
         {
            if(value == this.builtinDefaultFilename)
            {
               if(this.defaultFileName != null)
               {
                  this.defaultFileName = null;
               }
            } else
            {
               if(this.defaultFileName != value)
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
      private string GetDefaultFilePath()
      {
         // this routine appears to have the only purpose of find a file!? 
         string x = Path.Combine(this.DefaultPath, "SomeSubDir", this.DefaultFileName);
         return Path.GetDirectoryName(FilesHelper.FindingFileName(Application.StartupPath, x, true));
      }
      #endregion

      private void OpenFileDialogHelper()
      {
         XtraOpenFileDialog dialog = this.xtraOpenFileDialog1;
         //using( XtraOpenFileDialog dialog = new DevExpress.XtraEditors.XtraOpenFileDialog( ) )
         //{
         dialog.InitialDirectory = this.DefaultPath;
         dialog.ShowDragDropConfirmation = true;
         dialog.AutoUpdateFilterDescription = false;
         dialog.Filter = FILE_FILTERS;
         dialog.FileName = this.DefaultFileName;
         DialogResult dialogResult = dialog.ShowDialog();
         if(dialogResult == DialogResult.OK)
         {
            this.DefaultFileName = dialog.FileName;
            this.FileOpened = true;
            this.UpdateFileNameLabel();
         }
         //}
      }


      private DialogResult SaveFileDialogHelper( bool decisionTaken=false)
      {
         if(this.NeedToSave || decisionTaken)
         {
            if( ! decisionTaken )
            {
               this.dialogResult = XtraMessageBox.Show( "Save your last modifications?", "Warning", MessageBoxButtons.YesNoCancel );
            }
            else
            {
               this.dialogResult = DialogResult.Yes;
            }
            switch( this.dialogResult)
            {
               case DialogResult.Yes:
                  XtraSaveFileDialog dialog = this.xtraSaveFileDialog1;
                  dialog.InitialDirectory = this.DefaultPath;
                  dialog.ShowDragDropConfirmation = true;
                  dialog.Filter = FILE_FILTERS;
                  dialog.FileName = this.DefaultFileName;
                  dialog.CreatePrompt = true;
                  dialog.OverwritePrompt = true;
                  this.dialogResult = dialog.ShowDialog();
                  if(this.dialogResult == DialogResult.OK)
                  {
                     //System.IO.File.WriteAllText( dialog.FileName, this.mainModule.Text );
                     this.DefaultFileName = Path.GetFileName(dialog.FileName);
                     this.DefaultPath = Path.GetDirectoryName(dialog.FileName);
                  }
                  break;
               case DialogResult.No:
                  break;
               case DialogResult.Cancel:
                  return DialogResult.Cancel;
            }
         }
         this.NeedToSave = false;
         this.UpdateFileNameLabel();
         this.UpdateFileStatusLabel();
         return this.dialogResult = DialogResult.OK;
      }

      private void SetWorkingFolderDialogHelper()
      {
         //string defaultFilePath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
         XtraFolderBrowserDialog dialog = this.xtraFolderBrowserDialog1;
         //using( XtraFolderBrowserDialog dialog = new DevExpress.XtraEditors.XtraFolderBrowserDialog( ) )
         //{
         dialog.SelectedPath = this.DefaultPath;
         if(dialog.ShowDialog() == DialogResult.OK)
         {
            this.DefaultPath = dialog.SelectedPath;
         }
         //}
      }


      private void newBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         if(this.SaveFileDialogHelper() != DialogResult.OK)
         {
            return;
         }

         this.DefaultFileName = this.builtinDefaultFilename;
         this.UpdateFileNameLabel();
         return;
      }

      private void openBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         if(this.SaveFileDialogHelper() != DialogResult.OK)
         {
            return;
         }

         this.OpenFileDialogHelper();
      }

      private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         this.SaveFileDialogHelper();
      }

      private void saveAsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         this.SaveFileDialogHelper(true);
      }


      private void closeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         if(this.SaveFileDialogHelper() != DialogResult.OK)
         {
            return;
         }

         this.DefaultFileName = this.builtinDefaultFilename;
      }

      private void exitBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         if(this.SaveFileDialogHelper() != DialogResult.OK)
         {
            return;
         }
         //
         //Informs all message pumps that they must terminate, and then closes all application windows after the
         // messages have been processed. This method stops all running message loops on all threads and closes
         // all windows of the application.This method does not force the application to exit.The Exit method is
         // typically called from within a message loop, and forces Run to return. To exit a message loop for the
         // current thread only, call "ExitThread". This is the call to use if you are running a WinForms application.
         // As a general guideline, use this call if you have called "System.Windows.Forms.Application.Run".
         System.Windows.Forms.Application.Exit();
         //
         // Terminates this process and gives the underlying operating system the specified exit code.This call
         // requires that you have SecurityPermissionFlag.UnmanagedCode permissions. If you do not, a
         // SecurityException error occurs. This is the call to use if you are running a console application.
         // System.Environment.Exit( exitCode )
      }

      private void setDefaultPathBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         this.SetWorkingFolderDialogHelper();
      }

      private void makeDirtyBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
      {
         this.NeedToSave = true;
         this.UpdateFileStatusLabel();
      }

      private void UpdateFileNameLabel()
      {
         this.fileNameLabelControl.Text = this.FileOpened ? Path.GetFileName(this.DefaultFileName) : "Empty";
      }

      private void UpdateFileStatusLabel()
      {
         this.fileStatusLabelControl.Text = this.NeedToSave ? "Dirty" : "Clean";
      }
   }
}
