using System.Runtime;

namespace Hani.Utilities
{
    internal static class ProfileOptimizer
    {
        internal static string FileRoamingPath { get; private set; }
        internal static string FileAppPath { get; private set; }

        private const string fileName = @"\profile";

        static ProfileOptimizer()
        {
            _set();
        }

        private static void _set()
        {
            FileRoamingPath = AppSettings.RoamingPath + fileName;
            FileAppPath = DirectoryHelper.CurrentDirectory + fileName;
        }

        internal static void Load()
        {
            ProfileOptimization.SetProfileRoot(AppSettings.SameAppPath ? DirectoryHelper.CurrentDirectory : AppSettings.RoamingPath);
            ProfileOptimization.StartProfile(fileName);
        }
    }
}