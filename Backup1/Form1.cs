using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Clifton.Tools.Events;

namespace MouseEventDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblLeftClick;
		private System.Windows.Forms.Label lblRightClick;
		private System.Windows.Forms.Label lblLeftDown;
		private System.Windows.Forms.Label lblRightDown;
		private System.Windows.Forms.Label lblMiddleClick;
		private System.Windows.Forms.Label lblMiddleDown;
		private System.Windows.Forms.Label lblForward;
		private System.Windows.Forms.Label lblBackward;
		private System.Windows.Forms.Label lblLeftDoubleClick;
		private System.Windows.Forms.Label lblRightDoubleClick;
		private System.Windows.Forms.Label lblMiddleDoubleClick;
		private System.Timers.Timer timer1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			MouseHelper mh=new MouseHelper(this);
			mh.AddControl(pictureBox1);
			mh.LeftClick+=new EventHandler(OnLeftClick);
			mh.LeftDoubleClick+=new EventHandler(OnLeftDoubleClick);
			mh.MiddleDoubleClick+=new EventHandler(OnMiddleDoubleClick);
			mh.RightDoubleClick+=new EventHandler(OnRightDoubleClick);
			mh.LeftMouseDown+=new MouseEventHandler(OnLeftMouseDown);
			mh.LeftMouseUp+=new MouseEventHandler(OnLeftMouseUp);
			mh.MiddleClick+=new EventHandler(OnMiddleClick);
			mh.MiddleMouseDown+=new MouseEventHandler(OnMiddleMouseDown);
			mh.MiddleMouseUp+=new MouseEventHandler(OnMiddleMouseUp);
			mh.RightClick+=new EventHandler(OnRightClick);
			mh.RightMouseDown+=new MouseEventHandler(OnRightMouseDown);
			mh.RightMouseUp+=new MouseEventHandler(OnRightMouseUp);
			mh.WheelBackward+=new MouseEventHandler(OnWheelBackward);
			mh.WheelForward+=new MouseEventHandler(OnWheelForward);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblLeftClick = new System.Windows.Forms.Label();
			this.lblRightClick = new System.Windows.Forms.Label();
			this.lblLeftDoubleClick = new System.Windows.Forms.Label();
			this.lblLeftDown = new System.Windows.Forms.Label();
			this.lblRightDown = new System.Windows.Forms.Label();
			this.lblMiddleClick = new System.Windows.Forms.Label();
			this.lblMiddleDown = new System.Windows.Forms.Label();
			this.lblForward = new System.Windows.Forms.Label();
			this.lblBackward = new System.Windows.Forms.Label();
			this.lblRightDoubleClick = new System.Windows.Forms.Label();
			this.lblMiddleDoubleClick = new System.Windows.Forms.Label();
			this.timer1 = new System.Timers.Timer();
			((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(56, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(168, 176);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lblLeftClick
			// 
			this.lblLeftClick.BackColor = System.Drawing.Color.White;
			this.lblLeftClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblLeftClick.ForeColor = System.Drawing.Color.Green;
			this.lblLeftClick.Location = new System.Drawing.Point(88, 80);
			this.lblLeftClick.Name = "lblLeftClick";
			this.lblLeftClick.Size = new System.Drawing.Size(40, 16);
			this.lblLeftClick.TabIndex = 1;
			this.lblLeftClick.Text = "Click";
			this.lblLeftClick.Visible = false;
			// 
			// lblRightClick
			// 
			this.lblRightClick.BackColor = System.Drawing.Color.White;
			this.lblRightClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblRightClick.ForeColor = System.Drawing.Color.Green;
			this.lblRightClick.Location = new System.Drawing.Point(152, 80);
			this.lblRightClick.Name = "lblRightClick";
			this.lblRightClick.Size = new System.Drawing.Size(40, 16);
			this.lblRightClick.TabIndex = 2;
			this.lblRightClick.Text = "Click";
			this.lblRightClick.Visible = false;
			// 
			// lblLeftDoubleClick
			// 
			this.lblLeftDoubleClick.BackColor = System.Drawing.Color.White;
			this.lblLeftDoubleClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblLeftDoubleClick.ForeColor = System.Drawing.Color.Green;
			this.lblLeftDoubleClick.Location = new System.Drawing.Point(56, 96);
			this.lblLeftDoubleClick.Name = "lblLeftDoubleClick";
			this.lblLeftDoubleClick.Size = new System.Drawing.Size(72, 16);
			this.lblLeftDoubleClick.TabIndex = 3;
			this.lblLeftDoubleClick.Text = "Double Click";
			this.lblLeftDoubleClick.Visible = false;
			// 
			// lblLeftDown
			// 
			this.lblLeftDown.BackColor = System.Drawing.Color.White;
			this.lblLeftDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblLeftDown.ForeColor = System.Drawing.Color.Green;
			this.lblLeftDown.Location = new System.Drawing.Point(64, 112);
			this.lblLeftDown.Name = "lblLeftDown";
			this.lblLeftDown.Size = new System.Drawing.Size(40, 16);
			this.lblLeftDown.TabIndex = 4;
			this.lblLeftDown.Text = "Down";
			this.lblLeftDown.Visible = false;
			// 
			// lblRightDown
			// 
			this.lblRightDown.BackColor = System.Drawing.Color.White;
			this.lblRightDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblRightDown.ForeColor = System.Drawing.Color.Green;
			this.lblRightDown.Location = new System.Drawing.Point(176, 112);
			this.lblRightDown.Name = "lblRightDown";
			this.lblRightDown.Size = new System.Drawing.Size(40, 16);
			this.lblRightDown.TabIndex = 5;
			this.lblRightDown.Text = "Down";
			this.lblRightDown.Visible = false;
			// 
			// lblMiddleClick
			// 
			this.lblMiddleClick.BackColor = System.Drawing.Color.White;
			this.lblMiddleClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblMiddleClick.ForeColor = System.Drawing.Color.Green;
			this.lblMiddleClick.Location = new System.Drawing.Point(120, 32);
			this.lblMiddleClick.Name = "lblMiddleClick";
			this.lblMiddleClick.Size = new System.Drawing.Size(40, 16);
			this.lblMiddleClick.TabIndex = 6;
			this.lblMiddleClick.Text = "Click";
			this.lblMiddleClick.Visible = false;
			// 
			// lblMiddleDown
			// 
			this.lblMiddleDown.BackColor = System.Drawing.Color.White;
			this.lblMiddleDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblMiddleDown.ForeColor = System.Drawing.Color.Green;
			this.lblMiddleDown.Location = new System.Drawing.Point(120, 48);
			this.lblMiddleDown.Name = "lblMiddleDown";
			this.lblMiddleDown.Size = new System.Drawing.Size(40, 16);
			this.lblMiddleDown.TabIndex = 7;
			this.lblMiddleDown.Text = "Down";
			this.lblMiddleDown.Visible = false;
			// 
			// lblForward
			// 
			this.lblForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblForward.ForeColor = System.Drawing.Color.Green;
			this.lblForward.Location = new System.Drawing.Point(112, 16);
			this.lblForward.Name = "lblForward";
			this.lblForward.Size = new System.Drawing.Size(48, 16);
			this.lblForward.TabIndex = 8;
			this.lblForward.Text = "Forward";
			this.lblForward.Visible = false;
			// 
			// lblBackward
			// 
			this.lblBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblBackward.ForeColor = System.Drawing.Color.Green;
			this.lblBackward.Location = new System.Drawing.Point(112, 208);
			this.lblBackward.Name = "lblBackward";
			this.lblBackward.Size = new System.Drawing.Size(64, 16);
			this.lblBackward.TabIndex = 9;
			this.lblBackward.Text = "Backward";
			this.lblBackward.Visible = false;
			// 
			// lblRightDoubleClick
			// 
			this.lblRightDoubleClick.BackColor = System.Drawing.Color.White;
			this.lblRightDoubleClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblRightDoubleClick.ForeColor = System.Drawing.Color.Green;
			this.lblRightDoubleClick.Location = new System.Drawing.Point(168, 96);
			this.lblRightDoubleClick.Name = "lblRightDoubleClick";
			this.lblRightDoubleClick.Size = new System.Drawing.Size(72, 16);
			this.lblRightDoubleClick.TabIndex = 10;
			this.lblRightDoubleClick.Text = "Double Click";
			this.lblRightDoubleClick.Visible = false;
			// 
			// lblMiddleDoubleClick
			// 
			this.lblMiddleDoubleClick.BackColor = System.Drawing.Color.White;
			this.lblMiddleDoubleClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblMiddleDoubleClick.ForeColor = System.Drawing.Color.Green;
			this.lblMiddleDoubleClick.Location = new System.Drawing.Point(104, 64);
			this.lblMiddleDoubleClick.Name = "lblMiddleDoubleClick";
			this.lblMiddleDoubleClick.Size = new System.Drawing.Size(72, 16);
			this.lblMiddleDoubleClick.TabIndex = 11;
			this.lblMiddleDoubleClick.Text = "Double Click";
			this.lblMiddleDoubleClick.Visible = false;
			// 
			// timer1
			// 
			this.timer1.AutoReset = false;
			this.timer1.Interval = 750;
			this.timer1.SynchronizingObject = this;
			this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.lblMiddleDoubleClick);
			this.Controls.Add(this.lblRightDoubleClick);
			this.Controls.Add(this.lblBackward);
			this.Controls.Add(this.lblForward);
			this.Controls.Add(this.lblMiddleDown);
			this.Controls.Add(this.lblMiddleClick);
			this.Controls.Add(this.lblRightDown);
			this.Controls.Add(this.lblLeftDown);
			this.Controls.Add(this.lblLeftDoubleClick);
			this.Controls.Add(this.lblRightClick);
			this.Controls.Add(this.lblLeftClick);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Form1 form=new Form1();
			Application.Run(form);
		}

		private void OnLeftClick(object sender, EventArgs e)
		{
			lblLeftClick.Visible=true;
			timer1.Start();
		}

		private void OnLeftDoubleClick(object sender, EventArgs e)
		{
			lblLeftDoubleClick.Visible=true;
			timer1.Start();
		}

		private void OnMiddleDoubleClick(object sender, EventArgs e)
		{
			lblMiddleDoubleClick.Visible=true;
			timer1.Start();
		}

		private void OnRightDoubleClick(object sender, EventArgs e)
		{
			lblRightDoubleClick.Visible=true;
			timer1.Start();
		}

		private void OnLeftMouseDown(object sender, MouseEventArgs e)
		{
			lblLeftDown.Visible=true;
		}

		private void OnLeftMouseUp(object sender, MouseEventArgs e)
		{
			lblLeftDown.Visible=false;
		}

		private void OnMiddleClick(object sender,EventArgs e)
		{
			lblMiddleClick.Visible=true;
			timer1.Start();
		}

		private void OnMiddleMouseDown(object sender, MouseEventArgs e)
		{
			lblMiddleDown.Visible=true;
		}

		private void OnMiddleMouseUp(object sender, MouseEventArgs e)
		{
			lblMiddleDown.Visible=false;
		}

		private void OnRightClick(object sender, EventArgs e)
		{
			lblRightClick.Visible=true;
			timer1.Start();
		}

		private void OnRightMouseDown(object sender, MouseEventArgs e)
		{
			lblRightDown.Visible=true;
		}

		private void OnRightMouseUp(object sender, MouseEventArgs e)
		{
			lblRightDown.Visible=false;
		}

		private void OnWheelBackward(object sender, MouseEventArgs e)
		{
			lblForward.Visible=true;
			lblBackward.Visible=false;
			timer1.Start();
		}

		private void OnWheelForward(object sender, MouseEventArgs e)
		{
			lblForward.Visible=false;
			lblBackward.Visible=true;
			timer1.Start();
		}

		private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			lblLeftClick.Visible=false;
			lblRightClick.Visible=false;;
			lblMiddleClick.Visible=false;;
			lblForward.Visible=false;;
			lblBackward.Visible=false;;
			lblLeftDoubleClick.Visible=false;;
			lblRightDoubleClick.Visible=false;;
			lblMiddleDoubleClick.Visible=false;;
		}
	}
}
