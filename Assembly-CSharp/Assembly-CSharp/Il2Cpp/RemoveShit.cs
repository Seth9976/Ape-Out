using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200016D RID: 365
	public class RemoveShit : MonoBehaviour
	{
		// Token: 0x06002BF4 RID: 11252 RVA: 0x0001E782 File Offset: 0x0001C982
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveShit()
		{
			Il2CppClassPointerStore<RemoveShit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RemoveShit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveShit>.NativeClassPtr);
			RemoveShit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveShit>.NativeClassPtr, 100666743);
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x000ADC08 File Offset: 0x000ABE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoveShit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveShit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveShit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x0001E7BB File Offset: 0x0001C9BB
		public RemoveShit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019E9 RID: 6633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
