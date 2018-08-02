using DataPhilosophiae.Config;
using System;
using System.Linq;
using System.Xml.Linq;

namespace TestConfig
{
   internal class Program
   {
      private static void Main(string[ ] args)
      {
         DateTime date = DateTime.ParseExact("20180101T235959,0000001+10:00", "yyyyMMddTHHmmss,fffffffzzz", System.Globalization.CultureInfo.InvariantCulture);
         string str = date.ToString( "yyyyMMddTHHmmss,fffffffzzz" );

         XDocument cfgSample = AppConfig.Sample();
         string element = cfgSample.ToString();
         AppConfig appCfg = AppConfig.Deserialize(cfgSample);
         XDocument serialize = appCfg.Serialize();
         return;
      }
   }
}
