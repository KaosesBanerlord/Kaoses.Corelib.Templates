using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Localization;

namespace BLNamespace.Settings
{
    public class BLNamespaceConfig
    {
        private static BLNamespaceConfig _instance = null;

        private BLNamespaceConfig()
        {

        }

        public static BLNamespaceConfig Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BLNamespaceConfig();
                return _instance;
            }
        }



        #region Debug

#if DEBUG
        public bool Debug { get; set; } = true;
#else
        public bool Debug { get; set; } = false;
#endif

#if DEBUG
        public bool LogToFile { get; set; } = true;
#else
        public bool LogToFile { get; set; } = false;
#endif


        #endregion //~Debug


        ///~ Mod Specific settings 
        #region Mod Specific settings

        public bool boolVariable { get; set; } = true;
        public int IntVariable { get; set; } = 25;
        public float FloatVariable { get; set; } = 0.75f;
        public string StringVariable { get; set; } = "The_textbox_data_here";
        public string DropDownName { get; set; } = "No Override";

        #endregion


    }
}
