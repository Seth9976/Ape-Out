using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Libraries.TinyJson
{
	// Token: 0x020001DB RID: 475
	public class DoNotSerializeAttribute : Attribute
	{
		// Token: 0x060030E3 RID: 12515 RVA: 0x00011904 File Offset: 0x0000FB04
		// Note: this type is marked as 'beforefieldinit'.
		static DoNotSerializeAttribute()
		{
			Il2CppClassPointerStore<DoNotSerializeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Libraries.TinyJson", "DoNotSerializeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoNotSerializeAttribute>.NativeClassPtr);
			DoNotSerializeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoNotSerializeAttribute>.NativeClassPtr, 100675750);
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x000F31C4 File Offset: 0x000F13C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoNotSerializeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoNotSerializeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoNotSerializeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x0001193D File Offset: 0x0000FB3D
		public DoNotSerializeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040029B3 RID: 10675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
