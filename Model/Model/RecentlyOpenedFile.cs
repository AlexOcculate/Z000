using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DataPhilosophiae.Config.Model
{
   public class RecentlyOpenedFile
   {
      public override string ToString()
      {
         return $"{this.Pinned} {this.Name}";
      }

      public const string Timestamp_FldName = "Timestamp";
      public const string Timestamp_ColName = "Timestamp";
      [Display( Name = Timestamp_ColName, Description = "Last Opening Timestamp" )]
      [Required]
      public DateTime Timestamp
      {
         get; set;
      }

      public const string Name_FldName = "Name";
      public const string Name_ColName = "Name";
      [Display( Name = Name_ColName, Description = "Unique File Name" )]
      [Required( AllowEmptyStrings = false )]
      public string Name
      {
         get ; set;
      }

      public const string Path_FldName = "Path";
      public const string Path_ColName = "Path";
      [Display( Name = Path_ColName, Description = "Path Name" )]
      [Required( AllowEmptyStrings = false )]
      public string Path
      {
         get; set;
      }

      public const string Pinned_FldName = "Pinned";
      public const string Pinned_ColName = "Pinned";
      [Display( Name = Pinned_ColName, Description = "Is it pinned?" )]
      public bool Pinned
      {
         get; set;
      }

      public const string Enabled_FldName = "Enable";
      public const string Enabled_ColName = "Enable";
      [Display( Name = Enabled_ColName, Description = "Is it enabled?" )]
      public bool Enabled
      {
         get ;set ;
      }

      private Random rnd = new Random( );
      public const string Available_FldName = "Available";
      public const string Available_ColName = "Available";
      [Display( Name = Available_ColName, Description = "Does it exist and is available?" )]
      public bool Available
      {
         get ; set;
      }

      public string FullQualifiedName()
      {
         return System.IO.Path.Combine(this.Path, this.Name);
      }
   }
}
