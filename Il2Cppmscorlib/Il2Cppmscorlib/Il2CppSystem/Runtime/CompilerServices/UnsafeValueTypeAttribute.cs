using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000436 RID: 1078
	[Serializable]
	public sealed class UnsafeValueTypeAttribute : Attribute
	{
		// Token: 0x0600436B RID: 17259 RVA: 0x0001995E File Offset: 0x00017B5E
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeValueTypeAttribute()
		{
			Il2CppClassPointerStore<UnsafeValueTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "UnsafeValueTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeValueTypeAttribute>.NativeClassPtr);
			UnsafeValueTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeValueTypeAttribute>.NativeClassPtr, 100673145);
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x001381D4 File Offset: 0x001363D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnsafeValueTypeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsafeValueTypeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeValueTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x00019997 File Offset: 0x00017B97
		public UnsafeValueTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040036C4 RID: 14020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
