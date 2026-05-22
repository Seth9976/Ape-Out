using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x02000048 RID: 72
	public static class Extrapolation : Object
	{
		// Token: 0x060004DE RID: 1246 RVA: 0x0001781C File Offset: 0x00015A1C
		// Note: this type is marked as 'beforefieldinit'.
		static Extrapolation()
		{
			Il2CppClassPointerStore<Extrapolation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "Extrapolation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extrapolation>.NativeClassPtr);
			Extrapolation.NativeFieldInfoPtr_kMinExtrapolationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extrapolation>.NativeClassPtr, "kMinExtrapolationTime");
			Extrapolation.NativeMethodInfoPtr_CalculateExtrapolationTimes_Internal_Static_Void_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extrapolation>.NativeClassPtr, 100664091);
			Extrapolation.NativeMethodInfoPtr_SortClipsByStartTime_Private_Static_Il2CppReferenceArray_1_TimelineClip_Il2CppReferenceArray_1_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extrapolation>.NativeClassPtr, 100664092);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00017888 File Offset: 0x00015A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479729, RefRangeEnd = 479730, XrefRangeStart = 479701, XrefRangeEnd = 479729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CalculateExtrapolationTimes(this TrackAsset asset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extrapolation.NativeMethodInfoPtr_CalculateExtrapolationTimes_Internal_Static_Void_TrackAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x000178C0 File Offset: 0x00015AC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479751, RefRangeEnd = 479752, XrefRangeStart = 479730, XrefRangeEnd = 479751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<TimelineClip> SortClipsByStartTime(Il2CppReferenceArray<TimelineClip> clips)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clips);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extrapolation.NativeMethodInfoPtr_SortClipsByStartTime_Private_Static_Il2CppReferenceArray_1_TimelineClip_Il2CppReferenceArray_1_TimelineClip_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TimelineClip>>(intPtr3) : null;
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00003A3C File Offset: 0x00001C3C
		public Extrapolation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00017904 File Offset: 0x00015B04
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00003A45 File Offset: 0x00001C45
		public unsafe static double kMinExtrapolationTime
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(Extrapolation.NativeFieldInfoPtr_kMinExtrapolationTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Extrapolation.NativeFieldInfoPtr_kMinExtrapolationTime, (void*)(&value));
			}
		}

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr_kMinExtrapolationTime;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_CalculateExtrapolationTimes_Internal_Static_Void_TrackAsset_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_SortClipsByStartTime_Private_Static_Il2CppReferenceArray_1_TimelineClip_Il2CppReferenceArray_1_TimelineClip_0;

		// Token: 0x02000078 RID: 120
		[ObfuscatedName("UnityEngine.Timeline.Extrapolation+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600061A RID: 1562 RVA: 0x0001BBD8 File Offset: 0x00019DD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Extrapolation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Extrapolation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extrapolation.__c>.NativeClassPtr);
				Extrapolation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extrapolation.__c>.NativeClassPtr, "<>9");
				Extrapolation.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extrapolation.__c>.NativeClassPtr, "<>9__2_0");
				Extrapolation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extrapolation.__c>.NativeClassPtr, 100664095);
				Extrapolation.__c.NativeMethodInfoPtr__SortClipsByStartTime_b__2_0_Internal_Int32_TimelineClip_TimelineClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extrapolation.__c>.NativeClassPtr, 100664096);
			}

			// Token: 0x0600061B RID: 1563 RVA: 0x0001BC54 File Offset: 0x00019E54
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Extrapolation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extrapolation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600061C RID: 1564 RVA: 0x0001BC90 File Offset: 0x00019E90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortClipsByStartTime_b__2_0(TimelineClip clip1, TimelineClip clip2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extrapolation.__c.NativeMethodInfoPtr__SortClipsByStartTime_b__2_0_Internal_Int32_TimelineClip_TimelineClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600061D RID: 1565 RVA: 0x000042CE File Offset: 0x000024CE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001DB RID: 475
			// (get) Token: 0x0600061E RID: 1566 RVA: 0x0001BCF0 File Offset: 0x00019EF0
			// (set) Token: 0x0600061F RID: 1567 RVA: 0x000042D7 File Offset: 0x000024D7
			public unsafe static Extrapolation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Extrapolation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Extrapolation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Extrapolation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001DC RID: 476
			// (get) Token: 0x06000620 RID: 1568 RVA: 0x0001BD18 File Offset: 0x00019F18
			// (set) Token: 0x06000621 RID: 1569 RVA: 0x000042E9 File Offset: 0x000024E9
			public unsafe static Comparison<TimelineClip> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Extrapolation.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<TimelineClip>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Extrapolation.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004BC RID: 1212
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040004BD RID: 1213
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040004BE RID: 1214
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004BF RID: 1215
			private static readonly IntPtr NativeMethodInfoPtr__SortClipsByStartTime_b__2_0_Internal_Int32_TimelineClip_TimelineClip_0;
		}
	}
}
