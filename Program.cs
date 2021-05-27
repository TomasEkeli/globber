using System;
using System.IO;
using System.Linq;
using GlobExpressions;
using PowerArgs;

namespace globber
{
	public class args
	{
		[ArgRequired(PromptIfMissing = true), ArgPosition(0), ArgShortcut("p")]
		public string Pattern { get; set; }

		[ArgPosition(1), ArgShortcut("d")]
		public string Directory { get; set; }

		[ArgShortcut("v")]
		public bool Verbose { get; set; } = false;
	}

	class Program
	{
		static int Main(string[] args)
		{
			try
			{
				var parsed = Args.Parse<args>(args);
				string workingDirectory = parsed.Directory ?? Directory.GetCurrentDirectory();

				if (parsed.Verbose)
				{
					Console.WriteLine($@"looking in {workingDirectory} for {parsed.Pattern}");
				}

				var matches = Glob.Files(workingDirectory, parsed.Pattern).ToArray();
				foreach (var match in matches)
				{
					Console.WriteLine($@"{match}");
				}
				return matches.Count();
			}
			catch(Exception ex)
			{
				Console.Error.WriteLine($@"problem parsing: {ex.Message}");
				return -1;
			}
		}
	}
}
