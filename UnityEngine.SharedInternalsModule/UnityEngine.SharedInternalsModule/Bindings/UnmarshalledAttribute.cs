using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x02000014 RID: 20
	public class UnmarshalledAttribute : Attribute
	{
		// Token: 0x0600008F RID: 143 RVA: 0x0000252E File Offset: 0x0000072E
		// Note: this type is marked as 'beforefieldinit'.
		static UnmarshalledAttribute()
		{
			Il2CppClassPointerStore<UnmarshalledAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "UnmarshalledAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmarshalledAttribute>.NativeClassPtr);
			UnmarshalledAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmarshalledAttribute>.NativeClassPtr, 100663342);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003E74 File Offset: 0x00002074
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnmarshalledAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmarshalledAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmarshalledAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002567 File Offset: 0x00000767
		public UnmarshalledAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
