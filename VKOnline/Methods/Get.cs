using System;
using System.IO;
using System.Threading;
using Rainmeter.Forms;
using Rainmeter.Plugin;

namespace Rainmeter.Methods
{
    class Get
    {
        public static void GetOnlineMessage(string token, string id)
        {
            string text1 = null;
            string text2 = null;

            #region Friends
            Thread t1 = new Thread(delegate() 
                {
                    Friends fr = new Friends();
                    fr.Token = token;
                    fr.Id = id;
                    fr.Count = Constants.Count;
                    text1 = string.Join("&", fr.OnlineString());
                });
            t1.Start();
            #endregion

            #region Messages
            Thread t2 = new Thread(delegate()
            {
                Messages ms = new Messages();
                ms.Token = token;
                ms.Id = id;
                text2 = Convert.ToString(ms.UnReadMessages());
            });
            t2.Start();
            #endregion

            t1.Join();
            t2.Join();

            string text = text1 + "&" + text2 + "&";

            if (text1 == null || text2 == null)
            {
                OAuth.OAuthRun();
            }

            using (StreamWriter outfile = new StreamWriter(Constants.OnlineusersPath))
            {
                outfile.Write(text);
            }
        }
    }
}
