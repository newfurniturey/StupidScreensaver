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
			this.components = new System.ComponentModel.Container();
			this.textLabel = new System.Windows.Forms.Label();
			this.moveTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// textLabel
			// 
			this.textLabel.AutoSize = true;
			this.textLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textLabel.ForeColor = System.Drawing.Color.Maroon;
			this.textLabel.Location = new System.Drawing.Point(22, 35);
			this.textLabel.Name = "textLabel";
			this.textLabel.Size = new System.Drawing.Size(138, 25);
			this.textLabel.TabIndex = 0;
			this.textLabel.Text = "Hi mom =]";
			// 
			// ScreensaverForm
			// 
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.textLabel);
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
		
		private System.Windows.Forms.Label textLabel;
		private System.Windows.Forms.Timer moveTimer;
	}
}

