using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PluginVK;

namespace Rainmeter
{
    internal class Measure
    {
        internal Measure()
        {
        }

        internal void Reload(Rainmeter.API rm, ref double maxValue)
        {
        }

        internal void Initialize()
        {
        }

        internal double Update()
        {
            return 0.0;
        }

        internal void ExecuteBang(string Command)
        {
            if (Command == "OnlineInfo")
            {
                Verification.Online();
            }
            return;
        }

    }

    #region Plugin

    public static class Plugin
    {
        internal static Dictionary<uint, Measure> Measures = new Dictionary<uint, Measure>();

        [DllExport]
        public unsafe static void Initialize(void** data, void* rm)
        {
            uint id = (uint)((void*)*data);
            Measures.Add(id, new Measure());
        }

        [DllExport]
        public unsafe static void Finalize(void* data)
        {
            uint id = (uint)data;
            Measures.Remove(id);
        }

        [DllExport]
        public unsafe static void Reload(void* data, void* rm, double* maxValue)
        {
            uint id = (uint)data;
            Measures[id].Reload(new Rainmeter.API((IntPtr)rm), ref *maxValue);
        }

        [DllExport]
        public unsafe static double Update(void* data)
        {
            uint id = (uint)data;
            return Measures[id].Update();
        }

        [DllExport]
        public unsafe static void ExecuteBang(void* data, char* args)
        {
            uint id = (uint)data;
            Measures[id].ExecuteBang(new string(args));
        }

    }
    #endregion
}
