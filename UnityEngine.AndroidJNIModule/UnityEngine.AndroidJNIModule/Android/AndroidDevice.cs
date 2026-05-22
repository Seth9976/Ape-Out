using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Android
{
	// Token: 0x0200001A RID: 26
	public class AndroidDevice
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x000029C6 File Offset: 0x00000BC6
		public static bool RunningOnChromeOS()
		{
			return AndroidDevice.RunningOnChromeOSDelegateField();
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000029D2 File Offset: 0x00000BD2
		public static AndroidHardwareType hardwareType
		{
			get
			{
				return AndroidDevice.RunningOnChromeOS() ? AndroidHardwareType.ChromeOS : AndroidHardwareType.Generic;
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000029DF File Offset: 0x00000BDF
		public static void SetSustainedPerformanceMode(bool enabled)
		{
			AndroidDevice.SetSustainedPerformanceModeDelegateField(enabled);
		}

		// Token: 0x04000187 RID: 391
		private static readonly AndroidDevice.RunningOnChromeOSDelegate RunningOnChromeOSDelegateField = IL2CPP.ResolveICall<AndroidDevice.RunningOnChromeOSDelegate>("UnityEngine.Android.AndroidDevice::RunningOnChromeOS");

		// Token: 0x04000188 RID: 392
		private static readonly AndroidDevice.SetSustainedPerformanceModeDelegate SetSustainedPerformanceModeDelegateField = IL2CPP.ResolveICall<AndroidDevice.SetSustainedPerformanceModeDelegate>("UnityEngine.Android.AndroidDevice::SetSustainedPerformanceMode");

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x060002A3 RID: 675
		private delegate bool RunningOnChromeOSDelegate();

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x060002A5 RID: 677
		private delegate void SetSustainedPerformanceModeDelegate(bool enabled);
	}
}
