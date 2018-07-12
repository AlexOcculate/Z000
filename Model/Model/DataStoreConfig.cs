using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace DataPhilosophiae.Config.Model
{
   public delegate void InfoMessageDelegate( string msg );

   public class DataStoreConfig
   {
      public static event InfoMessageDelegate Info;

      public DataStoreConfig()
      {
         this.DataStoreList = new BindingList<DataStore>( );
      }

      public override string ToString()
      {
         return this.DataStoreList.Count.ToString( );
      }

      public string DefaultStgDirVal
      {
         get; set;
      }

      public IList<DataStore> DataStoreList
      {
         get; set;
      }

      #region --- De/Serialize + Sample ---
      public const string DsCfgElemNm = "dsCfg";
      public const string StgDirElemNm = "stgDir";
      public const string DsCollElemNm = "dsColl";
      public const string DsElemNm = "ds";
      public const string ActvAttrNm = "actv";
      public const string NmAttrNm = "nm";
      public const string LddoAttrNm = "lddo";
      public const string LsoAttrNm = "lso";
      public const string WfAttrNm = "wf";
      public const string CsElemNm = "cs";
      public const string PnAttrNm = "pn";
      public const string ConnStrElemNm = "str";

      public static XDocument DsCfgSample()
      {
         XDocument doc =
            new XDocument(
               new XDeclaration( "1.0", "utf-8", "yes" ),
               new XComment( "DataStore Configuration..." ),
                  //new XProcessingInstruction("MyApp", "123-44-4444"),
                  new XElement( DsCfgElemNm,
                     new XElement(
                        StgDirElemNm,
                        new XCData( "default/stage/dir" ) // Default StagePathDir
                     ),
                     new XElement( DsCollElemNm,
                        new XElement( DsElemNm,
                           new XAttribute( NmAttrNm, "Production" ),
                           new XAttribute( ActvAttrNm, false ),
                           new XAttribute( LddoAttrNm, true ), // LoadDefaultDatabaseOnly
                           new XAttribute( LsoAttrNm, true ),  // LoadSystemObjects
                           new XAttribute( WfAttrNm, true ),   // WithFields
                           new XElement(
                              StgDirElemNm,                    // Local StagePathDir
                              new XCData( "stage/dir/" + "Production" )
                           ),
                           new XElement( CsElemNm,
                              new XAttribute( PnAttrNm, "System.Data.SqlClient" ),  // DataStore's Provider Name
                              new XElement(
                                 ConnStrElemNm,                  // DataStore's Connection String
                                 new XCData( @"D:\TEMP\SQLite\chinook\chinook.db" )
                              )
                           )
                        ),
                        new XElement( DsElemNm,
                           new XAttribute( NmAttrNm, "Development" ),
                           new XAttribute( ActvAttrNm, false ),
                           new XAttribute( LddoAttrNm, true ), // LoadDefaultDatabaseOnly
                           new XAttribute( LsoAttrNm, true ),  // LoadSystemObjects
                           new XAttribute( WfAttrNm, true ),   // WithFields
                           new XElement(
                              StgDirElemNm,                    // Local StagePathDir
                              new XCData( "default/stage/dir"/*"stage/dir/" + "Development"*/)
                           ),
                           new XElement( CsElemNm,
                              new XAttribute( PnAttrNm, "System.Data.SqlClient" ),  // DataStore's Provider Name
                              new XElement(
                                 ConnStrElemNm,                  // DataStore's Connection String
                                 new XCData( @"D:\TEMP\SQLite\chinook\chinook.db" )
                              )
                           )
                        )
                     )
                  )
            );
         return doc;
      }

      public XDocument Serialize()
      {
         XElement dsColl = new XElement( DsCollElemNm );
         foreach( DataStore ds in this.DataStoreList )
         {
            XElement dsElem = new XElement( DsElemNm,
               new XAttribute( NmAttrNm, ds.Name ),
               new XAttribute( ActvAttrNm, ds.Active ),
               new XAttribute( LddoAttrNm, ds.LoadDefaultDatabaseOnly ),
               new XAttribute( LsoAttrNm, ds.LoadSystemObjects ),
               new XAttribute( WfAttrNm, ds.LoadWithFields ),
               new XElement( StgDirElemNm,
                             ds.StagePathDir == this.DefaultStgDirVal
               ? null
               : new XCData( ds.StagePathDir )
               ),
               new XElement( CsElemNm,
                  new XAttribute( PnAttrNm, ds.ProviderName ),
                  new XElement( ConnStrElemNm, new XCData( ds.ConnectionString ) )
               )
            );
            dsColl.Add( dsElem );
         }
         XDocument doc =
            new XDocument(
               new XDeclaration( "1.0", "utf-8", "yes" ),
               new XComment( "DataStore Configuration..." ),
                  //new XProcessingInstruction("MyApp", "123-44-4444"),
                  new XElement( DsCfgElemNm,
                     new XElement(
                        StgDirElemNm,
                        new XCData( this.DefaultStgDirVal ) // Default StagePathDir
                     ),
                     dsColl
                  )
            );
         return doc;
      }

      public static DataStoreConfig Deserialize( XDocument doc )
      {
         #region --- Calling Contract... ---
         if( doc == null )
         {
            Info?.Invoke( "Document is null!" );
            return null;
         }
         //
         XElement dsCfgElem = doc.Element( DsCfgElemNm );
         if( dsCfgElem == null )
         {
            Info?.Invoke( $"Document does not contains a <{DsCfgElemNm}> element!" );
            return null;
         }
         #endregion
         //
         DataStoreConfig dsConfig = new DataStoreConfig( );
         // Default StagePathDir
         dsConfig.DefaultStgDirVal = (dsCfgElem.Element( StgDirElemNm )?.Value);
         if( string.IsNullOrWhiteSpace( dsConfig.DefaultStgDirVal ) )
         {
            Info?.Invoke( $"Document does not contains a <{StgDirElemNm}> element!" );
         }
         // List of DataStores...
         XElement dsCollElem = dsCfgElem.Element( DsCollElemNm );
         if( dsCollElem == null )
         {
            Info?.Invoke( $"There is no DataStore configuration: <{DsCollElemNm}> element!" );
            return dsConfig;
         }
         //
         IEnumerable<XElement> dsElemList = dsCollElem.Elements( DsElemNm );
         foreach( XElement dsElem in dsElemList )
         {
            DataStore ds = new DataStore( );
            ds.Name = (dsElem.Attribute( NmAttrNm )?.Value);
            ds.Active = GetBooleanAttribute( (dsElem.Attribute( ActvAttrNm )?.Value), false );
            ds.LoadDefaultDatabaseOnly = GetBooleanAttribute( (dsElem.Attribute( LddoAttrNm )?.Value), false );
            ds.LoadSystemObjects = GetBooleanAttribute( (dsElem.Attribute( LsoAttrNm )?.Value), false );
            ds.LoadWithFields = GetBooleanAttribute( (dsElem.Attribute( WfAttrNm )?.Value), false );
            ds.StagePathDir = (dsElem.Element( StgDirElemNm )?.Value);
            if( ds.StagePathDir == null )
            {
               ds.StagePathDir = dsConfig.DefaultStgDirVal;
            }
            //
            XElement csElem = dsElem.Element( CsElemNm );
            if( csElem == null )
            {
               dsConfig.DataStoreList.Add( ds );
               continue;
            }
            ds.ProviderName = (csElem.Attribute( PnAttrNm )?.Value);
            ds.ConnectionString = (csElem.Element( ConnStrElemNm )?.Value);
            dsConfig.DataStoreList.Add( ds );
         }
         if( dsConfig.DataStoreList.Count == 0 )
         {
            Info?.Invoke( $"There is no DataStore configuration: <{DsElemNm}> element!" );
         }
         //
         return dsConfig;
      }

      private static bool GetBooleanAttribute( string boolStrVal, bool defaultValue )
      {
         if( boolStrVal != null )
         {
            bool.TryParse( boolStrVal, out defaultValue );
         }

         return defaultValue;
      }

      public static DataStoreConfig Load( string filename )
      {
         if( !File.Exists( filename ) )
         {
            Info?.Invoke( $"File {filename} does not exist!" );
            return null;
         }

         try
         {
            XDocument doc = XDocument.Load( filename, LoadOptions.None );
            DataStoreConfig dsConfig = DataStoreConfig.Deserialize( doc );
            Info?.Invoke( $"File {filename} loaded!" );
            return dsConfig;
         }
         catch( Exception ex )
         {
            Info?.Invoke( $"File {filename} exception!" );
            Info?.Invoke( ex.Message );
            Info?.Invoke( ex.StackTrace );
            return null;
         }
      }

      public void Save( string filename )
      {
         XDocument doc = this.Serialize( );
         try
         {
            doc.Save( filename );
            Info?.Invoke( $"File {filename} saved!" );
         }
         catch( Exception ex )
         {
            Info?.Invoke( $"File {filename} exception!" );
            Info?.Invoke( ex.Message );
            Info?.Invoke( ex.StackTrace );
            return;
         }
      }
      #endregion
   }
}
