using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000449 RID: 1097
	public sealed class InAttribute : Attribute
	{
		// Token: 0x060043D0 RID: 17360 RVA: 0x00019CDB File Offset: 0x00017EDB
		// Note: this type is marked as 'beforefieldinit'.
		static InAttribute()
		{
			Il2CppClassPointerStore<InAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "InAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InAttribute>.NativeClassPtr);
			InAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAttribute>.NativeClassPtr, 100673179);
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x001394D8 File Offset: 0x001376D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x00019D14 File Offset: 0x00017F14
		public InAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003753 RID: 14163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
