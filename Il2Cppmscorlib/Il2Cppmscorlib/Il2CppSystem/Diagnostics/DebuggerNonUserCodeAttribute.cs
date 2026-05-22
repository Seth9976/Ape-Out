using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004B8 RID: 1208
	[Serializable]
	public sealed class DebuggerNonUserCodeAttribute : Attribute
	{
		// Token: 0x060048B9 RID: 18617 RVA: 0x0001B240 File Offset: 0x00019440
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerNonUserCodeAttribute()
		{
			Il2CppClassPointerStore<DebuggerNonUserCodeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerNonUserCodeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerNonUserCodeAttribute>.NativeClassPtr);
			DebuggerNonUserCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerNonUserCodeAttribute>.NativeClassPtr, 100674202);
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x00151628 File Offset: 0x0014F828
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerNonUserCodeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerNonUserCodeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerNonUserCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x0001B279 File Offset: 0x00019479
		public DebuggerNonUserCodeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003AFB RID: 15099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
