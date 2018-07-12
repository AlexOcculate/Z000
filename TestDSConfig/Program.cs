using DataPhilosophiae.Config.Model;
using System;
using System.Linq;
using System.Xml.Linq;

namespace TestDSConfig
{
   internal class Program
   {
      private static void Main(string[ ] args)
      {
         XDocument dsCfgSample = DataStoreConfig.DsCfgSample();
         string element = dsCfgSample.ToString();
         DataStoreConfig dsCfg = DataStoreConfig.Deserialize( dsCfgSample );
         XDocument serialize = dsCfg.Serialize( );
         return;
      }
   }
}
