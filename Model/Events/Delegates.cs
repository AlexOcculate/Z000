using System;
using System.Linq;

namespace DataPhilosophiae.Delegates
{
   public delegate void InfoMessageDelegate(string msg);
   public delegate void WarnMessageDelegate(string msg);
   public delegate void ErrorMessageDelegate(string msg);
   //
   public delegate void ReOpenFileDelegate(string filename, string pathname);
}
