namespace ConfigFilesHeadStart
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
         this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
         this.skinListDropDownButtonItem = new DevExpress.XtraBars.SkinDropDownButtonItem();
         this.skinGalleryRibbonBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
         this.skinPaletteRibbonGalleryBarItem = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
         this.colorMixerBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
         this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
         this.skinsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
         this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
         this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
         ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
         this.SuspendLayout();
         // 
         // ribbonControl1
         // 
         this.ribbonControl1.ExpandCollapseItem.Id = 0;
         this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.skinListDropDownButtonItem,
            this.skinGalleryRibbonBarItem,
            this.skinPaletteRibbonGalleryBarItem,
            this.colorMixerBarButtonItem});
         this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
         this.ribbonControl1.MaxItemId = 5;
         this.ribbonControl1.Name = "ribbonControl1";
         this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.skinsRibbonPage});
         this.ribbonControl1.Size = new System.Drawing.Size(929, 162);
         // 
         // skinListDropDownButtonItem
         // 
         this.skinListDropDownButtonItem.Id = 1;
         this.skinListDropDownButtonItem.Name = "skinListDropDownButtonItem";
         // 
         // skinGalleryRibbonBarItem
         // 
         this.skinGalleryRibbonBarItem.Caption = "skinRibbonGalleryBarItem1";
         this.skinGalleryRibbonBarItem.Id = 2;
         this.skinGalleryRibbonBarItem.Name = "skinGalleryRibbonBarItem";
         // 
         // skinPaletteRibbonGalleryBarItem
         // 
         this.skinPaletteRibbonGalleryBarItem.Caption = "skinPaletteRibbonGalleryBarItem1";
         this.skinPaletteRibbonGalleryBarItem.Id = 3;
         this.skinPaletteRibbonGalleryBarItem.Name = "skinPaletteRibbonGalleryBarItem";
         // 
         // colorMixerBarButtonItem
         // 
         this.colorMixerBarButtonItem.Caption = "Color Mixer";
         this.colorMixerBarButtonItem.Id = 4;
         this.colorMixerBarButtonItem.Name = "colorMixerBarButtonItem";
         this.colorMixerBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.colorMixerBarButtonItem_ItemClick);
         // 
         // ribbonPage1
         // 
         this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
         this.ribbonPage1.Name = "ribbonPage1";
         this.ribbonPage1.Text = "ribbonPage1";
         // 
         // ribbonPageGroup1
         // 
         this.ribbonPageGroup1.Name = "ribbonPageGroup1";
         this.ribbonPageGroup1.Text = "ribbonPageGroup1";
         // 
         // skinsRibbonPage
         // 
         this.skinsRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup2});
         this.skinsRibbonPage.Name = "skinsRibbonPage";
         this.skinsRibbonPage.Text = "Skins";
         // 
         // ribbonPageGroup2
         // 
         this.ribbonPageGroup2.Name = "ribbonPageGroup2";
         this.ribbonPageGroup2.Text = "ribbonPageGroup2";
         // 
         // ribbonPageGroup3
         // 
         this.ribbonPageGroup3.ItemLinks.Add(this.skinListDropDownButtonItem);
         this.ribbonPageGroup3.ItemLinks.Add(this.skinGalleryRibbonBarItem);
         this.ribbonPageGroup3.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem);
         this.ribbonPageGroup3.ItemLinks.Add(this.colorMixerBarButtonItem);
         this.ribbonPageGroup3.Name = "ribbonPageGroup3";
         this.ribbonPageGroup3.Text = "ribbonPageGroup3";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(929, 517);
         this.Controls.Add(this.ribbonControl1);
         this.Name = "Form1";
         this.Ribbon = this.ribbonControl1;
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
      private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
      private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
      private DevExpress.XtraBars.SkinDropDownButtonItem skinListDropDownButtonItem;
      private DevExpress.XtraBars.Ribbon.RibbonPage skinsRibbonPage;
      private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
      private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
      private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinGalleryRibbonBarItem;
      private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem;
      private DevExpress.XtraBars.BarButtonItem colorMixerBarButtonItem;
   }
}

