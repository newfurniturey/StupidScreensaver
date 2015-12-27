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
	public partial class ScreensaverForm : Form {
		private Point mouseLocation;
		private int mouseMoveThreshold = 10;
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

		private void ScreensaverForm_Load(object sender, EventArgs e) {
			Cursor.Hide();
			TopMost = true;
		}

		private void ScreensaverForm_MouseClick(object sender, MouseEventArgs e) {
			Application.Exit();
		}

		private void ScreensaverForm_KeyPress(object sender, KeyPressEventArgs e) {
			Application.Exit();
		}

		private void ScreensaverForm_MouseMove(object sender, MouseEventArgs e) {
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
