using System;
using System.IO;


namespace NEWRTL
{
    internal class Constants
    {
        public static string INIPath = "rethawed.ini"; //settings path
        //public static string compinfo = new ComputerInfo().OSFullName;

        /*public static string vNumfilePath = "version.txt";
        public static string vNumFile = main.Version;
        public static string VNUM = main.VersionToString;*/

        public static string EXEPath = "rethawed.exe";

        public static string vanFile = "binkw32.dll";
        public static string vanFile2 = Path.Combine(".", "data"); //this might go unused

        public static string verText = null;
        public static string newverText = null;

        public static string[] OptionsItemDesc = { // every item must have a description. --- Options List.
            "This is your Resolution Width.\n\nExample: 1280 for 1280x720.",
            "This is your Resolution Height. \n\nExample: 720 for 1280x720.",
            "Toggle this on to run your game in windowed mode.",
            "Toggle this on to run your game in borderless windowed mode.",
            "None = No Shadows\nLow = Flat Circle Shadow\nHigh = Dynamically Casted Shadows",
            "Determines the positioning of the HUD\nbased on 4:3 and 16:9 positioning.",
            "An option to aide performance on low end PCs.",
            "Enables or disables Discord Rich Presence integration.",
            "Enables or disables the boot activision/aspyr movies.",
            "If toggled on, it will unlock FPS to 120fps.\n120fps mode may cause various issues.\n\nDue to these issues, using UnlockFPSValue (120fps mode)\nwill lock online play.",
            "Shows a command prompt window displaying\nuseful information for debugging purposes.",
            "Writes contents of the 'Console' option above to a file called 'debug.txt'\nin the game directory.\n\nThe 'Console' option doesn't need to be toggled on\nfor this option to work.",
            "Choose to autolaunch into freeskate or mainmenu upon game launch.",
            "Choose the level to autolaunch into.",
            "Choose the gamemode to autolaunch into.",
            "Full Clip Range - Allows extended Clipping Ranges",
            "The fog that covers the clipping distance.",
            "Clip Distance - The distance of the clipping range.\nMax range is 595 with FullRange on\nMax range is 100 with FullRange off",
            "This option allows you to switch between DX9 and DXVK\nat ease.\n\nDo not attempt to switch to Vulkan if your hardware\nDOES NOT support it!"
        };

        public static int KeyCodeBuffer = 0;
        public static string ConvertedKeyCode;

        public static string[] KeyboardBindBlacklist = {
            "Return",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F12"
        };
    }
}
