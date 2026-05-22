using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	public class LocationService
	{
		// Token: 0x0600009E RID: 158 RVA: 0x000023A9 File Offset: 0x000005A9
		public static bool IsServiceEnabledByUser()
		{
			return LocationService.IsServiceEnabledByUserDelegateField();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000023B5 File Offset: 0x000005B5
		public static LocationServiceStatus GetLocationStatus()
		{
			return LocationService.GetLocationStatusDelegateField();
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000023C1 File Offset: 0x000005C1
		public static void SetDesiredAccuracy(float value)
		{
			LocationService.SetDesiredAccuracyDelegateField(value);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000023CE File Offset: 0x000005CE
		public static void SetDistanceFilter(float value)
		{
			LocationService.SetDistanceFilterDelegateField(value);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000023DB File Offset: 0x000005DB
		public static void StartUpdatingLocation()
		{
			LocationService.StartUpdatingLocationDelegateField();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000023E7 File Offset: 0x000005E7
		public static void StopUpdatingLocation()
		{
			LocationService.StopUpdatingLocationDelegateField();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000023F3 File Offset: 0x000005F3
		public static bool IsHeadingUpdatesEnabled()
		{
			return LocationService.IsHeadingUpdatesEnabledDelegateField();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000023FF File Offset: 0x000005FF
		public static void SetHeadingUpdatesEnabled(bool value)
		{
			LocationService.SetHeadingUpdatesEnabledDelegateField(value);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00003D5C File Offset: 0x00001F5C
		public bool isEnabledByUser
		{
			get
			{
				return LocationService.IsServiceEnabledByUser();
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00003D74 File Offset: 0x00001F74
		public LocationServiceStatus status
		{
			get
			{
				return LocationService.GetLocationStatus();
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000240C File Offset: 0x0000060C
		public void Start(float desiredAccuracyInMeters, float updateDistanceInMeters)
		{
			LocationService.SetDesiredAccuracy(desiredAccuracyInMeters);
			LocationService.SetDistanceFilter(updateDistanceInMeters);
			LocationService.StartUpdatingLocation();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002423 File Offset: 0x00000623
		public void Start(float desiredAccuracyInMeters)
		{
			this.Start(desiredAccuracyInMeters, 10f);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002433 File Offset: 0x00000633
		public void Start()
		{
			this.Start(10f, 10f);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002447 File Offset: 0x00000647
		public void Stop()
		{
			LocationService.StopUpdatingLocation();
		}

		// Token: 0x04000096 RID: 150
		private static readonly LocationService.IsServiceEnabledByUserDelegate IsServiceEnabledByUserDelegateField = IL2CPP.ResolveICall<LocationService.IsServiceEnabledByUserDelegate>("UnityEngine.LocationService::IsServiceEnabledByUser");

		// Token: 0x04000097 RID: 151
		private static readonly LocationService.GetLocationStatusDelegate GetLocationStatusDelegateField = IL2CPP.ResolveICall<LocationService.GetLocationStatusDelegate>("UnityEngine.LocationService::GetLocationStatus");

		// Token: 0x04000098 RID: 152
		private static readonly LocationService.SetDesiredAccuracyDelegate SetDesiredAccuracyDelegateField = IL2CPP.ResolveICall<LocationService.SetDesiredAccuracyDelegate>("UnityEngine.LocationService::SetDesiredAccuracy");

		// Token: 0x04000099 RID: 153
		private static readonly LocationService.SetDistanceFilterDelegate SetDistanceFilterDelegateField = IL2CPP.ResolveICall<LocationService.SetDistanceFilterDelegate>("UnityEngine.LocationService::SetDistanceFilter");

		// Token: 0x0400009A RID: 154
		private static readonly LocationService.StartUpdatingLocationDelegate StartUpdatingLocationDelegateField = IL2CPP.ResolveICall<LocationService.StartUpdatingLocationDelegate>("UnityEngine.LocationService::StartUpdatingLocation");

		// Token: 0x0400009B RID: 155
		private static readonly LocationService.StopUpdatingLocationDelegate StopUpdatingLocationDelegateField = IL2CPP.ResolveICall<LocationService.StopUpdatingLocationDelegate>("UnityEngine.LocationService::StopUpdatingLocation");

		// Token: 0x0400009C RID: 156
		private static readonly LocationService.IsHeadingUpdatesEnabledDelegate IsHeadingUpdatesEnabledDelegateField = IL2CPP.ResolveICall<LocationService.IsHeadingUpdatesEnabledDelegate>("UnityEngine.LocationService::IsHeadingUpdatesEnabled");

		// Token: 0x0400009D RID: 157
		private static readonly LocationService.SetHeadingUpdatesEnabledDelegate SetHeadingUpdatesEnabledDelegateField = IL2CPP.ResolveICall<LocationService.SetHeadingUpdatesEnabledDelegate>("UnityEngine.LocationService::SetHeadingUpdatesEnabled");

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x060000FC RID: 252
		private delegate bool IsServiceEnabledByUserDelegate();

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x060000FE RID: 254
		private delegate LocationServiceStatus GetLocationStatusDelegate();

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x06000100 RID: 256
		private delegate void SetDesiredAccuracyDelegate(float value);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000102 RID: 258
		private delegate void SetDistanceFilterDelegate(float value);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000104 RID: 260
		private delegate void StartUpdatingLocationDelegate();

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000106 RID: 262
		private delegate void StopUpdatingLocationDelegate();

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000108 RID: 264
		private delegate bool IsHeadingUpdatesEnabledDelegate();

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x0600010A RID: 266
		private delegate void SetHeadingUpdatesEnabledDelegate(bool value);
	}
}
