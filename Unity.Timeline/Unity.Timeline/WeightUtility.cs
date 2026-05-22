using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000050 RID: 80
	public static class WeightUtility : Object
	{
		// Token: 0x06000526 RID: 1318 RVA: 0x00003AEB File Offset: 0x00001CEB
		// Note: this type is marked as 'beforefieldinit'.
		static WeightUtility()
		{
			Il2CppClassPointerStore<WeightUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "WeightUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeightUtility>.NativeClassPtr);
			WeightUtility.NativeMethodInfoPtr_NormalizeMixer_Public_Static_Single_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightUtility>.NativeClassPtr, 100664152);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00018DA4 File Offset: 0x00016FA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480385, RefRangeEnd = 480386, XrefRangeStart = 480348, XrefRangeEnd = 480385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float NormalizeMixer(Playable mixer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mixer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightUtility.NativeMethodInfoPtr_NormalizeMixer_Public_Static_Single_Playable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00003B24 File Offset: 0x00001D24
		public WeightUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeMixer_Public_Static_Single_Playable_0;
	}
}
