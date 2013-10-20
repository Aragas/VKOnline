using System;
using Rainmeter.Forms;
using Rainmeter.Methods;
using Rainmeter.Plugin;

namespace Rainmeter.Information
{
    public static class Info
    {
        private static int FriendsCount
        {
            get
            {
                return Measure.FriendsCount;
            }
        }

        private static string Token 
        {
            get
            {
                return OAuth.Token;
            }
        }

        private static string Id
        {
            get
            {
                return OAuth.Id;
            }
        }

        private static bool TokenIdExists
        {
            get { return (OAuth.Token != null || OAuth.Id != null); }
        }

        private static readonly Friends Friends = new Friends();
        private static readonly Messages Messages = new Messages();

        #region UserData

        private static string[] _userArray;
        private static string[] _userData = new string[5];

        private static bool UserArrayExists
        {
            get { return _userArray != null; }
        }

        private static string[] UserArray
        {
            get
            {
                if (UserArrayExists) return _userArray;
                if (!TokenIdExists) OAuth.OAuthRun();
                Friends.Token = Token;
                Friends.Id = Id;
                Friends.Count = FriendsCount;
                _userArray = Friends.OnlineString();
                return _userArray;
            }
        }

        public static string[] UserData(int user)
        {
            int i = (user*5)-1;
            _userData[0] = UserArray[i + 2] + " " + UserArray[i + 3];    // First Last Name.
            _userData[1] = UserArray[i + 1];    // Friend Id.
            _userData[2] = UserArray[i + 4];    // Photo Url.
            _userData[3] = UserArray[i + 5];    // Online or Online_m. 
            return _userData;
        }

        #endregion

        #region Messages

        private static bool UnReadExists = false;
        private static int _unRead;

        public static int UnReadCount
        {
            get
            {
                if (UnReadExists) return _unRead;
                if (!TokenIdExists) OAuth.OAuthRun();
                Messages.Token = Token;
                Messages.Id = Id;
                _unRead = Messages.UnReadMessages();

                UnReadExists = true;

                return _unRead;
            }
        }

        #endregion

    }
}
