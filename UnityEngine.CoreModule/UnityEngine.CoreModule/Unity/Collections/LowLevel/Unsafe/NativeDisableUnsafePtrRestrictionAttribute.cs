using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000034 RID: 52
	public sealed class NativeDisableUnsafePtrRestrictionAttribute : Attribute
	{
		// Token: 0x0600016E RID: 366 RVA: 0x00002F3E File Offset: 0x0000113E
		// Note: this type is marked as 'beforefieldinit'.
		static NativeDisableUnsafePtrRestrictionAttribute()
		{
			Il2CppClassPointerStore<NativeDisableUnsafePtrRestrictionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeDisableUnsafePtrRestrictionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeDisableUnsafePtrRestrictionAttribute>.NativeClassPtr);
			NativeDisableUnsafePtrRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeDisableUnsafePtrRestrictionAttribute>.NativeClassPtr, 100663390);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0001879C File Offset: 0x0001699C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeDisableUnsafePtrRestrictionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeDisableUnsafePtrRestrictionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeDisableUnsafePtrRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002F77 File Offset: 0x00001177
		public NativeDisableUnsafePtrRestrictionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
