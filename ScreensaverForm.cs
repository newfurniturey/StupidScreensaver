using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.newfurniturey {
	public partial class ScreensaverForm : Form {
        #region Win32_API_functions
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);
        #endregion

		private Point mouseLocation;
		private int mouseMoveThreshold = 10;
		private bool previewMode = false;
		private Random rand = new Random();

		public ScreensaverForm() {
			InitializeComponent();
		}

		public ScreensaverForm(Rectangle Bounds) {
			InitializeComponent();
			this.Bounds = Bounds;

			moveTimer.Interval = 3000;
			moveTimer.Tick += new EventHandler(moveTimer_Tick);
			moveTimer.Start();
		}

		public ScreensaverForm(IntPtr handle) {
			InitializeComponent();

			SetParent(this.Handle, handle);

			// Make this a child window so it'll auto-close when the parent closes
			// GWL_STYLE = -16, WS_CHILD = 0x40000000
			SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

			Rectangle parentRect;
			GetClientRect(handle, out parentRect);
			this.Size = parentRect.Size;
			this.Location = new Point(0, 0);

			textLabel.Font = new System.Drawing.Font("Verdana", 8);

			this.previewMode = true;
		}

		private void ScreensaverForm_Load(object sender, EventArgs e) {
			RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\StupidScreensaver");
			if (key == null) {
				textLabel.Text = "Hi mom =]";
			} else {
				textLabel.Text = (string)key.GetValue("text");
			}

			Cursor.Hide();
			TopMost = true;
		}

		private void ScreensaverForm_MouseClick(object sender, MouseEventArgs e) {
			if (this.previewMode) {
				return;
			}

			Application.Exit();
		}

		private void ScreensaverForm_KeyPress(object sender, KeyPressEventArgs e) {
			if (this.previewMode) {
				return;
			}
			
			Application.Exit();
		}

		private void ScreensaverForm_MouseMove(object sender, MouseEventArgs e) {
			if (this.previewMode) {
				return;
			}

			if (!this.mouseLocation.IsEmpty) {
				int moveX = Math.Abs(this.mouseLocation.X - e.X),
					moveY = Math.Abs(this.mouseLocation.Y - e.Y);

				if ((moveX >= this.mouseMoveThreshold) || (moveY >= this.mouseMoveThreshold)) {
					Application.Exit();
				}
			}

			this.mouseLocation = e.Location;
		}

		private void moveTimer_Tick(object sender, EventArgs e) {
			textLabel.Left = rand.Next(Math.Max(1, Bounds.Width - textLabel.Width));
			textLabel.Top = rand.Next(Math.Max(1, Bounds.Height - textLabel.Height));
		}
	}
}
