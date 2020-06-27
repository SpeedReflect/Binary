using System;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;
using System.Security.Principal;
using Nikki.Core;
using CoreExtensions.Native;



namespace Binary
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// Skip administator check if in the debug mode
			if (!System.Diagnostics.Debugger.IsAttached)
			{
			
				// Check if the program is run as administator, exit if not
				using var identity = WindowsIdentity.GetCurrent();
				var principal = new WindowsPrincipal(identity);
				
				if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
				{
				
					MessageBox.Show("Run Binary in Administrator mode!", "Warning",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				
				}
			
			}

			#if DEBUG
			NativeCallerX.AllocConsole();
			#endif

			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var culture = CultureInfo.CreateSpecificCulture("en-US");
			Thread.CurrentThread.CurrentCulture = culture;
			CultureInfo.DefaultThreadCurrentCulture = culture;
			CultureInfo.DefaultThreadCurrentUICulture = culture;

			Loader.LoadBinKeys(new string[] { "keys.txt" });
			Application.Run(new IntroUI());

			#if DEBUG
			NativeCallerX.FreeConsole();
			#endif
		}
	}
}
