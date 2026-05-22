using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000FE RID: 254
	public class Time : Object
	{
		// Token: 0x0600155D RID: 5469 RVA: 0x00053AD0 File Offset: 0x00051CD0
		// Note: this type is marked as 'beforefieldinit'.
		static Time()
		{
			Il2CppClassPointerStore<Time>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Time");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Time>.NativeClassPtr);
			Time.NativeMethodInfoPtr_get_time_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100665128);
			Time.NativeMethodInfoPtr_get_timeSinceLevelLoad_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100665129);
			Time.NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100665130);
			Time.NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100665131);
			Time.NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100665132);
			Time.NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100665133);
			Time.NativeMethodInfoPtr_set_fixedDeltaTime_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100665134);
			Time.NativeMethodInfoPtr_get_maximumDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100665135);
			Time.NativeMethodInfoPtr_get_smoothDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100665136);
			Time.NativeMethodInfoPtr_get_timeScale_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100665137);
			Time.NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100665138);
			Time.NativeMethodInfoPtr_get_frameCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100665139);
			Time.NativeMethodInfoPtr_get_renderedFrameCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100665140);
			Time.NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100665141);
			Time.get_timeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_timeAsDoubleDelegate>("UnityEngine.Time::get_timeAsDouble");
			Time.get_timeSinceLevelLoadAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_timeSinceLevelLoadAsDoubleDelegate>("UnityEngine.Time::get_timeSinceLevelLoadAsDouble");
			Time.get_fixedTimeDelegateField = IL2CPP.ResolveICall<Time.get_fixedTimeDelegate>("UnityEngine.Time::get_fixedTime");
			Time.get_fixedTimeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_fixedTimeAsDoubleDelegate>("UnityEngine.Time::get_fixedTimeAsDouble");
			Time.get_unscaledTimeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_unscaledTimeAsDoubleDelegate>("UnityEngine.Time::get_unscaledTimeAsDouble");
			Time.get_fixedUnscaledTimeDelegateField = IL2CPP.ResolveICall<Time.get_fixedUnscaledTimeDelegate>("UnityEngine.Time::get_fixedUnscaledTime");
			Time.get_fixedUnscaledTimeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_fixedUnscaledTimeAsDoubleDelegate>("UnityEngine.Time::get_fixedUnscaledTimeAsDouble");
			Time.get_fixedUnscaledDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_fixedUnscaledDeltaTimeDelegate>("UnityEngine.Time::get_fixedUnscaledDeltaTime");
			Time.set_maximumDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_maximumDeltaTimeDelegate>("UnityEngine.Time::set_maximumDeltaTime");
			Time.get_maximumParticleDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_maximumParticleDeltaTimeDelegate>("UnityEngine.Time::get_maximumParticleDeltaTime");
			Time.set_maximumParticleDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_maximumParticleDeltaTimeDelegate>("UnityEngine.Time::set_maximumParticleDeltaTime");
			Time.get_realtimeSinceStartupAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_realtimeSinceStartupAsDoubleDelegate>("UnityEngine.Time::get_realtimeSinceStartupAsDouble");
			Time.get_captureDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_captureDeltaTimeDelegate>("UnityEngine.Time::get_captureDeltaTime");
			Time.set_captureDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_captureDeltaTimeDelegate>("UnityEngine.Time::set_captureDeltaTime");
			Time.get_inFixedTimeStepDelegateField = IL2CPP.ResolveICall<Time.get_inFixedTimeStepDelegate>("UnityEngine.Time::get_inFixedTimeStep");
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x00053CFC File Offset: 0x00051EFC
		public unsafe static float time
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 498556, RefRangeEnd = 498564, XrefRangeStart = 498552, XrefRangeEnd = 498556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_time_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x00053D2C File Offset: 0x00051F2C
		public unsafe static float timeSinceLevelLoad
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 498568, RefRangeEnd = 498584, XrefRangeStart = 498564, XrefRangeEnd = 498568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_timeSinceLevelLoad_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x00053D5C File Offset: 0x00051F5C
		public unsafe static float deltaTime
		{
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 498588, RefRangeEnd = 498631, XrefRangeStart = 498584, XrefRangeEnd = 498588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001561 RID: 5473 RVA: 0x00053D8C File Offset: 0x00051F8C
		public unsafe static float unscaledTime
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 498635, RefRangeEnd = 498641, XrefRangeStart = 498631, XrefRangeEnd = 498635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x00053DBC File Offset: 0x00051FBC
		public unsafe static float unscaledDeltaTime
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 317902, RefRangeEnd = 317906, XrefRangeStart = 317902, XrefRangeEnd = 317906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x00053DEC File Offset: 0x00051FEC
		// (set) Token: 0x06001564 RID: 5476 RVA: 0x00053E1C File Offset: 0x0005201C
		public unsafe static float fixedDeltaTime
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 498645, RefRangeEnd = 498651, XrefRangeStart = 498641, XrefRangeEnd = 498645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 498655, RefRangeEnd = 498656, XrefRangeStart = 498651, XrefRangeEnd = 498655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_set_fixedDeltaTime_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x00053E50 File Offset: 0x00052050
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x0000BCCC File Offset: 0x00009ECC
		public unsafe static float maximumDeltaTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498656, XrefRangeEnd = 498660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_maximumDeltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Time.set_maximumDeltaTimeDelegateField(value);
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x00053E80 File Offset: 0x00052080
		public unsafe static float smoothDeltaTime
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 498664, RefRangeEnd = 498672, XrefRangeStart = 498660, XrefRangeEnd = 498664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_smoothDeltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x00053EB0 File Offset: 0x000520B0
		// (set) Token: 0x06001568 RID: 5480 RVA: 0x00053EE0 File Offset: 0x000520E0
		public unsafe static float timeScale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498672, XrefRangeEnd = 498676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_timeScale_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 498680, RefRangeEnd = 498681, XrefRangeStart = 498676, XrefRangeEnd = 498680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x00053F14 File Offset: 0x00052114
		public unsafe static int frameCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498681, XrefRangeEnd = 498685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_frameCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x00053F44 File Offset: 0x00052144
		public unsafe static int renderedFrameCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498685, XrefRangeEnd = 498689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_renderedFrameCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x00053F74 File Offset: 0x00052174
		public unsafe static float realtimeSinceStartup
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 498693, RefRangeEnd = 498701, XrefRangeStart = 498689, XrefRangeEnd = 498693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0000BC63 File Offset: 0x00009E63
		public Time(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x0000BC6C File Offset: 0x00009E6C
		public static double timeAsDouble
		{
			get
			{
				return Time.get_timeAsDoubleDelegateField();
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x0000BC78 File Offset: 0x00009E78
		public static double timeSinceLevelLoadAsDouble
		{
			get
			{
				return Time.get_timeSinceLevelLoadAsDoubleDelegateField();
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x0000BC84 File Offset: 0x00009E84
		public static float fixedTime
		{
			get
			{
				return Time.get_fixedTimeDelegateField();
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x0000BC90 File Offset: 0x00009E90
		public static double fixedTimeAsDouble
		{
			get
			{
				return Time.get_fixedTimeAsDoubleDelegateField();
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x0000BC9C File Offset: 0x00009E9C
		public static double unscaledTimeAsDouble
		{
			get
			{
				return Time.get_unscaledTimeAsDoubleDelegateField();
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x0000BCA8 File Offset: 0x00009EA8
		public static float fixedUnscaledTime
		{
			get
			{
				return Time.get_fixedUnscaledTimeDelegateField();
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		public static double fixedUnscaledTimeAsDouble
		{
			get
			{
				return Time.get_fixedUnscaledTimeAsDoubleDelegateField();
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x0000BCC0 File Offset: 0x00009EC0
		public static float fixedUnscaledDeltaTime
		{
			get
			{
				return Time.get_fixedUnscaledDeltaTimeDelegateField();
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x0000BCD9 File Offset: 0x00009ED9
		// (set) Token: 0x06001577 RID: 5495 RVA: 0x0000BCE5 File Offset: 0x00009EE5
		public static float maximumParticleDeltaTime
		{
			get
			{
				return Time.get_maximumParticleDeltaTimeDelegateField();
			}
			set
			{
				Time.set_maximumParticleDeltaTimeDelegateField(value);
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x0000BCF2 File Offset: 0x00009EF2
		public static double realtimeSinceStartupAsDouble
		{
			get
			{
				return Time.get_realtimeSinceStartupAsDoubleDelegateField();
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x0000BCFE File Offset: 0x00009EFE
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x0000BD0A File Offset: 0x00009F0A
		public static float captureDeltaTime
		{
			get
			{
				return Time.get_captureDeltaTimeDelegateField();
			}
			set
			{
				Time.set_captureDeltaTimeDelegateField(value);
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x00053FA4 File Offset: 0x000521A4
		// (set) Token: 0x0600157C RID: 5500 RVA: 0x0000BD17 File Offset: 0x00009F17
		public static int captureFramerate
		{
			get
			{
				return (Time.captureDeltaTime == 0f) ? 0 : ((int)Mathf.Round(1f / Time.captureDeltaTime));
			}
			set
			{
				Time.captureDeltaTime = ((value == 0) ? 0f : (1f / (float)value));
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x0000BD32 File Offset: 0x00009F32
		public static bool inFixedTimeStep
		{
			get
			{
				return Time.get_inFixedTimeStepDelegateField();
			}
		}

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_Static_get_Single_0;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceLevelLoad_Public_Static_get_Single_0;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_set_fixedDeltaTime_Public_Static_set_Void_Single_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_get_maximumDeltaTime_Public_Static_get_Single_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_get_smoothDeltaTime_Public_Static_get_Single_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr_get_timeScale_Public_Static_get_Single_0;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr_get_frameCount_Public_Static_get_Int32_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_get_renderedFrameCount_Public_Static_get_Int32_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0;

		// Token: 0x040010AD RID: 4269
		private static readonly Time.get_timeAsDoubleDelegate get_timeAsDoubleDelegateField;

		// Token: 0x040010AE RID: 4270
		private static readonly Time.get_timeSinceLevelLoadAsDoubleDelegate get_timeSinceLevelLoadAsDoubleDelegateField;

		// Token: 0x040010AF RID: 4271
		private static readonly Time.get_fixedTimeDelegate get_fixedTimeDelegateField;

		// Token: 0x040010B0 RID: 4272
		private static readonly Time.get_fixedTimeAsDoubleDelegate get_fixedTimeAsDoubleDelegateField;

		// Token: 0x040010B1 RID: 4273
		private static readonly Time.get_unscaledTimeAsDoubleDelegate get_unscaledTimeAsDoubleDelegateField;

		// Token: 0x040010B2 RID: 4274
		private static readonly Time.get_fixedUnscaledTimeDelegate get_fixedUnscaledTimeDelegateField;

		// Token: 0x040010B3 RID: 4275
		private static readonly Time.get_fixedUnscaledTimeAsDoubleDelegate get_fixedUnscaledTimeAsDoubleDelegateField;

		// Token: 0x040010B4 RID: 4276
		private static readonly Time.get_fixedUnscaledDeltaTimeDelegate get_fixedUnscaledDeltaTimeDelegateField;

		// Token: 0x040010B5 RID: 4277
		private static readonly Time.set_maximumDeltaTimeDelegate set_maximumDeltaTimeDelegateField;

		// Token: 0x040010B6 RID: 4278
		private static readonly Time.get_maximumParticleDeltaTimeDelegate get_maximumParticleDeltaTimeDelegateField;

		// Token: 0x040010B7 RID: 4279
		private static readonly Time.set_maximumParticleDeltaTimeDelegate set_maximumParticleDeltaTimeDelegateField;

		// Token: 0x040010B8 RID: 4280
		private static readonly Time.get_realtimeSinceStartupAsDoubleDelegate get_realtimeSinceStartupAsDoubleDelegateField;

		// Token: 0x040010B9 RID: 4281
		private static readonly Time.get_captureDeltaTimeDelegate get_captureDeltaTimeDelegateField;

		// Token: 0x040010BA RID: 4282
		private static readonly Time.set_captureDeltaTimeDelegate set_captureDeltaTimeDelegateField;

		// Token: 0x040010BB RID: 4283
		private static readonly Time.get_inFixedTimeStepDelegate get_inFixedTimeStepDelegateField;

		// Token: 0x0200083B RID: 2107
		// (Invoke) Token: 0x06002E78 RID: 11896
		private delegate double get_timeAsDoubleDelegate();

		// Token: 0x0200083C RID: 2108
		// (Invoke) Token: 0x06002E7A RID: 11898
		private delegate double get_timeSinceLevelLoadAsDoubleDelegate();

		// Token: 0x0200083D RID: 2109
		// (Invoke) Token: 0x06002E7C RID: 11900
		private delegate float get_fixedTimeDelegate();

		// Token: 0x0200083E RID: 2110
		// (Invoke) Token: 0x06002E7E RID: 11902
		private delegate double get_fixedTimeAsDoubleDelegate();

		// Token: 0x0200083F RID: 2111
		// (Invoke) Token: 0x06002E80 RID: 11904
		private delegate double get_unscaledTimeAsDoubleDelegate();

		// Token: 0x02000840 RID: 2112
		// (Invoke) Token: 0x06002E82 RID: 11906
		private delegate float get_fixedUnscaledTimeDelegate();

		// Token: 0x02000841 RID: 2113
		// (Invoke) Token: 0x06002E84 RID: 11908
		private delegate double get_fixedUnscaledTimeAsDoubleDelegate();

		// Token: 0x02000842 RID: 2114
		// (Invoke) Token: 0x06002E86 RID: 11910
		private delegate float get_fixedUnscaledDeltaTimeDelegate();

		// Token: 0x02000843 RID: 2115
		// (Invoke) Token: 0x06002E88 RID: 11912
		private delegate void set_maximumDeltaTimeDelegate(float value);

		// Token: 0x02000844 RID: 2116
		// (Invoke) Token: 0x06002E8A RID: 11914
		private delegate float get_maximumParticleDeltaTimeDelegate();

		// Token: 0x02000845 RID: 2117
		// (Invoke) Token: 0x06002E8C RID: 11916
		private delegate void set_maximumParticleDeltaTimeDelegate(float value);

		// Token: 0x02000846 RID: 2118
		// (Invoke) Token: 0x06002E8E RID: 11918
		private delegate double get_realtimeSinceStartupAsDoubleDelegate();

		// Token: 0x02000847 RID: 2119
		// (Invoke) Token: 0x06002E90 RID: 11920
		private delegate float get_captureDeltaTimeDelegate();

		// Token: 0x02000848 RID: 2120
		// (Invoke) Token: 0x06002E92 RID: 11922
		private delegate void set_captureDeltaTimeDelegate(float value);

		// Token: 0x02000849 RID: 2121
		// (Invoke) Token: 0x06002E94 RID: 11924
		private delegate bool get_inFixedTimeStepDelegate();
	}
}
