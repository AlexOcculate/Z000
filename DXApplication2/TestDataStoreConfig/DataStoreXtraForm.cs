using DataPhilosophiae.Config.Model;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TestDataStoreConfig
{
   public partial class DataStoreXtraForm : DevExpress.XtraEditors.XtraForm
   {
      public DataStoreXtraForm()
      {
         this.InitializeComponent();
      }

      private static XDocument dsCfgSample = DataStoreConfig.DsCfgSample( );
      private static DataStoreConfig dsCfg = DataStoreConfig.Deserialize( dsCfgSample );

      private void DataStoreXtraForm_Load(object sender, EventArgs e)
      {
         BindingSource dsBindingSource = new BindingSource();
         dsBindingSource.DataSource = dsCfg.DataStoreList[0];
        // dsBindingSource.AddNew();

         this.dataLayoutControl1.AutoRetrieveFields = true;
         this.dataLayoutControl1.DataSource = dsBindingSource;
      }
   }
}