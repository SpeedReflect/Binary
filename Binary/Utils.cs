using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Nikki.Reflection.Abstract;
using Nikki.Reflection.Interface;



namespace Binary
{
	internal static class Utils
	{
		public static IReflective GetReflective(string path, string separator, List<SyncDatabase> SyncDBs)
		{
			var splits = path.Split(separator);

			// splits[0] = Filename
			// splits[1] = IManager
			// splits[2] = Collectable
			// splits[3] = Expandable
			// splits[4] = SubPart

			if (splits.Length != 3 && splits.Length != 5) return null;

			var db = SyncDBs.Find(_ => _.Filename == splits[0]);
			if (db == null) return null;

			var manager = db.Database.GetManager(splits[1]);
			if (manager == null) return null;

			var collection = manager[manager.IndexOf(splits[2])] as Collectable;

			return splits.Length == 3
				? collection
				: (IReflective)collection.GetSubPart(splits[4], splits[3]);
		}

        /// <summary>
        /// Opens URL link in default browser.
        /// Credit to: https://brockallen.com/2016/09/24/process-start-for-urls-on-net-core/
        /// </summary>
        /// <param name="url">URL link to open.</param>
        public static void OpenBrowser(string url)
        {
            try
            {

                Process.Start(url);
            
            }
            catch
            {
            
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                
                    Process.Start("xdg-open", url);
                
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                
                    Process.Start("open", url);
                
                }
                else
                {

                    throw new PlatformNotSupportedException();
                
                }
            
            }
        }
    }
}
