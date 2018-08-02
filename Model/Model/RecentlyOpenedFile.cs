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

   }
}
