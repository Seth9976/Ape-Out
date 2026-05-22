using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000091 RID: 145
	public class BuildingEdge : MonoBehaviour
	{
		// Token: 0x060011AD RID: 4525 RVA: 0x00067248 File Offset: 0x00065448
		// Note: this type is marked as 'beforefieldinit'.
		static BuildingEdge()
		{
			Il2CppClassPointerStore<BuildingEdge>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BuildingEdge");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingEdge>.NativeClassPtr);
			BuildingEdge.NativeFieldInfoPtr_palZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingEdge>.NativeClassPtr, "palZone");
			BuildingEdge.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingEdge>.NativeClassPtr, 100664787);
			BuildingEdge.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingEdge>.NativeClassPtr, 100664788);
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x000672B4 File Offset: 0x000654B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49201, XrefRangeEnd = 49229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingEdge.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x000672E8 File Offset: 0x000654E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildingEdge()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingEdge>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingEdge.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0000CFEC File Offset: 0x0000B1EC
		public BuildingEdge(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x00067324 File Offset: 0x00065524
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x0000CFF5 File Offset: 0x0000B1F5
		public unsafe GameObject palZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingEdge.NativeFieldInfoPtr_palZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingEdge.NativeFieldInfoPtr_palZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeFieldInfoPtr_palZone;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
