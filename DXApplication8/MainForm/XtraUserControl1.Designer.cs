namespace DataPhilosophiae
{
   partial class XtraUserControl1
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
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
         this.SuspendLayout();
         // 
         // labelControl1
         // 
         this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl1.Appearance.Options.UseFont = true;
         this.labelControl1.LineVisible = true;
         this.labelControl1.Location = new System.Drawing.Point(94, 125);
         this.labelControl1.Name = "labelControl1";
         this.labelControl1.Size = new System.Drawing.Size(314, 42);
         this.labelControl1.TabIndex = 0;
         this.labelControl1.Text = "DataStore Collection";
         // 
         // XtraUserControl1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.labelControl1);
         this.Name = "XtraUserControl1";
         this.Size = new System.Drawing.Size(433, 410);
         ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraEditors.LabelControl labelControl1;
      private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
   }
}
