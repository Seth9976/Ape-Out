using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200044B RID: 1099
	public sealed class OptionalAttribute : Attribute
	{
		// Token: 0x060043D6 RID: 17366 RVA: 0x00019D5F File Offset: 0x00017F5F
		// Note: this type is marked as 'beforefieldinit'.
		static OptionalAttribute()
		{
			Il2CppClassPointerStore<OptionalAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "OptionalAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionalAttribute>.NativeClassPtr);
			OptionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalAttribute>.NativeClassPtr, 100673181);
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x00139550 File Offset: 0x00137750
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionalAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionalAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x00019D98 File Offset: 0x00017F98
		public OptionalAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003755 RID: 14165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
