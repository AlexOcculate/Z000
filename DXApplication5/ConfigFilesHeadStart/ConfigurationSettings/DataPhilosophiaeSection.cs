﻿namespace FrontEnd.ConfigurationSetting
{
   public partial class DataStore
   {
      public static System.Data.DataTable LoadDataStoreConfigurationSetting(string name = DataStore.DATA_STORE_CONFIG_TBLNAME)
      {
         if(string.IsNullOrWhiteSpace(name))
         {
            throw new System.ArgumentException($"{nameof( name )} is null, empty or whitespaces only.", nameof(name));
         }
         DataPhilosophiaeSection dps = System.Configuration.ConfigurationManager.GetSection(nameof(DataPhilosophiaeSection)) as DataPhilosophiaeSection;
         System.Configuration.ConnectionStringSettingsCollection css = System.Configuration.ConfigurationManager.ConnectionStrings;
         if(dps == null)
         {
            throw new System.Exception("[DataPhilosophiaeSection] section missing in app.config!!!");
         }
         if(css == null)
         {
            throw new System.Exception("[connectionStrings] section missing in app.config!!!");
         }
         System.Data.DataTable tbl = DataStore.CreateDataStoreConfigTable(name);
         {
            foreach(DataStoreElement dse in dps.DataStores)
            {
               System.Configuration.ConnectionStringSettings cs = css[dse.ConnectionStringName];
               DataStore ds = new DataStore(dps, dse, cs);
               tbl.Rows.Add(ds.GetAsDataRow(tbl.NewRow()));
               validateStagePathDir(ds);
            }
         }
         return tbl;
      }

      private static void validateStagePathDir(DataStore ds)
      {
         bool isValidProviderName = ds.IsValidProviderName;
         if(!ds.IsValidStagePathDir)
         {
            try
            {
               System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(ds.StagePathDir);
               di.Create();
               bool isValidStagePathDir = ds.IsValidStagePathDir;
            } catch(System.IO.DirectoryNotFoundException ex)
            {
               // do something with this error!...
            }
         }
         if(string.IsNullOrWhiteSpace(ds.ConnectionString))
         {
            // error...
         }
      }
   }
}
