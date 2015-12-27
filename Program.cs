using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.newfurniturey {
	static class Program {
		[STAThread]
		static void Main(string[] args) {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (args.Length > 0) {
				string firstArg = args[0].ToLower().Trim();
				string secondArg = null;

				if (firstArg.Length > 2) {
					secondArg = firstArg.Substring(3).Trim();
					firstArg = firstArg.Substring(0, 2);
				} else if (args.Length > 1) {
					secondArg = args[1];
				}

				if (firstArg == "/c") {
					// Configuration Mode

				} else if (firstArg == "/p") {
					// Preview Mode
					if (secondArg == null) {
						MessageBox.Show(
							"Missing the window handle =/",
							"Stupid Screensaver",
							MessageBoxButtons.OK, MessageBoxIcon.Exclamation
						);
						return;
					}

					IntPtr handle = new IntPtr(long.Parse(secondArg));
					Application.Run(new ScreensaverForm(handle));
				} else if (firstArg == "/s") {
					// FullScreen Mode
					ShowScreensaver();
					Application.Run();
				} else {
					MessageBox.Show(
						"Invalid argument(s) passed in =[",
						"Stupid Screensaver",
						MessageBoxButtons.OK, MessageBoxIcon.Exclamation
					);
				}
			} else {
				Application.Run(new ScreensaverForm());
			}
		}

		static void ShowScreensaver() {
			foreach (Screen screen in Screen.AllScreens) {
				ScreensaverForm form = new ScreensaverForm(screen.Bounds);
				form.Show();
			}
		}
	}
}
