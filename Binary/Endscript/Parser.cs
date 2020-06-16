using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Collections.Generic;
using Binary.Enums;
using CoreExtensions.Management;



namespace Binary.Endscript
{
	public static class Parser
	{
		private static readonly JsonSerializerOptions options = new JsonSerializerOptions()
		{
			AllowTrailingCommas = true,
			IgnoreReadOnlyProperties = true,
			ReadCommentHandling = JsonCommentHandling.Skip,
			WriteIndented = true,
		};

		public static void GenerateSample() => GenerateSample(String.Empty);

		public static void GenerateSample(string directory)
		{
			var launch = new Launch()
			{
				Directory = directory,
				Files = new List<string>()
				{
					@"GLOBAL\GLOBALA.BUN",
					@"GLOBAL\GLOBALB.LZC",
				},
				Links = new List<SubLoader>()
				{
					new SubLoader() { File = @"GLOBAL\attributes.bin", LoadType = eLoaderType.Attributes.ToString() },
					new SubLoader() { File = @"GLOBAL\fe_attrib.bin", LoadType = eLoaderType.FeAttrib.ToString() },
					new SubLoader() { File = @"LANGUAGES\Labels_Global.bin", LoadType = eLoaderType.Labels.ToString(), },
					new SubLoader() { File = @"LANGUAGES\Labels.bin", LoadType = eLoaderType.Labels.ToString(), },
				},
			};

			Serialize("launch.end", launch);
		}
	
		public static void Serialize(string filename, Launch launch)
		{
			try
			{

				var settings = JsonSerializer.Serialize(launch, options);
				settings = settings.Replace(@"\\", @"\");
				File.WriteAllText(filename, settings);

			}
			catch (Exception e)
			{

				MessageBox.Show(e.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		public static void Deserialize(string filename, out Launch launch)
		{
			try
			{

				var settings = File.ReadAllText(filename);
				settings = settings.Replace(@"\", @"\\");
				launch = JsonSerializer.Deserialize<Launch>(settings, options);

			}
			catch (Exception e)
			{

				launch = null;
				MessageBox.Show(e.GetLowestMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}
	}
}
