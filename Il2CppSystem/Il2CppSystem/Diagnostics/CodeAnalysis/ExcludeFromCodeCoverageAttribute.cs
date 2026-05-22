using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x02000069 RID: 105
	public sealed class ExcludeFromCodeCoverageAttribute : Attribute
	{
		// Token: 0x06000787 RID: 1927 RVA: 0x00004EF4 File Offset: 0x000030F4
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeFromCodeCoverageAttribute()
		{
			Il2CppClassPointerStore<ExcludeFromCodeCoverageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics.CodeAnalysis", "ExcludeFromCodeCoverageAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromCodeCoverageAttribute>.NativeClassPtr);
			ExcludeFromCodeCoverageAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromCodeCoverageAttribute>.NativeClassPtr, 100664408);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0002D658 File Offset: 0x0002B858
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeFromCodeCoverageAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromCodeCoverageAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeFromCodeCoverageAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00004F2D File Offset: 0x0000312D
		public ExcludeFromCodeCoverageAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
