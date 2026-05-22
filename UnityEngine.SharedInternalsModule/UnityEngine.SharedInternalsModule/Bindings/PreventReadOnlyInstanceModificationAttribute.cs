using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x0200001B RID: 27
	public class PreventReadOnlyInstanceModificationAttribute : Attribute
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00002666 File Offset: 0x00000866
		// Note: this type is marked as 'beforefieldinit'.
		static PreventReadOnlyInstanceModificationAttribute()
		{
			Il2CppClassPointerStore<PreventReadOnlyInstanceModificationAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "PreventReadOnlyInstanceModificationAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreventReadOnlyInstanceModificationAttribute>.NativeClassPtr);
			PreventReadOnlyInstanceModificationAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreventReadOnlyInstanceModificationAttribute>.NativeClassPtr, 100663355);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004480 File Offset: 0x00002680
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreventReadOnlyInstanceModificationAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreventReadOnlyInstanceModificationAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreventReadOnlyInstanceModificationAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000269F File Offset: 0x0000089F
		public PreventReadOnlyInstanceModificationAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
