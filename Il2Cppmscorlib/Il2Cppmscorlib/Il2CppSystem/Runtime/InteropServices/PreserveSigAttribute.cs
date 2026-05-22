using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000448 RID: 1096
	public sealed class PreserveSigAttribute : Attribute
	{
		// Token: 0x060043CD RID: 17357 RVA: 0x00019C99 File Offset: 0x00017E99
		// Note: this type is marked as 'beforefieldinit'.
		static PreserveSigAttribute()
		{
			Il2CppClassPointerStore<PreserveSigAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "PreserveSigAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreserveSigAttribute>.NativeClassPtr);
			PreserveSigAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreserveSigAttribute>.NativeClassPtr, 100673178);
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x0013949C File Offset: 0x0013769C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreserveSigAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreserveSigAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreserveSigAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x00019CD2 File Offset: 0x00017ED2
		public PreserveSigAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003752 RID: 14162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
