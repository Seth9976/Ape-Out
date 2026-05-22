using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200051C RID: 1308
	public sealed class NonEventAttribute : Attribute
	{
		// Token: 0x06004D22 RID: 19746 RVA: 0x0001CB86 File Offset: 0x0001AD86
		// Note: this type is marked as 'beforefieldinit'.
		static NonEventAttribute()
		{
			Il2CppClassPointerStore<NonEventAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "NonEventAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonEventAttribute>.NativeClassPtr);
			NonEventAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonEventAttribute>.NativeClassPtr, 100674808);
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x001633A8 File Offset: 0x001615A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NonEventAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NonEventAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonEventAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x0001CBBF File Offset: 0x0001ADBF
		public NonEventAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003E41 RID: 15937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
