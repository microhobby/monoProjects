using System;

namespace Test
{
	public class CrossPlatform
	{
		public CrossPlatform ()
		{
		}

		public bool IsLinux () 
		{
			return Environment.OSVersion.Platform == PlatformID.Unix;
		}

		public bool IsWindows () 
		{
			return Environment.OSVersion.Platform == PlatformID.Win32NT
					|| Environment.OSVersion.Platform == PlatformID.Win32S
					|| Environment.OSVersion.Platform == PlatformID.Win32Windows
					|| Environment.OSVersion.Platform == PlatformID.WinCE;
		}

		public string ExecBashCommand (string cmd) 
		{
			return this.execTerminalCmd ("bash", "-c '" + cmd + "'");
		}

		public string ExecCmdCommand (string cmd) 
		{
			return this.execTerminalCmd ("CMD.exe", cmd);
		}

		private string execTerminalCmd (string prg, string cmd) 
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = prg;
			startInfo.Arguments = cmd;
			startInfo.RedirectStandardOutput = true;
			startInfo.CreateNoWindow = true;
			startInfo.UseShellExecute = false;
			process.StartInfo = startInfo;
			process.Start();

			return process.StandardOutput.ReadToEnd ();
		}

		public bool IsARM () 
		{
			string machine = "";

			if (IsLinux ()) {
				machine = ExecBashCommand ("uname -m");

				return machine.Contains ("arm");
			} else
				throw new Exception ("Windows arch method not implemented");
		}

		public bool IsX86 () 
		{
			string machine = "";

			if (IsLinux ()) {
				machine = ExecBashCommand ("uname -m");

				return machine.Contains ("x86");
			} else
				throw new Exception ("Windows arch method not implemented");
		}
	}
}
