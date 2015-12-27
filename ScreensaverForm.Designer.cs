namespace com.newfurniturey {
	partial class ScreensaverForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Maroon;
			this.label1.Location = new System.Drawing.Point(22, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hi mom =]";
			// 
			// ScreensaverForm
			// 
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ScreensaverForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Load += new System.EventHandler(this.ScreensaverForm_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScreensaverForm_KeyPress);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScreensaverForm_MouseClick);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreensaverForm_MouseMove);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		
		private System.Windows.Forms.Label label1;
	}
}

