using BepInEx;
using BepInEx.Unity.IL2CPP;
using BepInEx.Logging;
// using HarmonyLib;

namespace MEGABONK_SIMPLE_MOD
{
    [BepInPlugin(GUID, MODNAME, VERSION)]
    public class Plugin : BasePlugin
    {
        public const string
            MODNAME = "MEGABONK_SIMPLE_MOD",
            AUTHOR = "AUTHOR_NAME",
            GUID = AUTHOR + "_" + MODNAME,
            VERSION = "0.1.0";

        public Plugin()
        {
            log = Log;
        }

        public override void Load()
        {
            log.LogInfo($"Loading {MODNAME} v{VERSION} by {AUTHOR}");
        }

        public static ManualLogSource log;
    }
}