namespace DialogHeadStart
{
   partial class Form1
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
         this.components = new System.ComponentModel.Container();
         this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
         this.bar1 = new DevExpress.XtraBars.Bar();
         this.bar2 = new DevExpress.XtraBars.Bar();
         this.fileBarSubItem = new DevExpress.XtraBars.BarSubItem();
         this.newBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.openBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.openRecentBarSubItem = new DevExpress.XtraBars.BarSubItem();
         this.openRecentBarListItem = new DevExpress.XtraBars.BarListItem();
         this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.saveAsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.printBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.exportBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.importBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.setDefaultPathBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.closeBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.exitBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.editBarSubItem = new DevExpress.XtraBars.BarSubItem();
         this.guiBarSubItem = new DevExpress.XtraBars.BarSubItem();
         this.skinMenuBarSubItem = new DevExpress.XtraBars.SkinBarSubItem();
         this.skinListDropDownButtonItem = new DevExpress.XtraBars.SkinDropDownButtonItem();
         this.makeDirtyBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.bar3 = new DevExpress.XtraBars.Bar();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
         this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
         this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
         this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
         this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
         this.xtraFolderBrowserDialog1 = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
         this.fileNameLabelControl = new DevExpress.XtraEditors.LabelControl();
         this.fileStatusLabelControl = new DevExpress.XtraEditors.LabelControl();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         this.SuspendLayout();
         // 
         // barManager1
         // 
         this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
         this.barManager1.DockControls.Add(this.barDockControlTop);
         this.barManager1.DockControls.Add(this.barDockControlBottom);
         this.barManager1.DockControls.Add(this.barDockControlLeft);
         this.barManager1.DockControls.Add(this.barDockControlRight);
         this.barManager1.Form = this;
         this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.fileBarSubItem,
            this.editBarSubItem,
            this.barSubItem1,
            this.openBarButtonItem,
            this.saveBarButtonItem,
            this.saveAsBarButtonItem,
            this.newBarButtonItem,
            this.barButtonItem5,
            this.barSubItem2,
            this.printBarButtonItem,
            this.exportBarButtonItem,
            this.importBarButtonItem,
            this.closeBarButtonItem,
            this.exitBarButtonItem,
            this.setDefaultPathBarButtonItem,
            this.guiBarSubItem,
            this.skinMenuBarSubItem,
            this.skinListDropDownButtonItem,
            this.makeDirtyBarButtonItem,
            this.openRecentBarListItem,
            this.openRecentBarSubItem});
         this.barManager1.MainMenu = this.bar2;
         this.barManager1.MaxItemId = 22;
         this.barManager1.StatusBar = this.bar3;
         // 
         // bar1
         // 
         this.bar1.BarName = "Tools";
         this.bar1.DockCol = 0;
         this.bar1.DockRow = 1;
         this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.bar1.Text = "Tools";
         // 
         // bar2
         // 
         this.bar2.BarName = "Main menu";
         this.bar2.DockCol = 0;
         this.bar2.DockRow = 0;
         this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.fileBarSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.editBarSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.guiBarSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.makeDirtyBarButtonItem)});
         this.bar2.OptionsBar.MultiLine = true;
         this.bar2.OptionsBar.UseWholeRow = true;
         this.bar2.Text = "Main menu";
         // 
         // fileBarSubItem
         // 
         this.fileBarSubItem.Caption = "&File";
         this.fileBarSubItem.Id = 0;
         this.fileBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.newBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.openBarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.openRecentBarSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.saveBarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.saveAsBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.printBarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.exportBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.importBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.setDefaultPathBarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.closeBarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.exitBarButtonItem, true)});
         this.fileBarSubItem.Name = "fileBarSubItem";
         // 
         // newBarButtonItem
         // 
         this.newBarButtonItem.Caption = "New";
         this.newBarButtonItem.Id = 6;
         this.newBarButtonItem.Name = "newBarButtonItem";
         this.newBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newBarButtonItem_ItemClick);
         // 
         // openBarButtonItem
         // 
         this.openBarButtonItem.Caption = "Open...";
         this.openBarButtonItem.Id = 3;
         this.openBarButtonItem.Name = "openBarButtonItem";
         this.openBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.openBarButtonItem_ItemClick);
         // 
         // openRecentBarSubItem
         // 
         this.openRecentBarSubItem.Caption = "Open Recent";
         this.openRecentBarSubItem.Id = 21;
         this.openRecentBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.openRecentBarListItem)});
         this.openRecentBarSubItem.Name = "openRecentBarSubItem";
         // 
         // openRecentBarListItem
         // 
         this.openRecentBarListItem.Caption = "Open Recent";
         this.openRecentBarListItem.Id = 20;
         this.openRecentBarListItem.MaxSubItemTextWidth = 100;
         this.openRecentBarListItem.Name = "openRecentBarListItem";
         this.openRecentBarListItem.ListItemClick += new DevExpress.XtraBars.ListItemClickEventHandler(this.openRecentBarListItem_ListItemClick);
         this.openRecentBarListItem.GetItemData += new System.EventHandler(this.openRecentBarListItem_GetItemData);
         // 
         // saveBarButtonItem
         // 
         this.saveBarButtonItem.Caption = "Save";
         this.saveBarButtonItem.Id = 4;
         this.saveBarButtonItem.Name = "saveBarButtonItem";
         this.saveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveBarButtonItem_ItemClick);
         // 
         // saveAsBarButtonItem
         // 
         this.saveAsBarButtonItem.Caption = "Save As...";
         this.saveAsBarButtonItem.Id = 5;
         this.saveAsBarButtonItem.Name = "saveAsBarButtonItem";
         this.saveAsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveAsBarButtonItem_ItemClick);
         // 
         // printBarButtonItem
         // 
         this.printBarButtonItem.Caption = "Print";
         this.printBarButtonItem.Id = 9;
         this.printBarButtonItem.Name = "printBarButtonItem";
         // 
         // exportBarButtonItem
         // 
         this.exportBarButtonItem.Caption = "Export";
         this.exportBarButtonItem.Id = 10;
         this.exportBarButtonItem.Name = "exportBarButtonItem";
         // 
         // importBarButtonItem
         // 
         this.importBarButtonItem.Caption = "Import";
         this.importBarButtonItem.Id = 11;
         this.importBarButtonItem.Name = "importBarButtonItem";
         // 
         // setDefaultPathBarButtonItem
         // 
         this.setDefaultPathBarButtonItem.Caption = "Set Default Path";
         this.setDefaultPathBarButtonItem.Id = 15;
         this.setDefaultPathBarButtonItem.Name = "setDefaultPathBarButtonItem";
         this.setDefaultPathBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.setDefaultPathBarButtonItem_ItemClick);
         // 
         // closeBarButtonItem
         // 
         this.closeBarButtonItem.Caption = "Close";
         this.closeBarButtonItem.Id = 13;
         this.closeBarButtonItem.Name = "closeBarButtonItem";
         this.closeBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.closeBarButtonItem_ItemClick);
         // 
         // exitBarButtonItem
         // 
         this.exitBarButtonItem.Caption = "Exit";
         this.exitBarButtonItem.Id = 14;
         this.exitBarButtonItem.Name = "exitBarButtonItem";
         this.exitBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exitBarButtonItem_ItemClick);
         // 
         // editBarSubItem
         // 
         this.editBarSubItem.Caption = "&Edit";
         this.editBarSubItem.Id = 1;
         this.editBarSubItem.Name = "editBarSubItem";
         // 
         // guiBarSubItem
         // 
         this.guiBarSubItem.Caption = "GUI";
         this.guiBarSubItem.Id = 16;
         this.guiBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinMenuBarSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinListDropDownButtonItem)});
         this.guiBarSubItem.Name = "guiBarSubItem";
         // 
         // skinMenuBarSubItem
         // 
         this.skinMenuBarSubItem.Caption = "Skin Menu";
         this.skinMenuBarSubItem.Id = 17;
         this.skinMenuBarSubItem.Name = "skinMenuBarSubItem";
         // 
         // skinListDropDownButtonItem
         // 
         this.skinListDropDownButtonItem.Id = 18;
         this.skinListDropDownButtonItem.Name = "skinListDropDownButtonItem";
         // 
         // makeDirtyBarButtonItem
         // 
         this.makeDirtyBarButtonItem.Caption = "\"Make Dirty\"";
         this.makeDirtyBarButtonItem.Id = 19;
         this.makeDirtyBarButtonItem.Name = "makeDirtyBarButtonItem";
         this.makeDirtyBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.makeDirtyBarButtonItem_ItemClick);
         // 
         // bar3
         // 
         this.bar3.BarName = "Status bar";
         this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
         this.bar3.DockCol = 0;
         this.bar3.DockRow = 0;
         this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
         this.bar3.OptionsBar.AllowQuickCustomization = false;
         this.bar3.OptionsBar.DrawDragBorder = false;
         this.bar3.OptionsBar.UseWholeRow = true;
         this.bar3.Text = "Status bar";
         // 
         // barDockControlTop
         // 
         this.barDockControlTop.CausesValidation = false;
         this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
         this.barDockControlTop.Manager = this.barManager1;
         this.barDockControlTop.Size = new System.Drawing.Size(723, 46);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 346);
         this.barDockControlBottom.Manager = this.barManager1;
         this.barDockControlBottom.Size = new System.Drawing.Size(723, 18);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 46);
         this.barDockControlLeft.Manager = this.barManager1;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 300);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(723, 46);
         this.barDockControlRight.Manager = this.barManager1;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 300);
         // 
         // barSubItem1
         // 
         this.barSubItem1.Caption = "Open";
         this.barSubItem1.Id = 2;
         this.barSubItem1.Name = "barSubItem1";
         // 
         // barButtonItem5
         // 
         this.barButtonItem5.Caption = "Open Recent";
         this.barButtonItem5.Id = 7;
         this.barButtonItem5.Name = "barButtonItem5";
         // 
         // barSubItem2
         // 
         this.barSubItem2.Caption = "Print";
         this.barSubItem2.Id = 8;
         this.barSubItem2.Name = "barSubItem2";
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
         // 
         // fileNameLabelControl
         // 
         this.fileNameLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.fileNameLabelControl.Appearance.Options.UseFont = true;
         this.fileNameLabelControl.LineVisible = true;
         this.fileNameLabelControl.Location = new System.Drawing.Point(220, 63);
         this.fileNameLabelControl.Name = "fileNameLabelControl";
         this.fileNameLabelControl.Size = new System.Drawing.Size(268, 116);
         this.fileNameLabelControl.TabIndex = 4;
         this.fileNameLabelControl.Text = "Empty";
         // 
         // fileStatusLabelControl
         // 
         this.fileStatusLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.fileStatusLabelControl.Appearance.Options.UseFont = true;
         this.fileStatusLabelControl.LineVisible = true;
         this.fileStatusLabelControl.Location = new System.Drawing.Point(220, 185);
         this.fileStatusLabelControl.Name = "fileStatusLabelControl";
         this.fileStatusLabelControl.Size = new System.Drawing.Size(268, 116);
         this.fileStatusLabelControl.TabIndex = 5;
         this.fileStatusLabelControl.Text = "Empty";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(723, 364);
         this.Controls.Add(this.fileStatusLabelControl);
         this.Controls.Add(this.fileNameLabelControl);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "Form1";
         this.Text = "Form1";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.BarManager barManager1;
      private DevExpress.XtraBars.Bar bar1;
      private DevExpress.XtraBars.Bar bar2;
      private DevExpress.XtraBars.Bar bar3;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private DevExpress.XtraBars.BarSubItem fileBarSubItem;
      private DevExpress.XtraBars.BarSubItem editBarSubItem;
      private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
      private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog1;
      private DevExpress.XtraEditors.XtraFolderBrowserDialog xtraFolderBrowserDialog1;
      private DevExpress.XtraBars.BarButtonItem newBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem openBarButtonItem;
      //private DevExpress.XtraBars.BarSubItem openRecentBarSubItem;
      private DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem saveAsBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem printBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem exportBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem importBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem closeBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem exitBarButtonItem;
      private DevExpress.XtraBars.BarSubItem barSubItem1;
      private DevExpress.XtraBars.BarButtonItem barButtonItem5;
      private DevExpress.XtraBars.BarSubItem barSubItem2;
      private DevExpress.XtraBars.BarButtonItem setDefaultPathBarButtonItem;
      private DevExpress.XtraBars.BarSubItem guiBarSubItem;
      private DevExpress.XtraBars.SkinBarSubItem skinMenuBarSubItem;
      private DevExpress.XtraBars.SkinDropDownButtonItem skinListDropDownButtonItem;
      private DevExpress.XtraBars.BarButtonItem makeDirtyBarButtonItem;
      private DevExpress.XtraEditors.LabelControl fileNameLabelControl;
      private DevExpress.XtraEditors.LabelControl fileStatusLabelControl;
      private DevExpress.XtraBars.BarListItem openRecentBarListItem;
      private DevExpress.XtraBars.BarSubItem openRecentBarSubItem;
   }
}

