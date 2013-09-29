﻿using System.IO;
using System.Threading;

namespace PluginVK
{
    class Get
    {
        public static void GetOnlineMessage(string token, string id)
        {
            string text1 = null;
            string text2 = null;
            string text3 = null;

            #region Friends
            Thread t1 = new Thread(delegate() 
                {
                    Friends fr = new Friends();
                    fr.token = token;
                    fr.id = id;
                    fr.path = Constants.path_onlineusers;
                    fr.count = Constants.count;
                    text1 = fr.ConvertFriendsOnline();
                });
            t1.Start();
            #endregion

            #region Messages
            Thread t2 = new Thread(delegate()
            {
                Messages ms = new Messages();
                ms.token = token;
                ms.id = id;
                text2 = ms.UnReadedMessages();
            });
            t2.Start();
            #endregion

            t1.Join();
            t2.Join();

            string text = text1 + text2 + "&";

            if (text1 == null || text2 == null)
            {
                OAuth.OAuthRun();
            }

            using (StreamWriter outfile = new StreamWriter(Constants.path_onlineusers))
            {
                outfile.Write(text);
            }
        }
    }
}