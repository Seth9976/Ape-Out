using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200042F RID: 1071
	public sealed class ExtensionAttribute : Attribute
	{
		// Token: 0x06004348 RID: 17224 RVA: 0x000197BC File Offset: 0x000179BC
		// Note: this type is marked as 'beforefieldinit'.
		static ExtensionAttribute()
		{
			Il2CppClassPointerStore<ExtensionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ExtensionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtensionAttribute>.NativeClassPtr);
			ExtensionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionAttribute>.NativeClassPtr, 100673134);
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x00137C98 File Offset: 0x00135E98
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtensionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtensionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x000197F5 File Offset: 0x000179F5
		public ExtensionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040036B4 RID: 14004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
