using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;

namespace DataPhilosophiae
{
   public partial class MessageXuc : XtraUserControl
   {
      #region --- CONSTANTS, FIELDS, ENUMS, ... ---
      public const string DATASETNAME = "Message";
      public const string INFO_TABLENAME = "Info";
      public const string WARN_TABLENAME = "Warn";
      public const string ERROR_TABLENAME = "Error";
      public const string TIMESTAMP_COLUMNNAME = "Timestamp";
      public const string TYPE_COLUMNNAME = "Type";
      public const string CODE_COLUMNNAME = "Code";
      public const string DESCRIPTION_COLUMNAME = "Description";
      public enum MessageType
      {
         Error = -90000,
         Info = 0,
         Warn = 90000,
      }
      public enum MessageCode
      {
         Error = MessageType.Error,
         OK = MessageType.Info,
         Warn = MessageType.Warn,
      }

      private DataSet ds = CreateDataSet( );
      #endregion

      public MessageXuc()
      {
         this.InitializeComponent( );
         this.gridControl1.DataSource = this.ds;
         this.gridControl1.DataMember = INFO_TABLENAME;
      }

      public void Info( string format, params object[ ] args )
      {
         this.Msg(MessageType.Info, MessageCode.OK, format, args);
      }

      public void Warn( string format, params object[ ] args )
      {
         this.Msg( MessageType.Warn, MessageCode.Warn, format, args );
      }
      public void Error( string format, params object[ ] args )
      {
         this.Msg( MessageType.Error, MessageCode.Error, format, args );
      }
      public void Msg( MessageType type, MessageCode code, string format, params object[ ] args )
      {
         DataTable t;
         switch( type )
         {
            default:
            case MessageType.Error:
               t = this.ds.Tables[INFO_TABLENAME];
               break;
            case MessageType.Info:
               t = this.ds.Tables[ INFO_TABLENAME ];
               break;
            case MessageType.Warn:
               t = this.ds.Tables[ INFO_TABLENAME ];
               break;
         }
         DataRow r = t.NewRow( );
         r[TIMESTAMP_COLUMNNAME] = DateTime.Now;
         r[ TYPE_COLUMNNAME ] = type;
         r[ CODE_COLUMNNAME ] = code;
         r[ DESCRIPTION_COLUMNAME ] = String.Format( format, args );
         t.Rows.Add( r );
      }

      private static DataSet CreateDataSet()
      {
         DataSet ds = new DataSet( DATASETNAME );
         {
            AddColumns( ds.Tables.Add( INFO_TABLENAME ) );
            AddColumns( ds.Tables.Add( WARN_TABLENAME ) );
            AddColumns( ds.Tables.Add( ERROR_TABLENAME ) );
         }
         return ds;
      }

      private static void AddColumns( DataTable t )
      {
         t.Columns.Add( TIMESTAMP_COLUMNNAME, typeof( DateTime ) );
         t.Columns.Add( TYPE_COLUMNNAME, typeof( MessageType ) );
         t.Columns.Add( CODE_COLUMNNAME, typeof( int ) );
         t.Columns.Add( DESCRIPTION_COLUMNAME, typeof( string ) );
      }
   }
}
