using Rainmeter.API;

namespace Rainmeter.Plugin
{
    internal class Measure
    {
        private enum Type
        {
            OnlineInfo
        }

        private Type _type;

        internal void Reload(RainmeterAPI rm, ref double maxValue)
        {
            string type = rm.ReadString("Type", "");
            switch (type.ToLowerInvariant())
            {
                case "onlineinfo":
                    _type = Type.OnlineInfo;
                    break;
            }
        }

        internal double Update()
        {
            switch (_type)
            {
                  case Type.OnlineInfo:
                    Verification.Online();
                    return 0.0;
            }
            return 0.0;
        }

        internal static void ExecuteBang(string command)
        {
        }

        internal string GetString()
        {
            return null;
        }
    }
}
