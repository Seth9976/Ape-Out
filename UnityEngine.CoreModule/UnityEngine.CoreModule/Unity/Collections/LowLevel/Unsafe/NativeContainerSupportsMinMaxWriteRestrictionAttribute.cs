using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200002E RID: 46
	public sealed class NativeContainerSupportsMinMaxWriteRestrictionAttribute : Attribute
	{
		// Token: 0x0600015E RID: 350 RVA: 0x00002DDA File Offset: 0x00000FDA
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerSupportsMinMaxWriteRestrictionAttribute()
		{
			Il2CppClassPointerStore<NativeContainerSupportsMinMaxWriteRestrictionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerSupportsMinMaxWriteRestrictionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerSupportsMinMaxWriteRestrictionAttribute>.NativeClassPtr);
			NativeContainerSupportsMinMaxWriteRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerSupportsMinMaxWriteRestrictionAttribute>.NativeClassPtr, 100663386);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000186AC File Offset: 0x000168AC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeContainerSupportsMinMaxWriteRestrictionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerSupportsMinMaxWriteRestrictionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeContainerSupportsMinMaxWriteRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002E13 File Offset: 0x00001013
		public NativeContainerSupportsMinMaxWriteRestrictionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
