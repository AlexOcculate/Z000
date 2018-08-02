﻿using DataPhilosophiae.Config.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;

namespace DataPhilosophiae.Config
{
   public class AppConfig
   {
      public static event InfoMessageDelegate Info;

      public static event WarnMessageDelegate Warn;

      public static event ErrorMessageDelegate Error;

      public AppConfig()
      {
         this.RecentlyOpenedFileList = new BindingList<RecentlyOpenedFile>();
      }

      public IList<RecentlyOpenedFile> RecentlyOpenedFileList
      {
         get;
         set;
      }

      #region --- De/Serialize + Sample ---
      public const string AppCfgElemNm = "appCfg";
      public const string RofCollElemNm = "rofColl"; // Recent Open Files
      public const string RofElemNm = "rof";         // Recent Open File
      public const string PinAttrNm = "pin";           // Pinned File?
      public const string TsAttrNm = "ts";           // Timestamp YYYYMMDD-HH24MISS,FFFFFF[+-]HHMM
      public const string FnmAttrNm = "fnm";         // File Name
      public const string PnmAttrNm = "pnm";         // Path Name


      public const string TIMESTAMP_FORMATSTR = "yyyyMMddTHHmmss,fffffffzzz";

      public static XDocument Sample()
      {
         XDocument doc =
            new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),
               new XComment("Application Configuration..."),
                  //new XProcessingInstruction("MyApp", "123-44-4444"),
                  new XElement(AppCfgElemNm,
                     new XElement(RofCollElemNm,
                        new XElement(RofElemNm,
                           new XAttribute(TsAttrNm, "20180101T235959,0000001+10:00"),
                           new XAttribute(FnmAttrNm, @"filename01.ext"),
                           new XAttribute(PnmAttrNm, @"D:\TEMP\CS"),
                           new XAttribute(PinAttrNm, "true")),
                        new XElement(RofElemNm,
                           new XAttribute(TsAttrNm, "20180101T235959,0000001+10:00"),
                           new XAttribute(FnmAttrNm, @"filename02.ext"),
                           new XAttribute(PnmAttrNm, @"D:\TEMP\CS"),
                           new XAttribute(PinAttrNm, "true")),
                        new XElement(RofElemNm,
                           new XAttribute(TsAttrNm, "20180101T235959,0000001+10:00"),
                           new XAttribute(FnmAttrNm, @"filename03.ext"),
                           new XAttribute(PnmAttrNm, @"D:\TEMP\CS"),
                           new XAttribute(PinAttrNm, "false")),
                        new XElement(RofElemNm,
                           new XAttribute(TsAttrNm, "20180101T235959,0000001+10:00"),
                           new XAttribute(FnmAttrNm, @"filename04.ext"),
                           new XAttribute(PnmAttrNm, @"D:\TEMP\CS"),
                           new XAttribute(PinAttrNm, "true")),
                        new XElement(RofElemNm,
                           new XAttribute(TsAttrNm, "20180101T235959,0000001+10:00"),
                           new XAttribute(FnmAttrNm, @"filename05.ext"),
                           new XAttribute(PnmAttrNm, @"D:\TEMP\CS"),
                           new XAttribute(PinAttrNm, "false")),
                        new XElement(RofElemNm,
                           new XAttribute(TsAttrNm, "20180101T235959,0000001+10:00"),
                           new XAttribute(FnmAttrNm, @"filename06.ext"),
                           new XAttribute(PnmAttrNm, @"D:\TEMP\CS"),
                           new XAttribute(PinAttrNm, "false")),
                        new XElement(RofElemNm,
                           new XAttribute(TsAttrNm, "20180101T235959,0000001+10:00"),
                           new XAttribute(FnmAttrNm, @"filename07.ext"),
                           new XAttribute(PnmAttrNm, @"D:\TEMP\CS"),
                           new XAttribute(PinAttrNm, "false")),
                        new XElement(RofElemNm,
                           new XAttribute(TsAttrNm, "20180101T235959,0000001+10:00"),
                           new XAttribute(FnmAttrNm, @"filename08.ext"),
                           new XAttribute(PnmAttrNm, @"D:\TEMP\CS"),
                           new XAttribute(PinAttrNm, "false")),
                        new XElement(RofElemNm,
                           new XAttribute(TsAttrNm, "20180101T235959,0000001+10:00"),
                           new XAttribute(FnmAttrNm, @"filename09.ext"),
                           new XAttribute(PnmAttrNm, @"D:\TEMP\CS")))));
         return doc;
      }

      public XDocument Serialize()
      {
         XDocument doc =
            new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),
               new XComment("Application Configuration...")
                  //new XElement( DsCfgElemNm,
                  //   new XElement(
                  //      StgDirElemNm,
                  //      new XCData( this.DefaultStgDirVal ) // Default StagePathDir
                  //   ),
                  //   dsColl
                  //)
                              //new XProcessingInstruction("MyApp", "123-44-4444"),
                  //new XElement( DsCfgElemNm,
                  //   new XElement(
                  //      StgDirElemNm,
                  //      new XCData( this.DefaultStgDirVal ) // Default StagePathDir
                  //   ),
                  //   dsColl
                  //)
            );
         return doc;
      }

      public static AppConfig Deserialize(XDocument doc)
      {
         #region --- Calling Contract... ---
         if(doc == null)
         {
            Error?.Invoke("Document is null!");
            return null;
         }
         //
         XElement rootElem = doc.Element(AppCfgElemNm);
         if(rootElem == null)
         {
            Error?.Invoke($"Document does not contains a <{AppCfgElemNm}> element!");
            return null;
         }
         #endregion
         //
         AppConfig cfg = new AppConfig();
         // List of Recently Opened Files...
         XElement rofCollElem = rootElem.Element(RofCollElemNm);
         if(rofCollElem == null)
         {
            Info?.Invoke($"There is no DataStore configuration: <{RofCollElemNm}> element!");
            return cfg;
         }
         //
         IEnumerable<XElement> rofElemList = rofCollElem.Elements(RofElemNm);
         foreach(XElement rofElem in rofElemList)
         {
            RecentlyOpenedFile rof = new RecentlyOpenedFile();
            string ts = (rofElem.Attribute( TsAttrNm )?.Value);
            if(ts != null)
            {
               DateTime date = DateTime.ParseExact(ts, TIMESTAMP_FORMATSTR, System.Globalization.CultureInfo.InvariantCulture);
               rof.Timestamp = date;
            }
            rof.Name = (rofElem.Attribute(FnmAttrNm)?.Value);
            rof.Path = (rofElem.Attribute( PnmAttrNm )?.Value);
            rof.Pinned = GetBooleanAttribute((rofElem.Attribute(PinAttrNm)?.Value), false);
            cfg.RecentlyOpenedFileList.Add(rof);
         }
         //
         return cfg;
      }

      private static bool GetBooleanAttribute(string boolStrVal, bool defaultValue)
      {
         if(boolStrVal != null)
         {
            bool.TryParse(boolStrVal, out defaultValue);
         }

         return defaultValue;
      }
      #endregion
   }
}