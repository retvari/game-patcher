using System.Collections.Generic;

namespace David.Patcher.Source_files
{
    class Texts
    {
        public enum Keys
        {
            UNKNOWNERROR,
            MISSINGBINARY,
            CANNOTSTART,
            NONETWORK,
            CONNECTING,
            LISTDOWNLOAD,
            CHECKFILE,
            DOWNLOADFILE,
            COMPLETEPROGRESS,
            CURRENTPROGRESS,
            CHECKCOMPLETE,
            DOWNLOADCOMPLETE,
            DOWNLOADSPEED
        }

        private static Dictionary<Keys, string> Text = new Dictionary<Keys, string>
        {
            {Keys.UNKNOWNERROR,                         "An unknown, but a critical error occured...error message which can help to solve the problem: \n{0}"},
            {Keys.MISSINGBINARY,                        "The game cannot be started, because the {0} is missing."},
            {Keys.CANNOTSTART,                          "Can't start the game, because the {0} is not accessible."},
            {Keys.NONETWORK,                            "Can't connect to server, please check your network settings and try again."},
            {Keys.CONNECTING,                           "Connecting to the server..."},
            {Keys.LISTDOWNLOAD,                         "Downloading patchlist..."},
            {Keys.CHECKFILE,                            "{0} checking..."},
            {Keys.DOWNLOADFILE,                         "{0} downloading... {1}/ {2}"},
            {Keys.COMPLETEPROGRESS,                     "Full progress: {0}%"},
            {Keys.CURRENTPROGRESS,                      "Per file progress: {0}%  |  {1} kb/s"},
            {Keys.CHECKCOMPLETE,                        "Every file has been checked properly"},
            {Keys.DOWNLOADCOMPLETE,                     "Every required files has been downloaded properly."},
            {Keys.DOWNLOADSPEED,                        "{0} kb/s"}
        };

        public static string GetText(Keys Key, params object[] Arguments)
        {
            foreach (KeyValuePair<Keys, string> currentItem in Text)
            {
                if (currentItem.Key == Key)
                {
                    return string.Format(currentItem.Value, Arguments);
                }
            }

            return null;
        }
    }
}
