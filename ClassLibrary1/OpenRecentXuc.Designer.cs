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
         DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
         DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
         DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
         DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
         DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
         DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
         DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
         DevExpress.XtraEditors.TableLayout.TableSpan tableSpan3 = new DevExpress.XtraEditors.TableLayout.TableSpan();
         DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
         DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
         DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
         DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
         this.colName = new DevExpress.XtraGrid.Columns.TileViewColumn();
         this.colPath = new DevExpress.XtraGrid.Columns.TileViewColumn();
         this.colTimestamp = new DevExpress.XtraGrid.Columns.TileViewColumn();
         this.gridControl1 = new DevExpress.XtraGrid.GridControl();
         this.recentlyOpenedFileListBindingSource = new System.Windows.Forms.BindingSource();
         this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
         this.colPinned = new DevExpress.XtraGrid.Columns.TileViewColumn();
         this.colEnabled = new DevExpress.XtraGrid.Columns.TileViewColumn();
         this.colAvailable = new DevExpress.XtraGrid.Columns.TileViewColumn();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.recentlyOpenedFileListBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
         this.SuspendLayout();
         // 
         // colName
         // 
         this.colName.FieldName = "Name";
         this.colName.Name = "colName";
         this.colName.Visible = true;
         this.colName.VisibleIndex = 1;
         // 
         // colPath
         // 
         this.colPath.FieldName = "Path";
         this.colPath.Name = "colPath";
         this.colPath.Visible = true;
         this.colPath.VisibleIndex = 2;
         // 
         // colTimestamp
         // 
         this.colTimestamp.DisplayFormat.FormatString = "yyyy/MM/dd-HH:mm:ss,fffffffzzz";
         this.colTimestamp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.colTimestamp.FieldName = "Timestamp";
         this.colTimestamp.GroupFormat.FormatString = "yyyy/MM/dd-HH:mmzzz";
         this.colTimestamp.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.colTimestamp.Name = "colTimestamp";
         this.colTimestamp.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
         this.colTimestamp.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.True;
         this.colTimestamp.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
         this.colTimestamp.Visible = true;
         this.colTimestamp.VisibleIndex = 0;
         // 
         // gridControl1
         // 
         this.gridControl1.DataSource = this.recentlyOpenedFileListBindingSource;
         this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gridControl1.Location = new System.Drawing.Point(0, 0);
         this.gridControl1.MainView = this.tileView1;
         this.gridControl1.Name = "gridControl1";
         this.gridControl1.Size = new System.Drawing.Size(945, 701);
         this.gridControl1.TabIndex = 0;
         this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
         // 
         // tileView1
         // 
         this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTimestamp,
            this.colName,
            this.colPath,
            this.colPinned,
            this.colEnabled,
            this.colAvailable});
         this.tileView1.ColumnSet.CheckedColumn = this.colPinned;
         this.tileView1.ColumnSet.EnabledColumn = this.colEnabled;
         this.tileView1.ColumnSet.GroupColumn = this.colTimestamp;
         this.tileView1.GridControl = this.gridControl1;
         this.tileView1.Name = "tileView1";
         this.tileView1.OptionsTiles.AllowItemHover = true;
         this.tileView1.OptionsTiles.IndentBetweenItems = 6;
         this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(464, 130);
         this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
         this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
         this.tileView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTimestamp, DevExpress.Data.ColumnSortOrder.Descending)});
         tableColumnDefinition1.Length.Value = 165D;
         this.tileView1.TileColumns.Add(tableColumnDefinition1);
         tableRowDefinition1.Length.Value = 43D;
         tableRowDefinition2.Length.Value = 26D;
         tableRowDefinition3.Length.Value = 24D;
         tableRowDefinition4.Length.Value = 21D;
         this.tileView1.TileRows.Add(tableRowDefinition1);
         this.tileView1.TileRows.Add(tableRowDefinition2);
         this.tileView1.TileRows.Add(tableRowDefinition3);
         this.tileView1.TileRows.Add(tableRowDefinition4);
         tableSpan1.ColumnSpan = 2;
         tableSpan2.ColumnSpan = 2;
         tableSpan2.RowIndex = 1;
         tableSpan3.ColumnSpan = 2;
         tableSpan3.RowIndex = 2;
         this.tileView1.TileSpans.Add(tableSpan1);
         this.tileView1.TileSpans.Add(tableSpan2);
         this.tileView1.TileSpans.Add(tableSpan3);
         tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
         tileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
         tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
         tileViewItemElement1.Appearance.Normal.Options.UseForeColor = true;
         tileViewItemElement1.Column = this.colName;
         tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
         tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
         tileViewItemElement1.StretchHorizontal = true;
         tileViewItemElement1.Text = "colName";
         tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
         tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
         tileViewItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(132)))), ((int)(((byte)(223)))));
         tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
         tileViewItemElement2.Appearance.Normal.Options.UseForeColor = true;
         tileViewItemElement2.Column = this.colPath;
         tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
         tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
         tileViewItemElement2.RowIndex = 1;
         tileViewItemElement2.Text = "colPath";
         tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
         tileViewItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
         tileViewItemElement3.Appearance.Normal.Options.UseFont = true;
         tileViewItemElement3.Column = this.colTimestamp;
         tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
         tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
         tileViewItemElement3.RowIndex = 2;
         tileViewItemElement3.Text = "colTimestamp";
         tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
         tileViewItemElement4.Appearance.Normal.BackColor = System.Drawing.Color.Red;
         tileViewItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold);
         tileViewItemElement4.Appearance.Normal.ForeColor = System.Drawing.Color.White;
         tileViewItemElement4.Appearance.Normal.Options.UseBackColor = true;
         tileViewItemElement4.Appearance.Normal.Options.UseFont = true;
         tileViewItemElement4.Appearance.Normal.Options.UseForeColor = true;
         tileViewItemElement4.Height = 20;
         tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
         tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
         tileViewItemElement4.Name = "notFound";
         tileViewItemElement4.RowIndex = 3;
         tileViewItemElement4.StretchHorizontal = true;
         tileViewItemElement4.Text = "Not Found";
         tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
         this.tileView1.TileTemplate.Add(tileViewItemElement1);
         this.tileView1.TileTemplate.Add(tileViewItemElement2);
         this.tileView1.TileTemplate.Add(tileViewItemElement3);
         this.tileView1.TileTemplate.Add(tileViewItemElement4);
         this.tileView1.ItemClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tileView1_ItemClick);
         this.tileView1.ItemCustomize += new DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventHandler(this.tileView1_ItemCustomize);
         // 
         // colPinned
         // 
         this.colPinned.FieldName = "Pinned";
         this.colPinned.Name = "colPinned";
         this.colPinned.Visible = true;
         this.colPinned.VisibleIndex = 3;
         // 
         // colEnabled
         // 
         this.colEnabled.FieldName = "Enabled";
         this.colEnabled.Name = "colEnabled";
         this.colEnabled.Visible = true;
         this.colEnabled.VisibleIndex = 4;
         // 
         // colAvailable
         // 
         this.colAvailable.FieldName = "Available";
         this.colAvailable.Name = "colAvailable";
         this.colAvailable.Visible = true;
         this.colAvailable.VisibleIndex = 5;
         // 
         // OpenRecentXuc
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.Controls.Add(this.gridControl1);
         this.Name = "OpenRecentXuc";
         this.Size = new System.Drawing.Size(945, 701);
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.recentlyOpenedFileListBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion
      private DevExpress.XtraGrid.GridControl gridControl1;
      private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
      private System.Windows.Forms.BindingSource recentlyOpenedFileListBindingSource;
      private DevExpress.XtraGrid.Columns.TileViewColumn colTimestamp;
      private DevExpress.XtraGrid.Columns.TileViewColumn colName;
      private DevExpress.XtraGrid.Columns.TileViewColumn colPath;
      private DevExpress.XtraGrid.Columns.TileViewColumn colPinned;
      private DevExpress.XtraGrid.Columns.TileViewColumn colEnabled;
      private DevExpress.XtraGrid.Columns.TileViewColumn colAvailable;
   }
}
