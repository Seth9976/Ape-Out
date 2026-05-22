using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200006E RID: 110
	public static class RaycasterManager : Object
	{
		// Token: 0x06000ADD RID: 2781 RVA: 0x00030A9C File Offset: 0x0002EC9C
		// Note: this type is marked as 'beforefieldinit'.
		static RaycasterManager()
		{
			Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "RaycasterManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr);
			RaycasterManager.NativeFieldInfoPtr_s_Raycasters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr, "s_Raycasters");
			RaycasterManager.NativeMethodInfoPtr_AddRaycaster_Internal_Static_Void_BaseRaycaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr, 100665017);
			RaycasterManager.NativeMethodInfoPtr_GetRaycasters_Public_Static_List_1_BaseRaycaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr, 100665018);
			RaycasterManager.NativeMethodInfoPtr_RemoveRaycasters_Internal_Static_Void_BaseRaycaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr, 100665019);
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00030B1C File Offset: 0x0002ED1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533033, XrefRangeEnd = 533046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddRaycaster(BaseRaycaster baseRaycaster)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseRaycaster);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycasterManager.NativeMethodInfoPtr_AddRaycaster_Internal_Static_Void_BaseRaycaster_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00030B54 File Offset: 0x0002ED54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533046, XrefRangeEnd = 533050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<BaseRaycaster> GetRaycasters()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycasterManager.NativeMethodInfoPtr_GetRaycasters_Public_Static_List_1_BaseRaycaster_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<BaseRaycaster>>(intPtr3) : null;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00030B88 File Offset: 0x0002ED88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533050, XrefRangeEnd = 533062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveRaycasters(BaseRaycaster baseRaycaster)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseRaycaster);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycasterManager.NativeMethodInfoPtr_RemoveRaycasters_Internal_Static_Void_BaseRaycaster_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00005EE7 File Offset: 0x000040E7
		public RaycasterManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00030BC0 File Offset: 0x0002EDC0
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00005EF0 File Offset: 0x000040F0
		public unsafe static List<BaseRaycaster> s_Raycasters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RaycasterManager.NativeFieldInfoPtr_s_Raycasters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseRaycaster>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RaycasterManager.NativeFieldInfoPtr_s_Raycasters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeFieldInfoPtr_s_Raycasters;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_AddRaycaster_Internal_Static_Void_BaseRaycaster_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_GetRaycasters_Public_Static_List_1_BaseRaycaster_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRaycasters_Internal_Static_Void_BaseRaycaster_0;
	}
}
