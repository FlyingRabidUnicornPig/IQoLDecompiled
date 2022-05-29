// Process nabber
// Used to see if someone is running cheat engine or other bs in the background
// I'm meh on this, i don't like being spied on, and it's not really "anti-cheat" as it is a "sus" marker
// Just cause someone has cheat engine in the background doesn't mean they're using it for Intralism

using System;
using System.Collections.Generic;
using System.Diagnostics;

public class GetProcessesJob : ThreadedJob
{
	// Prolly "Start()"
	protected override void BLFNOPKJDGC() { }

	// Find processes and list them
	protected override void JAFCCBIPELN()
	{
		this.activeProcesses = new List<string>();

		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "cmd.exe",
				Arguments = "/C tasklist",
				Verb = "runas",
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			process.Start();

			while (!process.HasExited)
				while (process.StandardOutput.Peek() >= 0)
					this.activeProcesses.Add(process.StandardOutput.ReadLine());
		}
		catch (Exception)
		{
			this.activeProcesses.Add("Error0");
		}
	}

	public List<string> activeProcesses;
}