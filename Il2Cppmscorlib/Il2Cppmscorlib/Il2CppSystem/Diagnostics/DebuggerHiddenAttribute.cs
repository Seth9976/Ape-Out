using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004B7 RID: 1207
	[Serializable]
	public sealed class DebuggerHiddenAttribute : Attribute
	{
		// Token: 0x060048B6 RID: 18614 RVA: 0x0001B1FE File Offset: 0x000193FE
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerHiddenAttribute()
		{
			Il2CppClassPointerStore<DebuggerHiddenAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerHiddenAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerHiddenAttribute>.NativeClassPtr);
			DebuggerHiddenAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerHiddenAttribute>.NativeClassPtr, 100674201);
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x001515EC File Offset: 0x0014F7EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerHiddenAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerHiddenAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerHiddenAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x0001B237 File Offset: 0x00019437
		public DebuggerHiddenAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003AFA RID: 15098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
