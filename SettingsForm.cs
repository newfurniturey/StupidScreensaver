using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.newfurniturey {
	public partial class SettingsForm : Form {
		public SettingsForm() {
			InitializeComponent();
			LoadSettings();
		}

		private void LoadSettings() {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\StupidScreensaver");
            if (key == null) {
                textBox.Text = "Hi mom =]";
			} else {
                textBox.Text = (string)key.GetValue("text");
			}
		}

		private void SaveSettings() {
			RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\StupidScreensaver");
			key.SetValue("text", textBox.Text);
		}

		private void saveButton_Click(object sender, EventArgs e) {
			SaveSettings();
			Close();
		}

		private void cancelButton_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
