using Microsoft.VisualBasic.CompilerServices;
using rndll86.My.Resources;
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
	public class rek1 : Form
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private IContainer components;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("LinkLabel1")]
		private LinkLabel _LinkLabel1;

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

		internal virtual LinkLabel LinkLabel1
		{
			[DebuggerNonUserCode]
			get
			{
				return _LinkLabel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = LinkLabel1_LinkClicked;
				if (_LinkLabel1 != null)
				{
					_LinkLabel1.LinkClicked -= value2;
				}
				_LinkLabel1 = value;
				if (_LinkLabel1 != null)
				{
					_LinkLabel1.LinkClicked += value2;
				}
			}
		}

		[DebuggerNonUserCode]
		public rek1()
		{
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
			PictureBox1 = new System.Windows.Forms.PictureBox();
			LinkLabel1 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
			SuspendLayout();
			PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			PictureBox1.Image = rndll86.My.Resources.Resources._1;
			System.Drawing.Point point2 = PictureBox1.Location = new System.Drawing.Point(0, 0);
			PictureBox1.Name = "PictureBox1";
			System.Drawing.Size size2 = PictureBox1.Size = new System.Drawing.Size(437, 255);
			PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			PictureBox1.TabIndex = 0;
			PictureBox1.TabStop = false;
			LinkLabel1.AutoSize = true;
			point2 = (LinkLabel1.Location = new System.Drawing.Point(12, 233));
			LinkLabel1.Name = "LinkLabel1";
			size2 = (LinkLabel1.Size = new System.Drawing.Size(176, 13));
			LinkLabel1.TabIndex = 1;
			LinkLabel1.TabStop = true;
			LinkLabel1.Text = "JAN PAWEŁ DRUGI - TAJEMNICE";
			System.Drawing.SizeF sizeF2 = AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size2 = (ClientSize = new System.Drawing.Size(437, 255));
			Controls.Add(LinkLabel1);
			Controls.Add(PictureBox1);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			Name = "rek1";
			ShowIcon = false;
			ShowInTaskbar = false;
			Text = "rek1";
			TopMost = true;
			((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://karachan.org/b/");
			Close();
		}
	}
}
