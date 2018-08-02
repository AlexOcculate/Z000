using DataPhilosophiae.Config;
using DataPhilosophiae.Config.Model;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TestDataStoreConfig
{
   public partial class Form1 : RibbonForm
   {
      private static DataStoreConfig dsCfg = DataStoreConfig.Deserialize( dsCfgSample );
      private static XDocument dsCfgSample = DataStoreConfig.Sample( );

      private GridColumn _colStagePathDir;

      public Form1()
      {
         this.InitializeComponent( );
         //
         DataStoreConfig.Info += this.DataStoreConfig_Info;
         dsCfg = DataStoreConfig.Deserialize( dsCfgSample );
         this.InitializeGrid( );
         //
         ToolTipController.DefaultController.GetActiveObjectInfo += this.DefaultController_GetActiveObjectInfo;
      }

      private void DefaultController_GetActiveObjectInfo( object sender, ToolTipControllerGetActiveObjectInfoEventArgs e )
      {
         if( e.SelectedControl != this.gridControl1 )
         {
            return;
         }

         //Get the view at the current mouse position 
         GridView view = this.gridControl1.GetViewAt( e.ControlMousePosition ) as GridView;
         if( view == null )
         {
            return;
         }
         //Get the view's element information that resides at the current position 
         GridHitInfo hi = view.CalcHitInfo( e.ControlMousePosition );
         ToolTipControlInfo info = null;
         //Display a hint for row indicator cells 
         if( hi.HitTest == GridHitTest.RowIndicator )
         {
            //An object that uniquely identifies a row indicator cell 
            object o = hi.HitTest.ToString( ) + hi.RowHandle.ToString( );
            string text = "Row " + hi.RowHandle.ToString( );
            info = new ToolTipControlInfo( o, text );
         }
         //Supply tooltip information if applicable, otherwise preserve default tooltip (if any) 
         if( info != null )
         {
            e.Info = info;
         }
      }

      private void InitializeGrid()
      {
         this.gridControl1.UseEmbeddedNavigator = true;
         this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
         this.gridView1.OptionsFilter.UseNewCustomFilterDialog = true;
         this.gridView1.OptionsView.ShowAutoFilterRow = true;
         this.gridView1.OptionsFind.AlwaysVisible = true;
         this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
         this.gridView1.OptionsMenu.ShowConditionalFormattingItem = true;
         this.gridView1.OptionsView.ShowPreview = true;
         {
            GridFormatRule gridFormatRule = new GridFormatRule( );
            FormatConditionRuleExpression formatConditionRuleExpression = new FormatConditionRuleExpression( );
            gridFormatRule.Column = this._colStagePathDir;
            //gridFormatRule.ColumnApplyTo = this._colStagePathDir;
            gridFormatRule.ApplyToRow = true;
            formatConditionRuleExpression.PredefinedName = "Yellow Fill, Yellow Text";
            formatConditionRuleExpression.Expression = "[" + DataStore.StagePathDir_FldName + "] == '" + dsCfg.DefaultStgDirVal + "'";
            gridFormatRule.Rule = formatConditionRuleExpression;
            this.gridView1.FormatRules.Add( gridFormatRule );
         }
         this.Load += new System.EventHandler( this.Form1_Load );
         this.FormClosed += new FormClosedEventHandler( this.Form1_FormClosed );
      }

      private void Form1_FormClosed( object sender, FormClosedEventArgs e )
      {
         XDocument serialize = dsCfg.Serialize( );
      }

      private void Form1_Load( object sender, EventArgs e )
      {
         this.gridControl1.DataSource = dsCfg.DataStoreList;
         this._colStagePathDir = this.gridView1.Columns[ DataStore.StagePathDir_FldName ];
         this.gridView1.CustomColumnDisplayText += this.GridView1_CustomColumnDisplayText;
         //this.gridView1.CustomRowCellEdit += this.GridView1_CustomRowCellEdit;
         this.gridView1.InitNewRow += this.GridView1_InitNewRow;
         this.gridView1.CalcPreviewText += this.GridView1_CalcPreviewText;
      }

      private void DataStoreConfig_Info( string msg )
      {
      }

      private void GridView1_CalcPreviewText( object sender, CalcPreviewTextEventArgs e )
      {
         GridView view = sender as GridView;
         if( view == null )
         {
            return;
         }

         e.PreviewText = "Stage Path Dir: "
            + view.GetRowCellDisplayText( e.RowHandle, view.Columns[ DataStore.StagePathDir_FldName ] );
      }

      private void GridView1_CustomColumnDisplayText( object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e )
      {
         if( e.ListSourceRowIndex < 0 )
         {
            return;
         }
         if( e.Column == this._colStagePathDir )
         {
            if( e.Value == null || e.Value.ToString( ) == dsCfg.DefaultStgDirVal )
            {
               e.DisplayText = "<DEFAULT>";
            }
         }
      }

      private void GridView1_InitNewRow( object sender, InitNewRowEventArgs e )
      {
         GridView view = sender as GridView;
         view.SetRowCellValue( e.RowHandle, view.Columns[ DataStore.StagePathDir_FldName ], dsCfg.DefaultStgDirVal );
         view.SetRowCellValue( e.RowHandle, view.Columns[ DataStore.LoadSystemObjects_FldName ], false );
         view.SetRowCellValue( e.RowHandle, view.Columns[ DataStore.LoadDefaultDatabaseOnly_FldName ], true );
      }

      private void gridView1_MouseDown( object sender, MouseEventArgs e )
      {
         GridView view = sender as GridView;
         // obtaining hit info 
         GridHitInfo hitInfo = view.CalcHitInfo( new Point( e.X, e.Y ) );
         if( ((e.Button & MouseButtons.Right) != 0) && (hitInfo.InRow) && (!view.IsGroupRow( hitInfo.RowHandle )) )
         {
            // switching focus 
            view.FocusedRowHandle = hitInfo.RowHandle;
            // showing the custom context menu 
            ViewMenu menu = new ViewMenu( view );
            {
               {
                  DXMenuItem menuItem = new DXMenuItem( "RefreshRow", new EventHandler( this.RefreshFocusedRow ) );
                  menuItem.Tag = view;
                  menu.Items.Add( menuItem );
               }
               {
                  DXMenuItem menuItem = new DXMenuItem( "DeleteRow", new EventHandler( this.DeleteFocusedRow ) );
                  menuItem.Tag = view;
                  menu.Items.Add( menuItem );
               }
               menu.Show( hitInfo.HitPoint );
            }
         }
      }

      private void RefreshFocusedRow( object sender, EventArgs e )
      {
         DXMenuItem menuItem = sender as DXMenuItem;
         if( menuItem == null )
         {
            return;
         }

         ColumnView View = menuItem.Tag as ColumnView;
         DataStore ds = View.GetRow( View.FocusedRowHandle ) as DataStore;
         if( ds == null )
         {
            return;
         }
         //
         // E aqui que vai acontecer a magica!
         //
      }

      private void DeleteFocusedRow( object sender, EventArgs e )
      {
         DXMenuItem menuItem = sender as DXMenuItem;
         if( menuItem == null )
         {
            return;
         }

         ColumnView View = menuItem.Tag as ColumnView;
         View.DeleteRow( View.FocusedRowHandle );
      }

      private void gridControl1_MouseMove( object sender, MouseEventArgs e )
      {
         GridControl grid = sender as GridControl;
         if( grid == null )
         {
            return;
         }
         // Get a View at the current point. 
         BaseView view = grid.GetViewAt( e.Location );
         // Retrieve information on the current View element. 
         BaseHitInfo baseHI = view.CalcHitInfo( e.Location );
         GridHitInfo gridHI = baseHI as GridHitInfo;
         if( gridHI != null )
         {
            Text = gridHI.HitTest.ToString( );
         }
      }
   }
}
