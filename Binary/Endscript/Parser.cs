using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Collections.Generic;
using Binary.Enums;
using CoreExtensions.Management;
using System.Runtime.CompilerServices;
using Nikki.Core;

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

		public static Launch GenerateSample() =>
			GenerateSample(String.Empty, GameINT.None.ToString(), eUsage.Invalid.ToString());

		public static Launch GenerateSample(string directory) =>
			GenerateSample(directory, GameINT.None.ToString(), eUsage.Invalid.ToString());
	
		public static Launch GenerateSample(string directory, string game, string usage)
		{
			var launch = new Launch()
			{

				Game = game,
				Usage = usage,
				Directory = directory,

				Files = new List<string>()
				{
					@"GLOBAL\GLOBALA.BUN",
					@"GLOBAL\GLOBALB.LZC",
				},

				Links = new List<SubLoader>()
				{

					new SubLoader()
					{
						File = @"GLOBAL\attributes.bin",
						LoadType = eLoaderType.Attributes.ToString(),
						PathType = ePathType.Absolute.ToString(),
					},

					new SubLoader()
					{
						File = @"GLOBAL\fe_attrib.bin",
						LoadType = eLoaderType.FeAttrib.ToString(),
						PathType = ePathType.Absolute.ToString(),
					},

					new SubLoader()
					{
						File = @"LANGUAGES\Labels_Global.bin",
						LoadType = eLoaderType.Labels.ToString(),
						PathType = ePathType.Absolute.ToString(),
					},

					new SubLoader()
					{
						File = @"LANGUAGES\Labels.bin",
						LoadType = eLoaderType.Labels.ToString(),
						PathType = ePathType.Absolute.ToString(),
					},

				},

			};

			return launch;
		}

		public static void Serialize(string filename, Launch launch)
		{
			var settings = JsonSerializer.Serialize(launch, options);
			settings = settings.Replace(@"\\", @"\");

			using var sw = new StreamWriter(File.Open(filename, FileMode.Create));
			sw.WriteLine("[VERSN1]");
			sw.WriteLine();
			sw.Write(settings);
			sw.WriteLine();
		}

		public static void Deserialize(string filename, out Launch launch)
		{
			var settings = File.ReadAllText(filename);
			if (!settings.StartsWith("[VERSN1]"))
			{

				throw new InvalidVersionException(1);

			}

			settings = settings[8..].Replace(@"\", @"\\");
			launch = JsonSerializer.Deserialize<Launch>(settings, options);
		}
	}
}
