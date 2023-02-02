using KaosesCommon.Utils;
using KaosesCommon;
using KaosesCommon.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BLNamespace.Settings;

namespace BLNamespace.Objects
{
    /// <summary>
    /// BLNamespaceFactory Factory Object
    /// </summary>
    public static class BLNamespaceFactory
    {
        /// <summary>
        /// Variable to hold the MCM settings object
        /// </summary>
        private static BLNamespaceConfig _settings = null;

        private static InfoMgr? _im = null;

        public static InfoMgr IM
        {
            get
            {
                return _im;
            }
            set
            {
                _im = value;
            }
        }

        /// <summary>
        /// MCM Settings Object Instance
        /// </summary>
        public static BLNamespaceConfig Settings
        {
            get
            {
                if (_settings == null)
                {
                    _settings = BLNamespaceConfig.Instance;
                    if (_settings is null)
                    {
                        //IM.ShowMessageBox("BLNamespaceConfig Failed to load BLNamespaceConfig provider", "BLNamespaceConfig Error");
                    }
                }
                return _settings;
            }
            set
            {
                _settings = value;
            }
        }
        
        /// <summary>
        /// Mod version
        /// </summary>
        public static string ModVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

    }
}
