using System.IO;
using System.Text;

namespace PluginVK
{
    public static class Verification
    {
        private static string crypted_id = null;
        public static string Id = null;
        public static string Token = null;

        public static void Online()
        {
            if (Id == null || Token == null)
            {
                #region Dir
                // Проверка файла на существование.
                if (!Directory.Exists(Constants.dir))
                {
                    Directory.CreateDirectory(Constants.dir);
                }
                if (!File.Exists(Constants.path_data))
                {
                    using (FileStream stream = File.Create(Constants.path_data)) { }
                }
                #endregion

                // Чтение параметров.
                using (StreamReader sr = new StreamReader(Constants.path_data, Encoding.UTF8))
                {
                    crypted_id = sr.ReadLine();

                    if (crypted_id != null)
                    {
                        Crypto cr = new Crypto();
                        Id = cr.Decrypt(crypted_id, "ididitjustforlulz");
                        Token = cr.Decrypt(sr.ReadLine(), "ididitjustforlulz");
                    }
                }

                // Проверка существования данных.
                if (crypted_id == null)
                {
                    OAuth.OAuthRun();
                    Get.GetOnlineMessage(Token, Id);
                }
                else
                {
                    Get.GetOnlineMessage(Token, Id);
                }
            }

        }
    }
}

