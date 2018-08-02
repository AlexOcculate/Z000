using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using DataPhilosophiae.Config.Model;
using FrontEnd.ConfigurationSetting;
using Microsoft.Win32;

namespace ConfigFilesHeadStart
{
   public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
   {
      public Form1()
      {
         LoadConfiguration( );
         InitializeComponent( );
      }

      private static void LoadConfiguration()
      {
         //
         // [Configuration files] are used to control and manage the behavior of a [desktop and web application].
         //
         //    [Machine.config] : [machine level configuration file]
         //    This is automatically installed when you install Visual Studio.Net. Only one [Machine.config] file exists on
         //    a server. This file is at the highest level in the configuration hierarchy.
         //
         //    [App.config] : [application level configuration file]
         //    This is automatically created when you create a [Desktop application] project. This file inherits setting
         //    from the [Machine.config]
         //
         //    [Web.config] : [web application level configuration file]
         //    This is automatically created when you create an [ASP.Net web application] project. This file inherits setting
         //    from the [Machine.config]
         //
         //    Difference between [(App|Web).config] and [Machine.config]:
         //
         //    The settings made in the [(App|Web).config] file are applied to that particular desktop/web application only,
         //    whereas the settings of [Machine.config] file are applied to the ALL Desktop or whole ASP.net application.
         //
         //    [(App|Web).config] file are settings of desktop/asp.net application project level. [Machine.config] are settings
         //    of server level.
         //
         //    [(App|Web).config] will be for that particular desktop/web application whereas the [Machine.config] will for
         //    the whole machine.
         //
         //    Every Desktop/ASP.NET application that you has a [(App|Web).config] file . The settings specified in this will
         //    imply only to that application. Whereas "Your System" will have a [Machine.config] file in folder:
         //    [[ Microsoft.NET\Framework\v1.1.4322\CONFIG ]]
         //    which contains specifications and settings at a system level.
         //
         //    [Web.config] file is to override the settings from the [Machine.config] file. [Machine.config] file settings are
         //    applied to all the web applications residing on the server while [Web.config] settings are application specific.
         //
         //    [Machine.config] is configuration file for all the application in the IIS. but [Web.config] is a configuration
         //    file for a application or folder.
         //
         //    [Machine.config] for machine level configuration.but [Web.config] for a application/folder level configuration.
         //
         // Add reference to : System.Configuration and System.ComponentModel.DataAnnotations
         //
         {
            // #1 WAY (App.config + Machine.config)
            System.Configuration.ConnectionStringSettingsCollection css = System.Configuration.ConfigurationManager.ConnectionStrings;
         }
         {
            // #2 WAY (App.config + Machine.config)
            string str = System.Configuration.ConfigurationManager.AppSettings[ "UrlToPing" ].ToString( );
         }
         {
            // #3 WAY (App.config + Machine.config)
            DataPhilosophiaeSection dps = System.Configuration.ConfigurationManager.GetSection( nameof( DataPhilosophiaeSection ) ) as DataPhilosophiaeSection;
         }
         {
            // #4 WAY (Proprietary File)
            string configFilePath = @"D:\TEMP\CS\";
            string configFileName = @"dsConfig.xml";
            string configFileFullPathName = Path.Combine(configFilePath,configFileName);;
            {
               XDocument dsCfgSample = DataStoreConfig.Sample( );
               dsCfgSample.Save(configFileFullPathName, SaveOptions.None);
            }
            XDocument xDoc = XDocument.Load( configFileFullPathName, LoadOptions.None );
            DataStoreConfig dsCfg = DataStoreConfig.Deserialize( xDoc );
         }
         {
            //RegistryKey key = Registry.LocalMachine.OpenSubKey( "Software", true );
            //RegistryKey key = Registry.CurrentUser.OpenSubKey( "Software", true );

            //key.CreateSubKey( "AppName" );
            //key = key.OpenSubKey( "AppName", true );


            //key.CreateSubKey( "AppVersion" );
            //key = key.OpenSubKey( "AppVersion", true );

            //key.SetValue( "yourkey", "yourvalue" );
         }
      }

      private void colorMixerBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         DevExpress.XtraEditors.ColorWheel.ColorWheelForm cwForm = new DevExpress.XtraEditors.ColorWheel.ColorWheelForm( );
         cwForm.Show( );
      }

      private void Form1_Load( object sender, EventArgs e )
      {
         // WinForms Controls > Build an Application > Skins
         //
         // To register bonus skins in code, first ensure that your project references the DevExpress.BonusSkins
         // assembly. Then call the DevExpress.UserSkins.BonusSkins.Register method before the main application
         // form runs.
         //
         // private static void Main()
         // {
         //   DevExpress.UserSkins.BonusSkins.Register( );
         //   DevExpress.Skins.SkinManager.EnableFormSkins( );
         //   //
         //   Application.EnableVisualStyles( );
         //   Application.SetCompatibleTextRenderingDefault( false );
         //   Application.Run( new Form1( ) );
         // }

         //TODO: App.Config!!!
         string skinStyle = "The Bezier";
         //string skinStyle = "Visual Studio 2013 Blue";
         //string skinStyle = "Metropolis Dark";
         //string skinStyle = "Office 2016 Colorful";
         //stringt skinStyle = "Visual Studio 2013 Blue";
         //foreach( SkinContainer cnt in SkinManager.Default.Skins )
         //{
         //   //( cnt.SkinName );
         //}
         DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle( skinStyle );
         //
         //for( int i = 0; i < this.skinMenuBarSubItem.ItemLinks.Count; i++ )
         //{
         //   if( this.skinMenuBarSubItem.ItemLinks[ i ].Caption == "The Bezier" )
         //   {
         //      BarButtonItem parentItem = (BarButtonItem) this.skinMenuBarSubItem.ItemLinks[ i ].Item;
         //      parentItem.Caption = "Default Skin";
         //      parentItem.ImageUri.Uri = "Apply";
         //   }
         //}
         //
         //TODO: this should come from a config file, e.g. App.config...
         //this.openRecentBarListItem.MaxSubItemTextWidth = 200;
         //this.openRecentBarListItem.ShowNumbers = true;
         //this.openRecentBarListItem.Strings.Add( "Item1" );
         //this.openRecentBarListItem.Strings.Add( "Item2" );
         //this.openRecentBarListItem.Strings.Add( "Item3" );

      }
   }
}
