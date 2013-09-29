using System;
using System.Xml;

namespace PluginVK
{
    public class Messages
    {
        public string token { get; set; }
        public string id { get; set; }

        public string UnReadedMessages()
        {
            // Параметры.
            string method = "messages.get.xml?";
            string param = "&filters=1";

            XmlDocument doc = new XmlDocument();
            doc.Load("https://api.vk.com/method/" + method + param + "&access_token=" + token);

            XmlNode root = doc.DocumentElement;

            #region ErrorCheck
            XmlNodeList nodeListError;
            nodeListError = root.SelectNodes("error_code"); // Для выявления ошибочного запроса.

            // Выявление ошибочного запрса.
            string sucheck = "";
            string sucheckerror = "<error_code>5</error_code>";
            string sucheckerror2 = "<error_code>7</error_code>";

            foreach (XmlNode node in nodeListError)
            {
                sucheck = node.OuterXml;
            }

            if (sucheck == sucheckerror)
            {
                return null;
            }

            if (sucheck == sucheckerror2)
            {
                return null;
            }
            #endregion

            string countstring = "0";

            try
            {
                countstring = root["count"].InnerText;
            }
            catch { }

            int i = Convert.ToInt32(countstring);
            if (i > 1)
            {
                i = 1;
            }

            countstring = Convert.ToString(i);

            return countstring;
        }

    }
}
