using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200006A RID: 106
	public class Animate : MonoBehaviour
	{
		// Token: 0x06000E2D RID: 3629 RVA: 0x0000ABE7 File Offset: 0x00008DE7
		// Note: this type is marked as 'beforefieldinit'.
		static Animate()
		{
			Il2CppClassPointerStore<Animate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Animate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Animate>.NativeClassPtr);
			Animate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Animate>.NativeClassPtr, 100664503);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0005DEB0 File Offset: 0x0005C0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Animate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Animate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Animate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0000AC20 File Offset: 0x00008E20
		public Animate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
