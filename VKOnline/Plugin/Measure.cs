using System;
using Rainmeter.API;
using Rainmeter.Information;

namespace Rainmeter.Plugin
{
    internal class Measure
    {
        public static int FriendsCount { get; private set; }
        private static int UserCount { get; set; }

        private InfoType _infoType;

        internal void Reload(RainmeterAPI rm, ref double maxValue)
        {
            FriendsCount = rm.ReadInt("FriendsCount", 1);
            UserCount = rm.ReadInt("UserType", 1);

            string type = rm.ReadString("InfoType", "");
            switch (type.ToLowerInvariant())
            {
                case "fname":
                    _infoType = InfoType.FName;
                    break;

                case "fphoto":
                    _infoType = InfoType.FPhoto;
                    break;

                case "fid":
                    _infoType = InfoType.FId;
                    break;

                case "fstatus":
                    _infoType = InfoType.FStatus;
                    break;


                case "messages":
                    _infoType = InfoType.Messages;
                    break;

                default:
                    RainmeterAPI.Log(RainmeterAPI.LogType.Error, "VKOnline.dll InfoType=" + type + " not valid");
                    break;
            }


        }

        internal double Update()
        {
            switch (_infoType)
            {
                case InfoType.Messages:
                    return (double)Info.UnReadCount;
            }
            return 0.0;
        }

        internal string GetString()
        {
            switch (_infoType)
            {
                case InfoType.FName:
                    return Info.UserData(UserCount)[0];

                case InfoType.FPhoto:
                    return Info.UserData(UserCount)[1];

                case InfoType.FId:
                    return Info.UserData(UserCount)[2];

                case InfoType.FStatus:
                    return Info.UserData(UserCount)[3];
            }
            return null;
        }

        internal static void ExecuteBang(string command)
        {
            //if (command == "OnlineInfo")
            //{
            //    Execute.Online();
            //}
        }

        private enum InfoType
        {
            FName,
            FPhoto,
            FId,
            FStatus,
            Messages
        }
    }
}
