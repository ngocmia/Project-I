using System;
using System.Windows.Forms;
using System.Web;
using Clifton.Tools.Events;
using System.IO;
using System.Text;
using log4net;
using System.Drawing;



namespace MouseEventDemo
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Timers.Timer timer1;
        private PictureBox pictureBoxChuottrai;
        private PictureBox pictureBoxChuotPhai;
        private PictureBox pictureBoxChuotGiua;
        private PictureBox pictureBoxForward;
        private PictureBox pictureBoxBackward;
        private Label label2;
        private Label label1;



        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public Form1()
		{
			//A
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			MouseHelper mh=new MouseHelper(this);
            mh.AddControl(pictureBox1);
			mh.LeftMouseDown+=new MouseEventHandler(OnLeftMouseDown);
			mh.LeftMouseUp+=new MouseEventHandler(OnLeftMouseUp);
			mh.MiddleMouseDown+=new MouseEventHandler(OnMiddleMouseDown);
			mh.MiddleMouseUp+=new MouseEventHandler(OnMiddleMouseUp);
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
            this.timer1 = new System.Timers.Timer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxChuotPhai = new System.Windows.Forms.PictureBox();
            this.pictureBoxChuottrai = new System.Windows.Forms.PictureBox();
            this.pictureBoxChuotGiua = new System.Windows.Forms.PictureBox();
            this.pictureBoxForward = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackward = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChuotPhai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChuottrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChuotGiua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackward)).BeginInit();
          
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.AutoReset = false;
            this.timer1.Interval = 750D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MouseEventDemo.Properties.Resources.chuot;
            this.pictureBox1.Location = new System.Drawing.Point(196, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // pictureBoxChuotPhai
            // 
            this.pictureBoxChuotPhai.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChuotPhai.BackgroundImage = global::MouseEventDemo.Properties.Resources.chuot;
            this.pictureBoxChuotPhai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxChuotPhai.Image = global::MouseEventDemo.Properties.Resources.chuot_phai;
            this.pictureBoxChuotPhai.Location = new System.Drawing.Point(196, 57);
            this.pictureBoxChuotPhai.Name = "pictureBoxChuotPhai";
            this.pictureBoxChuotPhai.Size = new System.Drawing.Size(281, 327);
            this.pictureBoxChuotPhai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChuotPhai.TabIndex = 15;
            this.pictureBoxChuotPhai.TabStop = false;
            this.pictureBoxChuotPhai.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxChuotPhai_MouseMove);
            // 
            // pictureBoxChuottrai
            // 
            this.pictureBoxChuottrai.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChuottrai.BackgroundImage = global::MouseEventDemo.Properties.Resources.chuot;
            this.pictureBoxChuottrai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxChuottrai.Image = global::MouseEventDemo.Properties.Resources.chuot_trai_Recovered1;
            this.pictureBoxChuottrai.Location = new System.Drawing.Point(196, 57);
            this.pictureBoxChuottrai.Name = "pictureBoxChuottrai";
            this.pictureBoxChuottrai.Size = new System.Drawing.Size(281, 327);
            this.pictureBoxChuottrai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChuottrai.TabIndex = 14;
            this.pictureBoxChuottrai.TabStop = false;
            this.pictureBoxChuottrai.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxChuottrai_MouseMove);
            // 
            // pictureBoxChuotGiua
            // 
            this.pictureBoxChuotGiua.Image = global::MouseEventDemo.Properties.Resources.chuotgiua1;
            this.pictureBoxChuotGiua.Location = new System.Drawing.Point(196, 57);
            this.pictureBoxChuotGiua.Name = "pictureBoxChuotGiua";
            this.pictureBoxChuotGiua.Size = new System.Drawing.Size(281, 327);
            this.pictureBoxChuotGiua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChuotGiua.TabIndex = 16;
            this.pictureBoxChuotGiua.TabStop = false;
            this.pictureBoxChuotGiua.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxChuotGiua_MouseMove);
            // 
            // pictureBoxForward
            // 
            this.pictureBoxForward.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxForward.Image = global::MouseEventDemo.Properties.Resources.chuotgiua_up;
            this.pictureBoxForward.Location = new System.Drawing.Point(196, 57);
            this.pictureBoxForward.Name = "pictureBoxForward";
            this.pictureBoxForward.Size = new System.Drawing.Size(281, 327);
            this.pictureBoxForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxForward.TabIndex = 13;
            this.pictureBoxForward.TabStop = false;
            this.pictureBoxForward.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxForward_MouseMove);
            this.pictureBoxForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnWheelBackward_MouseUp);
            // 
            // pictureBoxBackward
            // 
            this.pictureBoxBackward.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBackward.Image = global::MouseEventDemo.Properties.Resources.chuotgiua_down;
            this.pictureBoxBackward.Location = new System.Drawing.Point(196, 57);
            this.pictureBoxBackward.Name = "pictureBoxBackward";
            this.pictureBoxBackward.Size = new System.Drawing.Size(281, 327);
            this.pictureBoxBackward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackward.TabIndex = 12;
            this.pictureBoxBackward.TabStop = false;
            this.pictureBoxBackward.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBackward_MouseMove);
            this.pictureBoxBackward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnWheelForward_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 14);
            this.label2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxChuotPhai);
            this.Controls.Add(this.pictureBoxChuottrai);
            this.Controls.Add(this.pictureBoxChuotGiua);
            this.Controls.Add(this.pictureBoxForward);
            this.Controls.Add(this.pictureBoxBackward);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChuotPhai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChuottrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChuotGiua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackward)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args) 
		{
			Form1 form=new Form1();
			Application.Run(form);
		}
       
		private void OnLeftMouseDown(object sender, MouseEventArgs e)
		{
		
            pictureBoxChuottrai.Visible = true;
            pictureBox1.Visible = false;
            pictureBoxBackward.Visible = false;
            pictureBoxForward.Visible = false;
            pictureBoxChuotPhai.Visible = false;
            pictureBoxChuotGiua.Visible = false;
            Log.Info("Nhay chuot trai");
        }

		private void OnLeftMouseUp(object sender, MouseEventArgs e)
		{
            pictureBox1.Visible = true;
            pictureBoxChuotPhai.Visible = true;
            pictureBoxChuottrai.Visible = true;
            pictureBoxForward.Visible = true;
            pictureBoxBackward.Visible = true;
            pictureBoxChuotGiua.Visible = true;
        }

        private void OnMiddleMouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxChuotGiua.Visible = true;
            pictureBoxChuottrai.Visible = false;
            pictureBox1.Visible = false;
            pictureBoxBackward.Visible = false;
            pictureBoxForward.Visible = false;
            pictureBoxChuotPhai.Visible = false;
            Log.Info("Nhay chuot giua");
        }
        
		private void OnMiddleMouseUp(object sender, MouseEventArgs e)
		{
            pictureBox1.Visible = true;
            pictureBoxChuotPhai.Visible = true;
            pictureBoxChuottrai.Visible = true;
            pictureBoxForward.Visible = true;
            pictureBoxBackward.Visible = true;
			pictureBoxChuotGiua.Visible=true;
        }

        private void OnRightMouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxChuotPhai.Visible = true;
            pictureBoxChuottrai.Visible = false;
            pictureBox1.Visible = false;
            pictureBoxBackward.Visible = false;
            pictureBoxForward.Visible = false;
            pictureBoxChuotGiua.Visible = false;
            Log.Info("Nhay chuot phai");
        }

		private void OnRightMouseUp(object sender, MouseEventArgs e)
		{
            pictureBox1.Visible = true;
            pictureBoxChuotPhai.Visible = true;
            pictureBoxChuottrai.Visible = true;
            pictureBoxForward.Visible = true;
            pictureBoxBackward.Visible = true;
            pictureBoxChuotGiua.Visible = true;
        }

		private void OnWheelBackward(object sender, MouseEventArgs e)
		{
			pictureBoxForward.Visible=true;
			pictureBoxBackward.Visible=false;
            pictureBoxChuottrai.Visible = false ;
            pictureBox1.Visible = false;
            pictureBoxChuotPhai.Visible = false;
            pictureBoxChuotGiua.Visible = false;
            timer1.Start();
            Log.Info("Chuot cuon xuong");
        }
        
        private void OnWheelForward(object sender, MouseEventArgs e)
		{
			pictureBoxForward.Visible=false;
			pictureBoxBackward.Visible=true;
            pictureBoxChuottrai.Visible = false;
            pictureBox1.Visible = false;
            pictureBoxChuotPhai.Visible = false;
            pictureBoxChuotGiua.Visible = false;
            timer1.Start();
            Log.Info("Chuot cuon len");
        }

		private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
            pictureBox1.Visible = true; 
            pictureBoxChuottrai.Visible=false;
			pictureBoxChuotPhai.Visible=false;;
	        pictureBoxChuotGiua.Visible=false;;
			pictureBoxForward.Visible=false;;
            pictureBoxBackward.Visible = false;
        }  

        private void OnWheelBackward_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBoxChuotPhai.Visible = true;
            pictureBoxChuottrai.Visible = true;
            pictureBoxForward.Visible = true;
            pictureBoxBackward.Visible = true;
            pictureBoxChuotGiua.Visible = true;
        }

        private void OnWheelForward_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBoxChuotPhai.Visible = true;
            pictureBoxChuottrai.Visible = true;
            pictureBoxForward.Visible = true;
            pictureBoxBackward.Visible = true;
            pictureBoxChuotGiua.Visible = true;
        }
      
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
            label1.Location = new Point(e.X - label1.Width, e.Y);
            label2.Location = new Point(e.X, e.Y - label2.Height);
            Log.Info("Toa do chuot di chuyen: " + (e.X) + - + (e.Y));
        }
        private void pictureBox1_MouseMove( object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
            label1.Location = new Point(e.X - label1.Width + pictureBoxChuotGiua.Location.X, e.Y + pictureBoxChuotPhai.Location.Y);
            label2.Location = new Point(e.X + pictureBoxChuotPhai.Location.X, e.Y - label2.Height + pictureBoxChuotPhai.Location.Y);
            Log.Info("Toa do chuot di chuyen: " + (e.X ) + - +(e.Y ));
        }
        private void pictureBoxChuotGiua_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
            label1.Location = new Point(e.X - label1.Width + pictureBoxChuotGiua.Location.X, e.Y + pictureBoxChuotPhai.Location.Y);
            label2.Location = new Point(e.X + pictureBoxChuotPhai.Location.X, e.Y - label2.Height + pictureBoxChuotPhai.Location.Y);
        }

        private void pictureBoxChuotPhai_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
            label1.Location = new Point(e.X - label1.Width + pictureBoxChuotPhai.Location.X, e.Y + pictureBoxChuotPhai.Location.Y);
            label2.Location = new Point(e.X + pictureBoxChuotPhai.Location.X, e.Y - label2.Height + pictureBoxChuotPhai.Location.Y);
        }

        private void pictureBoxForward_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
            label1.Location = new Point(e.X - label1.Width + pictureBoxChuotPhai.Location.X, e.Y + pictureBoxChuotPhai.Location.Y);
            label2.Location = new Point(e.X + pictureBoxChuotPhai.Location.X, e.Y - label2.Height + pictureBoxChuotPhai.Location.Y);
        }

        private void pictureBoxBackward_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
            label1.Location = new Point(e.X - label1.Width + pictureBoxChuotPhai.Location.X, e.Y + pictureBoxChuotPhai.Location.Y);
            label2.Location = new Point(e.X + pictureBoxChuotPhai.Location.X, e.Y - label2.Height + pictureBoxChuotPhai.Location.Y);
        }

        private void pictureBoxChuottrai_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
            label1.Location = new Point(e.X - label1.Width + pictureBoxChuotPhai.Location.X, e.Y + pictureBoxChuotPhai.Location.Y);
            label2.Location = new Point(e.X + pictureBoxChuotPhai.Location.X, e.Y - label2.Height + pictureBoxChuotPhai.Location.Y);
        }
        private void label1_MouseMove(object sender,MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
            label1.Location = new Point(e.X - label1.Width, e.Y);
            label2.Location = new Point(e.X, e.Y - label2.Height);
        }
        private void label2_MouseMove( object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
            label1.Location = new Point(e.X - label1.Width, e.Y);
            label2.Location = new Point(e.X, e.Y - label2.Height);
        }
        private static readonly ILog Log = LogManager.GetLogger(typeof(Form1));

    }
}
