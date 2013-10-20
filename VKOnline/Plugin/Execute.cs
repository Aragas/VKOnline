using Rainmeter.Forms;

namespace Rainmeter.Plugin
{
    public static class Execute
    {
        private static bool TokenIdExists
        {
            get { return (OAuth.Token != null || OAuth.Id != null); }
        }

        public static void Start(string command)
        {
            if (!TokenIdExists)
            {
                OAuth.OAuthRun();
                //Info.Execute(command);
            }
            else
            {
                //Info.Execute(command);
            }
        }
    }
}

