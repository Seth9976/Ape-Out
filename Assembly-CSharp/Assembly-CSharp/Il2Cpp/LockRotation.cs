using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000125 RID: 293
	public class LockRotation : MonoBehaviour
	{
		// Token: 0x060022F6 RID: 8950 RVA: 0x00095510 File Offset: 0x00093710
		// Note: this type is marked as 'beforefieldinit'.
		static LockRotation()
		{
			Il2CppClassPointerStore<LockRotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LockRotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LockRotation>.NativeClassPtr);
			LockRotation.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockRotation>.NativeClassPtr, 100666013);
			LockRotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockRotation>.NativeClassPtr, 100666014);
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x00095568 File Offset: 0x00093768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69766, XrefRangeEnd = 69771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockRotation.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x0009559C File Offset: 0x0009379C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LockRotation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockRotation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockRotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x0001885F File Offset: 0x00016A5F
		public LockRotation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
