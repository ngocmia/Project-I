using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseEventDemo
{
    public class MouseEvents : Form
    {
        private Label lbl;
        private Button btnReset;
        private TextBox txt;

        public MouseEvents()
        {
            Text = "Mouse Event Demo";
            Size = new Size(400, 650);

            btnReset = new Button();
            btnReset.Parent = this;
            btnReset.Location = new Point(250, 50);
            btnReset.Text = "Reset";
            btnReset.Click += new EventHandler(btnReset_Click);

            lbl = new Label();
            lbl.Parent = this;
            lbl.Location = new Point(50, 50);
            lbl.Size = new Size(150, 25);
            lbl.BorderStyle = BorderStyle.Fixed3D;
            lbl.MouseEnter += new EventHandler(lbl_MouseEnter);
            lbl.MouseHover += new EventHandler(lbl_MouseHover);
            lbl.MouseLeave += new EventHandler(lbl_MouseLeave);
            lbl.MouseDown +=new MouseEventHandler(MouseEvents_MouseDown);
            lbl.MouseUp += new MouseEventHandler(lbl_MouseUp);
            lbl.Click += new EventHandler(lbl_Click);
            lbl.DoubleClick += new EventHandler(lbl_DoubleClick);

            txt = new TextBox();
            txt.Parent = this;
            txt.Location = new Point(50, 100);
            txt.Size = new Size(300, 500);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Multiline = true;
            txt.ScrollBars = ScrollBars.Vertical;
        }

        static void Main()
        {
            Application.Run(new MouseEvents());
        }

        void lbl_DoubleClick(object sender, EventArgs e)
        {

            lbl.Text = "DoubleClick";
            TextBoxDraw("Label DoubleClick");
        }

        void lbl_Click(object sender, EventArgs e)
        {
            lbl.Text = "Click";
            TextBoxDraw("Label Click");
        }

        void lbl_MouseUp(object sender, MouseEventArgs e)
        {
            MouseMsg("MouseUp", e);
        }

        void MouseEvents_MouseDown(object sender, MouseEventArgs e)
        {
            MouseMsg("MouseDown", e);
        }

        void lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.Text = "MouseLeave";
            TextBoxDraw("Label MouseLeave");
        }

        void lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.Text = "MouseHover";
            TextBoxDraw("Label MouseHover");
        }

        void lbl_MouseEnter(object sender, EventArgs e)
        {
            lbl.Text = "MouseEnter";
            TextBoxDraw("Label MouseEnter");
        }

        void btnReset_Click(object sender, EventArgs e)
        {
            lbl.Text = "";
            txt.Text = "";
        }

        private void TextBoxDraw(String str)
        {
            txt.AppendText("\r\n" + str);
        }

        private void MouseMsg(string lblText, MouseEventArgs e)
        {
            lbl.Text = lblText;
            string str;
            str = "Label " + lblText;
            str += "\r\n\tButton: " + e.Button.ToString();
            str += "\r\n\tClicks: " + e.Clicks.ToString();
            str += "\r\n\tX: " + e.X.ToString ();
            str += "\r\n\tY: " + e.Y.ToString ();
            TextBoxDraw(str);          
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MouseEvents
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MouseEvents";
            this.Load += new System.EventHandler(this.MouseEvents_Load);
            this.ResumeLayout(false);

        }

        private void MouseEvents_Load(object sender, EventArgs e)
        {

        }
    }
}