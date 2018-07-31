namespace DataPhilosophiae
{
   partial class OpenSaveFolderHelper
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if( disposing && (components != null) )
         {
            components.Dispose( );
         }
         base.Dispose( disposing );
      }

      #region Component Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
         this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
         this.xtraFolderBrowserDialog1 = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
         // 
         // xtraOpenFileDialog1
         // 
         this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
         // 
         // xtraSaveFileDialog1
         // 
         this.xtraSaveFileDialog1.FileName = "xtraSaveFileDialog1";
         // 
         // xtraFolderBrowserDialog1
         // 
         this.xtraFolderBrowserDialog1.SelectedPath = "xtraFolderBrowserDialog1";

      }

      #endregion

      private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
      private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog1;
      private DevExpress.XtraEditors.XtraFolderBrowserDialog xtraFolderBrowserDialog1;
   }
}
