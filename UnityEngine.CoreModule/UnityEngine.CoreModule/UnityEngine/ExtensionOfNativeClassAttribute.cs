using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000D7 RID: 215
	public sealed class ExtensionOfNativeClassAttribute : Attribute
	{
		// Token: 0x060012C6 RID: 4806 RVA: 0x0000AC42 File Offset: 0x00008E42
		// Note: this type is marked as 'beforefieldinit'.
		static ExtensionOfNativeClassAttribute()
		{
			Il2CppClassPointerStore<ExtensionOfNativeClassAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExtensionOfNativeClassAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtensionOfNativeClassAttribute>.NativeClassPtr);
			ExtensionOfNativeClassAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionOfNativeClassAttribute>.NativeClassPtr, 100664879);
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0004C36C File Offset: 0x0004A56C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtensionOfNativeClassAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtensionOfNativeClassAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionOfNativeClassAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x0000AC7B File Offset: 0x00008E7B
		public ExtensionOfNativeClassAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
