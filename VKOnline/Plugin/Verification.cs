using Rainmeter.Forms;
using Rainmeter.Methods;

namespace Rainmeter.Plugin
{
    public static class Verification
    {
        private static bool TokenIdExists
        {
            get { return (OAuth.Token != null || OAuth.Id != null); }
        }

        public static void Online()
        {
            if (!TokenIdExists)
            {
                OAuth.OAuthRun();
                Get.GetOnlineMessage(OAuth.Token, OAuth.Id);
            }
            else
            {
                Get.GetOnlineMessage(OAuth.Token, OAuth.Id);
            }


        }
    }
}

