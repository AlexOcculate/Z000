using System;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace DataPhilosophiae
{
   public partial class OpenRecentXuc : DevExpress.XtraEditors.XtraUserControl
   {
      public OpenRecentXuc()
      {
         this.InitializeComponent();
         {
            BindingList<MyRecord> list = new BindingList<MyRecord>();
            list.Add(new MyRecord(0, Path.Combine(Path.GetTempPath(), Path.GetTempFileName())));
            list.Add(new MyRecord(0, Path.Combine(Path.GetTempPath(), Path.GetTempFileName())));
            list.Add(new MyRecord(0, Path.Combine(Path.GetTempPath(), Path.GetTempFileName())));
            list.Add(new MyRecord(0, Path.Combine(Path.GetTempPath(), Path.GetTempFileName())));
            this.gridControl1.DataSource = list;
         }
      }
   }

   public class MyRecord
   {
      public int ID
      {
         get;
         set;
      }

      public string Filename
      {
         get;
         set;
      }

      public bool Pinned
      {
         get;
         set;
      }

      public string Preview
      {
         get;
         set;
      }

      public MyRecord(int icon, string filename, bool pinned = false)
      {
         this.ID = icon;
         this.Filename = Path.GetFileName(filename);
         this.Preview = Path.GetDirectoryName(filename);
         this.Pinned = pinned;
      }
   }
}
