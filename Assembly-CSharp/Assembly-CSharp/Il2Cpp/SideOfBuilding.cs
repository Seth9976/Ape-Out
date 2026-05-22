using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200018B RID: 395
	public class SideOfBuilding : MonoBehaviour
	{
		// Token: 0x06002EDE RID: 11998 RVA: 0x000B58B4 File Offset: 0x000B3AB4
		// Note: this type is marked as 'beforefieldinit'.
		static SideOfBuilding()
		{
			Il2CppClassPointerStore<SideOfBuilding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SideOfBuilding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SideOfBuilding>.NativeClassPtr);
			SideOfBuilding.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SideOfBuilding>.NativeClassPtr, 100666966);
			SideOfBuilding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SideOfBuilding>.NativeClassPtr, 100666967);
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x000B590C File Offset: 0x000B3B0C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SideOfBuilding.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x000B5940 File Offset: 0x000B3B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SideOfBuilding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SideOfBuilding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SideOfBuilding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x000205AC File Offset: 0x0001E7AC
		public SideOfBuilding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
