using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000E6 RID: 230
	public class GetTilePalCol : MonoBehaviour
	{
		// Token: 0x06001A68 RID: 6760 RVA: 0x0007F424 File Offset: 0x0007D624
		// Note: this type is marked as 'beforefieldinit'.
		static GetTilePalCol()
		{
			Il2CppClassPointerStore<GetTilePalCol>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GetTilePalCol");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetTilePalCol>.NativeClassPtr);
			GetTilePalCol.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTilePalCol>.NativeClassPtr, 100665489);
			GetTilePalCol.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTilePalCol>.NativeClassPtr, 100665490);
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x0007F47C File Offset: 0x0007D67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60819, XrefRangeEnd = 60838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetTilePalCol.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x0007F4B0 File Offset: 0x0007D6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetTilePalCol()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetTilePalCol>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetTilePalCol.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x000128DD File Offset: 0x00010ADD
		public GetTilePalCol(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
