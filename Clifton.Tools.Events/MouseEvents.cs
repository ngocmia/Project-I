using System;
using System.Windows.Forms;

namespace Clifton.Tools.Events
{
	public class MouseHelper
	{
		protected Control control;
		protected MouseButtons lastButton;
		public event MouseEventHandler LeftMouseDown;
		public event MouseEventHandler LeftMouseUp;
		public event MouseEventHandler MiddleMouseDown;
		public event MouseEventHandler MiddleMouseUp;
		public event MouseEventHandler RightMouseDown;
		public event MouseEventHandler RightMouseUp;
		public event MouseEventHandler WheelForward;
		public event MouseEventHandler WheelBackward;

		public Control Control
		{
			get {return control;}
			set
			{
				control=value;
				Initialize();
			}
		}

		public MouseHelper()
		{
		}

		public MouseHelper(Control ctrl)
		{
			Control=ctrl;
		}

		public void AddControl(Control ctrl)
		{
			Control=ctrl;
		}

		protected virtual void Initialize()
		{
			control.MouseDown+=new MouseEventHandler(OnMouseDown);
			control.MouseUp+=new MouseEventHandler(OnMouseUp);
			control.MouseWheel+=new MouseEventHandler(OnMouseWheel);
		}

		private void OnMouseDown(object sender, MouseEventArgs e)
		{
			lastButton=e.Button;

			switch(e.Button)
			{
				case MouseButtons.Left:
				{
					if (LeftMouseDown != null)
					{
						LeftMouseDown(sender, e);
					}
					break;
				}
				case MouseButtons.Middle:
				{
					if (MiddleMouseDown != null)
					{
						MiddleMouseDown(sender, e);
					}
					break;
				}
				case MouseButtons.Right:
				{
					if (RightMouseDown != null)
					{
						RightMouseDown(sender, e);
					}
					break;
				}
			}
		}

		private void OnMouseUp(object sender, MouseEventArgs e)
		{
			switch(e.Button)
			{
				case MouseButtons.Left:
				{
					if (LeftMouseUp != null)
					{
						LeftMouseUp(sender, e);
					}
					break;
				}
				case MouseButtons.Middle:
				{
					if (MiddleMouseUp != null)
					{
						MiddleMouseUp(sender, e);
					}
					break;
				}
				case MouseButtons.Right:
				{
					if (RightMouseUp != null)
					{
						RightMouseUp(sender, e);
					}
					break;
				}
			}
		}

		private void OnMouseWheel(object sender, MouseEventArgs e)
		{
			if (e.Delta > 0)
			{
				if (WheelForward != null)
				{
					WheelForward(sender, e);
				}
			}
			else
			{
				if (WheelBackward != null)
				{
					WheelBackward(sender, e);
				}
			}
		}
	}
}
