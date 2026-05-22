using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002C RID: 44
	public static class OcclusionController : global::Il2CppSystem.Object
	{
		// Token: 0x06000599 RID: 1433 RVA: 0x00045310 File Offset: 0x00043510
		// Note: this type is marked as 'beforefieldinit'.
		static OcclusionController()
		{
			Il2CppClassPointerStore<OcclusionController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "OcclusionController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OcclusionController>.NativeClassPtr);
			OcclusionController.NativeFieldInfoPtr_IsResonance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionController>.NativeClassPtr, "IsResonance");
			OcclusionController.NativeFieldInfoPtr_hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionController>.NativeClassPtr, "hit");
			OcclusionController.NativeFieldInfoPtr_ListenerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionController>.NativeClassPtr, "ListenerTransform");
			OcclusionController.NativeFieldInfoPtr_SourceTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionController>.NativeClassPtr, "SourceTransforms");
			OcclusionController.NativeFieldInfoPtr_SourceOcclusions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionController>.NativeClassPtr, "SourceOcclusions");
			OcclusionController.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionController>.NativeClassPtr, "i");
			OcclusionController.NativeMethodInfoPtr_MyAwake_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionController>.NativeClassPtr, 100663785);
			OcclusionController.NativeMethodInfoPtr_CalculateSectr_Public_Static_Int32_Vector3_OcclusionModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionController>.NativeClassPtr, 100663786);
			OcclusionController.NativeMethodInfoPtr_ResetIndex_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionController>.NativeClassPtr, 100663787);
			OcclusionController.NativeMethodInfoPtr_CalculateResonance_Public_Static_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionController>.NativeClassPtr, 100663788);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00045408 File Offset: 0x00043608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35535, RefRangeEnd = 35536, XrefRangeStart = 35522, XrefRangeEnd = 35535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MyAwake()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionController.NativeMethodInfoPtr_MyAwake_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00045430 File Offset: 0x00043630
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35557, RefRangeEnd = 35559, XrefRangeStart = 35536, XrefRangeEnd = 35557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CalculateSectr(Vector3 pos, SECTR_AudioSystem.OcclusionModes occlusionFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref occlusionFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionController.NativeMethodInfoPtr_CalculateSectr_Public_Static_Int32_Vector3_OcclusionModes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0004547C File Offset: 0x0004367C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35559, XrefRangeEnd = 35563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetIndex()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionController.NativeMethodInfoPtr_ResetIndex_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x000454A4 File Offset: 0x000436A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35625, RefRangeEnd = 35626, XrefRangeStart = 35563, XrefRangeEnd = 35625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CalculateResonance(Vector3 pos)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionController.NativeMethodInfoPtr_CalculateResonance_Public_Static_Single_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0000562F File Offset: 0x0000382F
		public OcclusionController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x000454E4 File Offset: 0x000436E4
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00005638 File Offset: 0x00003838
		public unsafe static bool IsResonance
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(OcclusionController.NativeFieldInfoPtr_IsResonance, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OcclusionController.NativeFieldInfoPtr_IsResonance, (void*)(&value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00045500 File Offset: 0x00043700
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00005646 File Offset: 0x00003846
		public unsafe static Il2CppStructArray<RaycastHit2D> hit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OcclusionController.NativeFieldInfoPtr_hit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OcclusionController.NativeFieldInfoPtr_hit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00045528 File Offset: 0x00043728
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00005658 File Offset: 0x00003858
		public unsafe static Transform ListenerTransform
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OcclusionController.NativeFieldInfoPtr_ListenerTransform, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OcclusionController.NativeFieldInfoPtr_ListenerTransform, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00045550 File Offset: 0x00043750
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x0000566A File Offset: 0x0000386A
		public unsafe static Il2CppStructArray<Vector3> SourceTransforms
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OcclusionController.NativeFieldInfoPtr_SourceTransforms, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OcclusionController.NativeFieldInfoPtr_SourceTransforms, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00045578 File Offset: 0x00043778
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x0000567C File Offset: 0x0000387C
		public unsafe static Il2CppStructArray<int> SourceOcclusions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OcclusionController.NativeFieldInfoPtr_SourceOcclusions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OcclusionController.NativeFieldInfoPtr_SourceOcclusions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x000455A0 File Offset: 0x000437A0
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x0000568E File Offset: 0x0000388E
		public unsafe static int i
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OcclusionController.NativeFieldInfoPtr_i, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OcclusionController.NativeFieldInfoPtr_i, (void*)(&value));
			}
		}

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeFieldInfoPtr_IsResonance;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeFieldInfoPtr_hit;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeFieldInfoPtr_ListenerTransform;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeFieldInfoPtr_SourceTransforms;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeFieldInfoPtr_SourceOcclusions;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeFieldInfoPtr_i;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_MyAwake_Public_Static_Void_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSectr_Public_Static_Int32_Vector3_OcclusionModes_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_ResetIndex_Public_Static_Void_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_CalculateResonance_Public_Static_Single_Vector3_0;
	}
}
