using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000148 RID: 328
	public class PFGrids : ScriptableObject
	{
		// Token: 0x06002746 RID: 10054 RVA: 0x000A1748 File Offset: 0x0009F948
		// Note: this type is marked as 'beforefieldinit'.
		static PFGrids()
		{
			Il2CppClassPointerStore<PFGrids>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PFGrids");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PFGrids>.NativeClassPtr);
			PFGrids.NativeFieldInfoPtr_grids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PFGrids>.NativeClassPtr, "grids");
			PFGrids.NativeFieldInfoPtr_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PFGrids>.NativeClassPtr, "world");
			PFGrids.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PFGrids>.NativeClassPtr, 100666471);
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x000A17B4 File Offset: 0x0009F9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PFGrids()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PFGrids>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PFGrids.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x0001B479 File Offset: 0x00019679
		public PFGrids(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06002749 RID: 10057 RVA: 0x000A17F0 File Offset: 0x0009F9F0
		// (set) Token: 0x0600274A RID: 10058 RVA: 0x0001B482 File Offset: 0x00019682
		public unsafe Il2CppReferenceArray<Il2CppObjectBase> grids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PFGrids.NativeFieldInfoPtr_grids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppObjectBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PFGrids.NativeFieldInfoPtr_grids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x0600274B RID: 10059 RVA: 0x000A1820 File Offset: 0x0009FA20
		// (set) Token: 0x0600274C RID: 10060 RVA: 0x0001B4A1 File Offset: 0x000196A1
		public unsafe HealthMaster.Levels world
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PFGrids.NativeFieldInfoPtr_world);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PFGrids.NativeFieldInfoPtr_world)) = value;
			}
		}

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeFieldInfoPtr_grids;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeFieldInfoPtr_world;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
