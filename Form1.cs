﻿using System;
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripMenuItem maiThịNgọcToolStripMenuItem;
        private ToolStripMenuItem tuổiToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem dHBachKhoaHaNoiToolStripMenuItem;
        private ToolStripMenuItem dHBachKhoaHaNoiToolStripMenuItem1;
        private System.ComponentModel.IContainer components;

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
			mh.RightMouseDown+=new MouseEventHandler(OnRightMouseDown);
			mh.RightMouseUp+=new MouseEventHandler(OnRightMouseUp);
            mh.MiddleMouseDown += new MouseEventHandler(OnMiddleMouseDown);
            mh.MiddleMouseUp += new MouseEventHandler(OnMiddleMouseUp);
            mh.WheelForward+=new MouseEventHandler(OnWheelForward);
            mh.WheelBackward += new MouseEventHandler(OnWheelBackward);
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Timers.Timer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxChuottrai = new System.Windows.Forms.PictureBox();
            this.pictureBoxChuotPhai = new System.Windows.Forms.PictureBox();
            this.pictureBoxChuotGiua = new System.Windows.Forms.PictureBox();
            this.pictureBoxForward = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackward = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maiThịNgọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dHBachKhoaHaNoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dHBachKhoaHaNoiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChuottrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChuotPhai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChuotGiua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackward)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.AutoReset = false;
            this.timer1.Interval = 750D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
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
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::MouseEventDemo.Properties.Resources.chuot;
            this.pictureBox1.Location = new System.Drawing.Point(212, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxChuottrai
            // 
            this.pictureBoxChuottrai.Enabled = false;
            this.pictureBoxChuottrai.Image = global::MouseEventDemo.Properties.Resources.chuottrai;
            this.pictureBoxChuottrai.Location = new System.Drawing.Point(212, 74);
            this.pictureBoxChuottrai.Name = "pictureBoxChuottrai";
            this.pictureBoxChuottrai.Size = new System.Drawing.Size(281, 327);
            this.pictureBoxChuottrai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChuottrai.TabIndex = 14;
            this.pictureBoxChuottrai.TabStop = false;
            // 
            // pictureBoxChuotPhai
            // 
            this.pictureBoxChuotPhai.Enabled = false;
            this.pictureBoxChuotPhai.Image = global::MouseEventDemo.Properties.Resources.chuotphai;
            this.pictureBoxChuotPhai.Location = new System.Drawing.Point(212, 74);
            this.pictureBoxChuotPhai.Name = "pictureBoxChuotPhai";
            this.pictureBoxChuotPhai.Size = new System.Drawing.Size(281, 327);
            this.pictureBoxChuotPhai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChuotPhai.TabIndex = 15;
            this.pictureBoxChuotPhai.TabStop = false;
            // 
            // pictureBoxChuotGiua
            // 
            this.pictureBoxChuotGiua.Enabled = false;
            this.pictureBoxChuotGiua.Image = global::MouseEventDemo.Properties.Resources.chuotgiua1;
            this.pictureBoxChuotGiua.Location = new System.Drawing.Point(212, 74);
            this.pictureBoxChuotGiua.Name = "pictureBoxChuotGiua";
            this.pictureBoxChuotGiua.Size = new System.Drawing.Size(281, 327);
            this.pictureBoxChuotGiua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChuotGiua.TabIndex = 16;
            this.pictureBoxChuotGiua.TabStop = false;
            // 
            // pictureBoxForward
            // 
            this.pictureBoxForward.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxForward.Enabled = false;
            this.pictureBoxForward.Image = global::MouseEventDemo.Properties.Resources.chuotgiua_up;
            this.pictureBoxForward.Location = new System.Drawing.Point(212, 74);
            this.pictureBoxForward.Name = "pictureBoxForward";
            this.pictureBoxForward.Size = new System.Drawing.Size(281, 327);
            this.pictureBoxForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxForward.TabIndex = 13;
            this.pictureBoxForward.TabStop = false;
            this.pictureBoxForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnWheelBackward_MouseUp);
            // 
            // pictureBoxBackward
            // 
            this.pictureBoxBackward.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBackward.Enabled = false;
            this.pictureBoxBackward.Image = global::MouseEventDemo.Properties.Resources.chuotgiua_down;
            this.pictureBoxBackward.Location = new System.Drawing.Point(212, 74);
            this.pictureBoxBackward.Name = "pictureBoxBackward";
            this.pictureBoxBackward.Size = new System.Drawing.Size(281, 327);
            this.pictureBoxBackward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackward.TabIndex = 12;
            this.pictureBoxBackward.TabStop = false;
            this.pictureBoxBackward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnWheelForward_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maiThịNgọcToolStripMenuItem,
            this.tuổiToolStripMenuItem,
            this.dHBachKhoaHaNoiToolStripMenuItem,
            this.dHBachKhoaHaNoiToolStripMenuItem1});
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aboutUsToolStripMenuItem.Text = "AboutUs";
            // 
            // maiThịNgọcToolStripMenuItem
            // 
            this.maiThịNgọcToolStripMenuItem.Name = "maiThịNgọcToolStripMenuItem";
            this.maiThịNgọcToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.maiThịNgọcToolStripMenuItem.Text = "Mai Thi Ngoc";
            // 
            // tuổiToolStripMenuItem
            // 
            this.tuổiToolStripMenuItem.Name = "tuổiToolStripMenuItem";
            this.tuổiToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.tuổiToolStripMenuItem.Text = "21 tuoi";
            // 
            // dHBachKhoaHaNoiToolStripMenuItem
            // 
            this.dHBachKhoaHaNoiToolStripMenuItem.Name = "dHBachKhoaHaNoiToolStripMenuItem";
            this.dHBachKhoaHaNoiToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.dHBachKhoaHaNoiToolStripMenuItem.Text = "CNTT1.02-K61";
            // 
            // dHBachKhoaHaNoiToolStripMenuItem1
            // 
            this.dHBachKhoaHaNoiToolStripMenuItem1.Name = "dHBachKhoaHaNoiToolStripMenuItem1";
            this.dHBachKhoaHaNoiToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.dHBachKhoaHaNoiToolStripMenuItem1.Text = "DH Bach Khoa Ha Noi";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxChuottrai);
            this.Controls.Add(this.pictureBoxChuotPhai);
            this.Controls.Add(this.pictureBoxChuotGiua);
            this.Controls.Add(this.pictureBoxForward);
            this.Controls.Add(this.pictureBoxBackward);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChuottrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChuotPhai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChuotGiua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackward)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
            pictureBox1.Visible = false;
            pictureBoxChuottrai.Visible = true;
            pictureBoxChuotPhai.Visible = false;
            pictureBoxChuotGiua.Visible = false;
            pictureBoxBackward.Visible = false;
            pictureBoxForward.Visible = false;
            Log.Info("Nhay chuot trai");
        }

		private void OnLeftMouseUp(object sender, MouseEventArgs e)
		{
            pictureBox1.Visible = true;
            pictureBoxChuottrai.Visible = true;
            pictureBoxChuotPhai.Visible = true;
            pictureBoxForward.Visible = true;
            pictureBoxBackward.Visible = true;
            pictureBoxChuotGiua.Visible = true;
        }

        private void OnRightMouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBoxChuottrai.Visible = false;
            pictureBoxChuotPhai.Visible = true;
            pictureBoxChuotGiua.Visible = false;
            pictureBoxBackward.Visible = false;
            pictureBoxForward.Visible = false;
            Log.Info("Nhay chuot phai");
        }

        private void OnRightMouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBoxChuottrai.Visible = true;
            pictureBoxChuotPhai.Visible = true;
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
            pictureBoxChuottrai.Visible = true;
            pictureBoxChuotPhai.Visible = true;
            pictureBoxForward.Visible = true;
            pictureBoxBackward.Visible = true;
            pictureBoxChuotGiua.Visible = true;
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
        
        private void OnWheelForward(object sender, MouseEventArgs e)
        {
            pictureBoxForward.Visible = false;
            pictureBoxBackward.Visible = true;
            pictureBoxChuottrai.Visible = false;
            pictureBox1.Visible = false;
            pictureBoxChuotPhai.Visible = false;
            pictureBoxChuotGiua.Visible = false;
            timer1.Start();
            Log.Info("Chuot cuon len");
        }
        private void OnWheelForward_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBoxChuottrai.Visible = true;
            pictureBoxChuotPhai.Visible = true;
            pictureBoxForward.Visible = true;
            pictureBoxBackward.Visible = true;
            pictureBoxChuotGiua.Visible = true;
        }

        private void OnWheelBackward(object sender, MouseEventArgs e)
        {
            pictureBoxForward.Visible = true;
            pictureBoxBackward.Visible = false;
            pictureBoxChuottrai.Visible = false;
            pictureBox1.Visible = false;
            pictureBoxChuotPhai.Visible = false;
            pictureBoxChuotGiua.Visible = false;
            timer1.Start();
            Log.Info("Chuot cuon xuong");
        }
        private void OnWheelBackward_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBoxChuottrai.Visible = true;
            pictureBoxChuotPhai.Visible = true;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
