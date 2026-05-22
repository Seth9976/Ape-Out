using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000094 RID: 148
	public class BunkerBlower : MonoBehaviour
	{
		// Token: 0x060011D5 RID: 4565 RVA: 0x0000D15A File Offset: 0x0000B35A
		// Note: this type is marked as 'beforefieldinit'.
		static BunkerBlower()
		{
			Il2CppClassPointerStore<BunkerBlower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BunkerBlower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BunkerBlower>.NativeClassPtr);
			BunkerBlower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerBlower>.NativeClassPtr, 100664797);
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x000678E8 File Offset: 0x00065AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BunkerBlower()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BunkerBlower>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerBlower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0000D193 File Offset: 0x0000B393
		public BunkerBlower(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
