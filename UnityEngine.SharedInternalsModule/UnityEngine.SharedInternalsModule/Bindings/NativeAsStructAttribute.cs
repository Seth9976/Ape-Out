using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x02000011 RID: 17
	public class NativeAsStructAttribute : Attribute
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00002442 File Offset: 0x00000642
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAsStructAttribute()
		{
			Il2CppClassPointerStore<NativeAsStructAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeAsStructAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeAsStructAttribute>.NativeClassPtr);
			NativeAsStructAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeAsStructAttribute>.NativeClassPtr, 100663332);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000039B0 File Offset: 0x00001BB0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeAsStructAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeAsStructAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeAsStructAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000247B File Offset: 0x0000067B
		public NativeAsStructAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
