using DataPhilosophiae.Config.Model;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Linq;
using System.Xml.Linq;

namespace TestDataStoreConfig
{
   public partial class Form1 : RibbonForm
   {
      private static XDocument dsCfgSample = DataStoreConfig.DsCfgSample( );
      private static DataStoreConfig dsCfg = DataStoreConfig.Deserialize( dsCfgSample );

      public Form1()
      {
         this.InitializeComponent( );
         //
         DataStoreConfig.Info += this.DataStoreConfig_Info;
         dsCfg = DataStoreConfig.Deserialize( dsCfgSample );
         this.InitializeGrid( );

      }

      private void DataStoreConfig_Info( string msg )
      {
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
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler( this.Form1_FormClosed );
      }

      private GridColumn _colStagePathDir;

      private void Form1_Load( object sender, EventArgs e )
      {
         this.gridControl1.DataSource = dsCfg.DataStoreList;
         this._colStagePathDir = this.gridView1.Columns[ DataStore.StagePathDir_FldName ];
         this.gridView1.CustomColumnDisplayText += this.GridView1_CustomColumnDisplayText;
         //this.gridView1.CustomRowCellEdit += this.GridView1_CustomRowCellEdit;
         this.gridView1.InitNewRow += this.GridView1_InitNewRow;
         this.gridView1.CalcPreviewText += this.GridView1_CalcPreviewText;
      }

      private void Form1_FormClosed( object sender, System.Windows.Forms.FormClosedEventArgs e )
      {
         XDocument serialize = dsCfg.Serialize( );
      }

      private void GridView1_InitNewRow( object sender, InitNewRowEventArgs e )
      {
         GridView view = sender as GridView;
         view.SetRowCellValue( e.RowHandle, view.Columns[ DataStore.StagePathDir_FldName ], dsCfg.DefaultStgDirVal );
         view.SetRowCellValue( e.RowHandle, view.Columns[ DataStore.LoadSystemObjects_FldName ], false );
         view.SetRowCellValue( e.RowHandle, view.Columns[ DataStore.LoadDefaultDatabaseOnly_FldName ], true );
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
      private void GridView1_CalcPreviewText( object sender, CalcPreviewTextEventArgs e )
      {
         GridView view = sender as GridView;
         if( view == null )
            return;
         e.PreviewText = "Stage Path Dir: "
            + view.GetRowCellDisplayText( e.RowHandle, view.Columns[ DataStore.StagePathDir_FldName ] )
            ;
      }

   }
}
