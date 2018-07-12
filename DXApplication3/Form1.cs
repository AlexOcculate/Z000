using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DXApplication3
{
   public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
   {
      private IList<DataStore> list = new BindingList<DataStore>();

      public Form1()
      {
         this.InitializeComponent();
         {
            this.list.Add(new DataStore());
         }
         this.gridControl1.DataSource = this.list;
         // Display a New Item Row to add rows to the View.
         this.gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top; // Available modes: Top, Bottom, None
      }
   }

   public class DataStore
   {
      public DataStore()
      {
      }

      public override string ToString()
      {
         return this.Name;
      }

      [Display( Name = nameof(Name), Description = "DataStore Unique Name" )]
      [Required( AllowEmptyStrings = false )]
      public string Name
      {
         get; set;
      }

      [Display( GroupName = "[Connection]", Name = "Provider Name", Description = "DataStore Provider Name" )]
      [Required( AllowEmptyStrings = false )]
      public string ProviderName
      {
         get; set;
      }

      [Display( GroupName = "[Connection]", Name = "Connection String" )]
      [Required( AllowEmptyStrings = false )]
      public string ConnectionString
      {
         get; set;
      }

      [Display( GroupName = "Path-", Description = "Where pulled data will be saved." )]
      public string StagePathDir
      {
         get; set;
      }


      [Display( GroupName = "Flags-", Description = "Is this DataStore Active?" )]
      public bool Active
      {
         get; set;
      }

      [Display( GroupName = "Flags-", Description = "Load only the Default Database?" )]
      public bool LoadDefaultDatabaseOnly
      {
         get; set;
      }

      [Display( GroupName = "Flags-", Description = "Load System Objects also?" )]
      public bool LoadSystemObjects
      {
         get; set;
      }

      [Display( GroupName = "Flags-", Description = "Load Tables' Fields also?" )]
      public bool LoadWithFields
      {
         get; set;
      }
   }
}
