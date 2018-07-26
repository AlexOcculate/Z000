namespace DashboardViewerHeadStart
{
   partial class ViewerForm1
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

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container( );
         this.dashboardViewer = new DevExpress.DashboardWin.DashboardViewer( this.components );
         ((System.ComponentModel.ISupportInitialize) (this.dashboardViewer)).BeginInit( );
         this.SuspendLayout( );
         //
         // dashboardViewer
         //
         this.dashboardViewer.DashboardSource = typeof( DashboardViewerHeadStart.SampleDashboard );
         this.dashboardViewer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dashboardViewer.Location = new System.Drawing.Point( 0, 0 );
         this.dashboardViewer.Name = "dashboardViewer";
         this.dashboardViewer.Size = new System.Drawing.Size( 986, 628 );
         this.dashboardViewer.TabIndex = 0;
         //
         // ViewerForm
         //
         this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 986, 628 );
         this.Controls.Add( this.dashboardViewer );
         this.Name = "ViewerForm";
         this.Text = "Dashboard Viewer";
         ((System.ComponentModel.ISupportInitialize) (this.dashboardViewer)).EndInit( );
         this.ResumeLayout( false );

      }

      #endregion

      private DevExpress.DashboardWin.DashboardViewer dashboardViewer;
   }
}

