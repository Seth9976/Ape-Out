using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200019B RID: 411
	public class SonarTrigger : MonoBehaviour
	{
		// Token: 0x06002FE7 RID: 12263 RVA: 0x000B8458 File Offset: 0x000B6658
		// Note: this type is marked as 'beforefieldinit'.
		static SonarTrigger()
		{
			Il2CppClassPointerStore<SonarTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SonarTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SonarTrigger>.NativeClassPtr);
			SonarTrigger.NativeMethodInfoPtr_OnTriggerStay2D_Public_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SonarTrigger>.NativeClassPtr, 100667042);
			SonarTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SonarTrigger>.NativeClassPtr, 100667043);
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x000B84B0 File Offset: 0x000B66B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83874, XrefRangeEnd = 83896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay2D(Collider2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SonarTrigger.NativeMethodInfoPtr_OnTriggerStay2D_Public_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x000B84F4 File Offset: 0x000B66F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SonarTrigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SonarTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SonarTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x00021029 File Offset: 0x0001F229
		public SonarTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C29 RID: 7209
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay2D_Public_Void_Collider2D_0;

		// Token: 0x04001C2A RID: 7210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
