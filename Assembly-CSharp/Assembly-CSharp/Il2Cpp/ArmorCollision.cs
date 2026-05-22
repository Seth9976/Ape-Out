using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x0200006C RID: 108
	public class ArmorCollision : FatCollision
	{
		// Token: 0x06000E55 RID: 3669 RVA: 0x0000AD6B File Offset: 0x00008F6B
		// Note: this type is marked as 'beforefieldinit'.
		static ArmorCollision()
		{
			Il2CppClassPointerStore<ArmorCollision>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ArmorCollision");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArmorCollision>.NativeClassPtr);
			ArmorCollision.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorCollision>.NativeClassPtr, 100664523);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0005E5F8 File Offset: 0x0005C7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArmorCollision()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArmorCollision>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArmorCollision.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0000ADA4 File Offset: 0x00008FA4
		public ArmorCollision(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
