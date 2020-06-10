using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace rndll86
{
	[DesignerGenerated]
	public class lataj_kurde : Form
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private IContainer components;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		private int a;

		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return _PictureBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_PictureBox1 = value;
			}
		}

		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return _Timer1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				EventHandler value2 = Timer1_Tick;
				if (_Timer1 != null)
				{
					_Timer1.Tick -= value2;
				}
				_Timer1 = value;
				if (_Timer1 != null)
				{
					_Timer1.Tick += value2;
				}
			}
		}

		[DebuggerNonUserCode]
		public lataj_kurde()
		{
			base.Load += lataj_kurde_Load;
			__ENCAddToList(this);
			InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			checked
			{
				lock (__ENCList)
				{
					if (__ENCList.Count == __ENCList.Capacity)
					{
						int num = 0;
						int num2 = __ENCList.Count - 1;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							WeakReference weakReference = __ENCList[num3];
							if (weakReference.IsAlive)
							{
								if (num3 != num)
								{
									__ENCList[num] = __ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						__ENCList.RemoveRange(num, __ENCList.Count - num);
						__ENCList.Capacity = __ENCList.Count;
					}
					__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if ((disposing && components != null) ? true : false)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rndll86.lataj_kurde));
			PictureBox1 = new System.Windows.Forms.PictureBox();
			Timer1 = new System.Windows.Forms.Timer(components);
			((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
			SuspendLayout();
			PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			System.Drawing.Point point2 = PictureBox1.Location = new System.Drawing.Point(0, 0);
			PictureBox1.Name = "PictureBox1";
			System.Drawing.Size size2 = PictureBox1.Size = new System.Drawing.Size(319, 209);
			PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			PictureBox1.TabIndex = 0;
			PictureBox1.TabStop = false;
			Timer1.Interval = 500;
			System.Drawing.SizeF sizeF2 = AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size2 = (ClientSize = new System.Drawing.Size(319, 209));
			Controls.Add(PictureBox1);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			Name = "lataj_kurde";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			Text = "lataj_kurde";
			TopMost = true;
			((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
			ResumeLayout(false);
		}

		private void lataj_kurde_Load(object sender, EventArgs e)
		{
			Visible = true;
			int num = Screen.PrimaryScreen.WorkingArea.Width;
			checked
			{
				int y = Screen.PrimaryScreen.WorkingArea.Height - Height;
				while (num != Screen.PrimaryScreen.WorkingArea.Width - Width)
				{
					num--;
					Point point2 = Location = new Point(num, y);
				}
				a = 0;
				Timer1.Start();
			}
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			checked
			{
				a++;
				if (a == 100)
				{
					Close();
				}
			}
		}
	}
}
