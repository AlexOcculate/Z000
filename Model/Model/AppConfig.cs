﻿using DataPhilosophiae.Config.Model;
using DataPhilosophiae.Delegates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

      public BindingList<RecentlyOpenedFile> RecentlyOpenedFileList
      {
         get;
         set;
      }

      public void AddRecentlyOpenedFile(string fqn)
      {
         //foreach( RecentlyOpenedFile rof in this.RecentlyOpenedFileList )
         //{
         //   if( string.Compare( rof.FullQualifiedName( ), fqn, StringComparison.Ordinal ) == 0 )
         //   {
         //      rof.Timestamp = DateTime.Now;
         //      return;
         //   }
         //}
         RecentlyOpenedFile newRof = new RecentlyOpenedFile();
         newRof.Name = System.IO.Path.GetFileName(fqn);
         newRof.Path = System.IO.Path.GetDirectoryName(fqn);
         newRof.Available = true;
         newRof.Enabled = true;
         newRof.Timestamp = DateTime.Now;
         this.RecentlyOpenedFileList.Add(newRof);
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
                           new XAttribute(FnmAttrNm, @"filename01_With_a_Very_long_name.ext"),
                           new XAttribute(PnmAttrNm, @"E:\VS10_PROJECTS\Awesomium.NET\1.6.6\Samples\Windows Forms\CSharp\WinFormsSample\Properties"),
                           new XAttribute(PinAttrNm, "true")),
                        new XElement(RofElemNm,
                           new XAttribute(TsAttrNm, "20180101T235959,0000001+10:00"),
                           new XAttribute(FnmAttrNm, @"filename02.ext"),
                           new XAttribute(PnmAttrNm, @"D:\TEMP\CS"),
                           new XAttribute(PinAttrNm, "true")),
                        new XElement(RofElemNm,
                           new XAttribute(TsAttrNm, "20170101T235959,0000001+10:00"),
                           new XAttribute(FnmAttrNm, @"filename03.ext"),
                           new XAttribute(PnmAttrNm, @"D:\TEMP\CS"),
                           new XAttribute(PinAttrNm, "false")),
                        new XElement(RofElemNm,
                           new XAttribute(TsAttrNm, "20180102T235959,0000001+10:00"),
                           new XAttribute(FnmAttrNm, @"filename04.ext"),
                           new XAttribute(PnmAttrNm, @"D:\TEMP\CS"),
                           new XAttribute(PinAttrNm, "true")),
                        new XElement(RofElemNm,
                           new XAttribute(TsAttrNm, "20180102T235959,0000001+10:00"),
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
                           new XAttribute(TsAttrNm, "20180802T235959,0000001+10:00"),
                           new XAttribute(FnmAttrNm, @"filename09.ext"),
                           new XAttribute(PnmAttrNm, @"D:\TEMP\CS")))));
         return doc;
      }

      public XDocument Serialize()
      {
         XElement coll = new XElement(RofCollElemNm);
         foreach(RecentlyOpenedFile rof in this.RecentlyOpenedFileList)
         {
            XElement rofElem = new XElement(RofElemNm);
            if(rof.Timestamp != DateTime.MinValue)
            {
               rofElem.Add(new XAttribute(TsAttrNm, rof.Timestamp.ToString(TIMESTAMP_FORMATSTR)));
            }
            rofElem.Add(new XAttribute(FnmAttrNm, rof.Name),
                         new XAttribute(PnmAttrNm, rof.Path),
                         new XAttribute(PinAttrNm, rof.Pinned));
            coll.Add(rofElem);
         }
         XDocument doc =
                  new XDocument(
                     new XDeclaration("1.0", "utf-8", "yes"),
                     new XComment("Application Configuration..."),
                        //new XProcessingInstruction("MyApp", "123-44-4444"),
                        new XElement(AppCfgElemNm, coll));
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
            string ts = (rofElem.Attribute(TsAttrNm)?.Value);
            if(ts != null)
            {
               DateTime date = DateTime.ParseExact(ts, TIMESTAMP_FORMATSTR, System.Globalization.CultureInfo.InvariantCulture);
               rof.Timestamp = date;
            } else
            {
               rof.Timestamp = DateTime.MinValue;
            }
            rof.Name = Path.GetFileName((rofElem.Attribute(FnmAttrNm)?.Value));
            rof.Path = (rofElem.Attribute(PnmAttrNm)?.Value);
            rof.Pinned = GetBooleanAttribute((rofElem.Attribute(PinAttrNm)?.Value), false);
            if(File.Exists(rof.FullQualifiedName()))
            {
               rof.Available = true;
               rof.Enabled = true;
            } else
            {
               rof.Available = false;
               rof.Enabled = false;
            }
            //
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

      public static AppConfig Load(string filename)
      {
         if(!File.Exists(filename))
         {
            Error?.Invoke($"File {filename} does not exist!");
            return null;
         }

         try
         {
            XDocument doc = XDocument.Load(filename, LoadOptions.None);
            AppConfig o = AppConfig.Deserialize(doc);
            if(o != null)
            {
               Info?.Invoke($"File '{filename}' loaded!");
               return o;
            }
            Error?.Invoke($"Load error @ '{filename}'!");
            return null;
         } catch(Exception ex)
         {
            Error?.Invoke($"Load exceptions @ '{filename}'!");
            Error?.Invoke(ex.Message);
            Error?.Invoke(ex.StackTrace);
            return null;
         }
      }

      public void Save(string filename)
      {
         XDocument doc = this.Serialize();
         try
         {
            doc.Save(filename);
            Info?.Invoke($"File {filename} saved!");
         } catch(Exception ex)
         {
            Error?.Invoke($"File {filename} exception!");
            Error?.Invoke(ex.Message);
            Error?.Invoke(ex.StackTrace);
            return;
         }
      }
      #endregion
   }
}
