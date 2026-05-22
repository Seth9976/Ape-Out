using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000446 RID: 1094
	public sealed class ComImportAttribute : Attribute
	{
		// Token: 0x060043C4 RID: 17348 RVA: 0x00019C2F File Offset: 0x00017E2F
		// Note: this type is marked as 'beforefieldinit'.
		static ComImportAttribute()
		{
			Il2CppClassPointerStore<ComImportAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ComImportAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComImportAttribute>.NativeClassPtr);
			ComImportAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComImportAttribute>.NativeClassPtr, 100673175);
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x00139348 File Offset: 0x00137548
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComImportAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComImportAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComImportAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x00019C68 File Offset: 0x00017E68
		public ComImportAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400374E RID: 14158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
