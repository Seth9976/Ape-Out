using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200044A RID: 1098
	public sealed class OutAttribute : Attribute
	{
		// Token: 0x060043D3 RID: 17363 RVA: 0x00019D1D File Offset: 0x00017F1D
		// Note: this type is marked as 'beforefieldinit'.
		static OutAttribute()
		{
			Il2CppClassPointerStore<OutAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "OutAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutAttribute>.NativeClassPtr);
			OutAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutAttribute>.NativeClassPtr, 100673180);
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x00139514 File Offset: 0x00137714
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x00019D56 File Offset: 0x00017F56
		public OutAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003754 RID: 14164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
