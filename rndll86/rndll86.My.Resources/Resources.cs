using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

namespace rndll86.My.Resources
{
	[StandardModule]
	[HideModuleName]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[CompilerGenerated]
	internal sealed class Resources
	{
		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(resourceMan, null))
				{
					ResourceManager resourceManager = resourceMan = new ResourceManager("rndll86.Resources", typeof(Resources).Assembly);
				}
				return resourceMan;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return resourceCulture;
			}
			set
			{
				resourceCulture = value;
			}
		}

		internal static Bitmap _1
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("_1", resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		internal static UnmanagedMemoryStream _11 => ResourceManager.GetStream("_11", resourceCulture);

		internal static Bitmap _11165220_871252142916802_1002301553187624596_n
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("_11165220_871252142916802_1002301553187624596_n", resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap _2
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("_2", resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap _3
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("_3", resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap _4
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("_4", resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		internal static UnmanagedMemoryStream barking => ResourceManager.GetStream("barking", resourceCulture);

		internal static string vatican => ResourceManager.GetString("vatican", resourceCulture);
	}
}
