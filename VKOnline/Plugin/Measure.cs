using System;
using System.Collections.Generic;
using Rainmeter.API;
using Rainmeter.Information;

namespace Rainmeter.Plugin
{
    internal class Measure
    {
        private static string _friendsCount;
        public static string FriendsCount
        {
            get
            {
                return _friendsCount;
            }

        }

        private int UserType = 1;

        private InfoType _infoType;
        private FriendsType _friendsType;

        internal void Reload(RainmeterAPI rm, ref double maxValue)
        {
            string ftype = rm.ReadString("FriendType", "");
            string type = rm.ReadString("InfoType", "");
            switch (type.ToLowerInvariant())
            {
                case "friends":
                    _infoType = InfoType.Friends;
                    if (_friendsCount == null)
                        _friendsCount = rm.ReadString("FriendsCount", "1");
                    UserType = rm.ReadInt("UserType", 1);
                    #region Friends
                    switch (ftype.ToLowerInvariant())
                    {
                        case "name":
                            _friendsType = FriendsType.Name;
                            break;

                        case "photo":
                            _friendsType = FriendsType.Photo;
                            break;

                        case "id":
                            _friendsType = FriendsType.Id;
                            break;

                        case "status":
                            _friendsType = FriendsType.Status;
                            break;
                    }
                    #endregion
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
                    return (double)Info.MessagesUnReadCount;
            }
            return 0.0;
        }

        internal string GetString()
        {
            switch (_infoType)
            {
                case InfoType.Friends:
                    #region Friends
                    switch (_friendsType)
                    {
                        case FriendsType.Name:
                            return Info.FriendsUserData(UserType)[0];

                        case FriendsType.Photo:
                            return Info.FriendsUserData(UserType)[2];

                        case FriendsType.Id:
                            return Info.FriendsUserData(UserType)[1];

                        case FriendsType.Status:
                            return Info.FriendsUserData(UserType)[3];
                    }
                    #endregion
                    return null;

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
            Friends,
            Messages
        }

        private enum FriendsType
        {
            Name,
            Photo,
            Id,
            Status
        }
    }
}
