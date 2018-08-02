namespace DataPhilosophiae
{
   partial class OpenRecentXuc
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
         DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
         DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
         DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
         DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
         DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
         DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
         DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
         DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
         DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
         this.colName = new DevExpress.XtraGrid.Columns.TileViewColumn();
         this.colTimestamp = new DevExpress.XtraGrid.Columns.TileViewColumn();
         this.colPath = new DevExpress.XtraGrid.Columns.TileViewColumn();
         this.colPinned = new DevExpress.XtraGrid.Columns.TileViewColumn();
         this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
         this.panel1 = new System.Windows.Forms.Panel();
         this.gridControl1 = new DevExpress.XtraGrid.GridControl();
         this.recentlyOpenedFileListBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.appConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
         this.splitContainerControl1.SuspendLayout();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.recentlyOpenedFileListBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.appConfigBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
         this.SuspendLayout();
         // 
         // colName
         // 
         this.colName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
         this.colName.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
         this.colName.AppearanceCell.Options.UseFont = true;
         this.colName.AppearanceCell.Options.UseForeColor = true;
         this.colName.FieldName = "Name";
         this.colName.Name = "colName";
         this.colName.Visible = true;
         this.colName.VisibleIndex = 1;
         // 
         // colTimestamp
         // 
         this.colTimestamp.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
         this.colTimestamp.AppearanceCell.Options.UseFont = true;
         this.colTimestamp.DisplayFormat.FormatString = "yyyy/MM/dd-HH:mm:ss,fffffffzzz";
         this.colTimestamp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.colTimestamp.FieldName = "Timestamp";
         this.colTimestamp.Name = "colTimestamp";
         this.colTimestamp.Visible = true;
         this.colTimestamp.VisibleIndex = 0;
         // 
         // colPath
         // 
         this.colPath.FieldName = "Path";
         this.colPath.Name = "colPath";
         this.colPath.Visible = true;
         this.colPath.VisibleIndex = 2;
         // 
         // colPinned
         // 
         this.colPinned.FieldName = "Pinned";
         this.colPinned.Name = "colPinned";
         this.colPinned.Visible = true;
         this.colPinned.VisibleIndex = 3;
         // 
         // splitContainerControl1
         // 
         this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
         this.splitContainerControl1.Name = "splitContainerControl1";
         this.splitContainerControl1.Panel1.Controls.Add(this.panel1);
         this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
         this.splitContainerControl1.Panel1.Text = "Panel1";
         this.splitContainerControl1.Panel2.Controls.Add(this.labelControl2);
         this.splitContainerControl1.Panel2.Text = "Panel2";
         this.splitContainerControl1.Size = new System.Drawing.Size(945, 701);
         this.splitContainerControl1.SplitterPosition = 597;
         this.splitContainerControl1.TabIndex = 1;
         this.splitContainerControl1.Text = "splitContainerControl1";
         // 
         // panel1
         // 
         this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel1.Controls.Add(this.gridControl1);
         this.panel1.Location = new System.Drawing.Point(3, 23);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(592, 675);
         this.panel1.TabIndex = 1;
         // 
         // gridControl1
         // 
         this.gridControl1.DataSource = this.recentlyOpenedFileListBindingSource;
         this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gridControl1.Location = new System.Drawing.Point(0, 0);
         this.gridControl1.MainView = this.tileView1;
         this.gridControl1.Name = "gridControl1";
         this.gridControl1.Size = new System.Drawing.Size(592, 675);
         this.gridControl1.TabIndex = 0;
         this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
         // 
         // recentlyOpenedFileListBindingSource
         // 
         this.recentlyOpenedFileListBindingSource.DataMember = "RecentlyOpenedFileList";
         this.recentlyOpenedFileListBindingSource.DataSource = this.appConfigBindingSource;
         // 
         // appConfigBindingSource
         // 
         this.appConfigBindingSource.DataSource = typeof(DataPhilosophiae.Config.AppConfig);
         // 
         // tileView1
         // 
         this.tileView1.Appearance.ItemNormal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
         this.tileView1.Appearance.ItemNormal.Options.UseFont = true;
         this.tileView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
         this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTimestamp,
            this.colName,
            this.colPath,
            this.colPinned});
         this.tileView1.ColumnSet.GroupColumn = this.colTimestamp;
         this.tileView1.GridControl = this.gridControl1;
         this.tileView1.Name = "tileView1";
         this.tileView1.OptionsBehavior.ReadOnly = true;
         this.tileView1.OptionsTiles.AllowItemHover = true;
         this.tileView1.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
         this.tileView1.OptionsTiles.IndentBetweenGroups = 0;
         this.tileView1.OptionsTiles.IndentBetweenItems = 0;
         this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(600, 100);
         this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
         this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
         this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
         this.tileView1.OptionsTiles.RowCount = 0;
         this.tileView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTimestamp, DevExpress.Data.ColumnSortOrder.Ascending)});
         tableColumnDefinition1.Length.Value = 529D;
         tableColumnDefinition2.Length.Value = 47D;
         this.tileView1.TileColumns.Add(tableColumnDefinition1);
         this.tileView1.TileColumns.Add(tableColumnDefinition2);
         this.tileView1.TileRows.Add(tableRowDefinition1);
         this.tileView1.TileRows.Add(tableRowDefinition2);
         this.tileView1.TileRows.Add(tableRowDefinition3);
         tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 16F);
         tileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
         tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
         tileViewItemElement1.Appearance.Normal.Options.UseForeColor = true;
         tileViewItemElement1.Column = this.colName;
         tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
         tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
         tileViewItemElement1.Text = "colName";
         tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
         tileViewItemElement2.Column = this.colTimestamp;
         tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
         tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
         tileViewItemElement2.RowIndex = 2;
         tileViewItemElement2.Text = "colTimestamp";
         tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
         tileViewItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
         tileViewItemElement3.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
         tileViewItemElement3.Appearance.Normal.Options.UseFont = true;
         tileViewItemElement3.Appearance.Normal.Options.UseForeColor = true;
         tileViewItemElement3.Column = this.colPath;
         tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
         tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
         tileViewItemElement3.RowIndex = 1;
         tileViewItemElement3.Text = "colPath";
         tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
         tileViewItemElement4.Column = this.colPinned;
         tileViewItemElement4.ColumnIndex = 1;
         tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
         tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
         tileViewItemElement4.Text = "colPinned";
         tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
         this.tileView1.TileTemplate.Add(tileViewItemElement1);
         this.tileView1.TileTemplate.Add(tileViewItemElement2);
         this.tileView1.TileTemplate.Add(tileViewItemElement3);
         this.tileView1.TileTemplate.Add(tileViewItemElement4);
         // 
         // labelControl1
         // 
         this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl1.Appearance.Options.UseFont = true;
         this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         this.labelControl1.LineVisible = true;
         this.labelControl1.Location = new System.Drawing.Point(3, 4);
         this.labelControl1.Name = "labelControl1";
         this.labelControl1.Size = new System.Drawing.Size(425, 13);
         this.labelControl1.TabIndex = 0;
         this.labelControl1.Text = "Recent DataStore Configs";
         // 
         // labelControl2
         // 
         this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl2.Appearance.Options.UseFont = true;
         this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         this.labelControl2.LineVisible = true;
         this.labelControl2.Location = new System.Drawing.Point(7, 4);
         this.labelControl2.Name = "labelControl2";
         this.labelControl2.Size = new System.Drawing.Size(425, 13);
         this.labelControl2.TabIndex = 1;
         this.labelControl2.Text = "Recent Dashboards";
         // 
         // OpenRecentXuc
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.Controls.Add(this.splitContainerControl1);
         this.Name = "OpenRecentXuc";
         this.Size = new System.Drawing.Size(945, 701);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
         this.splitContainerControl1.ResumeLayout(false);
         this.panel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.recentlyOpenedFileListBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.appConfigBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion
      private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private System.Windows.Forms.Panel panel1;
      private DevExpress.XtraGrid.GridControl gridControl1;
      private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
      private System.Windows.Forms.BindingSource appConfigBindingSource;
      private System.Windows.Forms.BindingSource recentlyOpenedFileListBindingSource;
      private DevExpress.XtraGrid.Columns.TileViewColumn colTimestamp;
      private DevExpress.XtraGrid.Columns.TileViewColumn colName;
      private DevExpress.XtraGrid.Columns.TileViewColumn colPath;
      private DevExpress.XtraGrid.Columns.TileViewColumn colPinned;
   }
}
