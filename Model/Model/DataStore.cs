using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DataPhilosophiae.Config.Model
{
   public class DataStore
   {
      public override string ToString()
      {
         return this.Name;
      }

      [Display( Name = "Name", Description = "DataStore Unique Name" )]
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

      public const string StagePathDir_FldName = "StagePathDir";
      public const string StagePathDir_ColName = "Stage Path Dir";
      [Display( GroupName = "Path-", Name= StagePathDir_ColName, Description = "Where pulled data will be saved." )]
      public string StagePathDir
      {
         get; set;
      }

      [Display( GroupName = "Flags-", Description = "Is this DataStore Active?" )]
      public bool Active
      {
         get; set;
      }

      public const string LoadDefaultDatabaseOnly_FldName = "LoadDefaultDatabaseOnly";
      public const string LoadDefaultDatabaseOnly_ColName = "Load Default Database Only";
      [Display( GroupName = "Flags-", Description = "Load only the Default Database?" )]
      public bool LoadDefaultDatabaseOnly
      {
         get; set;
      }

      public const string LoadSystemObjects_FldName = "LoadSystemObjects";
      public const string LoadSystemObjects_ColName = "Load System Objects";
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
