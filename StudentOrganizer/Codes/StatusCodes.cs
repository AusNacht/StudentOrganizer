
using System.Collections.Generic;
namespace StudentOrganizer.Codes { 
    static class Status
    {
        public static readonly string ACTIVE = "Active";
        public static readonly string INACTIVE = "Inactive";
        public static readonly string HOLD = "Hold";

        public static readonly List<string> STATUS_OPTIONS = new List<string>(new string[] { ACTIVE, INACTIVE, HOLD });
    }
}