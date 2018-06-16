using System;
using System.Diagnostics;
using System.IO;

namespace Azurlane
{
    internal static class Utils
    {
        internal static void Command(string argument)
        {
            var process = new Process();
            process.StartInfo.FileName = "cmd";
            process.StartInfo.Arguments = $"/c {argument}";
            process.StartInfo.WorkingDirectory = PathMgr.Thirdparty();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            process.WaitForExit();
            process.Close();
        }

        internal static void DeleteDirectory(string path)
        {
            foreach (var directory in Directory.GetDirectories(path))
                DeleteDirectory(directory);

            try
            {
                Directory.Delete(path, true);
            }
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
        }
    }
}