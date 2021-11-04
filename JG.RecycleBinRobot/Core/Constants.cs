using System;
using System.Configuration;

namespace JG.RecycleBinRobot.Core
{
    internal class Constants
    {
        public static string SERVICE_NAME = ConfigurationManager.AppSettings["SERVICE_NAME"]; 
        public static string SERVICE_DISPLAY_NAME = ConfigurationManager.AppSettings["SERVICE_DISPLAY_NAME"];
        public static string SERVICE_DESCRIPTION = ConfigurationManager.AppSettings["SERVICE_DESCRIPTION"];
        public static int MINUTES = Convert.ToInt32(ConfigurationManager.AppSettings["MINUTES"]);
        public static DateTime TIME_TO_START = ConfigurationManager.AppSettings["TIME_TO_START"] == null ? DateTime.MinValue : Convert.ToDateTime(ConfigurationManager.AppSettings["TIME_TO_START"]);
        public static DateTime TIME_TO_END = ConfigurationManager.AppSettings["TIME_TO_END"] == null ? DateTime.MaxValue : Convert.ToDateTime(ConfigurationManager.AppSettings["TIME_TO_END"]);

        internal enum RecycleFlag : int
        {
            SHERB_NOCONFIRMATION = 0x00000001, // No confirmation, when emptying
            SHERB_NOPROGRESSUI = 0x00000001, // No progress tracking window during the emptying of the recycle bin
            SHERB_NOSOUND = 0x00000004 // No sound when the emptying of the recycle bin is complete
        }
    }
}
