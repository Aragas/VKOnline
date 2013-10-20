using System;

namespace Rainmeter.Plugin
{
    /// <summary>
    /// Contains various constants used by project.
	/// </summary>
	internal static class Constants
	{
		#region Content
        public static string OnlineusersName = "OnlineUsers.tmp";
        public static string Dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Rainmeter\Plugins\VKPlugin\";
        public static string OnlineusersPath = Dir + OnlineusersName;
        public static int Count = 5;
		#endregion

	}
}
