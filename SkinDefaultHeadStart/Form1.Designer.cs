namespace SkinDefaultHeadStart
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
         DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SkinDefaultHeadStart.SplashScreen1), true, true, true);
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
         this.bar1 = new DevExpress.XtraBars.Bar();
         this.bar2 = new DevExpress.XtraBars.Bar();
         this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
         this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
         this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
         this.colorSwatchesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.colorMixerBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.bar3 = new DevExpress.XtraBars.Bar();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
         this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
         this.splashscreenBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         this.SuspendLayout();
         // 
         // splashScreenManager1
         // 
         splashScreenManager1.ClosingDelay = 1000;
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
            this.skinBarSubItem1,
            this.skinDropDownButtonItem1,
            this.barButtonItem1,
            this.barSubItem1,
            this.colorSwatchesBarButtonItem,
            this.colorMixerBarButtonItem,
            this.barSubItem2,
            this.splashscreenBarButtonItem});
         this.barManager1.MainMenu = this.bar2;
         this.barManager1.MaxItemId = 8;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
         this.bar2.OptionsBar.MultiLine = true;
         this.bar2.OptionsBar.UseWholeRow = true;
         this.bar2.Text = "Main menu";
         // 
         // barSubItem1
         // 
         this.barSubItem1.Caption = "GUI";
         this.barSubItem1.Id = 3;
         this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinDropDownButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.colorSwatchesBarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.colorMixerBarButtonItem)});
         this.barSubItem1.Name = "barSubItem1";
         // 
         // skinBarSubItem1
         // 
         this.skinBarSubItem1.Caption = "Skin Menu";
         this.skinBarSubItem1.Id = 0;
         this.skinBarSubItem1.Name = "skinBarSubItem1";
         // 
         // skinDropDownButtonItem1
         // 
         this.skinDropDownButtonItem1.Id = 1;
         this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
         // 
         // colorSwatchesBarButtonItem
         // 
         this.colorSwatchesBarButtonItem.Caption = "Color Swatches";
         this.colorSwatchesBarButtonItem.Id = 4;
         this.colorSwatchesBarButtonItem.Name = "colorSwatchesBarButtonItem";
         this.colorSwatchesBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.colorSwatchesBarButtonItem_ItemClick);
         // 
         // colorMixerBarButtonItem
         // 
         this.colorMixerBarButtonItem.Caption = "Color Mixer";
         this.colorMixerBarButtonItem.Id = 5;
         this.colorMixerBarButtonItem.Name = "colorMixerBarButtonItem";
         this.colorMixerBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.colorMixerBarButtonItem_ItemClick);
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
         this.barDockControlTop.Size = new System.Drawing.Size(955, 48);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 488);
         this.barDockControlBottom.Manager = this.barManager1;
         this.barDockControlBottom.Size = new System.Drawing.Size(955, 18);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 48);
         this.barDockControlLeft.Manager = this.barManager1;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 440);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(955, 48);
         this.barDockControlRight.Manager = this.barManager1;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 440);
         // 
         // barButtonItem1
         // 
         this.barButtonItem1.Caption = "Skin";
         this.barButtonItem1.Id = 2;
         this.barButtonItem1.Name = "barButtonItem1";
         // 
         // barSubItem2
         // 
         this.barSubItem2.Caption = "Help";
         this.barSubItem2.Id = 6;
         this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.splashscreenBarButtonItem)});
         this.barSubItem2.Name = "barSubItem2";
         // 
         // splashscreenBarButtonItem
         // 
         this.splashscreenBarButtonItem.Caption = "Splashscreen";
         this.splashscreenBarButtonItem.Id = 7;
         this.splashscreenBarButtonItem.Name = "splashscreenBarButtonItem";
         this.splashscreenBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.splashscreenBarButtonItem_ItemClick);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(955, 506);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "Form1";
         this.Text = "Form1";
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
      private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
      private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
      private DevExpress.XtraBars.BarSubItem barSubItem1;
      private DevExpress.XtraBars.BarButtonItem barButtonItem1;
      private DevExpress.XtraBars.BarButtonItem colorSwatchesBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem colorMixerBarButtonItem;
      private DevExpress.XtraBars.BarSubItem barSubItem2;
      private DevExpress.XtraBars.BarButtonItem splashscreenBarButtonItem;
   }
}

