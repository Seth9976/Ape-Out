using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004B6 RID: 1206
	[Serializable]
	public sealed class DebuggerStepThroughAttribute : Attribute
	{
		// Token: 0x060048B3 RID: 18611 RVA: 0x0001B1BC File Offset: 0x000193BC
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerStepThroughAttribute()
		{
			Il2CppClassPointerStore<DebuggerStepThroughAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerStepThroughAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerStepThroughAttribute>.NativeClassPtr);
			DebuggerStepThroughAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerStepThroughAttribute>.NativeClassPtr, 100674200);
		}

		// Token: 0x060048B4 RID: 18612 RVA: 0x001515B0 File Offset: 0x0014F7B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerStepThroughAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerStepThroughAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerStepThroughAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048B5 RID: 18613 RVA: 0x0001B1F5 File Offset: 0x000193F5
		public DebuggerStepThroughAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003AF9 RID: 15097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
