using System.IO;

namespace NitroxLauncher.Patching
{
    public class PlatformDetection
    {
        internal static Platform GetPlatform(string subnauticaPath)
        {

            if (Directory.Exists(Path.Combine(subnauticaPath, ".egstore")))
            {
                return Platform.Epic;
            }
            else if (File.Exists(Path.Combine(subnauticaPath, "Subnautica_Data", "Plugins", "CSteamworks.dll")))
            {
                return Platform.Steam;
            }
            else if (File.Exists(Path.Combine(subnauticaPath, "appxmanifest.xml")))
            {
                return Platform.Microsoft;
            }
            return Platform.None;
        }

        internal enum Platform
        {
            Epic,
            Steam,
            Microsoft,
            None
        }
    }
}
